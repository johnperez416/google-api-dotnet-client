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

namespace Google.Apis.AdMob.v1
{
    /// <summary>The AdMob Service.</summary>
    public class AdMobService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdMobService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdMobService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://admob.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://admob.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admob";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the AdMob API.</summary>
        public class Scope
        {
            /// <summary>See your AdMob data</summary>
            public static string AdmobReadonly = "https://www.googleapis.com/auth/admob.readonly";

            /// <summary>See your AdMob data</summary>
            public static string AdmobReport = "https://www.googleapis.com/auth/admob.report";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AdMob API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See your AdMob data</summary>
            public const string AdmobReadonly = "https://www.googleapis.com/auth/admob.readonly";

            /// <summary>See your AdMob data</summary>
            public const string AdmobReport = "https://www.googleapis.com/auth/admob.report";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for AdMob requests.</summary>
    public abstract class AdMobBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdMobBaseServiceRequest instance.</summary>
        protected AdMobBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AdMob parameter list.</summary>
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
            AdUnits = new AdUnitsResource(service);
            Apps = new AppsResource(service);
            MediationReport = new MediationReportResource(service);
            NetworkReport = new NetworkReportResource(service);
        }

        /// <summary>Gets the AdUnits resource.</summary>
        public virtual AdUnitsResource AdUnits { get; }

        /// <summary>The "adUnits" collection of methods.</summary>
        public class AdUnitsResource
        {
            private const string Resource = "adUnits";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdUnitsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List the ad units under the specified AdMob account.</summary>
            /// <param name="parent">
            /// Required. Resource name of the account to list ad units for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the ad units under the specified AdMob account.</summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.ListAdUnitsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to list ad units for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of ad units to return. If unspecified or 0, at most 10,000 ad units will be
                /// returned. The maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAdUnitsResponse`; indicates that this is a continuation of a
                /// prior `ListAdUnits` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/adUnits";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List the apps under the specified AdMob account.</summary>
            /// <param name="parent">
            /// Required. Resource name of the account to list apps for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the apps under the specified AdMob account.</summary>
            public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.ListAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the account to list apps for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of apps to return. If unspecified or 0, at most 10,000 apps will be returned. The
                /// maximum value is 20,000; values above 20,000 will be coerced to 20,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAppsResponse`; indicates that this is a continuation of a prior
                /// `ListApps` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/apps";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the MediationReport resource.</summary>
        public virtual MediationReportResource MediationReport { get; }

        /// <summary>The "mediationReport" collection of methods.</summary>
        public class MediationReportResource
        {
            private const string Resource = "mediationReport";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MediationReportResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Generates an AdMob Mediation report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.AdMob.v1.Data.GenerateMediationReportRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Generates an AdMob Mediation report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            public class GenerateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateMediationReportResponse[]>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1.Data.GenerateMediationReportRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1.Data.GenerateMediationReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/mediationReport:generate";

                /// <summary>Initializes Generate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the NetworkReport resource.</summary>
        public virtual NetworkReportResource NetworkReport { get; }

        /// <summary>The "networkReport" collection of methods.</summary>
        public class NetworkReportResource
        {
            private const string Resource = "networkReport";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NetworkReportResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Generates an AdMob Network report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.AdMob.v1.Data.GenerateNetworkReportRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Generates an AdMob Network report based on the provided report specification. Returns result of a
            /// server-side streaming RPC. The result is returned in a sequence of responses.
            /// </summary>
            public class GenerateRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateNetworkReportResponse[]>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdMob.v1.Data.GenerateNetworkReportRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the account to generate the report for. Example: accounts/pub-9876543210987654
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdMob.v1.Data.GenerateNetworkReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/networkReport:generate";

