﻿/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Testing;

namespace Google.Apis.Requests
{
    /// <summary>
    /// A batch request which represents individual requests to Google servers. You should add a single service 
    /// request using the <see cref="Queue"/> method and execute all individual requests using 
    /// <see cref="ExecuteAsync()"/>. More information about the batch protocol is available in 
    /// https://developers.google.com/storage/docs/json_api/v1/how-tos/batch.
    /// <remarks>
    /// Current implementation doesn't retry on unsuccessful individual response and doesn't support requests with 
    /// different access tokens (different users or scopes).
    /// </remarks>
    /// </summary>
    public sealed class BatchRequest
    {
        private const string DefaultBatchUrl = "https://www.googleapis.com/batch";
        private const int QueueLimit = 1000;

        private readonly IList<InnerRequest> allRequests = new List<InnerRequest>();

        private readonly string batchUrl;
        private readonly IClientService service;

        // For testing
        internal string BatchUrl => batchUrl;

        /// <summary>A concrete type callback for an individual response.</summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="content">The parsed content response or <c>null</c> if the request failed or the response
        /// could not be parsed using the associated <see cref="IClientService.Serializer"/>.</param>
        /// <param name="error">Error or <c>null</c> if the request succeeded and response content was parsed succesfully.</param>
        /// <param name="index">The request index.</param>
        /// <param name="message">The HTTP individual response.</param>
        public delegate void OnResponse<in TResponse>
            (TResponse content, RequestError error, int index, HttpResponseMessage message) where TResponse : class;

        #region Inner Request

        /// <summary>This inner class represents an individual inner request.</summary>
        private class InnerRequest
        {
            /// <summary>Gets or sets the client service request.</summary>
            public IClientServiceRequest ClientRequest { get; set; }

            /// <summary>Gets or sets the response class type.</summary>
            public Type ResponseType { get; set; }

            /// <summary>A callback method which will be called after an individual response was parsed.</summary>
            /// <param name="content">The parsed content response or <c>null</c> if the request failed or the response
            /// could not be parsed using the associated <see cref="IClientService.Serializer"/>.</param>
            /// <param name="error">Error or <c>null</c> if the request succeeded and response content was parsed succesfully.</param>
            /// <param name="index">The request index.</param>
            /// <param name="message">The HTTP individual response.</param>
            public virtual void OnResponse(object content, RequestError error, int index, HttpResponseMessage message)
            {
                // Set ETag on the response.
                var eTagValue = message.Headers.ETag != null ? message.Headers.ETag.Tag : null;
                var eTagContainer = content as IDirectResponseSchema;
                if (eTagContainer != null && eTagContainer.ETag == null && eTagValue != null)
                {
                    eTagContainer.ETag = eTagValue;
                }
            }
        }

        /// <summary>
        /// This generic inner class represents an individual inner request with a generic response type.
        /// </summary>
        private class InnerRequest<TResponse> : InnerRequest
            where TResponse : class
        {
            /// <summary>Gets or sets a concrete type callback for an individual response. </summary>
            public OnResponse<TResponse> OnResponseCallback { get; set; }

            public override void OnResponse(object content, RequestError error, int index,
                HttpResponseMessage message)
            {
                base.OnResponse(content, error, index, message);
                if (OnResponseCallback == null)
                    return;

                OnResponseCallback(content as TResponse, error, index, message);
            }
        }

        #endregion

        /// <summary>
        /// Constructs a new batch request using the given service. See 
        /// <see cref="BatchRequest(IClientService, string)"/> for more information.
        /// </summary>
        public BatchRequest(IClientService service)
            : this(service, (service as BaseClientService)?.BatchUri ?? DefaultBatchUrl) { }

        /// <summary>
        /// Constructs a new batch request using the given service. The service's HTTP client is used to create a 
        /// request to the given server URL and its serializer members are used to serialize the request and 
        /// deserialize the response.
        /// </summary>
        public BatchRequest(IClientService service, string batchUrl)
        {
            this.batchUrl = batchUrl;
            this.service = service;
        }

        /// <summary>Gets the count of all queued requests.</summary>
        public int Count => allRequests.Count;

        /// <summary>Queues an individual request.</summary>
        /// <typeparam name="TResponse">The response's type.</typeparam>
        /// <param name="request">The individual request.</param>
        /// <param name="callback">A callback which will be called after a response was parsed.</param>
        public void Queue<TResponse>(IClientServiceRequest request, OnResponse<TResponse> callback)
            where TResponse : class
        {
            if (Count > QueueLimit)
            {
                throw new InvalidOperationException("A batch request cannot contain more than 1000 single requests");
            }

            allRequests.Add(new InnerRequest<TResponse>
            {
                ClientRequest = request,
                ResponseType = typeof(TResponse),
                OnResponseCallback = callback,
            });
        }

        /// <summary>Asynchronously executes the batch request.</summary>
        public Task ExecuteAsync()
        {
            return ExecuteAsync(CancellationToken.None);
        }

        /// <summary>Asynchronously executes the batch request.</summary>
        /// <param name="cancellationToken">Cancellation token to cancel operation.</param>
        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            if (Count == 0)
            {
                return;
            }

