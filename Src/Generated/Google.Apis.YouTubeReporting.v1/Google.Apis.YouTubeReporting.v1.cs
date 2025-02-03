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

namespace Google.Apis.YouTubeReporting.v1
{
    /// <summary>The YouTubeReporting Service.</summary>
    public class YouTubeReportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public YouTubeReportingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public YouTubeReportingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Jobs = new JobsResource(this);
            Media = new MediaResource(this);
            ReportTypes = new ReportTypesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://youtubereporting.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://youtubereporting.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "youtubereporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the YouTube Reporting API.</summary>
        public class Scope
        {
            /// <summary>View monetary and non-monetary YouTube Analytics reports for your YouTube content</summary>
            public static string YtAnalyticsMonetaryReadonly = "https://www.googleapis.com/auth/yt-analytics-monetary.readonly";

            /// <summary>View YouTube Analytics reports for your YouTube content</summary>
            public static string YtAnalyticsReadonly = "https://www.googleapis.com/auth/yt-analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the YouTube Reporting API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View monetary and non-monetary YouTube Analytics reports for your YouTube content</summary>
            public const string YtAnalyticsMonetaryReadonly = "https://www.googleapis.com/auth/yt-analytics-monetary.readonly";

            /// <summary>View YouTube Analytics reports for your YouTube content</summary>
            public const string YtAnalyticsReadonly = "https://www.googleapis.com/auth/yt-analytics.readonly";
        }

        /// <summary>Gets the Jobs resource.</summary>
        public virtual JobsResource Jobs { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the ReportTypes resource.</summary>
        public virtual ReportTypesResource ReportTypes { get; }
    }

    /// <summary>A base abstract class for YouTubeReporting requests.</summary>
    public abstract class YouTubeReportingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new YouTubeReportingBaseServiceRequest instance.</summary>
        protected YouTubeReportingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes YouTubeReporting parameter list.</summary>
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

    /// <summary>The "jobs" collection of methods.</summary>
    public class JobsResource
    {
        private const string Resource = "jobs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JobsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Reports = new ReportsResource(service);
        }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>The "reports" collection of methods.</summary>
        public class ReportsResource
        {
            private const string Resource = "reports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the metadata of a specific report.</summary>
            /// <param name="jobId">The ID of the job.</param>
            /// <param name="reportId">The ID of the report to retrieve.</param>
            public virtual GetRequest Get(string jobId, string reportId)
            {
                return new GetRequest(this.service, jobId, reportId);
            }

            /// <summary>Gets the metadata of a specific report.</summary>
            public class GetRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.Report>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string jobId, string reportId) : base(service)
                {
                    JobId = jobId;
                    ReportId = reportId;
                    InitParameters();
                }

                /// <summary>The ID of the job.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                /// <summary>The ID of the report to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ReportId { get; private set; }

                /// <summary>
                /// The content owner's external ID on which behalf the user is acting on. If not set, the user is
                /// acting for himself (his own channel).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OnBehalfOfContentOwner { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/jobs/{jobId}/reports/{reportId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reportId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "onBehalfOfContentOwner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists reports created by a specific job. Returns NOT_FOUND if the job does not exist.</summary>
            /// <param name="jobId">The ID of the job.</param>
            public virtual ListRequest List(string jobId)
            {
                return new ListRequest(this.service, jobId);
            }

