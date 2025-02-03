// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Playcustomapp.v1
{
    /// <summary>The Playcustomapp Service.</summary>
    public class PlaycustomappService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlaycustomappService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlaycustomappService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://playcustomapp.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://playcustomapp.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playcustomapp";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Custom App Publishing API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Google Play Custom App Publishing API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public const string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Playcustomapp requests.</summary>
    public abstract class PlaycustomappBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlaycustomappBaseServiceRequest instance.</summary>
        protected PlaycustomappBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Playcustomapp parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            CustomApps = new CustomAppsResource(service);
        }

        /// <summary>Gets the CustomApps resource.</summary>
        public virtual CustomAppsResource CustomApps { get; }

        /// <summary>The "customApps" collection of methods.</summary>
        public class CustomAppsResource
        {
            private const string Resource = "customApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new custom app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="account">Developer account ID.</param>
            public virtual CreateRequest Create(Google.Apis.Playcustomapp.v1.Data.CustomApp body, long account)
            {
                return new CreateRequest(this.service, body, account);
            }

            /// <summary>Creates a new custom app.</summary>
            public class CreateRequest : PlaycustomappBaseServiceRequest<Google.Apis.Playcustomapp.v1.Data.CustomApp>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Playcustomapp.v1.Data.CustomApp body, long account) : base(service)
                {
                    Account = account;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Developer account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long Account { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playcustomapp.v1.Data.CustomApp Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "playcustomapp/v1/accounts/{account}/customApps";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                    {
                        Name = "account",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates a new custom app.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="account">Developer account ID.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual CreateMediaUpload Create(Google.Apis.Playcustomapp.v1.Data.CustomApp body, long account, System.IO.Stream stream, string contentType)
            {
                return new CreateMediaUpload(service, body, account, stream, contentType);
            }

            /// <summary>Create media upload which supports resumable upload.</summary>
            public class CreateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Playcustomapp.v1.Data.CustomApp, Google.Apis.Playcustomapp.v1.Data.CustomApp>
            {
                /// <summary>V1 error format.</summary>
                [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

                /// <summary>V1 error format.</summary>
                public enum XgafvEnum
                {
                    /// <summary>v1 error format</summary>
                    [Google.Apis.Util.StringValueAttribute("1")]
                    Value1 = 0,

                    /// <summary>v2 error format</summary>
                    [Google.Apis.Util.StringValueAttribute("2")]
                    Value2 = 1,
                }

                /// <summary>OAuth access token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AccessToken { get; set; }

                /// <summary>Data format for response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AltEnum> Alt { get; set; }

                /// <summary>Data format for response.</summary>
                public enum AltEnum
                {
                    /// <summary>Responses with Content-Type of application/json</summary>
                    [Google.Apis.Util.StringValueAttribute("json")]
                    Json = 0,

                    /// <summary>Media download with context-dependent Content-Type</summary>
                    [Google.Apis.Util.StringValueAttribute("media")]
                    Media = 1,

                    /// <summary>Responses with Content-Type of application/x-protobuf</summary>
                    [Google.Apis.Util.StringValueAttribute("proto")]
                    Proto = 2,
                }

                /// <summary>JSONP</summary>
                [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Callback { get; set; }

                /// <summary>Selector specifying which fields to include in a partial response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fields { get; set; }

                /// <summary>
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Key { get; set; }

                /// <summary>OAuth 2.0 token for the current user.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OauthToken { get; set; }

                /// <summary>Returns response with indentations and line breaks.</summary>
                [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> PrettyPrint { get; set; }

                /// <summary>
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Developer account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long Account { get; private set; }

                /// <summary>Constructs a new Create media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public CreateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Playcustomapp.v1.Data.CustomApp body, long account, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "playcustomapp/v1/accounts/{account}/customApps"), "POST", stream, contentType)
                {
                    Account = account;
                    Body = body;
                }
            }
        }
    }
}
namespace Google.Apis.Playcustomapp.v1.Data
{
    /// <summary>This resource represents a custom app.</summary>
    public class CustomApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default listing language in BCP 47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Organizations to which the custom app should be made available. If the request contains any organizations,
        /// then the app will be restricted to only these organizations. To support the organization linked to the
        /// developer account, the organization ID should be provided explicitly together with other organizations. If
        /// no organizations are provided, then the app is only available to the organization linked to the developer
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Organization> Organizations { get; set; }

        /// <summary>Output only. Package name of the created Android app. Only present in the API response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Title for the Android app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an organization that can access a custom app.</summary>
    public class Organization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationId")]
        public virtual string OrganizationId { get; set; }

        /// <summary>Optional. A human-readable name of the organization, to help recognize the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationName")]
        public virtual string OrganizationName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