            ConfigurableHttpClient httpClient = service.HttpClient;

            var requests = from r in allRequests
                           select r.ClientRequest;
            HttpContent outerContent = await CreateOuterRequestContent(requests).ConfigureAwait(false);

            string fullContent;
            string boundary;
            using (var result = await httpClient.PostAsync(new Uri(batchUrl), outerContent, cancellationToken).ConfigureAwait(false))
            {
                // Will throw as meaningful an exception as possible if there was an error.
                await EnsureSuccessAsync(result).ConfigureAwait(false);

                // Get the boundary separator.
                const string boundaryKey = "boundary=";
                var contentType = result.Content.Headers.GetValues("Content-Type").First();
                boundary = contentType.Substring(contentType.IndexOf(boundaryKey, StringComparison.Ordinal) + boundaryKey.Length);
                fullContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            }

            int requestIndex = 0;
            // While there is still content to read, parse the current HTTP response.
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var startIndex = fullContent.IndexOf("--" + boundary, StringComparison.Ordinal);
                if (startIndex == -1)
                {
                    break;
                }
                fullContent = fullContent.Substring(startIndex + boundary.Length + 2);
                var endIndex = fullContent.IndexOf("--" + boundary, StringComparison.Ordinal);
                if (endIndex == -1)
                {
                    break;
                }

                HttpResponseMessage responseMessage = ParseAsHttpResponse(fullContent.Substring(0, endIndex));

                if (responseMessage.IsSuccessStatusCode)
                {
                    // Parse the current content object.
                    var responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                    object deserializedContent = null;
                    RequestError error = null;
                    try
                    {
                        deserializedContent = service.Serializer.Deserialize(responseContent,
                            allRequests[requestIndex].ResponseType);
                    }
                    catch (Exception ex)
                    {
                        error = new RequestError
                        {
                            Message = $"The response was read but could not be deserialized using the {nameof(service.Serializer)}.{Environment.NewLine}" +
                                $"The exception thrown on deserializaton was:{Environment.NewLine}" +
                                $"{ex}",
                        };
                    }

                    allRequests[requestIndex].OnResponse(deserializedContent, error, requestIndex, responseMessage);
                }
                else
                {
                    RequestError error;
                    try
                    {
                        // Parse the error from the current response.
                        error = await service.DeserializeError(responseMessage).ConfigureAwait(false);
                    }
                    catch (GoogleApiException ex) when (ex.Error is object)
                    {
                        error = ex.Error;
                    }

                    allRequests[requestIndex].OnResponse(null, error, requestIndex, responseMessage);
                }

