﻿/*
Copyright 2015 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.JsonWebSignature;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.ComputeCredential"/>.</summary>
    public class ComputeCredentialTests
    {
        private const string FakeUniverseDomain = "fake.universe.domain.com";

        [Fact]
        public void IsRunningOnComputeEngine_ResultIsCached()
        {
            // Two subsequent invocations should return the same task.
            Assert.Same(ComputeCredential.IsRunningOnComputeEngine(),
                ComputeCredential.IsRunningOnComputeEngine());
        }

        [Fact]
        public async Task UniverseDomain_Custom()
        {
            var credential = new ComputeCredential(new ComputeCredential.Initializer
            {
                UniverseDomain = FakeUniverseDomain
            }) as IGoogleCredential;

            Assert.Equal(FakeUniverseDomain, await credential.GetUniverseDomainAsync(default));
            Assert.Equal(FakeUniverseDomain, credential.GetUniverseDomain());
        }

        [Fact]
        public async Task WithUniverseDomain()
        {
            var credential = new ComputeCredential() as IGoogleCredential;

            var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

            Assert.NotSame(credential, newCredential);
            Assert.IsType<ComputeCredential>(newCredential);

            Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
            Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
        }

        [Fact]
        public void WithHttpClientFactory()
        {
            var credential = new ComputeCredential();
            var factory = new HttpClientFactory();
            var credentialWithFactory = Assert.IsType<ComputeCredential>(((IGoogleCredential)credential).WithHttpClientFactory(factory));

            Assert.NotSame(credential, credentialWithFactory);
            Assert.NotSame(credential.HttpClient, credentialWithFactory.HttpClient);
            Assert.NotSame(credential.HttpClientFactory, credentialWithFactory.HttpClientFactory);
            Assert.Same(factory, credentialWithFactory.HttpClientFactory);
        }

        [Fact]
        public async Task FetchesDefaultServiceAccountEmail()
        {
            string fakeServiceAccountEmail = "fake-service-account@fake-instance.com";

            var messageHandler = new DelegatedMessageHandler(FetchServiceAccountId);
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            var serviceAccountEmailTask = credential.GetDefaultServiceAccountEmailAsync();

            Assert.Equal(fakeServiceAccountEmail, await serviceAccountEmailTask);

            Task<HttpResponseMessage> FetchServiceAccountId(HttpRequestMessage request)
            {
                Assert.Equal(GoogleAuthConsts.EffectiveComputeDefaultServiceAccountEmailUrl, request.RequestUri.ToString());
                Assert.Null(request.Headers.Authorization);
                Assert.Contains(request.Headers, h => h.Key == ComputeCredential.MetadataFlavor && h.Value.Contains(ComputeCredential.GoogleMetadataHeader));
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(fakeServiceAccountEmail)
                });
            }
        }

        [Fact]
        public async Task FetchesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Move the clock some but not enough that the token expires.
            clock.UtcNow = clock.UtcNow.AddMinutes(20);
            signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Only the first call should have resulted in a request. The second time the token hadn't expired.
            Assert.Equal(1, messageHandler.Calls);
        }

        [Fact]
        public async Task RefreshesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Move the clock so that the token expires.
            clock.UtcNow = clock.UtcNow.AddHours(2);
            signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://subsequent_calls.test", signedToken.Payload.Audience);
            // Two calls, because the second time we tried to get the token, the first one had expired.
            Assert.Equal(2, messageHandler.Calls);
        }

        [Fact]
        public async Task FetchesOidcToken_WithDefaultOptions()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("any_audience"));
            await oidcToken.GetAccessTokenAsync();

            Assert.Equal("?audience=any_audience&format=full", messageHandler.LatestRequest.RequestUri.Query);
        }

        [Theory]
        [InlineData(OidcTokenFormat.Full, "another_audience", "?audience=another_audience&format=full")]
        [InlineData(OidcTokenFormat.Standard, "another_audience", "?audience=another_audience")]
        [InlineData(OidcTokenFormat.FullWithLicences, "another_audience", "?audience=another_audience&format=full&licenses=true")]
        public async Task FetchesOidcToken_WithOptions(OidcTokenFormat format, string targetAudience, string expectedQueryString)
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            var oidcToken = await credential.GetOidcTokenAsync(
                OidcTokenOptions.FromTargetAudience("any_audience")
                .WithTargetAudience(targetAudience)
                .WithTokenFormat(format));
            await oidcToken.GetAccessTokenAsync();

            Assert.Equal(expectedQueryString, messageHandler.LatestRequest.RequestUri.Query);
        }

        public static TheoryData<string[], string> Scoped_WithDefaultTokenUrl_Data =>
            new TheoryData<string[], string>
            {
                // explicit scopes, expected token URL
                { null, GoogleAuthConsts.EffectiveComputeTokenUrl },
                { new string[] { "scope1", "scope2"}, $"{GoogleAuthConsts.EffectiveComputeTokenUrl}?scopes=scope1,scope2" }
            };

        public static TheoryData<string[], string, string> Scoped_WithCustomTokenUrl_Data =>
            new TheoryData<string[], string, string>
            {
                // explicit scopes, custom token URL, expected token URL
                { null, "https://custom.metadata.server/compute/token", "https://custom.metadata.server/compute/token" },
                { null, "https://custom.metadata.server/compute/token?parameter=value", "https://custom.metadata.server/compute/token?parameter=value" },
                { new string[] { "scope1", "scope2" }, "https://custom.metadata.server/compute/token", "https://custom.metadata.server/compute/token?scopes=scope1,scope2" },
                { new string[] { "scope1", "scope2" }, "https://custom.metadata.server/compute/token?parameter=value", "https://custom.metadata.server/compute/token?parameter=value&scopes=scope1,scope2" }
            };

        private void AssertScoped(ComputeCredential credential, string[] scopes, string expectedTokenUrl)
        {
            Assert.Collection(credential.Scopes ?? Enumerable.Empty<string>(),
                (scopes?.Select<string, Action<string>>(expectedScope => actualScope => Assert.Equal(expectedScope, actualScope)) ?? Enumerable.Empty<Action<string>>()).ToArray());
            Assert.Equal(expectedTokenUrl, credential.EffectiveTokenServerUrl);
        }

        private async Task AssertUsesScopedUrl(ComputeCredential credential, FetchesTokenMessageHandler fakeMessageHandler, string expectedTokenUrl)
        {
            Assert.NotNull(await credential.GetAccessTokenForRequestAsync());
            Assert.Equal(1, fakeMessageHandler.Calls);
            Assert.Equal(expectedTokenUrl, fakeMessageHandler.Requests.First().RequestUri.AbsoluteUri);
        }

        [Theory]
        [MemberData(nameof(Scoped_WithDefaultTokenUrl_Data))]
        public async Task Scoped_Initializer_WithDefaultTokenUrl(string[] scopes, string expectedTokenUrl)
        {
            var fakeMessageHandler = new FetchesTokenMessageHandler();
            var credential = new ComputeCredential(new ComputeCredential.Initializer()
            {
                Scopes = scopes,
                HttpClientFactory = new MockHttpClientFactory(fakeMessageHandler)
            });

            AssertScoped(credential, scopes, expectedTokenUrl);
            await AssertUsesScopedUrl(credential, fakeMessageHandler, expectedTokenUrl);
        }

        [Theory]
        [MemberData(nameof(Scoped_WithDefaultTokenUrl_Data))]
        public async Task Scoped_MaybeWithScopes_WithDefaultTokenUrl(string[] scopes, string expectedTokenUrl)
        {
            var fakeMessageHandler = new FetchesTokenMessageHandler();
            var credential = (new ComputeCredential(new ComputeCredential.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(fakeMessageHandler)
            }) as IGoogleCredential).MaybeWithScopes(scopes) as ComputeCredential;
            
            AssertScoped(credential, scopes, expectedTokenUrl);
            await AssertUsesScopedUrl(credential, fakeMessageHandler, expectedTokenUrl);
        }

        [Theory]
        [MemberData(nameof(Scoped_WithCustomTokenUrl_Data))]
        public async Task Scoped_Initializer_WithCustomTokenUrl(string[] scopes, string customTokenUrl, string expectedTokenUrl)
        {
            var fakeMessageHandler = new FetchesTokenMessageHandler();
            var credential = new ComputeCredential(new ComputeCredential.Initializer(customTokenUrl)
            {
                Scopes = scopes,
                HttpClientFactory = new MockHttpClientFactory(fakeMessageHandler)
            });

            AssertScoped(credential, scopes, expectedTokenUrl);
            await AssertUsesScopedUrl(credential, fakeMessageHandler, expectedTokenUrl);
        }

        [Theory]
        [MemberData(nameof(Scoped_WithCustomTokenUrl_Data))]
        public async Task Scoped_MaybeWithScopes_WithCustomTokenUrl(string[] scopes, string customTokenUrl, string expectedTokenUrl)
        {
            var fakeMessageHandler = new FetchesTokenMessageHandler();
            var credential = (new ComputeCredential(new ComputeCredential.Initializer(customTokenUrl)
            {
                HttpClientFactory = new MockHttpClientFactory(fakeMessageHandler)
            }) as IGoogleCredential).MaybeWithScopes(scopes) as ComputeCredential;

            AssertScoped(credential, scopes, expectedTokenUrl);
            await AssertUsesScopedUrl(credential, fakeMessageHandler, expectedTokenUrl);
        }

        [Fact]
        public async Task SignBlob_Default_RecommendedRetryPolicy()
        {
            var initializer = GetInitializerForSignBlob();
            var mockFactory = initializer.HttpClientFactory as MockHttpClientFactory;
            var credential = new ComputeCredential(initializer);

            await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));

            // Three clients have been created:
            // - One is credential.HttpClient
            // - One is the HttpClient of the IAM scoped Compute Credential that's used for authenticated IAM requests.
            // - One is the HttpClient that will make requests to the IAM endpoint.
            Assert.Equal(3, mockFactory.AllCreateHttpClientArgs.Count());
            var signBlobArgs = mockFactory.AllCreateHttpClientArgs.Last();

            // One initializer is the retry policy and the other one is the IAM scoped compute credential
            Assert.Equal(2, signBlobArgs.Initializers.Count());
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ComputeCredential);
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer == GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
        }

        [Fact]
        public async Task SignBlob_BadResponse503AndRecommended_RecommendedRetryPolicy()
        {
            var initializer = GetInitializerForSignBlob();
            var mockFactory = initializer.HttpClientFactory as MockHttpClientFactory;

            initializer.DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503 | ExponentialBackOffPolicy.RecommendedOrDefault;
            var credential = new ComputeCredential(initializer);

            await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));

            // Three clients have been created:
            // - One is credential.HttpClient
            // - One is the HttpClient of the IAM scoped Compute Credential that's used for authenticated IAM requests.
            // - One is the HttpClient that will make requests to the IAM endpoint.
            Assert.Equal(3, mockFactory.AllCreateHttpClientArgs.Count());
            var signBlobArgs = mockFactory.AllCreateHttpClientArgs.Last();

            // One initializer is the retry policy and the other one is the IAM scoped compute credential
            Assert.Equal(2, signBlobArgs.Initializers.Count());
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ComputeCredential);
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer == GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
        }

        [Fact]
        public async Task SignBlob_ExceptionAndRecommended_RecommendedAndOtherRetryPolicy()
        {
            var initializer = GetInitializerForSignBlob();
            var mockFactory = initializer.HttpClientFactory as MockHttpClientFactory;

            initializer.DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.RecommendedOrDefault;
            var credential = new ComputeCredential(initializer);

            await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));

            // Three clients have been created:
            // - One is credential.HttpClient
            // - One is the HttpClient of the IAM scoped Compute Credential that's used for authenticated IAM requests.
            // - One is the HttpClient that will make requests to the IAM endpoint.
            Assert.Equal(3, mockFactory.AllCreateHttpClientArgs.Count());
            var signBlobArgs = mockFactory.AllCreateHttpClientArgs.Last();

            // Two retry policies and the IAM scoped compute credential
            Assert.Equal(3, signBlobArgs.Initializers.Count());
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ComputeCredential);
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer == GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ExponentialBackOffInitializer && initializer != GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
        }

        [Fact]
        public async Task SignBlob_NoRetryPolicy()
        {
            var initializer = GetInitializerForSignBlob();
            var mockFactory = initializer.HttpClientFactory as MockHttpClientFactory;

            initializer.DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.None;
            var credential = new ComputeCredential(initializer);

            await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));

            // Three clients have been created:
            // - One is credential.HttpClient
            // - One is the HttpClient of the IAM scoped Compute Credential that's used for authenticated IAM requests.
            // - One is the HttpClient that will make requests to the IAM endpoint.
            Assert.Equal(3, mockFactory.AllCreateHttpClientArgs.Count());
            var signBlobArgs = mockFactory.AllCreateHttpClientArgs.Last();

            // Just the IAM scoped compute credential
            var clientInitializer = Assert.Single(signBlobArgs.Initializers);
            Assert.IsType<ComputeCredential>(clientInitializer);
        }

        [Theory]
        [InlineData(ExponentialBackOffPolicy.Exception)]
        [InlineData(ExponentialBackOffPolicy.UnsuccessfulResponse503)]
        [InlineData(ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.UnsuccessfulResponse503)]
        public async Task SignBlob_OtherThanRecommendedRetryPolicy(ExponentialBackOffPolicy policy)
        {
            var initializer = GetInitializerForSignBlob();
            var mockFactory = initializer.HttpClientFactory as MockHttpClientFactory;

            initializer.DefaultExponentialBackOffPolicy = policy;
            var credential = new ComputeCredential(initializer);

            await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));

            // Three clients have been created:
            // - One is credential.HttpClient
            // - One is the HttpClient of the IAM scoped Compute Credential that's used for authenticated IAM requests.
            // - One is the HttpClient that will make requests to the IAM endpoint.
            Assert.Equal(3, mockFactory.AllCreateHttpClientArgs.Count());
            var signBlobArgs = mockFactory.AllCreateHttpClientArgs.Last();

            // Two retry policy but not the default and the IAM scoped compute credential
            Assert.Equal(2, signBlobArgs.Initializers.Count());
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ComputeCredential);
            Assert.Contains(signBlobArgs.Initializers, initializer => initializer is ExponentialBackOffInitializer && initializer != GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
        }

        [Fact]
        public async Task SignBlobAsync()
        {
            var initializer = GetInitializerForSignBlob();

            var credential = new ComputeCredential(initializer);

            var signature = await credential.SignBlobAsync(Encoding.ASCII.GetBytes("ignored"));
            Assert.Equal("Zm9v", signature);
        }

        private ComputeCredential.Initializer GetInitializerForSignBlob()
        {
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var response = NewtonsoftJsonSerializer.Instance.Serialize(new { keyId = "1", signedBlob = "Zm9v" });
            var fakeAccessToken = "fake_access_token";
            var fakeServiceAccountEmail = "fake-service-account@fake-instance.com";
            var fakeUniverseDomain = "fake.universe.domain.com";

            var messageHandler = new DelegatedMessageHandler(FetchServiceAccountId, FetchOAuthToken, SignBlob);
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                Clock = clock,
                UniverseDomain = fakeUniverseDomain,
            };

            return initializer;

            Task<HttpResponseMessage> FetchServiceAccountId(HttpRequestMessage request)
            {
                Assert.Null(request.Headers.Authorization);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(fakeServiceAccountEmail)
                });
            }

            Task<HttpResponseMessage> FetchOAuthToken(HttpRequestMessage request)
            {
                Assert.Null(request.Headers.Authorization);
                // We are requesting a token for calling the IAM API, the request URI should include the IAM scope.
                Assert.Equal($"http://will.be.ignored/?scopes={GoogleAuthConsts.IamScope}", request.RequestUri.ToString());
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                    {
                        AccessToken = fakeAccessToken,
                        ExpiresInSeconds = 24 * 60 * 60, //One day in seconds
                        IssuedUtc = clock.UtcNow
                    }))
                });
            }

            Task<HttpResponseMessage> SignBlob(HttpRequestMessage request)
            {
                Assert.Equal(string.Format(GoogleAuthConsts.IamSignEndpointFormatString, fakeUniverseDomain, fakeServiceAccountEmail), request.RequestUri.ToString());
                Assert.Equal(fakeAccessToken, request.Headers.Authorization.Parameter);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(response)
                });
            }
        }
    }
}
