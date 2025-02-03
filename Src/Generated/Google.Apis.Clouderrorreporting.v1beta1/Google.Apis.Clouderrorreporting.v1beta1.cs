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

namespace Google.Apis.Clouderrorreporting.v1beta1
{
    /// <summary>The Clouderrorreporting Service.</summary>
    public class ClouderrorreportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ClouderrorreportingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ClouderrorreportingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://clouderrorreporting.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://clouderrorreporting.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "clouderrorreporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Error Reporting API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Error Reporting API.</summary>
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

    /// <summary>A base abstract class for Clouderrorreporting requests.</summary>
    public abstract class ClouderrorreportingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ClouderrorreportingBaseServiceRequest instance.</summary>
        protected ClouderrorreportingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Clouderrorreporting parameter list.</summary>
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
            Events = new EventsResource(service);
            GroupStats = new GroupStatsResource(service);
            Groups = new GroupsResource(service);
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Events resource.</summary>
        public virtual EventsResource Events { get; }

        /// <summary>The "events" collection of methods.</summary>
        public class EventsResource
        {
            private const string Resource = "events";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the specified events.</summary>
            /// <param name="projectName">
            /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}` or
            /// `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform project
            /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region. Examples:
            /// `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of supported
            /// locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is
            /// the default when unspecified.
            /// </param>
            public virtual ListRequest List(string projectName)
            {
                return new ListRequest(this.service, projectName);
            }

            /// <summary>Lists the specified events.</summary>
            public class ListRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ListEventsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
                {
                    ProjectName = projectName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}`
                /// or `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform
                /// project ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region.
                /// Examples: `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of
                /// supported locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support).
                /// `global` is the default when unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectName { get; private set; }

                /// <summary>
                /// Required. The group for which events shall be returned. The `group_id` is a unique identifier for a
                /// particular error group. The identifier is derived from key parts of the error-log content and is
                /// treated as Service Data. For information about how Service Data is handled, see [Google Cloud
                /// Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GroupId { get; set; }

                /// <summary>Optional. The maximum number of results to return per response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A `next_page_token` provided by a previous response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.resource_type`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.resource_type).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.resourceType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterResourceType { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.service`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.service).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.service", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterService { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.version`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.version).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.version", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterVersion { get; set; }