                requestIndex++;
                fullContent = fullContent.Substring(endIndex);
            }
        }

        private async Task EnsureSuccessAsync(HttpResponseMessage result)
        {
            if (!result.IsSuccessStatusCode)
            {
                Exception innerException;
                try
                {
                    // Try to parse the error from the current response.
                    RequestError error = await service.DeserializeError(result).ConfigureAwait(false);
                    // If DeserializeError didn't threw, then we got an error object.
                    // We wrap it in a GoogleApiException and throw that to use as the inner exception.
                    // We throw here instead of simply creating a new GoogleApiException
                    // so as to get the StackTrace.
                    throw new GoogleApiException(service.Name)
                    {
                        Error = error,
                        HttpStatusCode = result.StatusCode
                    };
                }
                catch (Exception ex)
                {
                    // If for any reason we couldn't parse the error,
                    // or if we did parse it and threw it wrapped in a GoogleApiException,
                    // let's keep the exception so we can use it as the inner exception
                    // of the final HttpRequestException
                    innerException = ex;
                }

                try
                {
                    // Now that we may have more error detail, let's call EnsureSuccessStatusCode.
                    // We don't want to introduce breaking changes for users that relied on
                    // HttpRequestException before, and importantly on its message format which is the only
                    // way they could access the HttpStatusCode (pre .NET 5).
                    result.EnsureSuccessStatusCode();
                }
                // innerException is never null, either it's the one thrown by DeserializeError
                // or is the one thrown by us that wraps the deserialized error object.
                catch (HttpRequestException original)
                {
                    throw new HttpRequestException(original.Message, innerException);
                }
            }
        }

        /// <summary>Parses the given string content to a HTTP response.</summary>
        [VisibleForTestOnly]
        internal static HttpResponseMessage ParseAsHttpResponse(string content)
        {
            var response = new HttpResponseMessage();

            using (var reader = new StringReader(content))
            {
                string line = reader.ReadLine();

                // Extract empty lines.
                while (string.IsNullOrEmpty(line))
                {
                    line = reader.ReadLine();
                }

                // Extract the outer header.
                while (!string.IsNullOrEmpty(line))
                {
                    line = reader.ReadLine();
                }

                // Extract the status code.
                line = reader.ReadLine();
                while (string.IsNullOrEmpty(line))
                {
                    line = reader.ReadLine();
                }
                int code = int.Parse(line.Split(' ')[1]);
                response.StatusCode = (HttpStatusCode)code;

                // Extract the headers.
                IDictionary<string, string> headersDic = new Dictionary<string, string>();
                while (!string.IsNullOrEmpty((line = reader.ReadLine())))
                {
                    var separatorIndex = line.IndexOf(':');
                    var key = line.Substring(0, separatorIndex).Trim();
                    var value = line.Substring(separatorIndex + 1).Trim();
                    // Check if the header already exists, and if so append its value 
                    // to the existing value. Fixes issue #548.
                    if (headersDic.ContainsKey(key))
                    {
                        headersDic[key] = headersDic[key] + ", " + value;
                    }
                    else
                    {
                        headersDic.Add(key, value);
                    }
                }

                // Set the content.
                string mediaType = null;
                if (headersDic.ContainsKey("Content-Type"))
                {
                    mediaType = headersDic["Content-Type"].Split(';', ' ')[0];
                    headersDic.Remove("Content-Type");
                }

                string contentBody = reader.ReadToEnd();
                // In .NET 6+, the default HttpResponseMessage.Content is an EmptyContent, which is fine
                // - we don't need to change it if we don't have any content. In earlier versions,
                // the Content property is null by default, but historically we've always populated it.
                // We don't want to break users, so we want to continue to make sure it's never null.
                if (contentBody != "" || !string.IsNullOrEmpty(mediaType) || response.Content is null)
                {
                    // As of .NET 7, the StringContent constructor fails with a null or empty
                    // media type. If there's no actual content, we can leave the HttpResponseMessage.Content
                    // at its default empty value; but if we've got content but no media type,
                    // we want to pass that to the callback. This would be a very odd situation, but
                    // text/plain is a reasonable "default media type" here.
                    if (string.IsNullOrEmpty(mediaType))
                    {
                        mediaType = "text/plain";
                    }
                    response.Content = new StringContent(contentBody, Encoding.UTF8, mediaType);
                }

                // Add the headers to the response.
                foreach (var keyValue in headersDic)
                {
                    HttpHeaders headers = response.Headers;
                    // Check if we need to add the current header to the content headers.
                    if (typeof(HttpContentHeaders).GetProperty(keyValue.Key.Replace("-", "")) != null)
                    {
                        headers = response.Content.Headers;
                    }

                    // Use TryAddWithoutValidation rather than Add because Mono's validation is
                    // improperly strict. https://bugzilla.xamarin.com/show_bug.cgi?id=39569
                    if (!headers.TryAddWithoutValidation(keyValue.Key, keyValue.Value))
                    {
                        throw new FormatException($"Could not parse header {keyValue.Key} from batch reply");
                    }
                }

                // TODO(peleyal): ContentLength header is x while the "real" content that we read from the stream is 
                // Content.ReadStringAsAsync().Length is x+2
            }

            return response;
        }

        /// <summary>
        /// Creates the batch outer request content which includes all the individual requests to Google servers.
        /// </summary>
        [VisibleForTestOnly]
        internal async static Task<HttpContent> CreateOuterRequestContent(IEnumerable<IClientServiceRequest> requests)
        {
            var mixedContent = new MultipartContent("mixed");
            foreach (var request in requests)
            {
                mixedContent.Add(await CreateIndividualRequest(request).ConfigureAwait(false));
            }

            // Note: Batch request currently doesn't support GZip.
            return mixedContent;
        }

        /// <summary>Creates the individual server request.</summary>
        [VisibleForTestOnly]
        internal static async Task<HttpContent> CreateIndividualRequest(IClientServiceRequest request)
        {
            HttpRequestMessage requestMessage = request.CreateRequest(false);
            string requestContent = await CreateRequestContentString(requestMessage).ConfigureAwait(false);

            var content = new StringContent(requestContent);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/http");
            return content;
        }

        /// <summary>
        /// Creates a string representation that includes the request's headers and content based on the input HTTP 
        /// request message.
        /// </summary>
        [VisibleForTestOnly]
        internal static async Task<string> CreateRequestContentString(HttpRequestMessage requestMessage)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", requestMessage.Method, requestMessage.RequestUri.AbsoluteUri);

            // Add Headers.
            foreach (var otherHeader in requestMessage.Headers)
            {
                sb.Append(Environment.NewLine)
                    .AppendFormat("{0}: {1}", otherHeader.Key, string.Join(", ", otherHeader.Value.ToArray()));
            }

            // Add content headers.
            if (requestMessage.Content != null)
            {
                foreach (var contentHeader in requestMessage.Content.Headers)
                {
                    sb.Append(Environment.NewLine)
                        .AppendFormat("{0}: {1}", contentHeader.Key, string.Join(", ", contentHeader.Value.ToArray()));
                }
            }

            // Content.
            if (requestMessage.Content != null)
            {
                sb.Append(Environment.NewLine);
                var content = await requestMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                sb.Append("Content-Length:  ").Append(content.Length);
                sb.Append(Environment.NewLine).Append(Environment.NewLine).Append(content);
            }

            return sb.Append(Environment.NewLine).ToString();
        }
    }
}