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

namespace Google.Apis.WebSecurityScanner.v1alpha
{
    /// <summary>The WebSecurityScanner Service.</summary>
    public class WebSecurityScannerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WebSecurityScannerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WebSecurityScannerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://websecurityscanner.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://websecurityscanner.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "websecurityscanner";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Web Security Scanner API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Web Security Scanner API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for WebSecurityScanner requests.</summary>
    public abstract class WebSecurityScannerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WebSecurityScannerBaseServiceRequest instance.</summary>
        protected WebSecurityScannerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WebSecurityScanner parameter list.</summary>
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

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ScanConfigs = new ScanConfigsResource(service);
        }

        /// <summary>Gets the ScanConfigs resource.</summary>
        public virtual ScanConfigsResource ScanConfigs { get; }

        /// <summary>The "scanConfigs" collection of methods.</summary>
        public class ScanConfigsResource
        {
            private const string Resource = "scanConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ScanConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ScanRuns = new ScanRunsResource(service);
            }

            /// <summary>Gets the ScanRuns resource.</summary>
            public virtual ScanRunsResource ScanRuns { get; }

            /// <summary>The "scanRuns" collection of methods.</summary>
            public class ScanRunsResource
            {
                private const string Resource = "scanRuns";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ScanRunsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CrawledUrls = new CrawledUrlsResource(service);
                    FindingTypeStats = new FindingTypeStatsResource(service);
                    Findings = new FindingsResource(service);
                }

                /// <summary>Gets the CrawledUrls resource.</summary>
                public virtual CrawledUrlsResource CrawledUrls { get; }

                /// <summary>The "crawledUrls" collection of methods.</summary>
                public class CrawledUrlsResource
                {
                    private const string Resource = "crawledUrls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CrawledUrlsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List CrawledUrls under a given ScanRun.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name, which should be a scan run resource name in the format
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List CrawledUrls under a given ScanRun.</summary>
                    public class ListRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ListCrawledUrlsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, which should be a scan run resource name in the format
                        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of CrawledUrls to return, can be limited by server. If not specified or
                        /// not positive, the implementation will select a reasonable value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results to be returned. This should be a `next_page_token`
                        /// value returned from a previous List request. If unspecified, the first page of results is
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/crawledUrls";

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
                                Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+$",
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

                /// <summary>Gets the FindingTypeStats resource.</summary>
                public virtual FindingTypeStatsResource FindingTypeStats { get; }

                /// <summary>The "findingTypeStats" collection of methods.</summary>
                public class FindingTypeStatsResource
                {
                    private const string Resource = "findingTypeStats";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FindingTypeStatsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List all FindingTypeStats under a given ScanRun.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name, which should be a scan run resource name in the format
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List all FindingTypeStats under a given ScanRun.</summary>
                    public class ListRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ListFindingTypeStatsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, which should be a scan run resource name in the format
                        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/findingTypeStats";

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
                                Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Findings resource.</summary>
                public virtual FindingsResource Findings { get; }

                /// <summary>The "findings" collection of methods.</summary>
                public class FindingsResource
                {
                    private const string Resource = "findings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FindingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a Finding.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Finding to be returned. The name follows the format of
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a Finding.</summary>
                    public class GetRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.Finding>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Finding to be returned. The name follows the format of
                        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+/findings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List Findings under a given ScanRun.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name, which should be a scan run resource name in the format
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List Findings under a given ScanRun.</summary>
                    public class ListRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ListFindingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, which should be a scan run resource name in the format
                        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The filter expression. The expression must be in the format: . Supported field:
                        /// 'finding_type'. Supported operator: '='.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// The maximum number of Findings to return, can be limited by server. If not specified or not
                        /// positive, the implementation will select a reasonable value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results to be returned. This should be a `next_page_token`
                        /// value returned from a previous List request. If unspecified, the first page of results is
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/findings";

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
                                Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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

                /// <summary>Gets a ScanRun.</summary>
                /// <param name="name">
                /// Required. The resource name of the ScanRun to be returned. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a ScanRun.</summary>
                public class GetRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanRun>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the ScanRun to be returned. The name follows the format of
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun stop time.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent resource name, which should be a scan resource name in the format
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun stop time.
                /// </summary>
                public class ListRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ListScanRunsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, which should be a scan resource name in the format
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of ScanRuns to return, can be limited by server. If not specified or not
                    /// positive, the implementation will select a reasonable value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results to be returned. This should be a `next_page_token` value
                    /// returned from a previous List request. If unspecified, the first page of results is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/scanRuns";

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
                            Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
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

                /// <summary>Stops a ScanRun. The stopped ScanRun is returned.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the ScanRun to be stopped. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                /// </param>
                public virtual StopRequest Stop(Google.Apis.WebSecurityScanner.v1alpha.Data.StopScanRunRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>Stops a ScanRun. The stopped ScanRun is returned.</summary>
                public class StopRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanRun>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.WebSecurityScanner.v1alpha.Data.StopScanRunRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the ScanRun to be stopped. The name follows the format of
                    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WebSecurityScanner.v1alpha.Data.StopScanRunRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/scanConfigs/[^/]+/scanRuns/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Creates a new ScanConfig.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource name where the scan is created, which should be a project resource name in
            /// the format 'projects/{projectId}'.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new ScanConfig.</summary>
            public class CreateRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name where the scan is created, which should be a project resource
                /// name in the format 'projects/{projectId}'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/scanConfigs";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes an existing ScanConfig and its child resources.</summary>
            /// <param name="name">
            /// Required. The resource name of the ScanConfig to be deleted. The name follows the format of
            /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an existing ScanConfig and its child resources.</summary>
            public class DeleteRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the ScanConfig to be deleted. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a ScanConfig.</summary>
            /// <param name="name">
            /// Required. The resource name of the ScanConfig to be returned. The name follows the format of
            /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a ScanConfig.</summary>
            public class GetRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the ScanConfig to be returned. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists ScanConfigs under a given project.</summary>
            /// <param name="parent">
            /// Required. The parent resource name, which should be a project resource name in the format
            /// 'projects/{projectId}'.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists ScanConfigs under a given project.</summary>
            public class ListRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ListScanConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name, which should be a project resource name in the format
                /// 'projects/{projectId}'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of ScanConfigs to return, can be limited by server. If not specified or not
                /// positive, the implementation will select a reasonable value.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results to be returned. This should be a `next_page_token` value
                /// returned from a previous List request. If unspecified, the first page of results is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/scanConfigs";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates a ScanConfig. This method support partial update of a ScanConfig.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the ScanConfig. The name follows the format of
            /// 'projects/{projectId}/scanConfigs/{scanConfigId}'. The ScanConfig IDs are generated by the system.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a ScanConfig. This method support partial update of a ScanConfig.</summary>
            public class PatchRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the ScanConfig. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}'. The ScanConfig IDs are generated by the system.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The update mask applies to the resource. For the `FieldMask` definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebSecurityScanner.v1alpha.Data.ScanConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Start a ScanRun according to the given ScanConfig.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the ScanConfig to be used. The name follows the format of
            /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
            /// </param>
            public virtual StartRequest Start(Google.Apis.WebSecurityScanner.v1alpha.Data.StartScanRunRequest body, string name)
            {
                return new StartRequest(this.service, body, name);
            }

            /// <summary>Start a ScanRun according to the given ScanConfig.</summary>
            public class StartRequest : WebSecurityScannerBaseServiceRequest<Google.Apis.WebSecurityScanner.v1alpha.Data.ScanRun>
            {
                /// <summary>Constructs a new Start request.</summary>
                public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.WebSecurityScanner.v1alpha.Data.StartScanRunRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the ScanConfig to be used. The name follows the format of
                /// 'projects/{projectId}/scanConfigs/{scanConfigId}'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebSecurityScanner.v1alpha.Data.StartScanRunRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "start";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:start";

                /// <summary>Initializes Start parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.WebSecurityScanner.v1alpha.Data
{
    /// <summary>Scan authentication configuration.</summary>
    public class Authentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication using a custom account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAccount")]
        public virtual CustomAccount CustomAccount { get; set; }

        /// <summary>Authentication using a Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAccount")]
        public virtual GoogleAccount GoogleAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CrawledUrl resource represents a URL that was crawled during a ScanRun. Web Security Scanner Service crawls
    /// the web applications, following all links within the scope of sites, to find the URLs to test against.
    /// </summary>
    public class CrawledUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The body of the request that was used to visit the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>Output only. The http method of the request that was used to visit the URL, in uppercase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>Output only. The URL that was crawled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes authentication configuration that uses a custom account.</summary>
    public class CustomAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The login form URL of the website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginUrl")]
        public virtual string LoginUrl { get; set; }

        /// <summary>
        /// Required. Input only. The password of the custom account. The credential is stored encrypted and not
        /// returned in any response nor included in audit logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Required. The user name of the custom account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Finding resource represents a vulnerability instance identified during a ScanRun.</summary>
    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The body of the request that triggered the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>The description of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The URL where the browser lands when the vulnerability is detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrl")]
        public virtual string FinalUrl { get; set; }

        /// <summary>The type of the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingType")]
        public virtual string FindingType { get; set; }

        /// <summary>
        /// If the vulnerability was originated from nested IFrame, the immediate parent IFrame is reported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameUrl")]
        public virtual string FrameUrl { get; set; }

        /// <summary>
        /// The URL produced by the server-side fuzzer and used in the request that triggered the vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fuzzedUrl")]
        public virtual string FuzzedUrl { get; set; }

        /// <summary>The http method of the request that triggered the vulnerability, in uppercase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>
        /// The resource name of the Finding. The name follows the format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanruns/{scanRunId}/findings/{findingId}'. The finding IDs
        /// are generated by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An addon containing information about outdated libraries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdatedLibrary")]
        public virtual OutdatedLibrary OutdatedLibrary { get; set; }

        /// <summary>
        /// The URL containing human-readable payload that user can leverage to reproduce the vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reproductionUrl")]
        public virtual string ReproductionUrl { get; set; }

        /// <summary>The tracking ID uniquely identifies a vulnerability instance across multiple ScanRuns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual string TrackingId { get; set; }

        /// <summary>
        /// An addon containing detailed information regarding any resource causing the vulnerability such as JavaScript
        /// sources, image, audio files, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatingResource")]
        public virtual ViolatingResource ViolatingResource { get; set; }

        /// <summary>An addon containing information about vulnerable or missing HTTP headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerableHeaders")]
        public virtual VulnerableHeaders VulnerableHeaders { get; set; }

        /// <summary>
        /// An addon containing information about request parameters which were found to be vulnerable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerableParameters")]
        public virtual VulnerableParameters VulnerableParameters { get; set; }

        /// <summary>An addon containing information reported for an XSS, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xss")]
        public virtual Xss Xss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A FindingTypeStats resource represents stats regarding a specific FindingType of Findings under a given ScanRun.
    /// </summary>
    public class FindingTypeStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The count of findings belonging to this finding type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingCount")]
        public virtual System.Nullable<int> FindingCount { get; set; }

        /// <summary>The finding type associated with the stats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingType")]
        public virtual string FindingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes authentication configuration that uses a Google account.</summary>
    public class GoogleAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. The password of the Google account. The credential is stored encrypted and not
        /// returned in any response nor included in audit logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Required. The user name of the Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a HTTP Header.</summary>
    public class Header : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Header name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Header value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListCrawledUrls` method.</summary>
    public class ListCrawledUrlsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CrawledUrls returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawledUrls")]
        public virtual System.Collections.Generic.IList<CrawledUrl> CrawledUrls { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListFindingTypeStats` method.</summary>
    public class ListFindingTypeStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of FindingTypeStats returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingTypeStats")]
        public virtual System.Collections.Generic.IList<FindingTypeStats> FindingTypeStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListFindings` method.</summary>
    public class ListFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Findings returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findings")]
        public virtual System.Collections.Generic.IList<Finding> Findings { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListScanConfigs` method.</summary>
    public class ListScanConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ScanConfigs returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanConfigs")]
        public virtual System.Collections.Generic.IList<ScanConfig> ScanConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListScanRuns` method.</summary>
    public class ListScanRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ScanRuns returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanRuns")]
        public virtual System.Collections.Generic.IList<ScanRun> ScanRuns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information reported for an outdated library.</summary>
    public class OutdatedLibrary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URLs to learn more information about the vulnerabilities in the library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnMoreUrls")]
        public virtual System.Collections.Generic.IList<string> LearnMoreUrls { get; set; }

        /// <summary>The name of the outdated library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraryName")]
        public virtual string LibraryName { get; set; }

        /// <summary>The version number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ScanConfig resource contains the configurations to launch a scan. next id: 12</summary>
    public class ScanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The authentication configuration. If specified, service will use the authentication configuration during
        /// scanning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authentication")]
        public virtual Authentication Authentication { get; set; }

        /// <summary>
        /// The excluded URL patterns as described in
        /// https://cloud.google.com/security-command-center/docs/how-to-use-web-security-scanner#excluding_urls
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blacklistPatterns")]
        public virtual System.Collections.Generic.IList<string> BlacklistPatterns { get; set; }

        /// <summary>Required. The user provided display name of the ScanConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Latest ScanRun if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRun")]
        public virtual ScanRun LatestRun { get; set; }

        /// <summary>
        /// The maximum QPS during scanning. A valid value ranges from 5 to 20 inclusively. If the field is unspecified
        /// or its value is set 0, server will default to 15. Other values outside of [5, 20] range will be rejected
        /// with INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxQps")]
        public virtual System.Nullable<int> MaxQps { get; set; }

        /// <summary>
        /// The resource name of the ScanConfig. The name follows the format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}'. The ScanConfig IDs are generated by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The schedule of the ScanConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual Schedule Schedule { get; set; }

        /// <summary>Required. The starting URLs from which the scanner finds site pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startingUrls")]
        public virtual System.Collections.Generic.IList<string> StartingUrls { get; set; }

        /// <summary>
        /// Set of Google Cloud platforms targeted by the scan. If empty, APP_ENGINE will be used as a default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPlatforms")]
        public virtual System.Collections.Generic.IList<string> TargetPlatforms { get; set; }

        /// <summary>The user agent used during scanning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ScanRun is a output-only resource representing an actual run of the scan.</summary>
    public class ScanRun : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time at which the ScanRun reached termination state - that the ScanRun is either finished or stopped by
        /// user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The execution state of the ScanRun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionState")]
        public virtual string ExecutionState { get; set; }

        /// <summary>Whether the scan run has found any vulnerabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasVulnerabilities")]
        public virtual System.Nullable<bool> HasVulnerabilities { get; set; }

        /// <summary>
        /// The resource name of the ScanRun. The name follows the format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'. The ScanRun IDs are generated by the
        /// system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The percentage of total completion ranging from 0 to 100. If the scan is in queue, the value is 0. If the
        /// scan is running, the value ranges from 0 to 100. If the scan is finished, the value is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>
        /// The result state of the ScanRun. This field is only available after the execution state reaches "FINISHED".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultState")]
        public virtual string ResultState { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which the ScanRun started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The number of URLs crawled during this ScanRun. If the scan is in progress, the value represents the number
        /// of URLs crawled up to now.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlsCrawledCount")]
        public virtual System.Nullable<long> UrlsCrawledCount { get; set; }

        /// <summary>
        /// The number of URLs tested during this ScanRun. If the scan is in progress, the value represents the number
        /// of URLs tested up to now. The number of URLs tested is usually larger than the number URLS crawled because
        /// typically a crawled URL is tested with multiple test payloads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlsTestedCount")]
        public virtual System.Nullable<long> UrlsTestedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scan schedule configuration.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The duration of time between executions in days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalDurationDays")]
        public virtual System.Nullable<int> IntervalDurationDays { get; set; }

        private string _scheduleTimeRaw;

        private object _scheduleTime;

        /// <summary>
        /// A timestamp indicates when the next run will be scheduled. The value is refreshed by the server after each
        /// run. If unspecified, it will default to current server time, which means the scan will be scheduled to start
        /// immediately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual string ScheduleTimeRaw
        {
            get => _scheduleTimeRaw;
            set
            {
                _scheduleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduleTimeDateTimeOffset instead.")]
        public virtual object ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                _scheduleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduleTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduleTimeRaw);
            set => ScheduleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `StartScanRun` method.</summary>
    public class StartScanRunRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `StopScanRun` method.</summary>
    public class StopScanRunRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information regarding any resource causing the vulnerability such as JavaScript sources, image, audio files,
    /// etc.
    /// </summary>
    public class ViolatingResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The MIME type of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>URL of this violating resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about vulnerable or missing HTTP Headers.</summary>
    public class VulnerableHeaders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of vulnerable headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<Header> Headers { get; set; }

        /// <summary>List of missing headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingHeaders")]
        public virtual System.Collections.Generic.IList<Header> MissingHeaders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about vulnerable request parameters.</summary>
    public class VulnerableParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The vulnerable parameter names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterNames")]
        public virtual System.Collections.Generic.IList<string> ParameterNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information reported for an XSS.</summary>
    public class Xss : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An error message generated by a javascript breakage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Stack traces leading to the point where the XSS occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTraces")]
        public virtual System.Collections.Generic.IList<string> StackTraces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