                /// <summary>Restricts the query to the specified time range.</summary>
                [Google.Apis.Util.RequestParameterAttribute("timeRange.period", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<TimeRangePeriodEnum> TimeRangePeriod { get; set; }

                /// <summary>Restricts the query to the specified time range.</summary>
                public enum TimeRangePeriodEnum
                {
                    /// <summary>Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_UNSPECIFIED")]
                    PERIODUNSPECIFIED = 0,

                    /// <summary>
                    /// Retrieve data for the last hour. Recommended minimum timed count duration: 1 min.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_HOUR")]
                    PERIOD1HOUR = 1,

                    /// <summary>
                    /// Retrieve data for the last 6 hours. Recommended minimum timed count duration: 10 min.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_6_HOURS")]
                    PERIOD6HOURS = 2,

                    /// <summary>
                    /// Retrieve data for the last day. Recommended minimum timed count duration: 1 hour.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_DAY")]
                    PERIOD1DAY = 3,

                    /// <summary>
                    /// Retrieve data for the last week. Recommended minimum timed count duration: 6 hours.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_WEEK")]
                    PERIOD1WEEK = 4,

                    /// <summary>
                    /// Retrieve data for the last 30 days. Recommended minimum timed count duration: 1 day.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_30_DAYS")]
                    PERIOD30DAYS = 5,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+projectName}/events";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupId",
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
                    RequestParameters.Add("serviceFilter.resourceType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.resourceType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceFilter.service", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.service",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceFilter.version", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.version",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("timeRange.period", new Google.Apis.Discovery.Parameter
                    {
                        Name = "timeRange.period",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Report an individual error event and record the event to a log. This endpoint accepts **either** an
            /// OAuth token, **or** an [API key](https://support.google.com/cloud/answer/6158862) for authentication. To
            /// use an API key, append it to the URL as the value of a `key` parameter. For example: `POST
            /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456` **Note:**
            /// [Error Reporting] (https://cloud.google.com/error-reporting) is a service built on Cloud Logging and can
            /// analyze log entries when all of the following are true: * Customer-managed encryption keys (CMEK) are
            /// disabled on the log bucket. * The log bucket satisfies one of the following: * The log bucket is stored
            /// in the same project where the logs originated. * The logs were routed to a project, and then that
            /// project stored those logs in a log bucket that it owns.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectName">
            /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectId}`,
            /// where `{projectId}` is the [Google Cloud Platform project
            /// ID](https://support.google.com/cloud/answer/6158840). Example: // `projects/my-project-123`.
            /// </param>
            public virtual ReportRequest Report(Google.Apis.Clouderrorreporting.v1beta1.Data.ReportedErrorEvent body, string projectName)
            {
                return new ReportRequest(this.service, body, projectName);
            }

            /// <summary>
            /// Report an individual error event and record the event to a log. This endpoint accepts **either** an
            /// OAuth token, **or** an [API key](https://support.google.com/cloud/answer/6158862) for authentication. To
            /// use an API key, append it to the URL as the value of a `key` parameter. For example: `POST
            /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456` **Note:**
            /// [Error Reporting] (https://cloud.google.com/error-reporting) is a service built on Cloud Logging and can
            /// analyze log entries when all of the following are true: * Customer-managed encryption keys (CMEK) are
            /// disabled on the log bucket. * The log bucket satisfies one of the following: * The log bucket is stored
            /// in the same project where the logs originated. * The logs were routed to a project, and then that
            /// project stored those logs in a log bucket that it owns.
            /// </summary>
            public class ReportRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ReportErrorEventResponse>
            {
                /// <summary>Constructs a new Report request.</summary>
                public ReportRequest(Google.Apis.Services.IClientService service, Google.Apis.Clouderrorreporting.v1beta1.Data.ReportedErrorEvent body, string projectName) : base(service)
                {
                    ProjectName = projectName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectId}`,
                /// where `{projectId}` is the [Google Cloud Platform project
                /// ID](https://support.google.com/cloud/answer/6158840). Example: // `projects/my-project-123`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Clouderrorreporting.v1beta1.Data.ReportedErrorEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "report";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+projectName}/events:report";

                /// <summary>Initializes Report parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the GroupStats resource.</summary>
        public virtual GroupStatsResource GroupStats { get; }

        /// <summary>The "groupStats" collection of methods.</summary>
        public class GroupStatsResource
        {
            private const string Resource = "groupStats";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GroupStatsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the specified groups.</summary>
            /// <param name="projectName">
            /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}` or
            /// `projects/{projectNumber}`, where `{projectID}` and `{projectNumber}` can be found in the [Google Cloud
            /// console](https://support.google.com/cloud/answer/6158840). It may also include a location, such as
            /// `projects/{projectID}/locations/{location}` where `{location}` is a cloud region. Examples:
            /// `projects/my-project-123`, `projects/5551234`, `projects/my-project-123/locations/us-central1`,
            /// `projects/5551234/locations/us-central1`. For a list of supported locations, see [Supported
            /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
            /// unspecified. Use `-` as a wildcard to request group stats from all regions.
            /// </param>
            public virtual ListRequest List(string projectName)
            {
                return new ListRequest(this.service, projectName);
            }

            /// <summary>Lists the specified groups.</summary>
            public class ListRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ListGroupStatsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
                {
                    ProjectName = projectName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}`
                /// or `projects/{projectNumber}`, where `{projectID}` and `{projectNumber}` can be found in the [Google
                /// Cloud console](https://support.google.com/cloud/answer/6158840). It may also include a location,
                /// such as `projects/{projectID}/locations/{location}` where `{location}` is a cloud region. Examples:
                /// `projects/my-project-123`, `projects/5551234`, `projects/my-project-123/locations/us-central1`,
                /// `projects/5551234/locations/us-central1`. For a list of supported locations, see [Supported
                /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
                /// unspecified. Use `-` as a wildcard to request group stats from all regions.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectName { get; private set; }

                /// <summary>
                /// Optional. The alignment of the timed counts to be returned. Default is `ALIGNMENT_EQUAL_AT_END`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("alignment", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AlignmentEnum> Alignment { get; set; }

                /// <summary>
                /// Optional. The alignment of the timed counts to be returned. Default is `ALIGNMENT_EQUAL_AT_END`.
                /// </summary>
                public enum AlignmentEnum
                {
                    /// <summary>No alignment specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("ERROR_COUNT_ALIGNMENT_UNSPECIFIED")]
                    ERRORCOUNTALIGNMENTUNSPECIFIED = 0,

                    /// <summary>
                    /// The time periods shall be consecutive, have width equal to the requested duration, and be
                    /// aligned at the alignment_time provided in the request. The alignment_time does not have to be
                    /// inside the query period but even if it is outside, only time periods are returned which overlap
                    /// with the query period. A rounded alignment will typically result in a different size of the
                    /// first or the last time period.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGNMENT_EQUAL_ROUNDED")]
                    ALIGNMENTEQUALROUNDED = 1,

                    /// <summary>
                    /// The time periods shall be consecutive, have width equal to the requested duration, and be
                    /// aligned at the end of the requested time period. This can result in a different size of the
                    /// first time period.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGNMENT_EQUAL_AT_END")]
                    ALIGNMENTEQUALATEND = 2,
                }

                private object _alignmentTime;

                /// <summary>
                /// String representation of <see cref="AlignmentTimeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("alignmentTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AlignmentTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="AlignmentTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AlignmentTimeDateTimeOffset instead.")]
                public virtual object AlignmentTime
                {
                    get => _alignmentTime;
                    set
                    {
                        AlignmentTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _alignmentTime = value;
                    }
                }

                public virtual System.DateTimeOffset? AlignmentTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AlignmentTimeRaw);
                    set
                    {
                        AlignmentTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _alignmentTime = value;
                    }
                }

                /// <summary>
                /// Optional. List all ErrorGroupStats with these IDs. The `group_id` is a unique identifier for a
                /// particular error group. The identifier is derived from key parts of the error-log content and is
                /// treated as Service Data. For information about how Service Data is handled, see [Google Cloud
                /// Privacy Notice] (https://cloud.google.com/terms/cloud-privacy-notice).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> GroupId { get; set; }

                /// <summary>
                /// Optional. The sort order in which the results are returned. Default is `COUNT_DESC`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("order", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<OrderEnum> Order { get; set; }

                /// <summary>
                /// Optional. The sort order in which the results are returned. Default is `COUNT_DESC`.
                /// </summary>
                public enum OrderEnum
                {
                    /// <summary>No group order specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("GROUP_ORDER_UNSPECIFIED")]
                    GROUPORDERUNSPECIFIED = 0,

                    /// <summary>Total count of errors in the given time window in descending order.</summary>
                    [Google.Apis.Util.StringValueAttribute("COUNT_DESC")]
                    COUNTDESC = 1,

                    /// <summary>
                    /// Timestamp when the group was last seen in the given time window in descending order.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_SEEN_DESC")]
                    LASTSEENDESC = 2,

                    /// <summary>Timestamp when the group was created in descending order.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATED_DESC")]
                    CREATEDDESC = 3,

                    /// <summary>Number of affected users in the given time window in descending order.</summary>
                    [Google.Apis.Util.StringValueAttribute("AFFECTED_USERS_DESC")]
                    AFFECTEDUSERSDESC = 4,
                }

                /// <summary>Optional. The maximum number of results to return per response. Default is 20.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A next_page_token provided by a previous response. To view additional results, pass this
                /// token along with the identical query parameters as the first request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.resource_type`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.resource_type).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.resourceType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterResourceType { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.service`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.service).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.service", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterService { get; set; }

                /// <summary>
                /// Optional. The exact value to match against
                /// [`ServiceContext.version`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.version).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceFilter.version", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceFilterVersion { get; set; }

                /// <summary>Restricts the query to the specified time range.</summary>
                [Google.Apis.Util.RequestParameterAttribute("timeRange.period", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<TimeRangePeriodEnum> TimeRangePeriod { get; set; }

                /// <summary>Restricts the query to the specified time range.</summary>
                public enum TimeRangePeriodEnum
                {
                    /// <summary>Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_UNSPECIFIED")]
                    PERIODUNSPECIFIED = 0,

                    /// <summary>
                    /// Retrieve data for the last hour. Recommended minimum timed count duration: 1 min.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_HOUR")]
                    PERIOD1HOUR = 1,

                    /// <summary>
                    /// Retrieve data for the last 6 hours. Recommended minimum timed count duration: 10 min.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_6_HOURS")]
                    PERIOD6HOURS = 2,

                    /// <summary>
                    /// Retrieve data for the last day. Recommended minimum timed count duration: 1 hour.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_DAY")]
                    PERIOD1DAY = 3,

                    /// <summary>
                    /// Retrieve data for the last week. Recommended minimum timed count duration: 6 hours.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_1_WEEK")]
                    PERIOD1WEEK = 4,

                    /// <summary>
                    /// Retrieve data for the last 30 days. Recommended minimum timed count duration: 1 day.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PERIOD_30_DAYS")]
                    PERIOD30DAYS = 5,
                }

                /// <summary>
                /// Optional. The preferred duration for a single returned TimedCount. If not set, no timed counts are
                /// returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("timedCountDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object TimedCountDuration { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+projectName}/groupStats";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("alignment", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alignment",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("alignmentTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alignmentTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("order", new Google.Apis.Discovery.Parameter
                    {
                        Name = "order",
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
                    RequestParameters.Add("serviceFilter.resourceType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.resourceType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceFilter.service", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.service",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceFilter.version", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceFilter.version",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("timeRange.period", new Google.Apis.Discovery.Parameter
                    {
                        Name = "timeRange.period",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("timedCountDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "timedCountDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>The "groups" collection of methods.</summary>
        public class GroupsResource
        {
            private const string Resource = "groups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get the specified group.</summary>
            /// <param name="groupName">
            /// Required. The group resource name. Written as either `projects/{projectID}/groups/{group_id}` or
            /// `projects/{projectID}/locations/{location}/groups/{group_id}`. Call groupStats.list to return a list of
            /// groups belonging to this project. Examples: `projects/my-project-123/groups/my-group`,
            /// `projects/my-project-123/locations/global/groups/my-group` In the group resource name, the `group_id` is
            /// a unique identifier for a particular error group. The identifier is derived from key parts of the
            /// error-log content and is treated as Service Data. For information about how Service Data is handled, see
            /// [Google Cloud Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of
            /// supported locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support).
            /// `global` is the default when unspecified.
            /// </param>
            public virtual GetRequest Get(string groupName)
            {
                return new GetRequest(this.service, groupName);
            }

            /// <summary>Get the specified group.</summary>
            public class GetRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string groupName) : base(service)
                {
                    GroupName = groupName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The group resource name. Written as either `projects/{projectID}/groups/{group_id}` or
                /// `projects/{projectID}/locations/{location}/groups/{group_id}`. Call groupStats.list to return a list
                /// of groups belonging to this project. Examples: `projects/my-project-123/groups/my-group`,
                /// `projects/my-project-123/locations/global/groups/my-group` In the group resource name, the
                /// `group_id` is a unique identifier for a particular error group. The identifier is derived from key
                /// parts of the error-log content and is treated as Service Data. For information about how Service
                /// Data is handled, see [Google Cloud Privacy
                /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations, see
                /// [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default
                /// when unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+groupName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("groupName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>Replace the data for the specified group. Fails if the group does not exist.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The group resource name. Written as `projects/{projectID}/groups/{group_id}` or
            /// `projects/{projectID}/locations/{location}/groups/{group_id}` Examples:
            /// `projects/my-project-123/groups/my-group`,
            /// `projects/my-project-123/locations/us-central1/groups/my-group` In the group resource name, the
            /// `group_id` is a unique identifier for a particular error group. The identifier is derived from key parts
            /// of the error-log content and is treated as Service Data. For information about how Service Data is
            /// handled, see [Google Cloud Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a
            /// list of supported locations, see [Supported
            /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
            /// unspecified.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>Replace the data for the specified group. Fails if the group does not exist.</summary>
            public class UpdateRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The group resource name. Written as `projects/{projectID}/groups/{group_id}` or
                /// `projects/{projectID}/locations/{location}/groups/{group_id}` Examples:
                /// `projects/my-project-123/groups/my-group`,
                /// `projects/my-project-123/locations/us-central1/groups/my-group` In the group resource name, the
                /// `group_id` is a unique identifier for a particular error group. The identifier is derived from key
                /// parts of the error-log content and is treated as Service Data. For information about how Service
                /// Data is handled, see [Google Cloud Privacy
                /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations, see
                /// [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default
                /// when unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }
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
                Events = new EventsResource(service);
                GroupStats = new GroupStatsResource(service);
                Groups = new GroupsResource(service);
            }

            /// <summary>Gets the Events resource.</summary>
            public virtual EventsResource Events { get; }

            /// <summary>The "events" collection of methods.</summary>
            public class EventsResource
            {
                private const string Resource = "events";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EventsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the specified events.</summary>
                /// <param name="projectName">
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}`
                /// or `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform
                /// project ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region.
                /// Examples: `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of
                /// supported locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support).
                /// `global` is the default when unspecified.
                /// </param>
                public virtual ListRequest List(string projectName)
                {
                    return new ListRequest(this.service, projectName);
                }

                /// <summary>Lists the specified events.</summary>
                public class ListRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ListEventsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
                    {
                        ProjectName = projectName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Google Cloud Platform project. Written as
                    /// `projects/{projectID}` or `projects/{projectID}/locations/{location}`, where `{projectID}` is
                    /// the [Google Cloud Platform project ID](https://support.google.com/cloud/answer/6158840) and
                    /// `{location}` is a Cloud region. Examples: `projects/my-project-123`,
                    /// `projects/my-project-123/locations/global`. For a list of supported locations, see [Supported
                    /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
                    /// unspecified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectName { get; private set; }

                    /// <summary>
                    /// Required. The group for which events shall be returned. The `group_id` is a unique identifier
                    /// for a particular error group. The identifier is derived from key parts of the error-log content
                    /// and is treated as Service Data. For information about how Service Data is handled, see [Google
                    /// Cloud Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GroupId { get; set; }

                    /// <summary>Optional. The maximum number of results to return per response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A `next_page_token` provided by a previous response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.resource_type`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.resource_type).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.resourceType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterResourceType { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.service`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.service).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.service", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterService { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.version`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.version).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterVersion { get; set; }

                    /// <summary>Restricts the query to the specified time range.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("timeRange.period", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TimeRangePeriodEnum> TimeRangePeriod { get; set; }

                    /// <summary>Restricts the query to the specified time range.</summary>
                    public enum TimeRangePeriodEnum
                    {
                        /// <summary>Do not use.</summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_UNSPECIFIED")]
                        PERIODUNSPECIFIED = 0,

                        /// <summary>
                        /// Retrieve data for the last hour. Recommended minimum timed count duration: 1 min.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_HOUR")]
                        PERIOD1HOUR = 1,

                        /// <summary>
                        /// Retrieve data for the last 6 hours. Recommended minimum timed count duration: 10 min.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_6_HOURS")]
                        PERIOD6HOURS = 2,

                        /// <summary>
                        /// Retrieve data for the last day. Recommended minimum timed count duration: 1 hour.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_DAY")]
                        PERIOD1DAY = 3,

                        /// <summary>
                        /// Retrieve data for the last week. Recommended minimum timed count duration: 6 hours.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_WEEK")]
                        PERIOD1WEEK = 4,

                        /// <summary>
                        /// Retrieve data for the last 30 days. Recommended minimum timed count duration: 1 day.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_30_DAYS")]
                        PERIOD30DAYS = 5,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+projectName}/events";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupId",
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
                        RequestParameters.Add("serviceFilter.resourceType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.resourceType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceFilter.service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.service",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceFilter.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("timeRange.period", new Google.Apis.Discovery.Parameter
                        {
                            Name = "timeRange.period",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the GroupStats resource.</summary>
            public virtual GroupStatsResource GroupStats { get; }

            /// <summary>The "groupStats" collection of methods.</summary>
            public class GroupStatsResource
            {
                private const string Resource = "groupStats";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GroupStatsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the specified groups.</summary>
                /// <param name="projectName">
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}`
                /// or `projects/{projectNumber}`, where `{projectID}` and `{projectNumber}` can be found in the [Google
                /// Cloud console](https://support.google.com/cloud/answer/6158840). It may also include a location,
                /// such as `projects/{projectID}/locations/{location}` where `{location}` is a cloud region. Examples:
                /// `projects/my-project-123`, `projects/5551234`, `projects/my-project-123/locations/us-central1`,
                /// `projects/5551234/locations/us-central1`. For a list of supported locations, see [Supported
                /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
                /// unspecified. Use `-` as a wildcard to request group stats from all regions.
                /// </param>
                public virtual ListRequest List(string projectName)
                {
                    return new ListRequest(this.service, projectName);
                }

                /// <summary>Lists the specified groups.</summary>
                public class ListRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ListGroupStatsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
                    {
                        ProjectName = projectName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Google Cloud Platform project. Written as
                    /// `projects/{projectID}` or `projects/{projectNumber}`, where `{projectID}` and `{projectNumber}`
                    /// can be found in the [Google Cloud console](https://support.google.com/cloud/answer/6158840). It
                    /// may also include a location, such as `projects/{projectID}/locations/{location}` where
                    /// `{location}` is a cloud region. Examples: `projects/my-project-123`, `projects/5551234`,
                    /// `projects/my-project-123/locations/us-central1`, `projects/5551234/locations/us-central1`. For a
                    /// list of supported locations, see [Supported
                    /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
                    /// unspecified. Use `-` as a wildcard to request group stats from all regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectName { get; private set; }

                    /// <summary>
                    /// Optional. The alignment of the timed counts to be returned. Default is `ALIGNMENT_EQUAL_AT_END`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("alignment", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<AlignmentEnum> Alignment { get; set; }

                    /// <summary>
                    /// Optional. The alignment of the timed counts to be returned. Default is `ALIGNMENT_EQUAL_AT_END`.
                    /// </summary>
                    public enum AlignmentEnum
                    {
                        /// <summary>No alignment specified.</summary>
                        [Google.Apis.Util.StringValueAttribute("ERROR_COUNT_ALIGNMENT_UNSPECIFIED")]
                        ERRORCOUNTALIGNMENTUNSPECIFIED = 0,

                        /// <summary>
                        /// The time periods shall be consecutive, have width equal to the requested duration, and be
                        /// aligned at the alignment_time provided in the request. The alignment_time does not have to
                        /// be inside the query period but even if it is outside, only time periods are returned which
                        /// overlap with the query period. A rounded alignment will typically result in a different size
                        /// of the first or the last time period.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ALIGNMENT_EQUAL_ROUNDED")]
                        ALIGNMENTEQUALROUNDED = 1,

                        /// <summary>
                        /// The time periods shall be consecutive, have width equal to the requested duration, and be
                        /// aligned at the end of the requested time period. This can result in a different size of the
                        /// first time period.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ALIGNMENT_EQUAL_AT_END")]
                        ALIGNMENTEQUALATEND = 2,
                    }

                    private object _alignmentTime;

                    /// <summary>
                    /// String representation of <see cref="AlignmentTimeDateTimeOffset"/>, formatted for inclusion in
                    /// the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("alignmentTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AlignmentTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="AlignmentTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AlignmentTimeDateTimeOffset instead.")]
                    public virtual object AlignmentTime
                    {
                        get => _alignmentTime;
                        set
                        {
                            AlignmentTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _alignmentTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? AlignmentTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AlignmentTimeRaw);
                        set
                        {
                            AlignmentTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _alignmentTime = value;
                        }
                    }

                    /// <summary>
                    /// Optional. List all ErrorGroupStats with these IDs. The `group_id` is a unique identifier for a
                    /// particular error group. The identifier is derived from key parts of the error-log content and is
                    /// treated as Service Data. For information about how Service Data is handled, see [Google Cloud
                    /// Privacy Notice] (https://cloud.google.com/terms/cloud-privacy-notice).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> GroupId { get; set; }

                    /// <summary>
                    /// Optional. The sort order in which the results are returned. Default is `COUNT_DESC`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("order", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<OrderEnum> Order { get; set; }

                    /// <summary>
                    /// Optional. The sort order in which the results are returned. Default is `COUNT_DESC`.
                    /// </summary>
                    public enum OrderEnum
                    {
                        /// <summary>No group order specified.</summary>
                        [Google.Apis.Util.StringValueAttribute("GROUP_ORDER_UNSPECIFIED")]
                        GROUPORDERUNSPECIFIED = 0,

                        /// <summary>Total count of errors in the given time window in descending order.</summary>
                        [Google.Apis.Util.StringValueAttribute("COUNT_DESC")]
                        COUNTDESC = 1,

                        /// <summary>
                        /// Timestamp when the group was last seen in the given time window in descending order.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("LAST_SEEN_DESC")]
                        LASTSEENDESC = 2,

                        /// <summary>Timestamp when the group was created in descending order.</summary>
                        [Google.Apis.Util.StringValueAttribute("CREATED_DESC")]
                        CREATEDDESC = 3,

                        /// <summary>Number of affected users in the given time window in descending order.</summary>
                        [Google.Apis.Util.StringValueAttribute("AFFECTED_USERS_DESC")]
                        AFFECTEDUSERSDESC = 4,
                    }

                    /// <summary>
                    /// Optional. The maximum number of results to return per response. Default is 20.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A next_page_token provided by a previous response. To view additional results, pass
                    /// this token along with the identical query parameters as the first request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.resource_type`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.resource_type).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.resourceType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterResourceType { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.service`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.service).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.service", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterService { get; set; }

                    /// <summary>
                    /// Optional. The exact value to match against
                    /// [`ServiceContext.version`](/error-reporting/reference/rest/v1beta1/ServiceContext#FIELDS.version).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceFilter.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceFilterVersion { get; set; }

                    /// <summary>Restricts the query to the specified time range.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("timeRange.period", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TimeRangePeriodEnum> TimeRangePeriod { get; set; }

                    /// <summary>Restricts the query to the specified time range.</summary>
                    public enum TimeRangePeriodEnum
                    {
                        /// <summary>Do not use.</summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_UNSPECIFIED")]
                        PERIODUNSPECIFIED = 0,

                        /// <summary>
                        /// Retrieve data for the last hour. Recommended minimum timed count duration: 1 min.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_HOUR")]
                        PERIOD1HOUR = 1,

                        /// <summary>
                        /// Retrieve data for the last 6 hours. Recommended minimum timed count duration: 10 min.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_6_HOURS")]
                        PERIOD6HOURS = 2,

                        /// <summary>
                        /// Retrieve data for the last day. Recommended minimum timed count duration: 1 hour.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_DAY")]
                        PERIOD1DAY = 3,

                        /// <summary>
                        /// Retrieve data for the last week. Recommended minimum timed count duration: 6 hours.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_1_WEEK")]
                        PERIOD1WEEK = 4,

                        /// <summary>
                        /// Retrieve data for the last 30 days. Recommended minimum timed count duration: 1 day.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PERIOD_30_DAYS")]
                        PERIOD30DAYS = 5,
                    }

                    /// <summary>
                    /// Optional. The preferred duration for a single returned TimedCount. If not set, no timed counts
                    /// are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("timedCountDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object TimedCountDuration { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+projectName}/groupStats";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("alignment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "alignment",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("alignmentTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "alignmentTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("order", new Google.Apis.Discovery.Parameter
                        {
                            Name = "order",
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
                        RequestParameters.Add("serviceFilter.resourceType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.resourceType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceFilter.service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.service",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceFilter.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceFilter.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("timeRange.period", new Google.Apis.Discovery.Parameter
                        {
                            Name = "timeRange.period",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("timedCountDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "timedCountDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Groups resource.</summary>
            public virtual GroupsResource Groups { get; }

            /// <summary>The "groups" collection of methods.</summary>
            public class GroupsResource
            {
                private const string Resource = "groups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get the specified group.</summary>
                /// <param name="groupName">
                /// Required. The group resource name. Written as either `projects/{projectID}/groups/{group_id}` or
                /// `projects/{projectID}/locations/{location}/groups/{group_id}`. Call groupStats.list to return a list
                /// of groups belonging to this project. Examples: `projects/my-project-123/groups/my-group`,
                /// `projects/my-project-123/locations/global/groups/my-group` In the group resource name, the
                /// `group_id` is a unique identifier for a particular error group. The identifier is derived from key
                /// parts of the error-log content and is treated as Service Data. For information about how Service
                /// Data is handled, see [Google Cloud Privacy
                /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations, see
                /// [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default
                /// when unspecified.
                /// </param>
                public virtual GetRequest Get(string groupName)
                {
                    return new GetRequest(this.service, groupName);
                }

                /// <summary>Get the specified group.</summary>
                public class GetRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string groupName) : base(service)
                    {
                        GroupName = groupName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The group resource name. Written as either `projects/{projectID}/groups/{group_id}` or
                    /// `projects/{projectID}/locations/{location}/groups/{group_id}`. Call groupStats.list to return a
                    /// list of groups belonging to this project. Examples: `projects/my-project-123/groups/my-group`,
                    /// `projects/my-project-123/locations/global/groups/my-group` In the group resource name, the
                    /// `group_id` is a unique identifier for a particular error group. The identifier is derived from
                    /// key parts of the error-log content and is treated as Service Data. For information about how
                    /// Service Data is handled, see [Google Cloud Privacy
                    /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations,
                    /// see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the
                    /// default when unspecified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("groupName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string GroupName { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+groupName}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("groupName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Replace the data for the specified group. Fails if the group does not exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The group resource name. Written as `projects/{projectID}/groups/{group_id}` or
                /// `projects/{projectID}/locations/{location}/groups/{group_id}` Examples:
                /// `projects/my-project-123/groups/my-group`,
                /// `projects/my-project-123/locations/us-central1/groups/my-group` In the group resource name, the
                /// `group_id` is a unique identifier for a particular error group. The identifier is derived from key
                /// parts of the error-log content and is treated as Service Data. For information about how Service
                /// Data is handled, see [Google Cloud Privacy
                /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations, see
                /// [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default
                /// when unspecified.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup body, string name)
                {
                    return new UpdateRequest(this.service, body, name);
                }

                /// <summary>Replace the data for the specified group. Fails if the group does not exist.</summary>
                public class UpdateRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The group resource name. Written as `projects/{projectID}/groups/{group_id}` or
                    /// `projects/{projectID}/locations/{location}/groups/{group_id}` Examples:
                    /// `projects/my-project-123/groups/my-group`,
                    /// `projects/my-project-123/locations/us-central1/groups/my-group` In the group resource name, the
                    /// `group_id` is a unique identifier for a particular error group. The identifier is derived from
                    /// key parts of the error-log content and is treated as Service Data. For information about how
                    /// Service Data is handled, see [Google Cloud Privacy
                    /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations,
                    /// see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the
                    /// default when unspecified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Clouderrorreporting.v1beta1.Data.ErrorGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Deletes all error events of a given project.</summary>
            /// <param name="projectName">
            /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}` or
            /// `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform project
            /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region. Examples:
            /// `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of supported
            /// locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is
            /// the default when unspecified.
            /// </param>
            public virtual DeleteEventsRequest DeleteEvents(string projectName)
            {
                return new DeleteEventsRequest(this.service, projectName);
            }

            /// <summary>Deletes all error events of a given project.</summary>
            public class DeleteEventsRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.DeleteEventsResponse>
            {
                /// <summary>Constructs a new DeleteEvents request.</summary>
                public DeleteEventsRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
                {
                    ProjectName = projectName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}`
                /// or `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform
                /// project ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region.
                /// Examples: `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of
                /// supported locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support).
                /// `global` is the default when unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteEvents";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+projectName}/events";

                /// <summary>Initializes DeleteEvents parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Deletes all error events of a given project.</summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}` or
        /// `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region. Examples:
        /// `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of supported locations,
        /// see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
        /// unspecified.
        /// </param>
        public virtual DeleteEventsRequest DeleteEvents(string projectName)
        {
            return new DeleteEventsRequest(this.service, projectName);
        }

        /// <summary>Deletes all error events of a given project.</summary>
        public class DeleteEventsRequest : ClouderrorreportingBaseServiceRequest<Google.Apis.Clouderrorreporting.v1beta1.Data.DeleteEventsResponse>
        {
            /// <summary>Constructs a new DeleteEvents request.</summary>
            public DeleteEventsRequest(Google.Apis.Services.IClientService service, string projectName) : base(service)
            {
                ProjectName = projectName;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the Google Cloud Platform project. Written as `projects/{projectID}` or
            /// `projects/{projectID}/locations/{location}`, where `{projectID}` is the [Google Cloud Platform project
            /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is a Cloud region. Examples:
            /// `projects/my-project-123`, `projects/my-project-123/locations/global`. For a list of supported
            /// locations, see [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is
            /// the default when unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projectName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteEvents";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+projectName}/events";

            /// <summary>Initializes DeleteEvents parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectName", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.Clouderrorreporting.v1beta1.Data
{
    /// <summary>Response message for deleting error events.</summary>
    public class DeleteEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A description of the context in which an error occurred. This data should be provided by the application when
    /// reporting an error, unless the error report has been generated automatically from Google App Engine logs.
    /// </summary>
    public class ErrorContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP request which was processed when the error was triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual HttpRequestContext HttpRequest { get; set; }

        /// <summary>
        /// The location in the source code where the decision was made to report the error, usually the place where it
        /// was logged. For a logged exception this would be the source line where the exception is logged, usually
        /// close to the place where it was caught.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportLocation")]
        public virtual SourceLocation ReportLocation { get; set; }

        /// <summary>
        /// Source code that was used to build the executable which has caused the given error message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceReferences")]
        public virtual System.Collections.Generic.IList<SourceReference> SourceReferences { get; set; }

        /// <summary>
        /// The user who caused or was affected by the crash. This can be a user ID, an email address, or an arbitrary
        /// token that uniquely identifies the user. When sending an error report, leave this field empty if the user
        /// was not logged in. In this case the Error Reporting system will use other data, such as remote IP address,
        /// to distinguish affected users. See `affected_users_count` in `ErrorGroupStats`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error event which is returned by the Error Reporting system.</summary>
    public class ErrorEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data about the context in which the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ErrorContext Context { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// Time when the event occurred as provided in the error report. If the report did not contain a timestamp, the
        /// time the error was received by the Error Reporting system is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The stack trace that was reported or logged by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The `ServiceContext` for which this error was reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceContext")]
        public virtual ServiceContext ServiceContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of a group of similar error events.</summary>
    public class ErrorGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque identifier of the group. This field is assigned by the Error Reporting system and always
        /// populated. In the group resource name, the `group_id` is a unique identifier for a particular error group.
        /// The identifier is derived from key parts of the error-log content and is treated as Service Data. For
        /// information about how Service Data is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// The group resource name. Written as `projects/{projectID}/groups/{group_id}` or
        /// `projects/{projectID}/locations/{location}/groups/{group_id}` Examples:
        /// `projects/my-project-123/groups/my-group`, `projects/my-project-123/locations/us-central1/groups/my-group`
        /// In the group resource name, the `group_id` is a unique identifier for a particular error group. The
        /// identifier is derived from key parts of the error-log content and is treated as Service Data. For
        /// information about how Service Data is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice). For a list of supported locations, see
        /// [Supported Regions](https://cloud.google.com/logging/docs/region-support). `global` is the default when
        /// unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Error group's resolution status. An unspecified resolution status will be interpreted as OPEN
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolutionStatus")]
        public virtual string ResolutionStatus { get; set; }

        /// <summary>Associated tracking issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingIssues")]
        public virtual System.Collections.Generic.IList<TrackingIssue> TrackingIssues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data extracted for a specific group based on certain filter criteria, such as a given time period and/or service
    /// filter.
    /// </summary>
    public class ErrorGroupStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Service contexts with a non-zero error count for the given filter criteria. This list can be truncated if
        /// multiple services are affected. Refer to `num_affected_services` for the total count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedServices")]
        public virtual System.Collections.Generic.IList<ServiceContext> AffectedServices { get; set; }

        /// <summary>
        /// Approximate number of affected users in the given group that match the filter criteria. Users are
        /// distinguished by data in the ErrorContext of the individual error events, such as their login name or their
        /// remote IP address in case of HTTP requests. The number of affected users can be zero even if the number of
        /// errors is non-zero if no data was provided from which the affected user could be deduced. Users are counted
        /// based on data in the request context that was provided in the error report. If more users are implicitly
        /// affected, such as due to a crash of the whole service, this is not reflected here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedUsersCount")]
        public virtual System.Nullable<long> AffectedUsersCount { get; set; }

        /// <summary>Approximate total number of events in the given group that match the filter criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        private string _firstSeenTimeRaw;

        private object _firstSeenTime;

        /// <summary>
        /// Approximate first occurrence that was ever seen for this group and which matches the given filter criteria,
        /// ignoring the time_range that was specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSeenTime")]
        public virtual string FirstSeenTimeRaw
        {
            get => _firstSeenTimeRaw;
            set
            {
                _firstSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstSeenTimeDateTimeOffset instead.")]
        public virtual object FirstSeenTime
        {
            get => _firstSeenTime;
            set
            {
                _firstSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstSeenTimeRaw);
            set => FirstSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Group data that is independent of the filter criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual ErrorGroup Group { get; set; }

        private string _lastSeenTimeRaw;

        private object _lastSeenTime;

        /// <summary>
        /// Approximate last occurrence that was ever seen for this group and which matches the given filter criteria,
        /// ignoring the time_range that was specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSeenTime")]
        public virtual string LastSeenTimeRaw
        {
            get => _lastSeenTimeRaw;
            set
            {
                _lastSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSeenTimeDateTimeOffset instead.")]
        public virtual object LastSeenTime
        {
            get => _lastSeenTime;
            set
            {
                _lastSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSeenTimeRaw);
            set => LastSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The total number of services with a non-zero error count for the given filter criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numAffectedServices")]
        public virtual System.Nullable<int> NumAffectedServices { get; set; }

        /// <summary>
        /// An arbitrary event that is chosen as representative for the whole group. The representative event is
        /// intended to be used as a quick preview for the whole group. Events in the group are usually sufficiently
        /// similar to each other such that showing an arbitrary representative provides insight into the
        /// characteristics of the group as a whole.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("representative")]
        public virtual ErrorEvent Representative { get; set; }

        /// <summary>
        /// Approximate number of occurrences over time. Timed counts returned by ListGroups are guaranteed to be: -
        /// Inside the requested time interval - Non-overlapping, and - Ordered by ascending time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedCounts")]
        public virtual System.Collections.Generic.IList<TimedCount> TimedCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HTTP request data that is related to a reported error. This data should be provided by the application when
    /// reporting an error, unless the error report has been generated automatically from Google App Engine logs.
    /// </summary>
    public class HttpRequestContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of HTTP request, such as `GET`, `POST`, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>The referrer information that is provided with the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrer")]
        public virtual string Referrer { get; set; }

        /// <summary>
        /// The IP address from which the request originated. This can be IPv4, IPv6, or a token which is derived from
        /// the IP address, depending on the data that has been provided in the error report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIp")]
        public virtual string RemoteIp { get; set; }

        /// <summary>The HTTP response status code for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatusCode")]
        public virtual System.Nullable<int> ResponseStatusCode { get; set; }

        /// <summary>The URL of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The user agent information that is provided with the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a set of requested error events.</summary>
    public class ListEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error events which match the given request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorEvents")]
        public virtual System.Collections.Generic.IList<ErrorEvent> ErrorEvents { get; set; }

        /// <summary>
        /// If non-empty, more results are available. Pass this token, along with the same query parameters as the first
        /// request, to view the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _timeRangeBeginRaw;

        private object _timeRangeBegin;

        /// <summary>The timestamp specifies the start time to which the request was restricted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRangeBegin")]
        public virtual string TimeRangeBeginRaw
        {
            get => _timeRangeBeginRaw;
            set
            {
                _timeRangeBegin = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeRangeBeginRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeRangeBeginRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeRangeBeginDateTimeOffset instead.")]
        public virtual object TimeRangeBegin
        {
            get => _timeRangeBegin;
            set
            {
                _timeRangeBeginRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timeRangeBegin = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeRangeBeginRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeRangeBeginDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeRangeBeginRaw);
            set => TimeRangeBeginRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a set of requested error group stats.</summary>
    public class ListGroupStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error group stats which match the given request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorGroupStats")]
        public virtual System.Collections.Generic.IList<ErrorGroupStats> ErrorGroupStats { get; set; }

        /// <summary>
        /// If non-empty, more results are available. Pass this token, along with the same query parameters as the first
        /// request, to view the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _timeRangeBeginRaw;

        private object _timeRangeBegin;

        /// <summary>
        /// The timestamp specifies the start time to which the request was restricted. The start time is set based on
        /// the requested time range. It may be adjusted to a later time if a project has exceeded the storage quota and
        /// older data has been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRangeBegin")]
        public virtual string TimeRangeBeginRaw
        {
            get => _timeRangeBeginRaw;
            set
            {
                _timeRangeBegin = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeRangeBeginRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeRangeBeginRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeRangeBeginDateTimeOffset instead.")]
        public virtual object TimeRangeBegin
        {
            get => _timeRangeBegin;
            set
            {
                _timeRangeBeginRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timeRangeBegin = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeRangeBeginRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeRangeBeginDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeRangeBeginRaw);
            set => TimeRangeBeginRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for reporting an individual error event. Data may be added to this message in the future.
    /// </summary>
    public class ReportErrorEventResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error event which is reported to the Error Reporting system.</summary>
    public class ReportedErrorEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A description of the context in which the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ErrorContext Context { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// Optional. Time when the event occurred. If not provided, the time when the event was received by the Error
        /// Reporting system is used. If provided, the time must not exceed the [logs retention
        /// period](https://cloud.google.com/logging/quotas#logs_retention_periods) in the past, or be more than 24
        /// hours in the future. If an invalid time is provided, then an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. The error message. If no `context.reportLocation` is provided, the message must contain a header
        /// (typically consisting of the exception type name and an error message) and an exception stack trace in one
        /// of the supported programming languages and formats. Supported languages are Java, Python, JavaScript, Ruby,
        /// C#, PHP, and Go. Supported stack trace formats are: * **Java**: Must be the return value of
        /// [`Throwable.printStackTrace()`](https://docs.oracle.com/javase/7/docs/api/java/lang/Throwable.html#printStackTrace%28%29).
        /// * **Python**: Must be the return value of
        /// [`traceback.format_exc()`](https://docs.python.org/2/library/traceback.html#traceback.format_exc). *
        /// **JavaScript**: Must be the value of [`error.stack`](https://github.com/v8/v8/wiki/Stack-Trace-API) as
        /// returned by V8. * **Ruby**: Must contain frames returned by
        /// [`Exception.backtrace`](https://ruby-doc.org/core-2.2.0/Exception.html#method-i-backtrace). * **C#**: Must
        /// be the return value of
        /// [`Exception.ToString()`](https://msdn.microsoft.com/en-us/library/system.exception.tostring.aspx). *
        /// **PHP**: Must be prefixed with `"PHP (Notice|Parse error|Fatal error|Warning): "` and contain the result of
        /// [`(string)$exception`](https://php.net/manual/en/exception.tostring.php). * **Go**: Must be the return value
        /// of [`debug.Stack()`](https://pkg.go.dev/runtime/debug#Stack).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Required. The service context in which this error has occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceContext")]
        public virtual ServiceContext ServiceContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a running service that sends errors. Its version changes over time and multiple versions can run in
    /// parallel.
    /// </summary>
    public class ServiceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of the MonitoredResource. List of possible values: https://cloud.google.com/monitoring/api/resources
        /// Value is set automatically for incoming errors and must not be set when reporting errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// An identifier of the service, such as the name of the executable, job, or Google App Engine service name.
        /// This field is expected to have a low number of values that are relatively stable over time, as opposed to
        /// `version`, which can be changed whenever new code is deployed. Contains the service name for error reports
        /// extracted from Google App Engine logs or `default` if the App Engine default service is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Represents the source code version that the developer provided, which could represent a version label or a
        /// Git SHA-1 hash, for example. For App Engine standard environment, the version is set to the version of the
        /// app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates a location in the source code of the service for which errors are reported. `functionName` must be
    /// provided by the application when reporting an error, unless the error report contains a `message` with a
    /// supported exception stack trace. All fields are optional for the later case.
    /// </summary>
    public class SourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The source code filename, which can include a truncated relative path, or a full path from a production
        /// machine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>
        /// Human-readable name of a function or method. The value can include optional context like the class or
        /// package name. For example, `my.package.MyClass.method` in case of Java.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>1-based. 0 indicates that the line number is unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<int> LineNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a particular snapshot of the source tree used to build and deploy an application.
    /// </summary>
    public class SourceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A URI string identifying the repository. Example:
        /// "https://github.com/GoogleCloudPlatform/kubernetes.git"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// The canonical and persistent identifier of the deployed revision. Example (git):
        /// "0035781c50ec7aa23385dc841529ce8a4b70db1b"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of errors in a given time period. All numbers are approximate since the error events are sampled
    /// before counting them.
    /// </summary>
    public class TimedCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Approximate number of occurrences in the given time period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End of the time period to which `count` refers (excluded).</summary>
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

        /// <summary>Start of the time period to which `count` refers (included).</summary>
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

    /// <summary>Information related to tracking the progress on resolving the error.</summary>
    public class TrackingIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A URL pointing to a related entry in an issue tracking system. Example:
        /// `https://github.com/user/project/issues/4`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
