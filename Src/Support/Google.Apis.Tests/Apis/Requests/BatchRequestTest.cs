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

using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>Tests for <seealso cref="Google.Apis.Requests.BatchRequest"/>.</summary>
    public class BatchRequestTest
    {
        private static string ExpectedContentMessage = NormalizeLineEndings(@"--BOUNDARY
Content-Type: application/http

POST http://sample.com/5?q=20
If-Match: ""100""
Content-Type: application/json; charset=utf-8
Content-Length:  41

{""etag_key"":""\""100\"""",""name_key"":""Name1""}

--BOUNDARY
Content-Type: application/http

POST http://sample.com/5?q=20
If-Match: ""200""
Content-Type: application/json; charset=utf-8
Content-Length:  43

{""etag_key"":""\""200\"""",""name_key"":""Name1-1""}

--BOUNDARY--
");
        /// <summary>A mock response class.</summary>
        class MockResponse : IDirectResponseSchema
        {
            [Newtonsoft.Json.JsonPropertyAttribute("etag_key")]
            public string ETag { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("id_key")]
            public Nullable<int> Id { get; set; }

            public override bool Equals(object obj)
            {
                var other = obj as MockResponse;
                return other != null && other.ETag == ETag && other.Id == Id;
            }

            public override int GetHashCode()
            {
                return (ETag ?? string.Empty).GetHashCode();
            }
        }

        /// <summary>A mock request class.</summary>
        class MockRequest : IDirectResponseSchema
        {
            [Newtonsoft.Json.JsonPropertyAttribute("etag_key")]
            public string ETag { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("name_key")]
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                var other = obj as MockRequest;
                return (other != null && other.ETag == ETag && other.Name == Name);
            }

            public override int GetHashCode()
            {
                return (ETag ?? string.Empty).GetHashCode() ^ (Name ?? string.Empty).GetHashCode();
            }
        }

        /// <summary>A mock service request which returns <see cref="MockResponse"/>.</summary>
        class TestClientServiceRequest : ClientServiceRequest<MockResponse>
        {
            private MockRequest body;

            [RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public int Id { get { return 5; } }

            [RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public int Q { get { return 20; } }

            public TestClientServiceRequest(IClientService service, MockRequest body)
                : base(service)
            {
                this.body = body;
                InitParameters();
            }

            public override string MethodName
            {
                get { return "POST"; }
            }

            public override string RestPath
            {
                get { return "{id}"; }
            }

            public override string HttpMethod
            {
                get { return "POST"; }
            }

            protected override object GetBody()
            {
                return body;
            }

            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Parameter { Name = "id", ParameterType = "path" });
                RequestParameters.Add("q", new Parameter { Name = "q", ParameterType = "query" });
            }
        }

        /// <summary>
        /// Message handler which verifies that the input request is correct and returns a response. The response may 
        /// contain an unsuccessful response for the 2nd individual request based on the boolean flag to its 
        /// constructor.
        /// </summary>
        class BatchMessageHandler : CountableMessageHandler
        {
            private static string ResponseContent = NormalizeLineEndings(@"--BOUNDARY
Content-Type: application/http

HTTP/1.1 200 OK
ETag: ""\""10011\""""
Content-Type: application/json; charset=UTF-8
Content-Length: 505
Vary: Accept-Encoding
Vary: Referer

{
 ""etag_key"": ""\""10011\"""",
 ""id_key"": 1
}

--BOUNDARY
Content-Type: application/http

SECOND_RESPONSE

--BOUNDARY--");

            private static string SuccessfulResponse = NormalizeLineEndings(
@"HTTP/1.1 200 OK
ETag: ""234""
Content-Type: application/json; charset=UTF-8
Content-Length: 202

{
 ""id_key"": 2
}");

            private static string UnsuccessfulResponse = NormalizeLineEndings(
@"HTTP/1.1 404 Not Found
Content-Type: application/json; charset=UTF-8
Date: Thu, 14 Nov 2013 22:03:08 GMT
Expires: Thu, 14 Nov 2013 22:03:08 GMT
Cache-Control: private, max-age=0
Content-Length: 202

{
 ""error"": {
  ""errors"": [
   {
    ""domain"": ""global"",
    ""reason"": ""notFound"",
    ""message"": ""Not Found"",
    ""customIndividual"": ""Custom individual error info""
   }
  ],
  ""code"": 404,
  ""message"": ""Not Found"",
  ""custom"": ""Custom error info""
 }
}");
            bool successful2ndResponse;
            public BatchMessageHandler(bool successful2ndReponse = true)
            {
                this.successful2ndResponse = successful2ndReponse;
            }

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                // Verify Request Message
                var contentType = request.Content.Headers.ContentType;
                Assert.Equal("multipart/mixed", contentType.MediaType.ToString());
                var parameter = Assert.Single(contentType.Parameters);
                Assert.True(parameter.ToString().StartsWith("boundary=", StringComparison.Ordinal),
                    "Parameter should start with boundary=");
                var boundary = parameter.ToString().Substring("boundary=".Length).
                    Replace("\"", "");
                var expectedContent = ExpectedContentMessage.Replace("BOUNDARY", boundary);
                var actualContent = await request.Content.ReadAsStringAsync();
                Assert.Equal(expectedContent, NormalizeLineEndings(actualContent));

                HttpResponseMessage response = new HttpResponseMessage();
                // Response contains 2 responses. The second one is successful based on the constructor's parameter.
                var content = ResponseContent.Replace("BOUNDARY", boundary).Replace("SECOND_RESPONSE",
                    successful2ndResponse ? SuccessfulResponse : UnsuccessfulResponse);
                response.Content = new StringContent(content,
                    Encoding.UTF8, "multipart/mixed");
                response.Content.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("boundary", boundary));

                return response;
            }
        }

        [Fact]
        public void ExecuteAsync_Test()
        {
            SubtestExecuteAsync_Test(true);
        }

        [Fact]
        public void ExecuteAsync_Error_Test()
        {
            SubtestExecuteAsync_Test(false);
        }

        /// <summary>Subtest for the execute method.</summary>
        /// <param name="successful2ndReponse">Indicates if the 2nd individual response is unsuccessful.</param>
        void SubtestExecuteAsync_Test(bool successful2ndReponse)
        {
            var handler = new BatchMessageHandler(successful2ndReponse);
            var initializer = new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(handler)
            };

            using (var service = new MockClientService(initializer, "http://sample.com"))
            {
                var responses = new List<Tuple<MockResponse, RequestError, HttpResponseMessage>>();
                var batch = new BatchRequest(service);
                var request1 = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"100\"",
                        Name = "Name1"
                    });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"200\"",
                        Name = "Name1-1"
                    });
                // Adding the content, error and message into the responses list to verify the results later on
                batch.Queue<MockResponse>(request1, (content, error, index, message) =>
                    {
                        responses.Add(new Tuple<MockResponse, RequestError, HttpResponseMessage>(
                            content, error, message));
                    });
                batch.Queue<MockResponse>(request2, (content, error, index, message) =>
                    {
                        responses.Add(new Tuple<MockResponse, RequestError, HttpResponseMessage>(
                                                    content, error, message));
                    });
                batch.ExecuteAsync().Wait();

                Assert.Equal(2, responses.Count);
                var tuple = responses[0];
                Assert.Null(tuple.Item2); // no error
                var response = tuple.Item1; // response
                Assert.Equal(@"""10011""", response.ETag);
                Assert.Equal(1, response.Id);
                var httpMessage = tuple.Item3; // HTTP message
                Assert.Equal("application/json", httpMessage.Content.Headers.ContentType.MediaType);
                Assert.Equal(505, httpMessage.Content.Headers.ContentLength);
                Assert.Contains("Accept-Encoding", httpMessage.Headers.Vary);
                Assert.Contains("Referer", httpMessage.Headers.Vary);

                tuple = responses[1];
                if (successful2ndReponse)
                {
                    Assert.Null(tuple.Item2); // no error
                    response = tuple.Item1; // response
                    Assert.Equal(@"""234""", response.ETag);
                    Assert.Equal(2, response.Id);
                }
                else
                {
                    Assert.Null(tuple.Item1); // no response
                    RequestError reqError = tuple.Item2; // error
                    Assert.Single(reqError.Errors);
                    Assert.Equal(404, reqError.Code);
                    Assert.Equal("Not Found", reqError.Message);
                    Assert.NotNull(reqError.ErrorResponseContent);
                    Assert.Contains("Custom individual error info", reqError.ErrorResponseContent);
                    Assert.Contains("Custom error info", reqError.ErrorResponseContent);
                }
                httpMessage = tuple.Item3; // HTTP message
                Assert.Equal("application/json", httpMessage.Content.Headers.ContentType.MediaType);
                Assert.Equal(202, httpMessage.Content.Headers.ContentLength);
            }
        }

        [Fact]
        public async Task ExecuteAsync_NoCallback_Test()
        {
            var handler = new BatchMessageHandler(true);
            var initializer = new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(handler)
            };

            using (var service = new MockClientService(initializer, "http://sample.com"))
            {
                var responses = new List<Tuple<MockResponse, RequestError, HttpResponseMessage>>();
                var batch = new BatchRequest(service);
                var request1 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"200\"",
                    Name = "Name1-1"
                });
                batch.Queue<MockResponse>(request1, null);
                batch.Queue<MockResponse>(request2, null);
                await batch.ExecuteAsync();
            }
        }

        [Fact]
        public async Task CreateOuterRequestContent_Test()
        {
            using (var service = new MockClientService("http://sample.com"))
            {
                var request1 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"200\"",
                    Name = "Name1-1"
                });

                var content = await BatchRequest.CreateOuterRequestContent(new[] { request1, request2 });
                var requestStr = await content.ReadAsStringAsync();

                // Read the boundary.
                string boundary = null;
                using (var reader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(requestStr))))
                {
                    var line = reader.ReadLine();
                    boundary = line.Substring(2);
                }

                Assert.Equal(ExpectedContentMessage.Replace("BOUNDARY", boundary), NormalizeLineEndings(requestStr));
            }
        }

        [Fact]
        public async Task CreateIndividualRequest_Test()
        {
            var expectedMessage = NormalizeLineEndings(@"POST http://sample.com/5?q=20
If-Match: ""123""
Content-Type: application/json; charset=utf-8
Content-Length:  40

{""etag_key"":""\""123\"""",""name_key"":""Name""}
");
            using (var service = new MockClientService("http://sample.com"))
            {
                var request = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"123\"",
                        Name = "Name"
                    });
                var content = await BatchRequest.CreateIndividualRequest(request);
                var requestStr = await content.ReadAsStringAsync();
                Assert.Equal(expectedMessage, NormalizeLineEndings(requestStr));
            }
        }

        [Fact]
        public async Task CreateRequestContentString_Test()
        {
            var expectedMessage = NormalizeLineEndings(@"GET http://test.com:2020/
Accept-Encoding: gzip
Content-Type: application/json
Content-Length:  11

hello world
");
            var request = new HttpRequestMessage(HttpMethod.Get, "http://test.com:2020");
            request.Content = new StringContent("hello world");
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var requestStr = await BatchRequest.CreateRequestContentString(request);
            Assert.Equal(expectedMessage, NormalizeLineEndings(requestStr));
        }

        [Fact]
        public void BatchUrl()
        {
            using (var service = new MockClientService("http://sample.com", "http://batch.sample.com"))
            {
                var batch = new BatchRequest(service);
                Assert.Equal("http://batch.sample.com", batch.BatchUrl);
            }
            using (var service = new MockClientService("http://sample.com", null))
            {
                var batch = new BatchRequest(service);
                Assert.Equal("https://www.googleapis.com/batch", batch.BatchUrl);
            }
        }

        class BatchEndpointErrorMessageHandler : CountableMessageHandler
        {
            private readonly string _responseContent;

            public BatchEndpointErrorMessageHandler(string responseContent) => _responseContent = responseContent;

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken cancellationToken) => 
                Task.FromResult(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ReasonPhrase = "Bad Request",
                    Content = _responseContent == null ? null : new StringContent(_responseContent, Encoding.UTF8, "application/json")
                });
        }

        [Fact]
        public async Task BatchEndpointErrorJsonContent()
        {
            string jsonErrorContent = NormalizeLineEndings(@"
{
  ""error"": {
    ""code"": 400,
    ""message"": ""Failed to parse batch request, error: Failed in parsing HTTP headers: invalid content\n. Received batch body: "",
    ""errors"": [
      {
        ""message"": ""Failed to parse batch request, error: Failed in parsing HTTP headers: invalid content\n. Received batch body: "",
        ""domain"": ""global"",
        ""reason"": ""badRequest""
      }
    ],
    ""status"": ""INVALID_ARGUMENT""
  }
}");

            using (var service = new MockClientService( new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(new BatchEndpointErrorMessageHandler(jsonErrorContent))
            }, "http://sample.com"))
            {
                var batchRequest = new BatchRequest(service);
                var request = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });
                
                batchRequest.Queue<MockResponse>( request, (c, e, i, m) =>
                    Assert.Fail("The batch endpoint call should have failed. Callbacks for individual requests shouldn't be called."));

                HttpRequestException outerException = await Assert.ThrowsAsync<HttpRequestException>(() => batchRequest.ExecuteAsync());

                Assert.Contains("400", outerException.Message);
                Assert.Contains("Bad Request", outerException.Message);

                GoogleApiException innerException = Assert.IsType<GoogleApiException>(outerException.InnerException);

                Assert.Equal(HttpStatusCode.BadRequest, innerException.HttpStatusCode);
                Assert.NotNull(innerException.Error);

                RequestError requestError = innerException.Error;
                Assert.Equal(jsonErrorContent, requestError.ErrorResponseContent);
                Assert.Equal(400, requestError.Code);

                SingleError singleError = Assert.Single(requestError.Errors);
                Assert.Equal("global", singleError.Domain);
                Assert.Equal("badRequest", singleError.Reason);
            }
        }

        [Fact]
        public async Task BatchEndpointErrorNonJsonContent()
        {
            string nonJsonContent = "Invalid JSON";
            string expectedExceptionMessage = "The service TestService has thrown an exception. HttpStatusCode is BadRequest. No error message was specified.";
            string expectedExceptionToStringContent =
                $"The service TestService has thrown an exception.{Environment.NewLine}" +
                $"HttpStatusCode is BadRequest.{Environment.NewLine}" +
                $"No JSON error details were specified.{Environment.NewLine}" +
                $"Raw error details are: {nonJsonContent}";

            using (var service = new MockClientService( new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(new BatchEndpointErrorMessageHandler(nonJsonContent))
            }, "http://sample.com"))
            {
                var batchRequest = new BatchRequest(service);
                var request = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });

                batchRequest.Queue<MockResponse>(request, (c, e, i, m) =>
                   Assert.Fail("The batch endpoint call should have failed. Callbacks for individual requests shouldn't be called."));

                HttpRequestException outerException = await Assert.ThrowsAsync<HttpRequestException>(() => batchRequest.ExecuteAsync());

                Assert.Contains("400", outerException.Message);
                Assert.Contains("Bad Request", outerException.Message);

                GoogleApiException innerException = Assert.IsType<GoogleApiException>(outerException.InnerException);

                Assert.Equal(HttpStatusCode.BadRequest, innerException.HttpStatusCode);
                Assert.True(innerException.Error.IsOnlyRawContent);
                Assert.Equal(expectedExceptionMessage, innerException.Message);
                Assert.Contains(expectedExceptionToStringContent, innerException.ToString());

                Assert.IsAssignableFrom<JsonException>(innerException.InnerException);
            }
        }

        [Fact]
        public async Task BatchEndpointErrorNullContent()
        {
            string expectedExceptionMessage = "The service TestService has thrown an exception. HttpStatusCode is BadRequest. No error message was specified.";

            using (var service = new MockClientService( new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(new BatchEndpointErrorMessageHandler(null))
            }, "http://sample.com"))
            {
                var batchRequest = new BatchRequest(service);
                var request = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });

                batchRequest.Queue<MockResponse>(request, (c, e, i, m) =>
                   Assert.Fail("The batch endpoint call should have failed. Callbacks for individual requests shouldn't be called."));

                HttpRequestException outerException = await Assert.ThrowsAsync<HttpRequestException>(() => batchRequest.ExecuteAsync());

                Assert.Contains("400", outerException.Message);
                Assert.Contains("Bad Request", outerException.Message);

                GoogleApiException innerException = Assert.IsType<GoogleApiException>(outerException.InnerException);
                Assert.Equal(HttpStatusCode.BadRequest, innerException.HttpStatusCode);
#if NET6_0_OR_GREATER
                // Even though we tell our handler to return a response with null content,
                // in .NET 6 we get a StringContent with empty string content.
                // This just documents that behaviour.
                Assert.Equal("", innerException.Error.ErrorResponseContent);
                string expectedExceptionToStringContent =
                    $"The service TestService has thrown an exception.{Environment.NewLine}" +
                    $"HttpStatusCode is BadRequest.{Environment.NewLine}" +
                    $"No JSON error details were specified.{Environment.NewLine}" +
                    $"Raw error details are empty or white spaces only.";
#else
                Assert.Null(innerException.Error);
                string expectedExceptionToStringContent =
                    $"The service TestService has thrown an exception.{Environment.NewLine}" +
                    $"HttpStatusCode is BadRequest.{Environment.NewLine}" +
                    $"No error details were specified.";
#endif
                Assert.Equal(expectedExceptionMessage, innerException.Message);
                Assert.Contains(expectedExceptionToStringContent, innerException.ToString());
            }
        }

        [Fact]
        public async Task ParseAsHttpResponse_NormalContent()
        {
            string content = @"Content-Type: application/http

HTTP/1.1 200 OK
Vary: Origin
Vary: X-Origin
Vary: Referer
Content-Type: application/json

{}
";
            var response = BatchRequest.ParseAsHttpResponse(content);
            Assert.Equal("application/json", response.Content.Headers.ContentType.MediaType);
            Assert.Equal("{}", (await response.Content.ReadAsStringAsync()).Trim());
        }

        [Fact]
        public async Task ParseAsHttpResponse_NoContent()
        {
            string content = @"Content-Type: application/http

HTTP/1.1 204 No content
Vary: Origin
Vary: X-Origin
Vary: Referer

";
            var response = BatchRequest.ParseAsHttpResponse(content);
            var httpContent = response.Content;
            Assert.NotNull(content);

#if NET6_0_OR_GREATER
            Assert.Null(httpContent.Headers.ContentType);
#else
            Assert.Equal("text/plain", httpContent.Headers.ContentType.MediaType);
#endif
            Assert.Equal("", (await response.Content.ReadAsStringAsync()).Trim());
        }

        [Fact]
        public async Task ParseAsHttpResponse_ContentButNoContentType()
        {
            string content = @"Content-Type: application/http

HTTP/1.1 200 OK
Vary: Origin
Vary: X-Origin
Vary: Referer

{}
";
            var response = BatchRequest.ParseAsHttpResponse(content);
            Assert.Equal("text/plain", response.Content.Headers.ContentType.MediaType);
            Assert.Equal("{}", (await response.Content.ReadAsStringAsync()).Trim());
        }

        // Line endings in HttpContent are different between mono & .NET.
        private static string NormalizeLineEndings(string s) =>
            Regex.Replace(s, @"\r\n|\n", "\r\n");
    }
}
