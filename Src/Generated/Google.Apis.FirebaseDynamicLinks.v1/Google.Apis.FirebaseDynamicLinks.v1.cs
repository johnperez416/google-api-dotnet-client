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

namespace Google.Apis.FirebaseDynamicLinks.v1
{
    /// <summary>The FirebaseDynamicLinks Service.</summary>
    public class FirebaseDynamicLinksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseDynamicLinksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseDynamicLinksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            ManagedShortLinks = new ManagedShortLinksResource(this);
            ShortLinks = new ShortLinksResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebasedynamiclinks.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebasedynamiclinks.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebasedynamiclinks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Dynamic Links API.</summary>
        public class Scope
        {
            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Dynamic Links API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Gets the ManagedShortLinks resource.</summary>
        public virtual ManagedShortLinksResource ManagedShortLinks { get; }

        /// <summary>Gets the ShortLinks resource.</summary>
        public virtual ShortLinksResource ShortLinks { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for FirebaseDynamicLinks requests.</summary>
    public abstract class FirebaseDynamicLinksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseDynamicLinksBaseServiceRequest instance.</summary>
        protected FirebaseDynamicLinksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseDynamicLinks parameter list.</summary>
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

    /// <summary>The "managedShortLinks" collection of methods.</summary>
    public class ManagedShortLinksResource
    {
        private const string Resource = "managedShortLinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedShortLinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a managed short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link
        /// domain, Android and iOS app information. The created short Dynamic Link will not expire. This differs from
        /// CreateShortDynamicLink in the following ways: - The request will also contain a name for the link (non
        /// unique name for the front end). - The response must be authenticated with an auth token (generated with the
        /// admin service account). - The link will appear in the FDL list of links in the console front end. The
        /// Dynamic Link domain in the request must be owned by requester's Firebase project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.FirebaseDynamicLinks.v1.Data.CreateManagedShortLinkRequest body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a managed short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link
        /// domain, Android and iOS app information. The created short Dynamic Link will not expire. This differs from
        /// CreateShortDynamicLink in the following ways: - The request will also contain a name for the link (non
        /// unique name for the front end). - The response must be authenticated with an auth token (generated with the
        /// admin service account). - The link will appear in the FDL list of links in the console front end. The
        /// Dynamic Link domain in the request must be owned by requester's Firebase project.
        /// </summary>
        public class CreateRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.CreateManagedShortLinkResponse>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseDynamicLinks.v1.Data.CreateManagedShortLinkRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseDynamicLinks.v1.Data.CreateManagedShortLinkRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/managedShortLinks:create";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "shortLinks" collection of methods.</summary>
    public class ShortLinksResource
    {
        private const string Resource = "shortLinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ShortLinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link domain,
        /// Android and iOS app information. The created short Dynamic Link will not expire. Repeated calls with the
        /// same long Dynamic Link or Dynamic Link information will produce the same short Dynamic Link. The Dynamic
        /// Link domain in the request must be owned by requester's Firebase project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link domain,
        /// Android and iOS app information. The created short Dynamic Link will not expire. Repeated calls with the
        /// same long Dynamic Link or Dynamic Link information will produce the same short Dynamic Link. The Dynamic
        /// Link domain in the request must be owned by requester's Firebase project.
        /// </summary>
        public class CreateRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkResponse>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/shortLinks";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Fetches analytics stats of a short Dynamic Link for a given duration. Metrics include number of clicks,
        /// redirects, installs, app first opens, and app reopens.
        /// </summary>
        /// <param name="dynamicLink">Dynamic Link URL. e.g. https://abcd.app.goo.gl/wxyz</param>
        public virtual GetLinkStatsRequest GetLinkStats(string dynamicLink)
        {
            return new GetLinkStatsRequest(this.service, dynamicLink);
        }

        /// <summary>
        /// Fetches analytics stats of a short Dynamic Link for a given duration. Metrics include number of clicks,
        /// redirects, installs, app first opens, and app reopens.
        /// </summary>
        public class GetLinkStatsRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.DynamicLinkStats>
        {
            /// <summary>Constructs a new GetLinkStats request.</summary>
            public GetLinkStatsRequest(Google.Apis.Services.IClientService service, string dynamicLink) : base(service)
            {
                DynamicLink = dynamicLink;
                InitParameters();
            }

            /// <summary>Dynamic Link URL. e.g. https://abcd.app.goo.gl/wxyz</summary>
            [Google.Apis.Util.RequestParameterAttribute("dynamicLink", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DynamicLink { get; private set; }

            /// <summary>The span of time requested in days.</summary>
            [Google.Apis.Util.RequestParameterAttribute("durationDays", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> DurationDays { get; set; }

            /// <summary>Google SDK version. Version takes the form "$major.$minor.$patch"</summary>
            [Google.Apis.Util.RequestParameterAttribute("sdkVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SdkVersion { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getLinkStats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{dynamicLink}/linkStats";

            /// <summary>Initializes GetLinkStats parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("dynamicLink", new Google.Apis.Discovery.Parameter
                {
                    Name = "dynamicLink",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("durationDays", new Google.Apis.Discovery.Parameter
                {
                    Name = "durationDays",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sdkVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "sdkVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get iOS strong/weak-match info for post-install attribution.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InstallAttributionRequest InstallAttribution(Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosPostInstallAttributionRequest body)
        {
            return new InstallAttributionRequest(this.service, body);
        }

        /// <summary>Get iOS strong/weak-match info for post-install attribution.</summary>
        public class InstallAttributionRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosPostInstallAttributionResponse>
        {
            /// <summary>Constructs a new InstallAttribution request.</summary>
            public InstallAttributionRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosPostInstallAttributionRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosPostInstallAttributionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "installAttribution";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/installAttribution";

            /// <summary>Initializes InstallAttribution parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Get iOS reopen attribution for app universal link open deeplinking.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ReopenAttributionRequest ReopenAttribution(Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosReopenAttributionRequest body)
        {
            return new ReopenAttributionRequest(this.service, body);
        }

        /// <summary>Get iOS reopen attribution for app universal link open deeplinking.</summary>
        public class ReopenAttributionRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosReopenAttributionResponse>
        {
            /// <summary>Constructs a new ReopenAttribution request.</summary>
            public ReopenAttributionRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosReopenAttributionRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseDynamicLinks.v1.Data.GetIosReopenAttributionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reopenAttribution";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/reopenAttribution";

            /// <summary>Initializes ReopenAttribution parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.FirebaseDynamicLinks.v1.Data
{
    /// <summary>Tracking parameters supported by Dynamic Link.</summary>
    public class AnalyticsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Play Campaign Measurements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePlayAnalytics")]
        public virtual GooglePlayAnalytics GooglePlayAnalytics { get; set; }

        /// <summary>iTunes Connect App Analytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itunesConnectAnalytics")]
        public virtual ITunesConnectAnalytics ItunesConnectAnalytics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android related attributes to the Dynamic Link.</summary>
    public class AndroidInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to open on Android if the app is not installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidFallbackLink")]
        public virtual string AndroidFallbackLink { get; set; }

        /// <summary>If specified, this overrides the ‘link’ parameter on Android.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidLink")]
        public virtual string AndroidLink { get; set; }

        /// <summary>
        /// Minimum version code for the Android app. If the installed app’s version code is lower, then the user is
        /// taken to the Play Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidMinPackageVersionCode")]
        public virtual string AndroidMinPackageVersionCode { get; set; }

        /// <summary>Android package name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPackageName")]
        public virtual string AndroidPackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a managed Short Dynamic Link.</summary>
    public class CreateManagedShortLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the Dynamic Link to be shortened. [Learn
        /// more](https://firebase.google.com/docs/reference/dynamic-links/link-shortener).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinkInfo")]
        public virtual DynamicLinkInfo DynamicLinkInfo { get; set; }

        /// <summary>
        /// Full long Dynamic Link URL with desired query parameters specified. For example,
        /// "https://sample.app.goo.gl/?link=http://www.google.com&amp;amp;apn=com.sample", [Learn
        /// more](https://firebase.google.com/docs/reference/dynamic-links/link-shortener).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDynamicLink")]
        public virtual string LongDynamicLink { get; set; }

        /// <summary>
        /// Link name to associate with the link. It's used for marketer to identify manually-created links in the
        /// Firebase console (https://console.firebase.google.com/). Links must be named to be tracked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Google SDK version. Version takes the form "$major.$minor.$patch"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual string SdkVersion { get; set; }

        /// <summary>Short Dynamic Link suffix. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual Suffix Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to create a short Dynamic Link.</summary>
    public class CreateManagedShortLinkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Short Dynamic Link value. e.g. https://abcd.app.goo.gl/wxyz</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedShortLink")]
        public virtual ManagedShortLink ManagedShortLink { get; set; }

        /// <summary>Preview link to show the link flow chart. (debug info.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewLink")]
        public virtual string PreviewLink { get; set; }

        /// <summary>Information about potential warnings on link creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<DynamicLinkWarning> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a short Dynamic Link.</summary>
    public class CreateShortDynamicLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the Dynamic Link to be shortened. [Learn
        /// more](https://firebase.google.com/docs/reference/dynamic-links/link-shortener).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinkInfo")]
        public virtual DynamicLinkInfo DynamicLinkInfo { get; set; }

        /// <summary>
        /// Full long Dynamic Link URL with desired query parameters specified. For example,
        /// "https://sample.app.goo.gl/?link=http://www.google.com&amp;amp;apn=com.sample", [Learn
        /// more](https://firebase.google.com/docs/reference/dynamic-links/link-shortener).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDynamicLink")]
        public virtual string LongDynamicLink { get; set; }

        /// <summary>Google SDK version. Version takes the form "$major.$minor.$patch"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual string SdkVersion { get; set; }

        /// <summary>Short Dynamic Link suffix. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual Suffix Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to create a short Dynamic Link.</summary>
    public class CreateShortDynamicLinkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Preview link to show the link flow chart. (debug info.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewLink")]
        public virtual string PreviewLink { get; set; }

        /// <summary>Short Dynamic Link value. e.g. https://abcd.app.goo.gl/wxyz</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortLink")]
        public virtual string ShortLink { get; set; }

        /// <summary>Information about potential warnings on link creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<DynamicLinkWarning> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Desktop related attributes to the Dynamic Link.</summary>
    public class DesktopInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to open on desktop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desktopFallbackLink")]
        public virtual string DesktopFallbackLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Signals associated with the device making the request.</summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device model name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModelName")]
        public virtual string DeviceModelName { get; set; }

        /// <summary>Device language code setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Device language code setting obtained by executing JavaScript code in WebView.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodeFromWebview")]
        public virtual string LanguageCodeFromWebview { get; set; }

        /// <summary>
        /// Device language code raw setting. iOS does returns language code in different format than iOS WebView. For
        /// example WebView returns en_US, but iOS returns en-US. Field below will return raw value returned by iOS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodeRaw")]
        public virtual string LanguageCodeRaw { get; set; }

        /// <summary>Device display resolution height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenResolutionHeight")]
        public virtual System.Nullable<long> ScreenResolutionHeight { get; set; }

        /// <summary>Device display resolution width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenResolutionWidth")]
        public virtual System.Nullable<long> ScreenResolutionWidth { get; set; }

        /// <summary>Device timezone setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dynamic Link event stat.</summary>
    public class DynamicLinkEventStat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of times this event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Link event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual string Event__ { get; set; }

        /// <summary>Requested platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a Dynamic Link.</summary>
    public class DynamicLinkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parameters used for tracking. See all tracking parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsInfo")]
        public virtual AnalyticsInfo AnalyticsInfo { get; set; }

        /// <summary>
        /// Android related information. See Android related parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInfo")]
        public virtual AndroidInfo AndroidInfo { get; set; }

        /// <summary>
        /// Desktop related information. See desktop related parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desktopInfo")]
        public virtual DesktopInfo DesktopInfo { get; set; }

        /// <summary>
        /// E.g. https://maps.app.goo.gl, https://maps.page.link, https://g.co/maps More examples can be found in
        /// description of getNormalizedUriPrefix in j/c/g/firebase/dynamiclinks/uri/DdlDomain.java Will fallback to
        /// dynamic_link_domain is this field is missing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainUriPrefix")]
        public virtual string DomainUriPrefix { get; set; }

        /// <summary>
        /// Dynamic Links domain that the project owns, e.g. abcd.app.goo.gl [Learn
        /// more](https://firebase.google.com/docs/dynamic-links/android/receive) on how to set up Dynamic Link domain
        /// associated with your Firebase project. Required if missing domain_uri_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinkDomain")]
        public virtual string DynamicLinkDomain { get; set; }

        /// <summary>
        /// iOS related information. See iOS related parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosInfo")]
        public virtual IosInfo IosInfo { get; set; }

        /// <summary>
        /// The link your app will open, You can specify any URL your app can handle. This link must be a well-formatted
        /// URL, be properly URL-encoded, and use the HTTP or HTTPS scheme. See 'link' parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually). Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>Information of navigation behavior of a Firebase Dynamic Links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("navigationInfo")]
        public virtual NavigationInfo NavigationInfo { get; set; }

        /// <summary>
        /// Parameters for social meta tag params. Used to set meta tag data for link previews on social sites.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialMetaTagInfo")]
        public virtual SocialMetaTagInfo SocialMetaTagInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Analytics stats of a Dynamic Link for a given timeframe.</summary>
    public class DynamicLinkStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dynamic Link event stats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkEventStats")]
        public virtual System.Collections.Generic.IList<DynamicLinkEventStat> LinkEventStats { get; set; }

        /// <summary>Optional warnings associated this API request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<DynamicLinkWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dynamic Links warning messages.</summary>
    public class DynamicLinkWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The warning code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningCode")]
        public virtual string WarningCode { get; set; }

        /// <summary>The document describing the warning, and helps resolve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningDocumentLink")]
        public virtual string WarningDocumentLink { get; set; }

        /// <summary>The warning message to help developers improve their requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningMessage")]
        public virtual string WarningMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request for iSDK to execute strong match flow for post-install attribution. This is meant for iOS requests only.
    /// Requests from other platforms will not be honored.
    /// </summary>
    public class GetIosPostInstallAttributionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// App installation epoch time (https://en.wikipedia.org/wiki/Unix_time). This is a client signal for a more
        /// accurate weak match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstallationTime")]
        public virtual System.Nullable<long> AppInstallationTime { get; set; }

        /// <summary>APP bundle ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Device information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual DeviceInfo Device { get; set; }

        /// <summary>iOS version, ie: 9.3.5. Consider adding "build".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosVersion")]
        public virtual string IosVersion { get; set; }

        /// <summary>
        /// App post install attribution retrieval information. Disambiguates mechanism (iSDK or developer invoked) to
        /// retrieve payload from clicked link.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalMethod")]
        public virtual string RetrievalMethod { get; set; }

        /// <summary>Google SDK version. Version takes the form "$major.$minor.$patch"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual string SdkVersion { get; set; }

        /// <summary>
        /// Possible unique matched link that server need to check before performing device heuristics match. If passed
        /// link is short server need to expand the link. If link is long server need to vslidate the link.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueMatchLinkToCheck")]
        public virtual string UniqueMatchLinkToCheck { get; set; }

        /// <summary>
        /// Strong match page information. Disambiguates between default UI and custom page to present when strong match
        /// succeeds/fails to find cookie.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualStyle")]
        public virtual string VisualStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for iSDK to execute strong match flow for post-install attribution. Information of the resolved FDL
    /// link.
    /// </summary>
    public class GetIosPostInstallAttributionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum version for app, specified by dev through ?imv= parameter. Return to iSDK to allow app to
        /// evaluate if current version meets this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appMinimumVersion")]
        public virtual string AppMinimumVersion { get; set; }

        /// <summary>The confidence of the returned attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionConfidence")]
        public virtual string AttributionConfidence { get; set; }

        /// <summary>
        /// The deep-link attributed post-install via one of several techniques (device heuristics, copy unique).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepLink")]
        public virtual string DeepLink { get; set; }

        /// <summary>
        /// User-agent specific custom-scheme URIs for iSDK to open. This will be set according to the user-agent tha
        /// the click was originally made in. There is no Safari-equivalent custom-scheme open URLs. ie:
        /// googlechrome://www.example.com ie: firefox://open-url?url=http://www.example.com ie:
        /// opera-http://example.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalBrowserDestinationLink")]
        public virtual string ExternalBrowserDestinationLink { get; set; }

        /// <summary>
        /// The link to navigate to update the app if min version is not met. This is either (in order): 1) fallback
        /// link (from ?ifl= parameter, if specified by developer) or 2) AppStore URL (from ?isi= parameter, if
        /// specified), or 3) the payload link (from required link= parameter).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackLink")]
        public virtual string FallbackLink { get; set; }

        /// <summary>
        /// Invitation ID attributed post-install via one of several techniques (device heuristics, copy unique).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitationId")]
        public virtual string InvitationId { get; set; }

        /// <summary>
        /// Instruction for iSDK to attemmpt to perform strong match. For instance, if browser does not support/allow
        /// cookie or outside of support browsers, this will be false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isStrongMatchExecutable")]
        public virtual System.Nullable<bool> IsStrongMatchExecutable { get; set; }

        /// <summary>
        /// Describes why match failed, ie: "discarded due to low confidence". This message will be publicly visible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchMessage")]
        public virtual string MatchMessage { get; set; }

        /// <summary>Which IP version the request was made from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestIpVersion")]
        public virtual string RequestIpVersion { get; set; }

        /// <summary>
        /// Entire FDL (short or long) attributed post-install via one of several techniques (device heuristics, copy
        /// unique).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLink")]
        public virtual string RequestedLink { get; set; }

        /// <summary>
        /// The entire FDL, expanded from a short link. It is the same as the requested_link, if it is long. Parameters
        /// from this should not be used directly (ie: server can default utm_[campaign|medium|source] to a value when
        /// requested_link lack them, server determine the best fallback_link when requested_link specifies &amp;gt;1
        /// fallback links).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedLink")]
        public virtual string ResolvedLink { get; set; }

        /// <summary>Scion campaign value to be propagated by iSDK to Scion at post-install.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmCampaign")]
        public virtual string UtmCampaign { get; set; }

        /// <summary>Scion content value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmContent")]
        public virtual string UtmContent { get; set; }

        /// <summary>Scion medium value to be propagated by iSDK to Scion at post-install.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmMedium")]
        public virtual string UtmMedium { get; set; }

        /// <summary>Scion source value to be propagated by iSDK to Scion at post-install.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmSource")]
        public virtual string UtmSource { get; set; }

        /// <summary>Scion term value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmTerm")]
        public virtual string UtmTerm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request for iSDK to get reopen attribution for app universal link open deeplinking. This endpoint is meant for
    /// only iOS requests.
    /// </summary>
    public class GetIosReopenAttributionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>APP bundle ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>
        /// FDL link to be verified from an app universal link open. The FDL link can be one of: 1) short FDL. e.g.
        /// .page.link/, or 2) long FDL. e.g. .page.link/?{query params}, or 3) Invite FDL. e.g. .page.link/i/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLink")]
        public virtual string RequestedLink { get; set; }

        /// <summary>Google SDK version. Version takes the form "$major.$minor.$patch"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual string SdkVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for iSDK to get reopen attribution for app universal link open deeplinking. This endpoint is meant for
    /// only iOS requests.
    /// </summary>
    public class GetIosReopenAttributionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The deep-link attributed the app universal link open. For both regular FDL links and invite FDL links.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepLink")]
        public virtual string DeepLink { get; set; }

        /// <summary>Optional invitation ID, for only invite typed requested FDL links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitationId")]
        public virtual string InvitationId { get; set; }

        /// <summary>
        /// FDL input value of the "&amp;amp;imv=" parameter, minimum app version to be returned to Google Firebase SDK
        /// running on iOS-9.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosMinAppVersion")]
        public virtual string IosMinAppVersion { get; set; }

        /// <summary>
        /// The entire FDL, expanded from a short link. It is the same as the requested_link, if it is long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedLink")]
        public virtual string ResolvedLink { get; set; }

        /// <summary>Scion campaign value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmCampaign")]
        public virtual string UtmCampaign { get; set; }

        /// <summary>Scion content value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmContent")]
        public virtual string UtmContent { get; set; }

        /// <summary>Scion medium value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmMedium")]
        public virtual string UtmMedium { get; set; }

        /// <summary>Scion source value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmSource")]
        public virtual string UtmSource { get; set; }

        /// <summary>Scion term value to be propagated by iSDK to Scion at app-reopen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmTerm")]
        public virtual string UtmTerm { get; set; }

        /// <summary>Optional warnings associated this API request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<DynamicLinkWarning> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters for Google Play Campaign Measurements. [Learn
    /// more](https://developers.google.com/analytics/devguides/collection/android/v4/campaigns#campaign-params)
    /// </summary>
    public class GooglePlayAnalytics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated; FDL SDK does not process nor log it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gclid")]
        public virtual string Gclid { get; set; }

        /// <summary>
        /// Campaign name; used for keyword analysis to identify a specific product promotion or strategic campaign.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmCampaign")]
        public virtual string UtmCampaign { get; set; }

        /// <summary>
        /// Campaign content; used for A/B testing and content-targeted ads to differentiate ads or links that point to
        /// the same URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmContent")]
        public virtual string UtmContent { get; set; }

        /// <summary>Campaign medium; used to identify a medium such as email or cost-per-click.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmMedium")]
        public virtual string UtmMedium { get; set; }

        /// <summary>Campaign source; used to identify a search engine, newsletter, or other source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmSource")]
        public virtual string UtmSource { get; set; }

        /// <summary>Campaign term; used with paid search to supply the keywords for ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmTerm")]
        public virtual string UtmTerm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for iTunes Connect App Analytics.</summary>
    public class ITunesConnectAnalytics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Affiliate token used to create affiliate-coded links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("at")]
        public virtual string At { get; set; }

        /// <summary>
        /// Campaign text that developers can optionally add to any link in order to track sales from a specific
        /// marketing campaign.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ct")]
        public virtual string Ct { get; set; }

        /// <summary>iTune media types, including music, podcasts, audiobooks and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mt")]
        public virtual string Mt { get; set; }

        /// <summary>Provider token that enables analytics for Dynamic Links from within iTunes Connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pt")]
        public virtual string Pt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>iOS related attributes to the Dynamic Link..</summary>
    public class IosInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>iOS App Store ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppStoreId")]
        public virtual string IosAppStoreId { get; set; }

        /// <summary>iOS bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosBundleId")]
        public virtual string IosBundleId { get; set; }

        /// <summary>
        /// Custom (destination) scheme to use for iOS. By default, we’ll use the bundle ID as the custom scheme.
        /// Developer can override this behavior using this param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosCustomScheme")]
        public virtual string IosCustomScheme { get; set; }

        /// <summary>Link to open on iOS if the app is not installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosFallbackLink")]
        public virtual string IosFallbackLink { get; set; }

        /// <summary>iPad bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosIpadBundleId")]
        public virtual string IosIpadBundleId { get; set; }

        /// <summary>If specified, this overrides the ios_fallback_link value on iPads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosIpadFallbackLink")]
        public virtual string IosIpadFallbackLink { get; set; }

        /// <summary>iOS minimum version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosMinimumVersion")]
        public virtual string IosMinimumVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Managed Short Link.</summary>
    public class ManagedShortLink : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>Creation timestamp of the short link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Attributes that have been flagged about this short url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flaggedAttribute")]
        public virtual System.Collections.Generic.IList<string> FlaggedAttribute { get; set; }

        /// <summary>Full Dyamic Link info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual DynamicLinkInfo Info { get; set; }

        /// <summary>Short durable link url, for example, "https://sample.app.goo.gl/xyz123". Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>Link name defined by the creator. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkName")]
        public virtual string LinkName { get; set; }

        /// <summary>Visibility status of link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of navigation behavior.</summary>
    public class NavigationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If this option is on, FDL click will be forced to redirect rather than show an interstitial page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableForcedRedirect")]
        public virtual System.Nullable<bool> EnableForcedRedirect { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters for social meta tag params. Used to set meta tag data for link previews on social sites.
    /// </summary>
    public class SocialMetaTagInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short description of the link. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialDescription")]
        public virtual string SocialDescription { get; set; }

        /// <summary>An image url string. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialImageLink")]
        public virtual string SocialImageLink { get; set; }

        /// <summary>Title to be displayed. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialTitle")]
        public virtual string SocialTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Short Dynamic Link suffix.</summary>
    public class Suffix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only applies to Option.CUSTOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSuffix")]
        public virtual string CustomSuffix { get; set; }

        /// <summary>Suffix option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("option")]
        public virtual string Option { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