            /// <summary>Lists reports created by a specific job. Returns NOT_FOUND if the job does not exist.</summary>
            public class ListRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.ListReportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string jobId) : base(service)
                {
                    JobId = jobId;
                    InitParameters();
                }

                /// <summary>The ID of the job.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                private object _createdAfter;

                /// <summary>
                /// String representation of <see cref="CreatedAfterDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("createdAfter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CreatedAfterRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="CreatedAfterRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedAfterDateTimeOffset instead.")]
                public virtual object CreatedAfter
                {
                    get => _createdAfter;
                    set
                    {
                        CreatedAfterRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _createdAfter = value;
                    }
                }

                public virtual System.DateTimeOffset? CreatedAfterDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreatedAfterRaw);
                    set
                    {
                        CreatedAfterRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _createdAfter = value;
                    }
                }

                /// <summary>
                /// The content owner's external ID on which behalf the user is acting on. If not set, the user is
                /// acting for himself (his own channel).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OnBehalfOfContentOwner { get; set; }

                /// <summary>
                /// Requested page size. Server may return fewer report types than requested. If unspecified, server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListReportsResponse.next_page_token returned in response to the previous call to the `ListReports`
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                private object _startTimeAtOrAfter;

                /// <summary>
                /// String representation of <see cref="StartTimeAtOrAfterDateTimeOffset"/>, formatted for inclusion in
                /// the HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTimeAtOrAfter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartTimeAtOrAfterRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="StartTimeAtOrAfterRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeAtOrAfterDateTimeOffset instead.")]
                public virtual object StartTimeAtOrAfter
                {
                    get => _startTimeAtOrAfter;
                    set
                    {
                        StartTimeAtOrAfterRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _startTimeAtOrAfter = value;
                    }
                }

                public virtual System.DateTimeOffset? StartTimeAtOrAfterDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeAtOrAfterRaw);
                    set
                    {
                        StartTimeAtOrAfterRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _startTimeAtOrAfter = value;
                    }
                }

                private object _startTimeBefore;

                /// <summary>
                /// String representation of <see cref="StartTimeBeforeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTimeBefore", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartTimeBeforeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="StartTimeBeforeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeBeforeDateTimeOffset instead.")]
                public virtual object StartTimeBefore
                {
                    get => _startTimeBefore;
                    set
                    {
                        StartTimeBeforeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _startTimeBefore = value;
                    }
                }

                public virtual System.DateTimeOffset? StartTimeBeforeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeBeforeRaw);
                    set
                    {
                        StartTimeBeforeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _startTimeBefore = value;
                    }
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/jobs/{jobId}/reports";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("createdAfter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "createdAfter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "onBehalfOfContentOwner",
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
                    RequestParameters.Add("startTimeAtOrAfter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTimeAtOrAfter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startTimeBefore", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTimeBefore",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Creates a job and returns it.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.YouTubeReporting.v1.Data.Job body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates a job and returns it.</summary>
        public class CreateRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.Job>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTubeReporting.v1.Data.Job body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting
            /// for himself (his own channel).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTubeReporting.v1.Data.Job Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/jobs";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a job.</summary>
        /// <param name="jobId">The ID of the job to delete.</param>
        public virtual DeleteRequest Delete(string jobId)
        {
            return new DeleteRequest(this.service, jobId);
        }

        /// <summary>Deletes a job.</summary>
        public class DeleteRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string jobId) : base(service)
            {
                JobId = jobId;
                InitParameters();
            }

            /// <summary>The ID of the job to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting
            /// for himself (his own channel).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/jobs/{jobId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a job.</summary>
        /// <param name="jobId">The ID of the job to retrieve.</param>
        public virtual GetRequest Get(string jobId)
        {
            return new GetRequest(this.service, jobId);
        }

        /// <summary>Gets a job.</summary>
        public class GetRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.Job>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string jobId) : base(service)
            {
                JobId = jobId;
                InitParameters();
            }

            /// <summary>The ID of the job to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string JobId { get; private set; }

            /// <summary>
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting
            /// for himself (his own channel).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/jobs/{jobId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                {
                    Name = "jobId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists jobs.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists jobs.</summary>
        public class ListRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.ListJobsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// If set to true, also system-managed jobs will be returned; otherwise only user-created jobs will be
            /// returned. System-managed jobs can neither be modified nor deleted.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeSystemManaged", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeSystemManaged { get; set; }

            /// <summary>
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting
            /// for himself (his own channel).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Requested page size. Server may return fewer jobs than requested. If unspecified, server will pick an
            /// appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying a page of results the server should return. Typically, this is the value of
            /// ListReportTypesResponse.next_page_token returned in response to the previous call to the `ListJobs`
            /// method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/jobs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("includeSystemManaged", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeSystemManaged",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
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

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Method for media download. Download is supported on the URI `/v1/media/{+name}?alt=media`.
        /// </summary>
        /// <param name="resourceName">Name of the media that is being downloaded.</param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(this.service, resourceName);
        }

        /// <summary>
        /// Method for media download. Download is supported on the URI `/v1/media/{+name}?alt=media`.
        /// </summary>
        public class DownloadRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.GdataMedia>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }
    }

    /// <summary>The "reportTypes" collection of methods.</summary>
    public class ReportTypesResource
    {
        private const string Resource = "reportTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReportTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists report types.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists report types.</summary>
        public class ListRequest : YouTubeReportingBaseServiceRequest<Google.Apis.YouTubeReporting.v1.Data.ListReportTypesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// If set to true, also system-managed report types will be returned; otherwise only the report types that
            /// can be used to create new reporting jobs will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeSystemManaged", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeSystemManaged { get; set; }

            /// <summary>
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting
            /// for himself (his own channel).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Requested page size. Server may return fewer report types than requested. If unspecified, server will
            /// pick an appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying a page of results the server should return. Typically, this is the value of
            /// ListReportTypesResponse.next_page_token returned in response to the previous call to the
            /// `ListReportTypes` method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/reportTypes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("includeSystemManaged", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeSystemManaged",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
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
namespace Google.Apis.YouTubeReporting.v1.Data
{
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

    /// <summary>gdata</summary>
    public class GdataBlobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataCompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual GdataBlobstore2Info Blobstore2Info { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual GdataObjectId ObjectId { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual GdataCompositeMedia ChecksumsLocation { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual GdataCompositeMedia ObjectLocation { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual GdataCompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual GdataCompositeMedia ChecksumsInfo { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual GdataCompositeMedia ObjectInfo { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual GdataCompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataDownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual GdataBlobstore2Info Blobstore2Info { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<GdataCompositeMedia> CompositeMedia { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual GdataContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual GdataDiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual GdataDiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual GdataDiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual GdataDiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual GdataDiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual GdataDownloadParameters DownloadParameters { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual GdataObjectId ObjectId { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>gdata</summary>
    public class GdataObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>gdata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A job creating reports of a specific type.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation date/time of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The date/time when this job will expire/expired. After a job expired, no new reports are generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The server-generated ID of the job (max. 40 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the job (max. 100 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The type of reports this job creates. Corresponds to the ID of a ReportType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTypeId")]
        public virtual string ReportTypeId { get; set; }

        /// <summary>True if this a system-managed job that cannot be modified by the user; otherwise false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemManaged")]
        public virtual System.Nullable<bool> SystemManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ReportingService.ListJobs.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in the ListJobsRequest.page_token field in the
        /// subsequent call to `ListJobs` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ReportingService.ListReportTypes.</summary>
    public class ListReportTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve next page of results. Pass this value in the ListReportTypesRequest.page_token field in
        /// the subsequent call to `ListReportTypes` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of report types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTypes")]
        public virtual System.Collections.Generic.IList<ReportType> ReportTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ReportingService.ListReports.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve next page of results. Pass this value in the ListReportsRequest.page_token field in the
        /// subsequent call to `ListReports` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of report types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A report's metadata including the URL from which the report itself can be downloaded.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The date/time when this report was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The URL from which the report can be downloaded (max. 1000 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The end of the time period that the report instance covers. The value is exclusive.</summary>
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

        /// <summary>The server-generated ID of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        private string _jobExpireTimeRaw;

        private object _jobExpireTime;

        /// <summary>The date/time when the job this report belongs to will expire/expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobExpireTime")]
        public virtual string JobExpireTimeRaw
        {
            get => _jobExpireTimeRaw;
            set
            {
                _jobExpireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _jobExpireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="JobExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use JobExpireTimeDateTimeOffset instead.")]
        public virtual object JobExpireTime
        {
            get => _jobExpireTime;
            set
            {
                _jobExpireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _jobExpireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="JobExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? JobExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(JobExpireTimeRaw);
            set => JobExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ID of the job that created this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The start of the time period that the report instance covers. The value is inclusive.</summary>
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

    /// <summary>A report type.</summary>
    public class ReportType : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _deprecateTimeRaw;

        private object _deprecateTime;

        /// <summary>The date/time when this report type was/will be deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecateTime")]
        public virtual string DeprecateTimeRaw
        {
            get => _deprecateTimeRaw;
            set
            {
                _deprecateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deprecateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeprecateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeprecateTimeDateTimeOffset instead.")]
        public virtual object DeprecateTime
        {
            get => _deprecateTime;
            set
            {
                _deprecateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deprecateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeprecateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeprecateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeprecateTimeRaw);
            set => DeprecateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ID of the report type (max. 100 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the report type (max. 100 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// True if this a system-managed report type; otherwise false. Reporting jobs for system-managed report types
        /// are created automatically and can thus not be used in the `CreateJob` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemManaged")]
        public virtual System.Nullable<bool> SystemManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
