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

using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
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
using Xunit;

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>Tests for <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.</summary>
    public class ConfigurableMessageHandlerTest
    {
        #region Handlers

        /// <summary>Unsuccessful handler which always returns <c>true</c>.</summary>
        private class TrueUnsuccessfulResponseHandler : IHttpUnsuccessfulResponseHandler
        {
            public Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
            {
                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                tcs.SetResult(true);
                return tcs.Task;
            }
        }

        /// <summary>Message handler which returns a new successful (and empty) response.</summary>
        private class MockMessageHandler : HttpMessageHandler
        {
            public HttpResponseMessage Response { get; set; } = new HttpResponseMessage();

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(Response);
                return tcs.Task;
            }
        }

        #endregion

        #region Redirect

        /// <summary>Redirect message handler which return redirect response.</summary>
        private class RedirectMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets the redirect location Uri string.</summary>
            private string Location { get; set; }

            /// <summary>Constructs a new redirect message handler with the given location.</summary>
            public RedirectMessageHandler(string location)
            {
                Location = location;
            }

            protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsyncCore(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                var response = new HttpResponseMessage();

                response.StatusCode = HttpStatusCode.Redirect;
                response.Headers.Location = new Uri(Location + Calls);
                response.RequestMessage = request;

                if (Calls == 1)
                {
                    // First call the message should contain If-* headers
                    Assert.Equal(new Uri(Location), request.RequestUri);
                    Assert.Single(request.Headers.IfMatch);
                    Assert.Single(request.Headers.IfNoneMatch);
                    Assert.True(request.Headers.IfModifiedSince.HasValue);
                    Assert.True(request.Headers.IfUnmodifiedSince.HasValue);
                }
                else
                {
                    // After first call the message should not contain If-* headers
                    Assert.Equal(new Uri(Location + (Calls - 1)), request.RequestUri);
                    Assert.Empty(request.Headers.IfMatch);
                    Assert.Empty(request.Headers.IfNoneMatch);
                    Assert.Null(request.Headers.IfModifiedSince);
                    Assert.Null(request.Headers.IfUnmodifiedSince);
                }

                tcs.SetResult(response);
                return tcs.Task;
            }
        }

        /// <summary>Tests that the message handler handles redirect messages successfully.</summary>
        [Fact]
        public async Task SendAsync_Redirect()
        {
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHandler = new ConfigurableMessageHandler(redirectHandler)
            {
                NumRedirects = 5
            };

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfUnmodifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = await client.SendAsync(request);

                Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
                Assert.Equal(new Uri(location + (configurableHandler.NumRedirects + 1)), response.Headers.Location);
                Assert.Equal(configurableHandler.NumRedirects + 1, redirectHandler.Calls);
            }
        }

        /// <summary>
        /// Tests that the message handler doesn't handle redirect messages when follow redirect is <c>false</c>. 
        /// </summary>
        [Fact]
        public async Task SendAsync_Redirect_FollowRedirectFalse()
        {
            const int tries = 12;
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHandler = new ConfigurableMessageHandler(redirectHandler)
            {
                NumRedirects = tries,
                FollowRedirect = false
            };

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfUnmodifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = await client.SendAsync(request);

                // there should be only one request because follow redirect is false
                Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
                Assert.Equal(new Uri(location + 1), response.Headers.Location);
                Assert.Equal(1, redirectHandler.Calls);
            }
        }

        #endregion

        #region Execute interceptor

        /// <summary>
        /// Mock interceptor handler which verifies that an interceptor is being called on a request. 
        /// </summary>
        private class InterceptorMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets an injected response message which will be returned on send.</summary>
            public HttpResponseMessage InjectedResponseMessage { get; set; }

            const string InjectedHeader = "Some-Header";
            const string InjectedValue = "123";

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                Assert.Equal(InjectedValue, request.Headers.GetValues(InjectedHeader).First());

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(InjectedResponseMessage);
                return tcs.Task;
            }

            /// <summary>A mock interceptor which inject a header to a request.</summary>
            internal class Interceptor : IHttpExecuteInterceptor
            {
                public int Calls { get; set; }

                public Task InterceptAsync(HttpRequestMessage request, CancellationToken token)
                {
                    ++Calls;
                    request.Headers.Add(InjectedHeader, InjectedValue);
                    return Task.Delay(0);
                }
            }
        }

        [Theory]
        [InlineData(HttpStatusCode.OK)]
        [InlineData(HttpStatusCode.BadRequest)]
        public async Task SendAsync_ExecuteInterceptor(HttpStatusCode code)
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage
            {
                StatusCode = code
            };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHandler.AddExecuteInterceptor(interceptor);

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(1, interceptor.Calls);
                Assert.Equal(1, handler.Calls);
            }
        }

        /// <summary>
        /// Tests that execute interceptor is called for each request. In this case an unsuccessful response handler is 
        /// plugged to the handler
        /// </summary>
        [Fact]
        public async Task SendAsync_ExecuteInterceptor_AbnormalResponse_UnsuccessfulResponseHandler()
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.ServiceUnavailable
            };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHandler.AddExecuteInterceptor(interceptor);
            configurableHandler.AddUnsuccessfulResponseHandler(new TrueUnsuccessfulResponseHandler());

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(configurableHandler.NumTries, interceptor.Calls);
                Assert.Equal(configurableHandler.NumTries, handler.Calls);
            }
        }

        [Fact]
        public async Task SendAsync_ExecuteInterceptor_AbnormalResponse_UnsuccessfulResponseHandler_PerRequestMaxRetries()
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.ServiceUnavailable
            };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHandler.AddExecuteInterceptor(interceptor);
            configurableHandler.AddUnsuccessfulResponseHandler(new TrueUnsuccessfulResponseHandler());
            // Let's have this request retry for a little longer than default.
            int perRequestRetries = configurableHandler.NumTries + 2;

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");
                var properties = TestHelpers.GetRequestProperties(request);
                properties.Add(ConfigurableMessageHandler.MaxRetriesKey, perRequestRetries);

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(perRequestRetries, interceptor.Calls);
                Assert.Equal(perRequestRetries, handler.Calls);
            }
        }

        #endregion

        #region Unsuccessful reponse handler

        /// <summary>
        /// Mock unsuccessful response handler which verifies that unsuccessful response handler is being called.
        /// </summary>
        private class UnsuccessfulResponseMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets the status code to return on the response.</summary>
            public HttpStatusCode ResponseStatusCode { get; set; }

            /// <summary>Gets or sets the cancellation token source.</summary>
            public CancellationTokenSource CancellationTokenSource { get; set; }

            /// <summary>
            /// Gets or sets the request number to invoke the Cancel method on <see cref="CancellationTokenSource"/>.
            /// </summary>
            public int CancelRequestNum { get; set; }

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (Calls == CancelRequestNum)
                {
                    CancellationTokenSource.Cancel();
                }

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(new HttpResponseMessage { StatusCode = ResponseStatusCode });
                return tcs.Task;
            }

            /// <summary>Unsuccessful response handler which "handles" only service unavailable responses.</summary>
            internal class ServiceUnavailableResponseHandler : IHttpUnsuccessfulResponseHandler
            {
                public int Calls { get; set; }

                public Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
                {
                    ++Calls;
                    TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                    tcs.SetResult(args.Response.StatusCode.Equals(HttpStatusCode.ServiceUnavailable));
                    return tcs.Task;
                }
            }
        }

        [Theory]
        [CombinatorialData]
        public async Task SendAsyncUnsuccessfulReponseHandler(
            [CombinatorialValues(HttpStatusCode.OK, HttpStatusCode.BadGateway, HttpStatusCode.ServiceUnavailable)] HttpStatusCode code,
            [CombinatorialValues(null, 5)] int? maxRetries)
        {
            var handler = new UnsuccessfulResponseMessageHandler { ResponseStatusCode = code };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var unsuccessfulHandler = new UnsuccessfulResponseMessageHandler.ServiceUnavailableResponseHandler();
            configurableHandler.AddUnsuccessfulResponseHandler(unsuccessfulHandler);

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-unsuccessful-handler");
                int expectedMaxRetries = MaybeSetMaxRetries(maxRetries, configurableHandler.NumTries, request);

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(code, response.StatusCode);

                // if service unavailable, retry will occur because we plugged unsuccessful response handler which 
                // handles service unavailable responses
                if (code == HttpStatusCode.ServiceUnavailable)
                {
                    Assert.Equal(expectedMaxRetries, unsuccessfulHandler.Calls);
                    Assert.Equal(expectedMaxRetries, handler.Calls);
                }
                else
                {
                    // if status is OK, there isn't any call to unsuccessful response handler
                    Assert.Equal(code != HttpStatusCode.OK ? 1 : 0, unsuccessfulHandler.Calls);
                    Assert.Equal(1, handler.Calls);
                }
            }
        }

        /// <summary>Tests abnormal response when unsuccessful response handler isn't plugged.</summary>
        [Fact]
        public async Task SendAsync_AbnormalResponse_WithoutUnsuccessfulReponseHandler()
        {
            var handler = new UnsuccessfulResponseMessageHandler
                {
                    ResponseStatusCode = HttpStatusCode.ServiceUnavailable
                };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-unsuccessful-handler");

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(HttpStatusCode.ServiceUnavailable, response.StatusCode);
                Assert.Equal(1, handler.Calls);
            }
        }

        #endregion

        #region Exception Handler

        /// <summary>Mock exception message handler which verifies that exception handler is being called.</summary>
        private class ExceptionMessageHandler : CountableMessageHandler
        {
            public ExceptionMessageHandler()
            {
                Exception = new Exception(ExceptionMessage);
            }

            /// <summary>Gets or sets indication if exception should be thrown.</summary>
            public bool ThrowException { get; set; }

            /// <summary>
            /// Gets or sets a specific exception to throw. Default value is <seealso cref="System.Exception"/> 
            /// with <see cref="ExceptionMessage"/>.</summary>
            public Exception Exception { get; set; }

            /// <summary>
            /// The exception message which is thrown in case <see cref="ThrowException"/> is <c>true</c>. 
            /// </summary>
            public const string ExceptionMessage = "Exception from execute";

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (ThrowException)
                {
                    throw Exception;
                }

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(new HttpResponseMessage());
                return tcs.Task;
            }

            /// <summary>Mock Exception handler which "handles" the exception.</summary>
            internal class ExceptionHandler : IHttpExceptionHandler
            {
                public int Calls { get; set; }
                public bool Handle { get; set; }

                public ExceptionHandler(bool handle = true)
                {
                    Handle = handle;
                }

                public Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
                {
                    ++Calls;
                    TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                    tcs.SetResult(Handle);
                    return tcs.Task;
                }
            }
        }

        [Theory]
        [CombinatorialData]
        public async Task SendAsyncExceptionHandler(bool throwException, bool handle,
            [CombinatorialValues(null, 5)] int? maxRetries)
        {
            var handler = new ExceptionMessageHandler { ThrowException = throwException };

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var exceptionHandler = new ExceptionMessageHandler.ExceptionHandler { Handle = handle };
            configurableHandler.AddExceptionHandler(exceptionHandler);

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                int expectedMaxRetries = MaybeSetMaxRetries(maxRetries, configurableHandler.NumTries, request);

                try
                {
                    // TODO: Separate these out into throw / not-throw tests
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (throwException)
                    {
                        Assert.Fail("SendAsync should throw an exception");
                    }
                }
                catch (Exception exception)
                {
                    Assert.Equal(ExceptionMessageHandler.ExceptionMessage, exception.Message);
                }

                // if exception is thrown, check if it's handled.
                // If so, there should be expectedMaxRetries calls, otherwise only 1.
                if (throwException)
                {
                    Assert.Equal(handle ? expectedMaxRetries : 1, exceptionHandler.Calls);
                }
                // Exception wasn't supposed to be thrown, so no call to exception handler should be made.
                else
                {
                    Assert.Equal(0, exceptionHandler.Calls);
                }

                Assert.Equal(throwException & handle ? expectedMaxRetries : 1, handler.Calls);
            }
        }

        /// <summary>Tests an exception is thrown on execute and there is no exception handler.</summary>
        [Fact]
        public async Task SendAsync_ThrowException_WithoutExceptionHandler()
        {
            var handler = new ExceptionMessageHandler { ThrowException = true };

            var configurableHandler = new ConfigurableMessageHandler(handler);

            using var client = new HttpClient(configurableHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
            var exception = await Assert.ThrowsAsync<Exception>(() => client.SendAsync(request));
            Assert.Same(ExceptionMessageHandler.ExceptionMessage, exception.Message);
            Assert.Equal(1, handler.Calls);
        }

        #endregion

        #region Back-off

        #region Exception

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Use default max time span (2 minutes).
        /// </summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_Throw_Max2Minutes(int? maxRetries)
        {
            // create exponential back-off without delta interval, so expected seconds are exactly 1, 2, 4, 8, etc.
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer, maxRetries: maxRetries);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Max time span is set to 200 milliseconds (as a result the back-off handler can't handle the exception).
        /// </summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_Throw_Max200Milliseconds(int? maxRetries)
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromMilliseconds(200)
                };
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer, maxRetries: maxRetries);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Max time span is set to 1 hour.
        /// </summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_Throw_Max1Hour(int? maxRetries)
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromHours(1)
                };
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer,maxRetries: maxRetries);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when 
        /// <seealso cref="System.Threading.Tasks.TaskCanceledException"/>> is thrown. 
        /// </summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_ThrowCanceledException(int? maxRetries)
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer, new TaskCanceledException(), maxRetries);
        }

        /// <summary>
        /// Tests that back-off handler works as expected with the not defaulted exception handler. 
        /// </summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_DifferentHandler(int? maxRetries)
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            initializer.HandleExceptionFunc = e => (e is InvalidCastException);
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException(), maxRetries);

            initializer.HandleExceptionFunc = e => !(e is InvalidCastException);
            await SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException(), maxRetries);
        }

        /// <summary>Tests that back-off handler works as expected when exception isn't thrown.</summary>
        [Theory]
        [InlineData(null)]
        [InlineData(5)]
        public async Task SendAsync_BackOffExceptionHandler_DontThrow(int? maxRetries)
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            await SubtestSendAsync_BackOffExceptionHandler(false, initializer, maxRetries: maxRetries);
        }

        private async Task SubtestSendAsync_BackOffExceptionHandler(bool throwException, BackOffHandler.Initializer initializer, Exception exceptionToThrow = null, int? maxRetries = null)
        {
            var handler = new ExceptionMessageHandler { ThrowException = throwException };
            if (exceptionToThrow != null)
            {
                handler.Exception = exceptionToThrow;
            }

            var configurableHandler = new ConfigurableMessageHandler(handler);
            var boHandler = new MockBackOffHandler(initializer);
            configurableHandler.AddExceptionHandler(boHandler);

            var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
            int expectedMaxRetries = MaybeSetMaxRetries(maxRetries, configurableHandler.NumTries, request);

            int boHandleCount = 0;
            // if an exception should be thrown and the handler can handle it then calculate the handle count by the 
            // lg(MaxTimeSpan)
            if (throwException && initializer.HandleExceptionFunc(exceptionToThrow))
            {
                boHandleCount = Math.Min((int)Math.Floor(Math.Log(boHandler.MaxTimeSpan.TotalSeconds, 2)) + 1,
                    expectedMaxRetries - 1);
                boHandleCount = boHandleCount >= 0 ? boHandleCount : 0;
            }

            using (var client = new HttpClient(configurableHandler))
            {
                try
                {
                    // TODO: Separate out exception/non-exception cases
                    HttpResponseMessage response = await client.SendAsync(request);
                    Assert.False(throwException);
                }
                catch (Exception exception)
                {
                    Assert.True(throwException);
                    // Don't compare exception messages because for TaskCanceledException the message
                    // on Mono is different if there is a task associated with the exception.
                    Assert.Equal(handler.Exception.GetType(), exception.GetType());
                }

                Assert.Equal(boHandleCount, boHandler.Waits.Count);
                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                if (throwException)
                {
                    for (int i = 0; i < boHandler.Waits.Count; ++i)
                    {
                        Assert.Equal((int)Math.Pow(2, i), boHandler.Waits[i].TotalSeconds);
                    }
                }
                Assert.Equal(boHandleCount + 1, handler.Calls);
            }
        }

        #endregion

        #region Unsuccessful Response Handler

        /// <summary>
        /// Tests that back-off handler works as expected when the server returns 5xx and the maximum time span is set
        /// to 5 seconds.
        /// </summary>
        [Fact]
        public async Task SendAsync_BackOffUnsuccessfulResponseHandler_ServiceUnavailable_Max5Seconds()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromSeconds(5)
                };
            await SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when the server returns 5xx and the maximum time span is set
        /// to 10 hours.
        /// </summary>
        [Fact]
        public async Task SendAsync_BackOffUnsuccessfulResponseHandler_ServiceUnavailable_Max10Hours()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromHours(10)
                };
            await SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer);
        }

        /// <summary>
        /// Tests that back-off handler isn't be called when the server returns a successful response.
        /// </summary>
        [Fact]
        public async Task SendAsync_BackOffUnsuccessfulResponseHandler_OK()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            await SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.OK, initializer);
        }

        /// <summary>Tests that back-off handler is canceled when cancellation token is used.</summary>
        [Fact]
        public async Task SendAsync_BackOffUnsuccessfulResponseHandler_Cancel()
        {
            // Test back-off with maximum 30 minutes per single request
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
            {
                MaxTimeSpan = TimeSpan.FromMinutes(30)
            };
            await SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer, 2);
            await SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer, 6);
        }

        /// <summary>
        /// Subtest that back-off handler works as expected when a successful or abnormal response is returned.
        /// For testing the back-off handler in case of a canceled request, set the <code>cancelRequestNum</code>
        /// parameter to the index of the request you want to cancel.
        /// </summary>
        private async Task SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode statusCode,
            BackOffHandler.Initializer initializer, int cancelRequestNum = 0, int numTries = 10)
        {
            var handler = new UnsuccessfulResponseMessageHandler { ResponseStatusCode = statusCode };

            CancellationToken cancellationToken = CancellationToken.None;
            bool cancel = cancelRequestNum > 0;

            if (cancel)
            {
                CancellationTokenSource tcs = new CancellationTokenSource();
                handler.CancellationTokenSource = tcs;
                handler.CancelRequestNum = cancelRequestNum;
                cancellationToken = tcs.Token;
            }

            var configurableHandler = new ConfigurableMessageHandler(handler)
            {
                NumTries = numTries
            };
            var boHandler = new MockBackOffHandler(initializer);
            configurableHandler.AddUnsuccessfulResponseHandler(boHandler);

            int boHandleCount = 0;
            if (initializer.HandleUnsuccessfulResponseFunc != null &&
                initializer.HandleUnsuccessfulResponseFunc(new HttpResponseMessage { StatusCode = statusCode }))
            {
                boHandleCount = Math.Min((int)Math.Floor(Math.Log(boHandler.MaxTimeSpan.TotalSeconds, 2)) + 1,
                    configurableHandler.NumTries - 1);
                boHandleCount = boHandleCount >= 0 ? boHandleCount : 0;
                if (cancel)
                {
                    boHandleCount = Math.Min(boHandleCount, cancelRequestNum);
                }
            }

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    // TODO: Split out failure and non-failure cases.
                    HttpResponseMessage response = await client.SendAsync(request, cancellationToken);
                    Assert.False(cancel);
                }
                catch (OperationCanceledException)
                {
                    // A canceled request should throw an exception
                    Assert.True(cancel);
                }

                Assert.Equal(boHandleCount, boHandler.Waits.Count);

                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                for (int i = 0; i < boHandler.Waits.Count; ++i)
                {
                    Assert.Equal((int)Math.Pow(2, i), boHandler.Waits[i].TotalSeconds);
                }

                // if the request was canceled the number of calls to the message handler is equal to the number of 
                // calls to back-off handler
                Assert.Equal(boHandleCount + (cancel ? 0 : 1), handler.Calls);
            }
        }

        #endregion

        #endregion

        #region Content

        /// <summary>Mock message handler which verifies that the content is correct on retry.</summary>
        private class ContentMessageHandler : CountableMessageHandler
        {
            public const int NumFails = 4;
            public string ReadContent;

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (Calls < NumFails)
                {
                    return new HttpResponseMessage() { StatusCode = HttpStatusCode.ServiceUnavailable };
                }

                ReadContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                return new HttpResponseMessage();
            }
        }

        /// <summary>
        /// Defines the different content types we test in <see cref="SubtestSendAsyncRetryContent"/>.
        /// </summary>
        public enum ContentType
        {
            String,
            Stream,
            ByteArray
        }

        /// <summary>Tests that retry works with different kind of contents (String, Stream and ByteArray).</summary>
        [Theory]
        [InlineData(ContentType.String)]
        [InlineData(ContentType.Stream)]
        [InlineData(ContentType.ByteArray)]
        public async Task SubtestSendAsyncRetryContent(ContentType type)
        {
            var content = "test-content";
            var contentHandler = new ContentMessageHandler();
            var configurableHandler = new ConfigurableMessageHandler(contentHandler)
            {
                NumTries = 10
            };
            configurableHandler.AddUnsuccessfulResponseHandler(new TrueUnsuccessfulResponseHandler());
            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Put, "https://test-unsuccessful-handler");
                // set the right content
                switch (type)
                {
                    case ContentType.String:
                        request.Content = new StringContent(content);
                        break;
                    case ContentType.Stream:
                        {
                            var stream = new MemoryStream();
                            var buffer = Encoding.UTF8.GetBytes(content);
                            stream.Write(buffer, 0, buffer.Length);
                            stream.Position = 0;
                            request.Content = new StreamContent(stream);
                        }
                        break;
                    case ContentType.ByteArray:
                        request.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
                        break;
                }

                HttpResponseMessage response = await client.SendAsync(request);
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal(ContentMessageHandler.NumFails, contentHandler.Calls);
                Assert.Equal(content, contentHandler.ReadContent);
            }
        }
        #endregion

        /// <summary>Tests setting number of tries.</summary>
        [Fact]
        public void NumTries_Setter()
        {
            var configurableHandler = new ConfigurableMessageHandler(new HttpClientHandler());

            // Valid values
            configurableHandler.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries;
            configurableHandler.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries - 1;
            configurableHandler.NumTries = 1;

            // Test invalid values
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => configurableHandler.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries + 1);
            Assert.Equal(nameof(configurableHandler.NumTries), exception.ParamName);

            exception = Assert.Throws<ArgumentOutOfRangeException>(() => configurableHandler.NumTries = 0);
            Assert.Equal(nameof(configurableHandler.NumTries), exception.ParamName);

            exception = Assert.Throws<ArgumentOutOfRangeException>(() => configurableHandler.NumTries = -2);
            Assert.Equal(nameof(configurableHandler.NumTries), exception.ParamName);
        }

        /// <summary>
        /// Tests the number of tries in case of unsuccessful response when unsuccessful response handler is plugged to 
        /// the message handler. 
        /// </summary>
        [Fact]
        public void SendAsync_NumTries()
        {
            SubtestSendAsyncNumTries(5, false);
            SubtestSendAsyncNumTries(5);
            SubtestSendAsyncNumTries(1);
            SubtestSendAsyncNumTries(1, false);
            SubtestSendAsyncNumTries(10);
            SubtestSendAsyncNumTries(10, false);
        }

        /// <summary>
        /// Tests the retry mechanism. In case the abnormal response is handled, there should be retries, but otherwise
        /// there should not be any retry.
        /// </summary>
        /// <param name="numTries"></param>
        /// <param name="handle"></param>
        private void SubtestSendAsyncNumTries(int numTries, bool handle = true)
        {
            var handler = new UnsuccessfulResponseMessageHandler
                {
                    ResponseStatusCode = HttpStatusCode.ServiceUnavailable
                };
            var configurableHandler = new ConfigurableMessageHandler(handler)
                {
                    NumTries = numTries
                };
            if (handle)
            {
                var unsuccessfulHandler = new UnsuccessfulResponseMessageHandler.ServiceUnavailableResponseHandler();
                configurableHandler.AddUnsuccessfulResponseHandler(unsuccessfulHandler);
            }

            using (var client = new HttpClient(configurableHandler))
            {
                client.GetAsync("http://num-retries");
                Assert.Equal(handle ? numTries : 1, handler.Calls);
            }
        }

        /// <summary>Tests that the configurable message handler sets the User-Agent header.</summary>
        [Fact]
        public async Task SendAsync_UserAgent()
        {
            var apiVersion = string.Format("google-api-dotnet-client/{0} (gzip)", Utilities.GetLibraryVersion());
            const string applicationName = "NO NAME";

            var handler = new MockMessageHandler();
            var configurableHandler = new ConfigurableMessageHandler(handler);

            using (var client = new HttpClient(configurableHandler))
            {
                // without application name
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-user-agent");
                HttpResponseMessage response = await client.SendAsync(request);
                var userAgent = string.Join(" ", request.Headers.GetValues("User-Agent").ToArray());
                Assert.Equal(apiVersion, userAgent);

                // with application name
                configurableHandler.ApplicationName = applicationName;
                request = new HttpRequestMessage(HttpMethod.Get, "https://test-user-agent");
                response = await client.SendAsync(request);
                userAgent = string.Join(" ", request.Headers.GetValues("User-Agent").ToArray());
                Assert.Equal(applicationName + " " + apiVersion, userAgent);
            }
        }

        [Fact]
        public async Task SendAsync_GoogleApiClientHeader_Unset()
        {
            var handler = new MockMessageHandler();
            var configurableHandler = new ConfigurableMessageHandler(handler);

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-request");
                HttpResponseMessage response = await client.SendAsync(request);
                Assert.False(request.Headers.Contains("x-goog-api-client"));
            }
        }

        [Fact]
        public async Task SendAsync_GoogleApiClientHeader_Set()
        {
            var handler = new MockMessageHandler();
            var configurableHandler = new ConfigurableMessageHandler(handler)
            {
                GoogleApiClientHeader = "test/1.2.3"
            };

            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-request");
                HttpResponseMessage response = await client.SendAsync(request);
                string header = string.Join(" ", request.Headers.GetValues("x-goog-api-client").ToArray());
                Assert.Equal("test/1.2.3", header);
            }
        }

        private async Task<IList<string>> LogTest(ConfigurableMessageHandler.LogEventType logEvents, bool errorResponse = false)
        {
            var clock = new MockClock(new DateTime(2017, 1, 2, 3, 4, 5, DateTimeKind.Utc));
            var logger = new MemoryLogger(LogLevel.All, clock: clock);
            HttpMessageHandler handler;
            if (errorResponse)
            {
                handler = new MockMessageHandler
                {
                    Response = new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.ServiceUnavailable
                    }
                };
            }
            else
            {
                handler = new MockMessageHandler
                {
                    Response = new HttpResponseMessage
                    {
                        Headers = { { "header1", "One" }, { "header2", "Two" } },
                        Content = new ByteArrayContent(new byte[] { 65, 66, 67, 0, 1, 255, 68, 69 }) // ABC...DE
                    }
                };
            }
            var configurableHandler = new ConfigurableMessageHandler(handler)
            {
                LogEvents = logEvents,
                InstanceLogger = logger
            };
            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-host/")
                {
                    Headers = { Host = "test-host", Referrer = new Uri("https://referrer/") },
                    Content = new ByteArrayContent(new byte[] { 88, 89, 90, 0, 1, 255, 68, 69 }) // XYZ...DE
                };
                await client.SendAsync(request).ConfigureAwait(false);
            }
            return logger.LogEntries;
        }

        [Fact]
        public async Task Logging_RequestUri()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestUri);
            Assert.Single(logEntries, "D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] (triesRemaining=3) URI: 'https://test-host/'");
        }

        [Fact]
        public async Task Logging_RequestHeaders()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestHeaders);
            var entry = Assert.Single(logEntries);
            // Header order may vary, and extra headers may be present (e.g. UserAgent), so test using Contain()
            Assert.Contains("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] Headers:\n", entry);
            Assert.Contains("  [Host] 'test-host'", entry);
            Assert.Contains("  [Referer] 'https://referrer/'", entry);
        }

        [Fact]
        public async Task Logging_RequestBody()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestBody);
            Assert.Single(logEntries, "D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] Body: 'XYZ...DE'");
        }

        [Fact]
        public async Task Logging_ResponseStatus()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseStatus);
            Assert.Single(logEntries, "D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Response status: OK 'OK'");
        }

        [Fact]
        public async Task Logging_ResponseError()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseAbnormal, true);
            Assert.Equal(2, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] An abnormal response wasn't handled. Status code is ServiceUnavailable", logEntries[0]);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Abnormal response is being returned. Status Code is ServiceUnavailable", logEntries[1]);
        }

        [Fact]
        public async Task Logging_ResponseHeaders()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseHeaders);
            var entry = Assert.Single(logEntries);
            Assert.Contains("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Headers:\n", entry);
            Assert.Contains("  [header1] 'One'", entry);
            Assert.Contains("  [header2] 'Two'", entry);
        }

        [Fact]
        public async Task Logging_ResponseBody()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseBody);
            Assert.Single(logEntries, "D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Body: 'ABC...DE'");
        }

        private class AddsQuotaProject : IHttpExecuteInterceptor
        {
            public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                request.Headers.Add("x-goog-user-project", "my-project");
                return Task.FromResult(true);
            }
        }

        [Fact]
        public async Task FailsIfQuotaProjectSetWithInterceptors()
        {
            var configurableHandler = new ConfigurableMessageHandler(new HttpClientHandler());
            configurableHandler.AddExecuteInterceptor(new AddsQuotaProject());

            using (var client = new HttpClient(configurableHandler))
            {
               await Assert.ThrowsAsync<InvalidOperationException>(() => client.GetAsync("http://will.be.ignored"));
            }
        }

        [Fact]
        public async Task AcceptsQuotaProjectFromCredential()
        {
            var fakeHandler = new FakeHandler();
            var configurableHandler = new ConfigurableMessageHandler(fakeHandler)
            {
                Credential = new AddsQuotaProject()
            };

            using (var client = new HttpClient(configurableHandler))
            {
                await client.GetAsync("http://will.be.ignored");
            }

            Assert.Single(fakeHandler.LatestRequestHeaders, h => h.Key == "x-goog-user-project");
        }

        [Theory]
        // googleapis.com is no different here than any other domain,
        // we still test for it explicitly to document behaviour.
        [InlineData("googleapis.com")]
        [InlineData("custom.domain")]
        public async Task PropagatesUniverseDomain(string expectedUniverseDomain)
        {
            var fakeHandler = new FakeHandler();
            var configurableHandler = new ConfigurableMessageHandler(fakeHandler)
            {
                UniverseDomain = expectedUniverseDomain
            };

            using (var client = new HttpClient(configurableHandler))
            {
                await client.GetAsync("http://will.be.ignored");
            }

            Assert.True(fakeHandler.LatestRequest.TryGetOption(ConfigurableMessageHandler.UniverseDomainKey, out string universeDomain));
            Assert.Equal(expectedUniverseDomain, universeDomain);
        }

        [Fact]
        public async Task NoUniverseDomain()
        {
            var fakeHandler = new FakeHandler();
            var configurableHandler = new ConfigurableMessageHandler(fakeHandler);

            using (var client = new HttpClient(configurableHandler))
            {
                await client.GetAsync("http://will.be.ignored");
            }

            Assert.False(fakeHandler.LatestRequest.TryGetOption(ConfigurableMessageHandler.UniverseDomainKey, out string universeDomain));
        }

        /// <summary>
        /// Handler for intercepting all authenticated requests.
        /// </summary>
        private class FakeHandler : HttpMessageHandler
        {
            public HttpRequestHeaders LatestRequestHeaders => LatestRequest?.Headers;
            public HttpRequestMessage LatestRequest { get; private set; }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                LatestRequest = request;
                return Task.FromResult(new HttpResponseMessage());
            }
        }

        private int MaybeSetMaxRetries(int? perRequestMaxRetries, int defaultMaxRetries, HttpRequestMessage requestMessage)
        {
            if (perRequestMaxRetries == null)
            {
                return defaultMaxRetries;
            }
            int configuredRetries = perRequestMaxRetries.Value;
            var properties = TestHelpers.GetRequestProperties(requestMessage);
            properties.Add(ConfigurableMessageHandler.MaxRetriesKey, configuredRetries);
            return configuredRetries;
        }
    }
}
