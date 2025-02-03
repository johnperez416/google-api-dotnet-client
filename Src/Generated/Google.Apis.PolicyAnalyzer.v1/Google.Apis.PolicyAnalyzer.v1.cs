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

namespace Google.Apis.PolicyAnalyzer.v1
{
    /// <summary>The PolicyAnalyzer Service.</summary>
    public class PolicyAnalyzerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PolicyAnalyzerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PolicyAnalyzerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://policyanalyzer.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://policyanalyzer.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "policyanalyzer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Policy Analyzer API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Policy Analyzer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for PolicyAnalyzer requests.</summary>
    public abstract class PolicyAnalyzerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PolicyAnalyzerBaseServiceRequest instance.</summary>
        protected PolicyAnalyzerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PolicyAnalyzer parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ActivityTypes = new ActivityTypesResource(service);
            }

            /// <summary>Gets the ActivityTypes resource.</summary>
            public virtual ActivityTypesResource ActivityTypes { get; }

            /// <summary>The "activityTypes" collection of methods.</summary>
            public class ActivityTypesResource
            {
                private const string Resource = "activityTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ActivityTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Activities = new ActivitiesResource(service);
                }

                /// <summary>Gets the Activities resource.</summary>
                public virtual ActivitiesResource Activities { get; }

                /// <summary>The "activities" collection of methods.</summary>
                public class ActivitiesResource
                {
                    private const string Resource = "activities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ActivitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats:
                    /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                    /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                    /// </param>
                    public virtual QueryRequest Query(string parent)
                    {
                        return new QueryRequest(this.service, parent);
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    public class QueryRequest : PolicyAnalyzerBaseServiceRequest<Google.Apis.PolicyAnalyzer.v1.Data.GoogleCloudPolicyanalyzerV1QueryActivityResponse>
                    {
                        /// <summary>Constructs a new Query request.</summary>
                        public QueryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats:
                        /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                        /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the activities returned. For
                        /// serviceAccountLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account. For
                        /// serviceAccountKeyLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account key.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Max limit is 1000.
                        /// Non-positive values are ignored. The presence of `nextPageToken` in the response indicates
                        /// that more results might be available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. `pageToken` must be the value of `nextPageToken` from the previous response.
                        /// The values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "query";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/activities:query";

                        /// <summary>Initializes Query parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^folders/[^/]+/locations/[^/]+/activityTypes/[^/]+$",
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
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ActivityTypes = new ActivityTypesResource(service);
            }

            /// <summary>Gets the ActivityTypes resource.</summary>
            public virtual ActivityTypesResource ActivityTypes { get; }

            /// <summary>The "activityTypes" collection of methods.</summary>
            public class ActivityTypesResource
            {
                private const string Resource = "activityTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ActivityTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Activities = new ActivitiesResource(service);
                }

                /// <summary>Gets the Activities resource.</summary>
                public virtual ActivitiesResource Activities { get; }

                /// <summary>The "activities" collection of methods.</summary>
                public class ActivitiesResource
                {
                    private const string Resource = "activities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ActivitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats:
                    /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                    /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                    /// </param>
                    public virtual QueryRequest Query(string parent)
                    {
                        return new QueryRequest(this.service, parent);
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    public class QueryRequest : PolicyAnalyzerBaseServiceRequest<Google.Apis.PolicyAnalyzer.v1.Data.GoogleCloudPolicyanalyzerV1QueryActivityResponse>
                    {
                        /// <summary>Constructs a new Query request.</summary>
                        public QueryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats:
                        /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                        /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the activities returned. For
                        /// serviceAccountLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account. For
                        /// serviceAccountKeyLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account key.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Max limit is 1000.
                        /// Non-positive values are ignored. The presence of `nextPageToken` in the response indicates
                        /// that more results might be available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. `pageToken` must be the value of `nextPageToken` from the previous response.
                        /// The values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "query";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/activities:query";

                        /// <summary>Initializes Query parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/activityTypes/[^/]+$",
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
            }
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ActivityTypes = new ActivityTypesResource(service);
            }

            /// <summary>Gets the ActivityTypes resource.</summary>
            public virtual ActivityTypesResource ActivityTypes { get; }

            /// <summary>The "activityTypes" collection of methods.</summary>
            public class ActivityTypesResource
            {
                private const string Resource = "activityTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ActivityTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Activities = new ActivitiesResource(service);
                }

                /// <summary>Gets the Activities resource.</summary>
                public virtual ActivitiesResource Activities { get; }

                /// <summary>The "activities" collection of methods.</summary>
                public class ActivitiesResource
                {
                    private const string Resource = "activities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ActivitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats:
                    /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                    /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                    /// </param>
                    public virtual QueryRequest Query(string parent)
                    {
                        return new QueryRequest(this.service, parent);
                    }

                    /// <summary>Queries policy activities on Google Cloud resources.</summary>
                    public class QueryRequest : PolicyAnalyzerBaseServiceRequest<Google.Apis.PolicyAnalyzer.v1.Data.GoogleCloudPolicyanalyzerV1QueryActivityResponse>
                    {
                        /// <summary>Constructs a new Query request.</summary>
                        public QueryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats:
                        /// `projects/[PROJECT_ID|PROJECT_NUMBER]/locations/[LOCATION]/activityTypes/[ACTIVITY_TYPE]`
                        /// LOCATION here refers to Google Cloud Locations: https://cloud.google.com/about/locations/
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the activities returned. For
                        /// serviceAccountLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account. For
                        /// serviceAccountKeyLastAuthentication activities, supported filters are: -
                        /// `activities.full_resource_name {=} [STRING]` - `activities.fullResourceName {=} [STRING]`
                        /// where `[STRING]` is the full resource name of the service account key.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Max limit is 1000.
                        /// Non-positive values are ignored. The presence of `nextPageToken` in the response indicates
                        /// that more results might be available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, then retrieve the next batch of results from the preceding call to
                        /// this method. `pageToken` must be the value of `nextPageToken` from the previous response.
                        /// The values of other method parameters should be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "query";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/activities:query";

                        /// <summary>Initializes Query parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/activityTypes/[^/]+$",
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
            }
        }
    }
}
namespace Google.Apis.PolicyAnalyzer.v1.Data
{
    /// <summary>Represents Activity on a GCP resource over specific observation period.</summary>
    public class GoogleCloudPolicyanalyzerV1Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A struct of custom fields to explain the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activity")]
        public virtual System.Collections.Generic.IDictionary<string, object> Activity { get; set; }

        /// <summary>The type of the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityType")]
        public virtual string ActivityType { get; set; }

        /// <summary>
        /// The full resource name that identifies the resource. For examples of full resource names for Google Cloud
        /// services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The data observation period to build the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationPeriod")]
        public virtual GoogleCloudPolicyanalyzerV1ObservationPeriod ObservationPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents data observation period.</summary>
    public class GoogleCloudPolicyanalyzerV1ObservationPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The observation end time. The time in this timestamp is always `07:00:00Z`.</summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The observation start time. The time in this timestamp is always `07:00:00Z`.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the `QueryActivity` method.</summary>
    public class GoogleCloudPolicyanalyzerV1QueryActivityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of activities that match the filter included in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activities")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicyanalyzerV1Activity> Activities { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `nextPageToken` is included. To
        /// get the next set of results, call this method again using the value of `nextPageToken` as `pageToken`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
