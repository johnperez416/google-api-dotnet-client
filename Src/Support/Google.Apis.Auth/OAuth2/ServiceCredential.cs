﻿/*
Copyright 2014 Google Inc

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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// This type of Google OAuth 2.0 credential enables access to protected resources using an access token when
    /// interacting server to server. For example, a service account credential could be used to access Google Cloud
    /// Storage from a web application without a user's involvement.
    /// <para>
    /// <see cref="ServiceAccountCredential"/> inherits from this class in order to support Service Accounts. More
    /// details available at: https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// <see cref="ComputeCredential"/> is another example of a class that inherits from this
    /// class in order to support Compute credentials. For more information about Compute authentication, see:
    /// https://cloud.google.com/compute/docs/authentication.
    /// </para>
    /// <para>
    /// <see cref="ExternalAccountCredential"/> inherits from this class to support both Workload Identity Federation
    /// and Workforce Identity Federation. You can read more about these topics in
    /// https://cloud.google.com/iam/docs/workload-identity-federation and
    /// https://cloud.google.com/iam/docs/workforce-identity-federation respectively.
    /// Note that in the case of Workforce Identity Federation, the external account does not represent a service account
    /// but a user account, so, the fact that <see cref="ExternalAccountCredential"/> inherits from <see cref="ServiceCredential"/>
    /// might be construed as misleading. In reality <see cref="ServiceCredential"/> is not tied to a service account
    /// in terms of implementation, only in terms of name. For instance, a better name for this class might have been NoUserFlowCredential, and
    /// in that sense, it's correct that <see cref="ExternalAccountCredential"/> inherits from <see cref="ServiceCredential"/>
    /// even when representing a Workforce Identity Federation account.
    /// </para>
    /// </summary>
    public abstract class ServiceCredential : ICredential, ITokenAccessWithHeaders,
        IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler
    {
        /// <summary>Logger for this class</summary>
        protected static readonly ILogger Logger = ApplicationContext.Logger.ForType<ServiceCredential>();

        /// <summary>An initializer class for the service credential. </summary>
        public class Initializer
        {
            /// <summary>Gets the token server URL.</summary>
            public string TokenServerUrl { get; private set; }

            /// <summary>
            /// Gets or sets the clock used to refresh the token when it expires. The default value is
            /// <see cref="Google.Apis.Util.SystemClock.Default"/>.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>
            /// Gets or sets the method for presenting the access token to the resource server.
            /// The default value is <see cref="BearerToken.AuthorizationHeaderAccessMethod"/>.
            /// </summary>
            public IAccessMethod AccessMethod { get; set; }

            /// <summary>
            /// Gets or sets the factory for creating a <see cref="System.Net.Http.HttpClient"/> instance.
            /// </summary>
            public IHttpClientFactory HttpClientFactory { get; set; }

            /// <summary>
            /// Indicates which of exceptions and / or HTTP status codes are automatically retried using exponential backoff.
            /// The default value is <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> which means retries will be
            /// executed as recommended by each service. For services that have no specific recommendations
            /// <see cref="ExponentialBackOffPolicy.UnsuccessfulResponse503"/> will be used, which means HTTP Status code 503
            /// will be retried with exponential backoff.
            /// If set to <see cref="ExponentialBackOffPolicy.None" /> no automatic retries will happen.
            /// Calling code may still specify custom retries by configuring <see cref="HttpClient"/>.
            /// </summary>
            public ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; set; }

            /// <summary>
            /// The ID of the project associated to this credential for the purposes of
            /// quota calculation and billing. May be null.
            /// </summary>
            public string QuotaProject { get; set; }

            /// <summary>
            /// Scopes to request during the authorization grant. May be null or empty.
            /// </summary>
            /// <remarks>
            /// If the scopes are pre-granted through the environement, like in GCE where scopes are granted to the VM,
            /// scopes set here will be ignored.
            /// </remarks>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Initializers to be sent to the <see cref="HttpClientFactory"/> to be set
            /// on the <see cref="HttpClient"/> that will be used by the credential to perform
            /// token operations.
            /// </summary>
            internal IList<IConfigurableHttpClientInitializer> HttpClientInitializers { get; }

            /// <summary>Constructs a new initializer using the given token server URL.</summary>
            public Initializer(string tokenServerUrl)
            {
                TokenServerUrl = tokenServerUrl;

                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                Clock = SystemClock.Default;
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.RecommendedOrDefault;

                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>();
            }

            internal Initializer(ServiceCredential other)
            {
                TokenServerUrl = other.TokenServerUrl;
                Clock = other.Clock;
                AccessMethod = other.AccessMethod;
                HttpClientFactory = other.HttpClientFactory;
                DefaultExponentialBackOffPolicy = other.DefaultExponentialBackOffPolicy;
                QuotaProject = other.QuotaProject;
                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(other.HttpClientInitializers);
                Scopes = other.Scopes;
            }

            internal Initializer(Initializer other)
            {
                TokenServerUrl = other.TokenServerUrl;
                Clock = other.Clock;
                AccessMethod = other.AccessMethod;
                HttpClientFactory = other.HttpClientFactory;
                DefaultExponentialBackOffPolicy = other.DefaultExponentialBackOffPolicy;
                QuotaProject = other.QuotaProject;
                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(other.HttpClientInitializers);
                Scopes = other.Scopes;
            }
        }

        /// <summary>
        /// Gets the token server URL.
        /// </summary>
        /// <remarks>
        /// May be null for credential types that resolve token endpoints just before obtaining an access token.
        /// This is the case for <see cref="ImpersonatedCredential"/> where the <see cref="ImpersonatedCredential.SourceCredential"/>
        /// is a <see cref="ComputeCredential"/>.
        /// </remarks>
        public string TokenServerUrl { get; }

        /// <summary>Gets the clock used to refresh the token if it expires.</summary>
        public IClock Clock { get; }

        /// <summary>Gets the method for presenting the access token to the resource server.</summary>
        public IAccessMethod AccessMethod { get; }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get; }

        /// <summary>
        /// Scopes to request during the authorization grant. May be null or empty.
        /// </summary>
        /// <remarks>
        /// If the scopes are pre-granted through the environment, like in GCE where scopes are granted to the VM,
        /// scopes set here will be ignored.
        /// </remarks>
        public IEnumerable<string> Scopes { get; set; }

        /// <summary>
        /// Returns true if this credential scopes have been explicitly set via this library.
        /// Returns false otherwise.
        /// </summary>
        internal bool HasExplicitScopes => Scopes?.Any() == true;

        internal IHttpClientFactory HttpClientFactory { get; }

        /// <summary>
        /// Initializers to be sent to the <see cref="HttpClientFactory"/> to be set
        /// on the <see cref="HttpClient"/> that will be used by the credential to perform
        /// token operations.
        /// </summary>
        internal IEnumerable<IConfigurableHttpClientInitializer> HttpClientInitializers { get; }

        internal ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; }

        private readonly TokenRefreshManager _refreshManager;

        /// <summary>Gets the token response which contains the access token.</summary>
        public TokenResponse Token
        {
            get => _refreshManager.Token;
            set => _refreshManager.Token = value;
        }

        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        public string QuotaProject { get; }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        public ServiceCredential(Initializer initializer)
        {
            TokenServerUrl = initializer.TokenServerUrl;
            AccessMethod = initializer.AccessMethod.ThrowIfNull("initializer.AccessMethod");
            Clock = initializer.Clock.ThrowIfNull("initializer.Clock");
            Scopes = initializer.Scopes?.Where(scope => !string.IsNullOrWhiteSpace(scope)).ToList().AsReadOnly()
                ?? Enumerable.Empty<string>();

            DefaultExponentialBackOffPolicy = initializer.DefaultExponentialBackOffPolicy;
            HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(initializer.HttpClientInitializers).AsReadOnly();

            HttpClientFactory = initializer.HttpClientFactory ?? new HttpClientFactory();
            HttpClient = HttpClientFactory.CreateHttpClient(BuildCreateHttpClientArgs());
            _refreshManager = new TokenRefreshManager(RequestAccessTokenAsync, Clock, Logger);

            QuotaProject = initializer.QuotaProject;
        }

        /// <summary>
        /// Builds HTTP client creation args from all this credential settings.
        /// These are used for initializing <see cref="HttpClient"/>.
        /// </summary>
        protected internal CreateHttpClientArgs BuildCreateHttpClientArgs()
        {
            var args = BuildCreateHttpClientArgsWithNoRetries();
            AddHttpClientRetryConfiguration(args);
            return args;
        }

        /// <summary>
        /// Builds HTTP client creation args from this credential settings except for <see cref="DefaultExponentialBackOffPolicy"/>.
        /// </summary>
        private protected CreateHttpClientArgs BuildCreateHttpClientArgsWithNoRetries()
        {
            var httpArgs = new CreateHttpClientArgs();

            // Add initializers
            foreach (var httpClientInitializer in HttpClientInitializers)
            {
                httpArgs.Initializers.Add(httpClientInitializer);
            }

            return httpArgs;
        }

        /// <summary>
        /// Configures <paramref name="args"/> with the expected retry policy for <see cref="HttpClient"/> based on
        /// <see cref="DefaultExponentialBackOffPolicy"/>. Can be extended as different credentials use different token
        /// endpoints that may recommende different retry strategies.
        /// </summary>
        private protected virtual void AddHttpClientRetryConfiguration(CreateHttpClientArgs args)
        {
            // Add exponential back-off initializer if necessary.
            if (DefaultExponentialBackOffPolicy != ExponentialBackOffPolicy.None)
            {
                var effectiveRetryPolicy = DefaultExponentialBackOffPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault) ?
                    // At this level there's no recommendation, but we know default is retry 503.
                    // Remove RecommendedOrDefault and add UnsuccessfulResponse503.
                    (DefaultExponentialBackOffPolicy & ~ExponentialBackOffPolicy.RecommendedOrDefault) | ExponentialBackOffPolicy.UnsuccessfulResponse503 :
                    DefaultExponentialBackOffPolicy;

                args.Initializers.Add(new ExponentialBackOffInitializer(effectiveRetryPolicy, () => new BackOffHandler(new ExponentialBackOff())));
            }
        }

        /// <summary>
        /// Configures <paramref name="args"/> with the expected retry policy for an HttpClient that's used only with the IAM SignBlob endpoint, based on
        /// <see cref="DefaultExponentialBackOffPolicy"/>.
        /// </summary>
        private protected void AddIamSignBlobRetryConfiguration(CreateHttpClientArgs args)
        {
            // In case the user explicitly configured retry policy.
            var customRetryPolicy = GoogleAuthConsts.StripIamSignBlobEndpointRecommendedPolicy(DefaultExponentialBackOffPolicy);
            if (customRetryPolicy != ExponentialBackOffPolicy.None)
            {
                args.Initializers.Add(new ExponentialBackOffInitializer(customRetryPolicy, () => new BackOffHandler(new ExponentialBackOff())));
            }
            // In case recommended is also configured.
            if (DefaultExponentialBackOffPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault))
            {
                args.Initializers.Add(GoogleAuthConsts.IamSignBlobEndpointRecommendedRetry);
            }
        }

        #region IConfigurableHttpClientInitializer

        /// <inheritdoc/>
        public void Initialize(ConfigurableHttpClient httpClient) =>
            httpClient.MessageHandler.Credential = this;

        #endregion

        #region IHttpExecuteInterceptor implementation

        /// <inheritdoc/>
        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var audience = new UriBuilder(request.RequestUri) { Query = string.Empty, Path = string.Empty }.Uri.ToString();
            var accessToken = await GetAccessTokenWithHeadersForRequestAsync(audience, cancellationToken).ConfigureAwait(false);
            AccessMethod.Intercept(request, accessToken.AccessToken);
            accessToken.AddHeaders(request);
        }

        #endregion

        #region IHttpUnsuccessfulResponseHandler

        /// <summary>
        /// Decorates unsuccessful responses, returns true if the response gets modified.
        /// See IHttpUnsuccessfulResponseHandler for more information. 
        /// </summary>
        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // If the response was unauthorized, request a new access token so that the original
            // request can be retried.
            // TODO(peleyal): check WWW-Authenticate header.
            if (args.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                bool tokensEqual = false;
                if (Token != null)
                {
                    tokensEqual = Object.Equals(
                        Token.AccessToken, AccessMethod.GetAccessToken(args.Request));
                }
                return !tokensEqual
                    || await RequestAccessTokenAsync(args.CancellationToken).ConfigureAwait(false);
            }

            return false;
        }

        #endregion

        #region ITokenAccess implementation

        /// <summary>
        /// Gets an access token to authorize a request. If the existing token expires soon, try to refresh it first.
        /// <seealso cref="ITokenAccess.GetAccessTokenForRequestAsync"/>
        /// </summary>
        public virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null,
            CancellationToken cancellationToken = default(CancellationToken)) =>
            _refreshManager.GetAccessTokenForRequestAsync(cancellationToken);

        #endregion

        #region ITokenAccessWithHeaders implementation
        /// <inheritdoc />
        public async Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = default)
        {
            string token = await GetAccessTokenForRequestAsync(authUri, cancellationToken).ConfigureAwait(false);
            return new AccessTokenWithHeaders.Builder { QuotaProject = QuotaProject }.Build(token);
        }
        #endregion

        /// <summary>Requests a new token.</summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public abstract Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken);
    }
}
