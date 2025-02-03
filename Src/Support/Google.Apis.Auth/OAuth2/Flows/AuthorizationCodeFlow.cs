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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Thread-safe OAuth 2.0 authorization code flow that manages and persists end-user credentials.
    /// <para>
    /// This is designed to simplify the flow in which an end-user authorizes the application to access their protected
    /// data, and then the application has access to their data based on an access token and a refresh token to refresh 
    /// that access token when it expires.
    /// </para>
    /// </summary>
    public class AuthorizationCodeFlow : IHttpAuthorizationFlow
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<AuthorizationCodeFlow>();

        #region Initializer

        /// <summary>An initializer class for the authorization code flow. </summary>
        public class Initializer
        {
            /// <summary>
            /// Gets or sets the method for presenting the access token to the resource server.
            /// The default value is
            /// <see cref="Google.Apis.Auth.OAuth2.BearerToken.AuthorizationHeaderAccessMethod"/>.
            /// </summary>
            public IAccessMethod AccessMethod { get; set; }

            /// <summary>Gets the token server URL.</summary>
            public string TokenServerUrl { get; private set; }

            /// <summary>Gets or sets the authorization server URL.</summary>
            public string AuthorizationServerUrl { get; private set; }

            /// <summary>Gets or sets the client secrets which includes the client identifier and its secret.</summary>
            public ClientSecrets ClientSecrets { get; set; }

            /// <summary>
            /// Gets or sets the client secrets stream which contains the client identifier and its secret.
            /// </summary>
            /// <remarks>The AuthorizationCodeFlow constructor is responsible for disposing the stream.</remarks>
            public Stream ClientSecretsStream { get; set; }

            /// <summary>Gets or sets the data store used to store the token response.</summary>
            public IDataStore DataStore { get; set; }

            /// <summary>
            /// Gets or sets the scopes which indicate the API access your application is requesting.
            /// </summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets the factory for creating <see cref="System.Net.Http.HttpClient"/> instance.
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
            /// Gets or sets the clock. The clock is used to determine if the token has expired, if so we will try to
            /// refresh it. The default value is <see cref="Google.Apis.Util.SystemClock.Default"/>.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="authorizationServerUrl">Authorization server URL</param>
            /// <param name="tokenServerUrl">Token server URL</param>
            public Initializer(string authorizationServerUrl, string tokenServerUrl)
            {
                AuthorizationServerUrl = authorizationServerUrl;
                TokenServerUrl = tokenServerUrl;

                Scopes = new List<string>();
                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.RecommendedOrDefault;
                Clock = SystemClock.Default;
            }

            /// <summary>
            /// Constructs a new initializer from the given <see cref="AuthorizationCodeFlow"/>
            /// </summary>
            internal Initializer(AuthorizationCodeFlow flow)
            {
                AccessMethod = flow.AccessMethod;
                TokenServerUrl = flow.TokenServerUrl;
                AuthorizationServerUrl = flow.AuthorizationServerUrl;
                ClientSecrets = flow.ClientSecrets;
                DataStore = flow.DataStore;
                Scopes = flow.Scopes;
                HttpClientFactory = flow.HttpClientFactory;
                DefaultExponentialBackOffPolicy = flow.DefaultExponentialBackOffPolicy;
                Clock = flow.Clock;
            }
        }

        #endregion

        /// <summary>Gets the token server URL.</summary>
        public string TokenServerUrl { get; }

        /// <summary>Gets the authorization code server URL.</summary>
        public string AuthorizationServerUrl { get; }

        /// <summary>Gets the client secrets which includes the client identifier and its secret.</summary>
        public ClientSecrets ClientSecrets { get; }

        /// <summary>Gets the data store used to store the credentials.</summary>
        public IDataStore DataStore { get; }

        /// <summary>Gets the scopes which indicate the API access your application is requesting.</summary>
        public IEnumerable<string> Scopes { get; }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get; }

        internal IHttpClientFactory HttpClientFactory { get; }

        private ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; }

        /// <summary>Constructs a new flow using the initializer's properties.</summary>
        public AuthorizationCodeFlow(Initializer initializer)
        {
            ClientSecrets = initializer.ClientSecrets;
            if (ClientSecrets == null)
            {
                if (initializer.ClientSecretsStream == null)
                {
                    throw new ArgumentException("You MUST set ClientSecret or ClientSecretStream on the initializer");
                }

                using (initializer.ClientSecretsStream)
                {
                    ClientSecrets = GoogleClientSecrets.FromStream(initializer.ClientSecretsStream).Secrets;
                }
            }
            else if (initializer.ClientSecretsStream != null)
            {
                throw new ArgumentException(
                    "You CAN'T set both ClientSecrets AND ClientSecretStream on the initializer");
            }

            AccessMethod = initializer.AccessMethod.ThrowIfNull("Initializer.AccessMethod");
            Clock = initializer.Clock.ThrowIfNull("Initializer.Clock");
            TokenServerUrl = initializer.TokenServerUrl.ThrowIfNullOrEmpty("Initializer.TokenServerUrl");
            AuthorizationServerUrl = initializer.AuthorizationServerUrl.ThrowIfNullOrEmpty
                ("Initializer.AuthorizationServerUrl");

            DataStore = initializer.DataStore;
            if (DataStore == null)
            {
                Logger.Warning("Datastore is null, as a result the user's credential will not be stored");
            }
            Scopes = initializer.Scopes;

            // Set the HTTP client.
            DefaultExponentialBackOffPolicy = initializer.DefaultExponentialBackOffPolicy;
            HttpClientFactory = initializer.HttpClientFactory ?? new HttpClientFactory();

            var httpArgs = new CreateHttpClientArgs();

            // In case the user explicitly configured retry policy.
            var customRetryPolicy = GoogleAuthConsts.StripOAuth2TokenEndpointRecommendedPolicy(DefaultExponentialBackOffPolicy);
            if (customRetryPolicy != ExponentialBackOffPolicy.None)
            {
                httpArgs.Initializers.Add(new ExponentialBackOffInitializer(customRetryPolicy, () => new BackOffHandler(new ExponentialBackOff())));
            }
            // In case recommended is also configured.
            if (DefaultExponentialBackOffPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault))
            {
                httpArgs.Initializers.Add(GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry);
            }
            HttpClient = HttpClientFactory.CreateHttpClient(httpArgs);
        }

        /// <inheritdoc/>
        IHttpAuthorizationFlow IHttpAuthorizationFlow.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new AuthorizationCodeFlow(new Initializer(this) { HttpClientFactory = httpClientFactory });

        #region IAuthorizationCodeFlow overrides

        /// <inheritdoc/>
        public IAccessMethod AccessMethod { get; }

        /// <inheritdoc/>
        public IClock Clock { get; }

        /// <inheritdoc/>
        public async Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore == null)
            {
                return null;
            }
            return await DataStore.GetAsync<TokenResponse>(userId).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore != null)
            {
                await DataStore.DeleteAsync<TokenResponse>(userId).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public virtual AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
        {
            return new AuthorizationCodeRequestUrl(new Uri(AuthorizationServerUrl))
            {
                ClientId = ClientSecrets.ClientId,
                Scope = Scopes == null ? null : string.Join(" ", Scopes),
                RedirectUri = redirectUri
            };
        }

        /// <inheritdoc/>
        public async Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri,
            CancellationToken taskCancellationToken)
        {
            var authorizationCodeTokenReq = CreateAuthorizationCodeTokenRequest(userId, code, redirectUri);

            return await ExchangeCodeForTokenAsync(userId, authorizationCodeTokenReq, taskCancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a <see cref="AuthorizationCodeTokenRequest"/> for the given parameters.
        /// </summary>
        protected internal AuthorizationCodeTokenRequest CreateAuthorizationCodeTokenRequest(string userId, string code, string redirectUri) =>
            new AuthorizationCodeTokenRequest
            {
                Scope = Scopes == null ? null : string.Join(" ", Scopes),
                RedirectUri = redirectUri,
                Code = code,
            };

        /// <summary>
        /// Executes <paramref name="authorizationCodeTokenReq"/> and stores and returns the received token.
        /// </summary>
        protected internal async Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, AuthorizationCodeTokenRequest authorizationCodeTokenReq,
            CancellationToken taskCancellationToken)
        {
            var token = await FetchTokenAsync(userId, authorizationCodeTokenReq, taskCancellationToken)
                .ConfigureAwait(false);
            await StoreTokenAsync(userId, token, taskCancellationToken).ConfigureAwait(false);
            return token;
        }

        /// <inheritdoc/>
        public async Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken,
            CancellationToken taskCancellationToken)
        {
            var refreshTokenReq = new RefreshTokenRequest
            {
                RefreshToken = refreshToken,
            };
            var token = await FetchTokenAsync(userId, refreshTokenReq, taskCancellationToken).ConfigureAwait(false);

            // The new token may not contain a refresh token, so set it with the given refresh token.
            if (token.RefreshToken == null)
            {
                token.RefreshToken = refreshToken;
            }

            await StoreTokenAsync(userId, token, taskCancellationToken).ConfigureAwait(false);
            return token;
        }

        /// <inheritdoc/>
        public virtual Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken)
        {
            throw new NotImplementedException("The OAuth 2.0 protocol does not support token revocation.");
        }

        /// <inheritdoc/>
        public virtual bool ShouldForceTokenRetrieval() { return false; }

        #endregion

        /// <summary>Stores the token in the <see cref="DataStore"/>.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">Token to store.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        private async Task StoreTokenAsync(string userId, TokenResponse token, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore != null)
            {
                await DataStore.StoreAsync<TokenResponse>(userId, token).ConfigureAwait(false);
            }
        }

        /// <summary>Retrieve a new token from the server using the specified request.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="request">Token request.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>Token response with the new access token.</returns>
        [VisibleForTestOnly]
        public async Task<TokenResponse> FetchTokenAsync(string userId, TokenRequest request,
            CancellationToken taskCancellationToken)
        {
            // Add client id and client secret to requests.
            request.ClientId = ClientSecrets.ClientId;
            request.ClientSecret = ClientSecrets.ClientSecret;

            try
            {
                var tokenResponse = await request.PostFormAsync
                    (HttpClient, TokenServerUrl, null, Clock, Logger, taskCancellationToken).ConfigureAwait(false);
                return tokenResponse;
            }
            catch (TokenResponseException ex)
            {
                // In case there is an exception during getting the token, we delete any user's token information from 
                // the data store if it's not a server-side error.
                int statusCode = (int)(ex.StatusCode ?? (HttpStatusCode)0);
                bool serverError = statusCode >= 500 && statusCode < 600;
                if (!serverError)
                {
                    // If not a server error, then delete the user token information.
                    // This is to guard against suspicious client-side behaviour.
                    await DeleteTokenAsync(userId, taskCancellationToken).ConfigureAwait(false);
                }
                throw;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (HttpClient != null)
            {
                HttpClient.Dispose();
            }
        }
    }
}
