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
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.ManufacturerCenter.v1;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Translate.v2;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.ManufacturerCenter.v1.AccountsResource.ProductsResource.GetRequest;

namespace Google.Apis.Tests.Apis.Services
{
    /// <summary>Test for the BaseClientService class.</summary>
    public class BaseClientServiceTest
    {
        /// <summary>A Json schema for testing serialization/deserialization.</summary>
        internal class MockJsonSchema : IDirectResponseSchema
        {
            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("longUrl")]
            public string LongURL { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            public RequestError Error { get; set; }

            public string ETag { get; set; }
        }

        /// <summary>Validates the deserialization result.</summary>
        private void CheckDeserializationResult(MockJsonSchema result)
        {
            Assert.NotNull(result);
            Assert.Equal("urlshortener#url", result.Kind);
            Assert.Equal("http://google.com/", result.LongURL);
            Assert.Null(result.Status);
        }

        /// <summary>Creates a client service for the given features.</summary>
        private IClientService CreateClientService(Features? features = null)
        {
            var client = new MockClientService();
            if (features.HasValue)
            {
                client.SetFeatures(new[] { Utilities.GetEnumStringValue(features.Value) });
            }

            return client;
        }

        /// <summary>This tests deserialization with data wrapping.</summary>
        [Fact]
        public async Task TestDeserialization_WithDataWrapping()
        {
            const string Response =
                @"{ ""data"" : 
                     {
                        ""kind"": ""urlshortener#url"",
                        ""longUrl"": ""http://google.com/"",
                     } 
                  }";

            var client = CreateClientService(Features.LegacyDataResponse);

            // Check that the default serializer is set.
            Assert.IsType<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly.
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResult(await client.DeserializeResponse<MockJsonSchema>(response));
        }


        /// <summary>This tests Deserialization without data wrapping.</summary>
        [Fact]
        public async Task TestDeserialization_WithoutDataWrapping()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            // by default the request provider doesn't contain the LegacyDataResponse
            var client = CreateClientService();

