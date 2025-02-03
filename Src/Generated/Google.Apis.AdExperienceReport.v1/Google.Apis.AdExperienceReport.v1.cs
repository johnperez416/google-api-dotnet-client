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

namespace Google.Apis.AdExperienceReport.v1
{
    /// <summary>The AdExperienceReport Service.</summary>
    public class AdExperienceReportService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExperienceReportService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExperienceReportService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Sites = new SitesResource(this);
            ViolatingSites = new ViolatingSitesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://adexperiencereport.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://adexperiencereport.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adexperiencereport";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }

        /// <summary>Gets the ViolatingSites resource.</summary>
        public virtual ViolatingSitesResource ViolatingSites { get; }
    }

    /// <summary>A base abstract class for AdExperienceReport requests.</summary>
    public abstract class AdExperienceReportBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdExperienceReportBaseServiceRequest instance.</summary>
        protected AdExperienceReportBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AdExperienceReport parameter list.</summary>
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

    /// <summary>The "sites" collection of methods.</summary>
    public class SitesResource
    {
        private const string Resource = "sites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a site's Ad Experience Report summary.</summary>
        /// <param name="name">
        /// Required. The name of the site whose summary to get, e.g. `sites/http%3A%2F%2Fwww.google.com%2F`. Format:
        /// `sites/{site}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets a site's Ad Experience Report summary.</summary>
        public class GetRequest : AdExperienceReportBaseServiceRequest<Google.Apis.AdExperienceReport.v1.Data.SiteSummaryResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the site whose summary to get, e.g. `sites/http%3A%2F%2Fwww.google.com%2F`.
            /// Format: `sites/{site}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^sites/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "violatingSites" collection of methods.</summary>
    public class ViolatingSitesResource
    {
        private const string Resource = "violatingSites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ViolatingSitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists sites that are failing in the Ad Experience Report on at least one platform.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists sites that are failing in the Ad Experience Report on at least one platform.</summary>
        public class ListRequest : AdExperienceReportBaseServiceRequest<Google.Apis.AdExperienceReport.v1.Data.ViolatingSitesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/violatingSites";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.AdExperienceReport.v1.Data
{
    /// <summary>A site's Ad Experience Report summary on a single platform.</summary>
    public class PlatformSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The site's Ad Experience Report status on this platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betterAdsStatus")]
        public virtual string BetterAdsStatus { get; set; }

        private string _enforcementTimeRaw;

        private object _enforcementTime;

        /// <summary>
        /// The time at which [enforcement](https://support.google.com/webtools/answer/7308033) against the site began
        /// or will begin on this platform. Not set when the filter_status is OFF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcementTime")]
        public virtual string EnforcementTimeRaw
        {
            get => _enforcementTimeRaw;
            set
            {
                _enforcementTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _enforcementTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EnforcementTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EnforcementTimeDateTimeOffset instead.")]
        public virtual object EnforcementTime
        {
            get => _enforcementTime;
            set
            {
                _enforcementTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _enforcementTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EnforcementTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EnforcementTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EnforcementTimeRaw);
            set => EnforcementTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The site's [enforcement status](https://support.google.com/webtools/answer/7308033) on this platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterStatus")]
        public virtual string FilterStatus { get; set; }

        private string _lastChangeTimeRaw;

        private object _lastChangeTime;

        /// <summary>The time at which the site's status last changed on this platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastChangeTime")]
        public virtual string LastChangeTimeRaw
        {
            get => _lastChangeTimeRaw;
            set
            {
                _lastChangeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastChangeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastChangeTimeDateTimeOffset instead.")]
        public virtual object LastChangeTime
        {
            get => _lastChangeTime;
            set
            {
                _lastChangeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastChangeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastChangeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastChangeTimeRaw);
            set => LastChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The site's regions on this platform. No longer populated, because there is no longer any semantic difference
        /// between sites in different regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual System.Collections.Generic.IList<string> Region { get; set; }

        /// <summary>
        /// A link to the full Ad Experience Report for the site on this platform.. Not set in ViolatingSitesResponse.
        /// Note that you must complete the [Search Console verification
        /// process](https://support.google.com/webmasters/answer/9008080) for the site before you can access the full
        /// report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportUrl")]
        public virtual string ReportUrl { get; set; }

        /// <summary>Whether the site is currently under review on this platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underReview")]
        public virtual System.Nullable<bool> UnderReview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GetSiteSummary.</summary>
    public class SiteSummaryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The site's Ad Experience Report summary on desktop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desktopSummary")]
        public virtual PlatformSummary DesktopSummary { get; set; }

        /// <summary>The site's Ad Experience Report summary on mobile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileSummary")]
        public virtual PlatformSummary MobileSummary { get; set; }

        /// <summary>The name of the reviewed site, e.g. `google.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewedSite")]
        public virtual string ReviewedSite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListViolatingSites.</summary>
    public class ViolatingSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of violating sites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatingSites")]
        public virtual System.Collections.Generic.IList<SiteSummaryResponse> ViolatingSites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