                /// <summary>Initializes Generate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets information about the specified AdMob publisher account.</summary>
        /// <param name="name">
        /// Resource name of the publisher account to retrieve. Example: accounts/pub-9876543210987654
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets information about the specified AdMob publisher account.</summary>
        public class GetRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.PublisherAccount>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Resource name of the publisher account to retrieve. Example: accounts/pub-9876543210987654
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
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists the AdMob publisher account that was most recently signed in to from the AdMob UI. For more
        /// information, see https://support.google.com/admob/answer/10243672.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists the AdMob publisher account that was most recently signed in to from the AdMob UI. For more
        /// information, see https://support.google.com/admob/answer/10243672.
        /// </summary>
        public class ListRequest : AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.ListPublisherAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of accounts to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The value returned by the last `ListPublisherAccountsResponse`; indicates that this is a continuation of
            /// a prior `ListPublisherAccounts` call, and that the system should return the next page of data.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.AdMob.v1.Data
{
    /// <summary>Describes an AdMob ad unit.</summary>
    public class AdUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// AdFormat of the ad unit. Possible values are as follows: "APP_OPEN" - App Open ad format. "BANNER" - Banner
        /// ad format. "BANNER_INTERSTITIAL" - Legacy format that can be used as either banner or interstitial. This
        /// format can no longer be created but can be targeted by mediation groups. "INTERSTITIAL" - A full screen ad.
        /// Supported ad types are "RICH_MEDIA" and "VIDEO". "NATIVE" - Native ad format. "REWARDED" - An ad that, once
        /// viewed, gets a callback verifying the view so that a reward can be given to the user. Supported ad types are
        /// "RICH_MEDIA" (interactive) and video where video can not be excluded. "REWARDED_INTERSTITIAL" - Rewarded
        /// Interstitial ad format. Only supports video ad type. See https://support.google.com/admob/answer/9884467.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adFormat")]
        public virtual string AdFormat { get; set; }

        /// <summary>
        /// Ad media type supported by this ad unit. Possible values as follows: "RICH_MEDIA" - Text, image, and other
        /// non-video media. "VIDEO" - Video media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTypes")]
        public virtual System.Collections.Generic.IList<string> AdTypes { get; set; }

        /// <summary>
        /// The externally visible ID of the ad unit which can be used to integrate with the AdMob SDK. This is a read
        /// only property. Example: ca-app-pub-9876543210987654/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnitId")]
        public virtual string AdUnitId { get; set; }

        /// <summary>
        /// The externally visible ID of the app this ad unit is associated with. Example:
        /// ca-app-pub-9876543210987654~0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// The display name of the ad unit as shown in the AdMob UI, which is provided by the user. The maximum length
        /// allowed is 80 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for this ad unit. Format is accounts/{publisher_id}/adUnits/{ad_unit_id_fragment} Example:
        /// accounts/pub-9876543210987654/adUnits/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an AdMob app for a specific platform (For example: Android or iOS).</summary>
    public class App : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The approval state for the app. The field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appApprovalState")]
        public virtual string AppApprovalState { get; set; }

        /// <summary>
        /// The externally visible ID of the app which can be used to integrate with the AdMob SDK. This is a read only
        /// property. Example: ca-app-pub-9876543210987654~0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// Immutable. The information for an app that is linked to an app store. This field is present if and only if
        /// the app is linked to an app store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAppInfo")]
        public virtual AppLinkedAppInfo LinkedAppInfo { get; set; }

        /// <summary>
        /// The information for an app that is not linked to any app store. After an app is linked, this information is
        /// still retrivable. If no name is provided for the app upon creation, a placeholder name will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualAppInfo")]
        public virtual AppManualAppInfo ManualAppInfo { get; set; }

        /// <summary>
        /// Resource name for this app. Format is accounts/{publisher_id}/apps/{app_id_fragment} Example:
        /// accounts/pub-9876543210987654/apps/0123456789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Describes the platform of the app. Limited to "IOS" and "ANDROID".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information from the app store if the app is linked to an app store.</summary>
    public class AppLinkedAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The app store ID of the app; present if and only if the app is linked to an app store. If the app is added
        /// to the Google Play store, it will be the application ID of the app. For example: "com.example.myapp". See
        /// https://developer.android.com/studio/build/application-id. If the app is added to the Apple App Store, it
        /// will be app store ID. For example "105169111". Note that setting the app store id is considered an
        /// irreversible action. Once an app is linked, it cannot be unlinked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStoreId")]
        public virtual string AppStoreId { get; set; }

        /// <summary>
        /// Output only. Display name of the app as it appears in the app store. This is an output-only field, and may
        /// be empty if the app cannot be found in the store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information provided for manual apps which are not linked to an application store (Example: Google Play, App
    /// Store).
    /// </summary>
    public class AppManualAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display name of the app as shown in the AdMob UI, which is provided by the user. The maximum length
        /// allowed is 80 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a single date range. Both dates are inclusive.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End date of the date range, inclusive. Must be greater than or equal to the start date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Start date of the date range, inclusive. Must be less than or equal to the end date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to generate an AdMob Mediation report.</summary>
    public class GenerateMediationReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network report specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSpec")]
        public virtual MediationReportSpec ReportSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The streaming response for the AdMob Mediation report where the first response contains the report header, then
    /// a stream of row responses, and finally a footer as the last response message. For example: [{ "header": {
    /// "date_range": { "start_date": {"year": 2018, "month": 9, "day": 1}, "end_date": {"year": 2018, "month": 9,
    /// "day": 1} }, "localization_settings": { "currency_code": "USD", "language_code": "en-US" } } }, { "row": {
    /// "dimension_values": { "DATE": {"value": "20180918"}, "APP": { "value": "ca-app-pub-8123415297019784~1001342552",
    /// "display_label": "My app name!" } }, "metric_values": { "ESTIMATED_EARNINGS": {"decimal_value": "1324746"} } }
    /// }, { "footer": {"matching_row_count": 1} }]
    /// </summary>
    public class GenerateMediationReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the generated report, such as warnings about the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual ReportFooter Footer { get; set; }

        /// <summary>
        /// Report generation settings that describes the report contents, such as the report date range and
        /// localization settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ReportHeader Header { get; set; }

        /// <summary>Actual report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual ReportRow Row { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to generate an AdMob Network report.</summary>
    public class GenerateNetworkReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network report specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportSpec")]
        public virtual NetworkReportSpec ReportSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The streaming response for the AdMob Network report where the first response contains the report header, then a
    /// stream of row responses, and finally a footer as the last response message. For example: [{ "header": {
    /// "dateRange": { "startDate": {"year": 2018, "month": 9, "day": 1}, "endDate": {"year": 2018, "month": 9, "day":
    /// 1} }, "localizationSettings": { "currencyCode": "USD", "languageCode": "en-US" } } }, { "row": {
    /// "dimensionValues": { "DATE": {"value": "20180918"}, "APP": { "value": "ca-app-pub-8123415297019784~1001342552",
    /// displayLabel: "My app name!" } }, "metricValues": { "ESTIMATED_EARNINGS": {"microsValue": 6500000} } } }, {
    /// "footer": {"matchingRowCount": 1} }]
    /// </summary>
    public class GenerateNetworkReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the generated report, such as warnings about the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual ReportFooter Footer { get; set; }

        /// <summary>
        /// Report generation settings that describes the report contents, such as the report date range and
        /// localization settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual ReportHeader Header { get; set; }

        /// <summary>Actual report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual ReportRow Row { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ad units list request.</summary>
    public class ListAdUnitsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting ad units for the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnits")]
        public virtual System.Collections.Generic.IList<AdUnit> AdUnits { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more ad units for the request; this value should be passed in a
        /// new `ListAdUnitsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the apps list request.</summary>
    public class ListAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting apps for the requested account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<App> Apps { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more apps for the request; this value should be passed in a new
        /// `ListAppsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the publisher account list request.</summary>
    public class ListPublisherAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publisher that the client credentials can access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual System.Collections.Generic.IList<PublisherAccount> Account { get; set; }

        /// <summary>
        /// If not empty, indicates that there might be more accounts for the request; you must pass this value in a new
        /// `ListPublisherAccountsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Localization settings for reports, such as currency and language. It affects how metrics are calculated.
    /// </summary>
    public class LocalizationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currency code of the earning related metrics, which is the 3-letter code defined in ISO 4217. The daily
        /// average rate is used for the currency conversion. Defaults to the account currency code if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Language used for any localized text, such as some dimension value display labels. The language tag defined
        /// in the IETF BCP47. Defaults to 'en-US' if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for generating an AdMob Mediation report. For example, the specification to get observed ECPM
    /// sliced by ad source and app for the 'US' and 'CN' countries can look like the following example: { "date_range":
    /// { "start_date": {"year": 2021, "month": 9, "day": 1}, "end_date": {"year": 2021, "month": 9, "day": 30} },
    /// "dimensions": ["AD_SOURCE", "APP", "COUNTRY"], "metrics": ["OBSERVED_ECPM"], "dimension_filters": [ {
    /// "dimension": "COUNTRY", "matches_any": {"values": [{"value": "US", "value": "CN"}]} } ], "sort_conditions": [
    /// {"dimension":"APP", order: "ASCENDING"} ], "localization_settings": { "currency_code": "USD", "language_code":
    /// "en-US" } } For a better understanding, you can treat the preceding specification like the following pseudo SQL:
    /// SELECT AD_SOURCE, APP, COUNTRY, OBSERVED_ECPM FROM MEDIATION_REPORT WHERE DATE &amp;gt;= '2021-09-01' AND DATE
    /// &amp;lt;= '2021-09-30' AND COUNTRY IN ('US', 'CN') GROUP BY AD_SOURCE, APP, COUNTRY ORDER BY APP ASC;
    /// </summary>
    public class MediationReportSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date range for which the report is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>Describes which report rows to match based on their dimension values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilters")]
        public virtual System.Collections.Generic.IList<MediationReportSpecDimensionFilter> DimensionFilters { get; set; }

        /// <summary>
        /// List of dimensions of the report. The value combination of these dimensions determines the row of the
        /// report. If no dimensions are specified, the report returns a single row of requested metrics for the entire
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Localization settings of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// Maximum number of report data rows to return. If the value is not set, the API returns as many rows as
        /// possible, up to 100000. Acceptable values are 1-100000, inclusive. Values larger than 100000 return an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReportRows")]
        public virtual System.Nullable<int> MaxReportRows { get; set; }

        /// <summary>List of metrics of the report. A report must specify at least one metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Describes the sorting of report rows. The order of the condition in the list defines its precedence; the
        /// earlier the condition, the higher its precedence. If no sort conditions are specified, the row ordering is
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortConditions")]
        public virtual System.Collections.Generic.IList<MediationReportSpecSortCondition> SortConditions { get; set; }

        /// <summary>
        /// A report time zone. Accepts an IANA TZ name values, such as "America/Los_Angeles." If no time zone is
        /// defined, the account default takes effect. Check default value by the get account action. **Warning:** The
        /// "America/Los_Angeles" is the only supported value at the moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes which report rows to match based on their dimension values.</summary>
    public class MediationReportSpecDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Applies the filter criterion to the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// Matches a row if its value for the specified dimension is in one of the values specified in this condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchesAny")]
        public virtual StringList MatchesAny { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorting direction to be applied on a dimension or a metric.</summary>
    public class MediationReportSpecSortCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sort by the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>Sort by the specified metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Sorting order of the dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for generating an AdMob Network report. For example, the specification to get clicks and
    /// estimated earnings for only the 'US' and 'CN' countries can look like the following example: { 'date_range': {
    /// 'start_date': {'year': 2021, 'month': 9, 'day': 1}, 'end_date': {'year': 2021, 'month': 9, 'day': 30} },
    /// 'dimensions': ['DATE', 'APP', 'COUNTRY'], 'metrics': ['CLICKS', 'ESTIMATED_EARNINGS'], 'dimension_filters': [ {
    /// 'dimension': 'COUNTRY', 'matches_any': {'values': [{'value': 'US', 'value': 'CN'}]} } ], 'sort_conditions': [
    /// {'dimension':'APP', order: 'ASCENDING'}, {'metric':'CLICKS', order: 'DESCENDING'} ], 'localization_settings': {
    /// 'currency_code': 'USD', 'language_code': 'en-US' } } For a better understanding, you can treat the preceding
    /// specification like the following pseudo SQL: SELECT DATE, APP, COUNTRY, CLICKS, ESTIMATED_EARNINGS FROM
    /// NETWORK_REPORT WHERE DATE &amp;gt;= '2021-09-01' AND DATE &amp;lt;= '2021-09-30' AND COUNTRY IN ('US', 'CN')
    /// GROUP BY DATE, APP, COUNTRY ORDER BY APP ASC, CLICKS DESC;
    /// </summary>
    public class NetworkReportSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date range for which the report is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>Describes which report rows to match based on their dimension values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilters")]
        public virtual System.Collections.Generic.IList<NetworkReportSpecDimensionFilter> DimensionFilters { get; set; }

        /// <summary>
        /// List of dimensions of the report. The value combination of these dimensions determines the row of the
        /// report. If no dimensions are specified, the report returns a single row of requested metrics for the entire
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Localization settings of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// Maximum number of report data rows to return. If the value is not set, the API returns as many rows as
        /// possible, up to 100000. Acceptable values are 1-100000, inclusive. Values larger than 100000 return an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReportRows")]
        public virtual System.Nullable<int> MaxReportRows { get; set; }

        /// <summary>List of metrics of the report. A report must specify at least one metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Describes the sorting of report rows. The order of the condition in the list defines its precedence; the
        /// earlier the condition, the higher its precedence. If no sort conditions are specified, the row ordering is
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortConditions")]
        public virtual System.Collections.Generic.IList<NetworkReportSpecSortCondition> SortConditions { get; set; }

        /// <summary>
        /// A report time zone. Accepts an IANA TZ name values, such as "America/Los_Angeles." If no time zone is
        /// defined, the account default takes effect. Check default value by the get account action. **Warning:** The
        /// "America/Los_Angeles" is the only supported value at the moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes which report rows to match based on their dimension values.</summary>
    public class NetworkReportSpecDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Applies the filter criterion to the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// Matches a row if its value for the specified dimension is in one of the values specified in this condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchesAny")]
        public virtual StringList MatchesAny { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorting direction to be applied on a dimension or a metric.</summary>
    public class NetworkReportSpecSortCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sort by the specified dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>Sort by the specified metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Sorting order of the dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A publisher account contains information relevant to the use of this API, such as the time zone used for the
    /// reports.
    /// </summary>
    public class PublisherAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currency code of the earning-related metrics, which is the 3-letter code defined in ISO 4217. The daily
        /// average rate is used for the currency conversion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Resource name of this account. Format is accounts/{publisher_id}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The unique ID by which this publisher account can be identified in the API requests (for example,
        /// pub-1234567890).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherId")]
        public virtual string PublisherId { get; set; }

        /// <summary>
        /// The time zone that is used in reports that are generated for this account. The value is a time-zone ID as
        /// specified by the CLDR project, for example, "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingTimeZone")]
        public virtual string ReportingTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Groups data available after report generation, for example, warnings and row counts. Always sent as the last
    /// message in the stream response.
    /// </summary>
    public class ReportFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of rows that matched the request. Warning: This count does NOT always match the number of rows
        /// in the response. Do not make that assumption when processing the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingRowCount")]
        public virtual System.Nullable<long> MatchingRowCount { get; set; }

        /// <summary>Warnings associated with generation of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ReportWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Groups data helps to treat the generated report. Always sent as a first message in the stream response.
    /// </summary>
    public class ReportHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date range for which the report is generated. This is identical to the range specified in the report
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// Localization settings of the report. This is identical to the settings in the report request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationSettings")]
        public virtual LocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// The report time zone. The value is a time-zone ID as specified by the CLDR project, for example,
        /// "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingTimeZone")]
        public virtual string ReportingTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of the returning report.</summary>
    public class ReportRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of dimension values in a row, with keys as enum name of the dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IDictionary<string, ReportRowDimensionValue> DimensionValues { get; set; }

        /// <summary>
        /// Map of metric values in a row, with keys as enum name of the metrics. If a metric being requested has no
        /// value returned, the map will not include it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IDictionary<string, ReportRowMetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a dimension value.</summary>
    public class ReportRowDimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The localized string representation of the value. If unspecified, the display label should be derived from
        /// the value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLabel")]
        public virtual string DisplayLabel { get; set; }

        /// <summary>Dimension value in the format specified in the report's spec Dimension enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a metric value.</summary>
    public class ReportRowMetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double precision (approximate) decimal values. Rates are from 0 to 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Metric integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        /// <summary>
        /// Amount in micros. One million is equivalent to one unit. Currency value is in the unit (USD, EUR or other)
        /// specified by the request. For example, $6.50 whould be represented as 6500000 micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microsValue")]
        public virtual System.Nullable<long> MicrosValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Warnings associated with generation of the report.</summary>
    public class ReportWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the details of the warning message, in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Type of the warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of string values.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