            // Check that the default serializer is set
            Assert.IsType<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResult(await client.DeserializeResponse<MockJsonSchema>(response));
        }

        /// <summary>Tests serialization with data wrapping.</summary>
        [Fact]
        public void TestSerialization_WithDataWrapping()
        {
            // Requets should not be wrapped
            const string Response =
                "{\"kind\":\"urlshortener#url\",\"longUrl\":\"http://google.com/\"}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientService(Features.LegacyDataResponse);

            // Check if a response is serialized correctly
            string result = client.SerializeObject(schema);
            Assert.Equal(Response, result);
        }

        /// <summary>Tests serialization without data wrapping.</summary>
        [Fact]
        public void TestSerialization_WithoutDataWrapping()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientService();

            // Check if a response is serialized correctly.
            string result = client.SerializeObject(schema);
            Assert.Equal(Response, result);
        }

        /// <summary>
        /// Confirms that the serializer won't do anything if a string is the requested response type.
        /// </summary>
        [Fact]
        public async Task TestDeserializationString()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockClientService client = new MockClientService();

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            string result = await client.DeserializeResponse<string>(response);
            Assert.Equal(Response, result);
        }

        /// <summary>Tests deserialization for server error response.</summary>
        [Theory, CombinatorialData]
        public async Task TestErrorDeserialization(
          [CombinatorialValues(Features.LegacyDataResponse, null)] Features? features)
        {
            const string ErrorResponse =
                @"{
                    ""error"": {
                        ""errors"": [
                            {
                                ""domain"": ""global"",
                                ""reason"": ""required"",
                                ""message"": ""Required"",
                                ""locationType"": ""parameter"",
                                ""location"": ""resource.longUrl"",
                                ""customIndividual"": ""Custom individual error info""
                            }
                        ],
                        ""code"": 400,
                        ""message"": ""Required"",
                        ""custom"": ""Custom error info""
                    }
                }";

            var client = CreateClientService(features);

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(ErrorResponse)))
            {
                var response = new HttpResponseMessage { Content = new StreamContent(stream) };
                RequestError error = await client.DeserializeError(response);
                Assert.Equal(400, error.Code);
                Assert.Equal("Required", error.Message);
                Assert.Single(error.Errors);
                Assert.NotNull(error.ErrorResponseContent);
                Assert.Equal(ErrorResponse, error.ErrorResponseContent);
            }
        }

        [Theory]
        [InlineData(null, "https://translation.googleapis.com/language/translate/")]
        [InlineData("https://alternative-uri", "https://alternative-uri")]
        public void InitializerBaseUriIsUsedByGeneratedServices(string initializerUri, string expectedServiceUri)
        {
            var service = new TranslateService(new BaseClientService.Initializer
            {
                BaseUri = initializerUri
            });
            Assert.Equal(expectedServiceUri, service.BaseUri);
        }

        [Theory]
        [InlineData(null, null, null, null)]
        [InlineData(null, "custom.domain", null, null)]
        [InlineData(null, "custom.domain", "https://service.googleapis.com", "https://service.custom.domain")]
        [InlineData(null, "custom.domain", "https://service.another.domain", "https://service.another.domain")]
        [InlineData("https://service.explicit.domain", "custom.domain", "https://service.googleapis.com", "https://service.explicit.domain")]
        [InlineData("https://service.explicit.domain", "custom.domain", "https://service.another.domain", "https://service.explicit.domain")]
        public void UniverseDomain_GetEffectiveUri(string explicitUri, string universeDomain, string defaultUri, string expectedUri)
        {
            var service = new MockClientService(new BaseClientService.Initializer
            { 
                // We don't need to initialize BaseUri here as we are testing the GetEffectiveUri method directly.
                UniverseDomain = universeDomain
            });

            var effectiveUri = service.GetEffectiveUri(explicitUri, defaultUri);
            Assert.Equal(expectedUri, effectiveUri);
        }

        [Theory]
        [InlineData(null, "googleapis.com")]
        [InlineData("googleapis.com", "googleapis.com")]
        [InlineData("custom.domain", "custom.domain")]
        public void UniverseDomain_PropagatesToMessageHandler(string explicitUniverseDomain, string expectedUnirseDomain)
        {
            var service = new MockClientService(new BaseClientService.Initializer
            {
                UniverseDomain = explicitUniverseDomain
            });

            Assert.Equal(service.HttpClient.MessageHandler.UniverseDomain, expectedUnirseDomain);
        }

        /// <summary>
        /// Tests the default values of <seealso cref="Google.Apis.Services.BaseClientService"/>
        /// </summary>
        [Fact]
        public void Constructor_DefaultValues()
        {
            var service = new MockClientService(new BaseClientService.Initializer());
            Assert.NotNull(service.HttpClient);
            Assert.Null(service.HttpClientInitializer);
            Assert.True(service.GZipEnabled);

            // Disable "<member> is obsolete" warning for these uses.
            // MessageHandler no longer provides a supported way for clients to query the list of handlers,
            // but we rely on the obsolete property as an implementation detail here.
            #pragma warning disable 618
            // Back-off handler for unsuccessful response (503) is added by default.
            var backoffHandler = Assert.Single(service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers);
            Assert.IsAssignableFrom<BackOffHandler>(backoffHandler);

            // An execute interceptor is expected (for handling GET requests with URLs that are too long)
            var interceptor = Assert.Single(service.HttpClient.MessageHandler.ExecuteInterceptors);
            Assert.IsType<MaxUrlLengthInterceptor>(interceptor);
            #pragma warning restore 618
        }

        private const uint DefaultMaxUrlLength = BaseClientService.DefaultMaxUrlLength;

        /// <summary>
        /// Verifies that URLs over 2K characters on GET requests are correctly translated to a POST request.
        /// </summary>
        [Fact]
        public void TestGetWithUrlTooLongByDefault()
        {
            // Build a query string such that the whole URI adds up to 2049 characters
            var query = "q=" + new String('x', 1020) + "&x=" + new String('y', 1000);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var messageHandler = new MockMessageHandler();
            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler)
                }))
            {
                service.HttpClient.SendAsync(request);
                // Confirm the test URI is one character too long.
                Assert.Equal(DefaultMaxUrlLength + 1, (uint)requestUri.Length);
                // Confirm the request was modified correctly:
                Assert.Equal(HttpMethod.Post, request.Method);
                Assert.Equal("GET", request.Headers.GetValues("X-HTTP-Method-Override").Single());
                Assert.Equal(new MediaTypeHeaderValue("application/x-www-form-urlencoded"), request.Content.Headers.ContentType);
                Assert.Equal(new Uri(uri), request.RequestUri);
                Assert.Equal(query, messageHandler.RequestContent);
            }
        }

        /// <summary>
        /// Verifies that URLs of great lengths on GET requests are NOT translated to a POST request when the user
        /// sets the <c>maxUrlLength = 0</c>.
        /// </summary>
        [Fact]
        public void TestGetWithUrlMaxLengthDisabled()
        {
            var query = "q=" + new String('x', 5000) + "&x=" + new String('y', 6000);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var messageHandler = new MockMessageHandler();
            var initializer = (new BaseClientService.Initializer
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                MaxUrlLength = 0
            });

            using (var service = new MockClientService(initializer))
            {
                service.HttpClient.SendAsync(request);
                // Confirm the request was not modified.
                Assert.Equal(requestUri.Length, request.RequestUri.ToString().Length);
                Assert.Equal(HttpMethod.Get, request.Method);
                Assert.False(request.Headers.Contains("X-HTTP-Method-Override"));
                Assert.Null(request.Content);
                Assert.Equal(new Uri(requestUri), request.RequestUri);
            }
        }

        [Fact]
        public void ValidApplicationName()
        {
            // Assert no exception thrown
            new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = "AppName"
            });
        }

        [Fact]
        public void NullApplicationName()
        {
            // Assert no exception thrown
            new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = null
            });
        }

        [Fact]
        public void InvalidApplicationName()
        {
            // Assert no exception thrown
            Assert.Throws<ArgumentException>(() => new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = "App=Name"
            }));
        }

        [Fact]
        public void HttpClientTimeout()
        {
            var timeout = TimeSpan.FromHours(10);
            var service = new MockClientService(new BaseClientService.Initializer
            {
                HttpClientTimeout = timeout
            });

            Assert.Equal(timeout, service.HttpClientTimeout);
            Assert.Equal(timeout, service.HttpClient.Timeout);
        }

        [Fact]
        public void VersionHeader()
        {
            var initializer = new BaseClientService.Initializer();
            initializer.VersionHeaderBuilder.AppendVersion("test", "1.2.3");
            var service = new MockClientService(initializer);
            var header = service.HttpClient.MessageHandler.GoogleApiClientHeader;
            Assert.Contains("test/1.2.3", header);
            Assert.Contains("gl-dotnet/", header);
            Assert.Contains("gdcl/", header);
        }

        [Fact]
        public void SharedInitializer()
        {
            var initializer = new BaseClientService.Initializer();
            var service1 = new TranslateService(initializer);
            var service2 = new TranslateService(initializer);
        }

        [Fact]
        public void RepeatedEnumQueryParameter()
        {
            var service = new ManufacturerCenterService();
            var request = service.Accounts.Products.Get("accounts/abc", "def");
            request.IncludeList = new[] { IncludeEnum.ATTRIBUTES, IncludeEnum.ISSUES };
            var uri = request.CreateRequest().RequestUri;
            Assert.Equal("https://manufacturers.googleapis.com/v1/accounts/abc/products/def?include=ATTRIBUTES&include=ISSUES", uri.ToString());
        }
    }
}
