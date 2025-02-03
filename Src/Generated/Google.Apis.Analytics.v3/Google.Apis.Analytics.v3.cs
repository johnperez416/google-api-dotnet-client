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

namespace Google.Apis.Analytics.v3
{
    /// <summary>The Analytics Service.</summary>
    public class AnalyticsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AnalyticsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AnalyticsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Data = new DataResource(this);
            Management = new ManagementResource(this);
            Metadata = new MetadataResource(this);
            Provisioning = new ProvisioningResource(this);
            UserDeletion = new UserDeletionResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://analytics.googleapis.com/analytics/v3/");
            BatchUri = GetEffectiveUri(null, "https://analytics.googleapis.com/batch/analytics/v3");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analytics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "analytics/v3/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/analytics/v3";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Analytics API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public static string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>Edit Google Analytics management entities</summary>
            public static string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>Manage Google Analytics Account users by email address</summary>
            public static string AnalyticsManageUsers = "https://www.googleapis.com/auth/analytics.manage.users";

            /// <summary>View Google Analytics user permissions</summary>
            public static string AnalyticsManageUsersReadonly = "https://www.googleapis.com/auth/analytics.manage.users.readonly";

            /// <summary>Create a new Google Analytics account along with its default property and view</summary>
            public static string AnalyticsProvision = "https://www.googleapis.com/auth/analytics.provision";

            /// <summary>View your Google Analytics data</summary>
            public static string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";

            /// <summary>Manage Google Analytics user deletion requests</summary>
            public static string AnalyticsUserDeletion = "https://www.googleapis.com/auth/analytics.user.deletion";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Analytics API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public const string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>Edit Google Analytics management entities</summary>
            public const string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>Manage Google Analytics Account users by email address</summary>
            public const string AnalyticsManageUsers = "https://www.googleapis.com/auth/analytics.manage.users";

            /// <summary>View Google Analytics user permissions</summary>
            public const string AnalyticsManageUsersReadonly = "https://www.googleapis.com/auth/analytics.manage.users.readonly";

            /// <summary>Create a new Google Analytics account along with its default property and view</summary>
            public const string AnalyticsProvision = "https://www.googleapis.com/auth/analytics.provision";

            /// <summary>View your Google Analytics data</summary>
            public const string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";

            /// <summary>Manage Google Analytics user deletion requests</summary>
            public const string AnalyticsUserDeletion = "https://www.googleapis.com/auth/analytics.user.deletion";
        }

        /// <summary>Gets the Data resource.</summary>
        public virtual DataResource Data { get; }

        /// <summary>Gets the Management resource.</summary>
        public virtual ManagementResource Management { get; }

        /// <summary>Gets the Metadata resource.</summary>
        public virtual MetadataResource Metadata { get; }

        /// <summary>Gets the Provisioning resource.</summary>
        public virtual ProvisioningResource Provisioning { get; }

        /// <summary>Gets the UserDeletion resource.</summary>
        public virtual UserDeletionResource UserDeletion { get; }
    }

    /// <summary>A base abstract class for Analytics requests.</summary>
    public abstract class AnalyticsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AnalyticsBaseServiceRequest instance.</summary>
        protected AnalyticsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,
        }

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
        /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Analytics parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
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
                DefaultValue = "false",
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
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "data" collection of methods.</summary>
    public class DataResource
    {
        private const string Resource = "data";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DataResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Ga = new GaResource(service);
            Mcf = new McfResource(service);
            Realtime = new RealtimeResource(service);
        }

        /// <summary>Gets the Ga resource.</summary>
        public virtual GaResource Ga { get; }

        /// <summary>The "ga" collection of methods.</summary>
        public class GaResource
        {
            private const string Resource = "ga";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GaResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns Analytics data for a view (profile).</summary>
            /// <param name="ids">
            /// Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the
            /// Analytics view (profile) ID.
            /// </param>
            /// <param name="startDate">
            /// Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as
            /// a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
            /// </param>
            /// <param name="endDate">
            /// End date for fetching Analytics data. Request can should specify an end date formatted as YYYY-MM-DD, or
            /// as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is yesterday.
            /// </param>
            /// <param name="metrics">
            /// A comma-separated list of Analytics metrics. E.g., 'ga:sessions,ga:pageviews'. At least one metric must
            /// be specified.
            /// </param>
            public virtual GetRequest Get(string ids, string startDate, string endDate, string metrics)
            {
                return new GetRequest(this.service, ids, startDate, endDate, metrics);
            }

            /// <summary>Returns Analytics data for a view (profile).</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.GaData>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string ids, string startDate, string endDate, string metrics) : base(service)
                {
                    Ids = ids;
                    StartDate = startDate;
                    EndDate = endDate;
                    Metrics = metrics;
                    InitParameters();
                }

                /// <summary>
                /// Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the
                /// Analytics view (profile) ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Ids { get; private set; }

                /// <summary>
                /// Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD,
                /// or as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate { get; private set; }

                /// <summary>
                /// End date for fetching Analytics data. Request can should specify an end date formatted as
                /// YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is
                /// yesterday.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("end-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate { get; private set; }

                /// <summary>
                /// A comma-separated list of Analytics metrics. E.g., 'ga:sessions,ga:pageviews'. At least one metric
                /// must be specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Metrics { get; private set; }

                /// <summary>A comma-separated list of Analytics dimensions. E.g., 'ga:browser,ga:city'.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Dimensions { get; set; }

                /// <summary>
                /// A comma-separated list of dimension or metric filters to be applied to Analytics data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filters { get; set; }

                /// <summary>
                /// The response will include empty rows if this parameter is set to true, the default is true
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("include-empty-rows", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeEmptyRows { get; set; }

                /// <summary>The maximum number of entries to include in this feed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>The selected format for the response. Default format is JSON.</summary>
                [Google.Apis.Util.RequestParameterAttribute("output", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<OutputEnum> Output { get; set; }

                /// <summary>The selected format for the response. Default format is JSON.</summary>
                public enum OutputEnum
                {
                    /// <summary>
                    /// Returns the response in Google Charts Data Table format. This is useful in creating
                    /// visualization using Google Charts.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("dataTable")]
                    DataTable = 0,

                    /// <summary>Returns the response in standard JSON format.</summary>
                    [Google.Apis.Util.StringValueAttribute("json")]
                    Json = 1,
                }

                /// <summary>The desired sampling level.</summary>
                [Google.Apis.Util.RequestParameterAttribute("samplingLevel", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SamplingLevelEnum> SamplingLevel { get; set; }

                /// <summary>The desired sampling level.</summary>
                public enum SamplingLevelEnum
                {
                    /// <summary>Returns response with a sample size that balances speed and accuracy.</summary>
                    [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                    DEFAULT__ = 0,

                    /// <summary>Returns a fast response with a smaller sample size.</summary>
                    [Google.Apis.Util.StringValueAttribute("FASTER")]
                    FASTER = 1,

                    /// <summary>
                    /// Returns a more accurate response using a large sample size, but this may result in the response
                    /// being slower.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HIGHER_PRECISION")]
                    HIGHERPRECISION = 2,
                }

                /// <summary>An Analytics segment to be applied to data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("segment", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Segment { get; set; }

                /// <summary>
                /// A comma-separated list of dimensions or metrics that determine the sort order for Analytics data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "data/ga";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("ids", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ids",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"ga:[0-9]+",
                    });
                    RequestParameters.Add("start-date", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-date",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[0-9]{4}-[0-9]{2}-[0-9]{2}|today|yesterday|[0-9]+(daysAgo)",
                    });
                    RequestParameters.Add("end-date", new Google.Apis.Discovery.Parameter
                    {
                        Name = "end-date",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[0-9]{4}-[0-9]{2}-[0-9]{2}|today|yesterday|[0-9]+(daysAgo)",
                    });
                    RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metrics",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"ga:.+",
                    });
                    RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimensions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(ga:.+)?",
                    });
                    RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filters",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"ga:.+",
                    });
                    RequestParameters.Add("include-empty-rows", new Google.Apis.Discovery.Parameter
                    {
                        Name = "include-empty-rows",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("output", new Google.Apis.Discovery.Parameter
                    {
                        Name = "output",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("samplingLevel", new Google.Apis.Discovery.Parameter
                    {
                        Name = "samplingLevel",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("segment", new Google.Apis.Discovery.Parameter
                    {
                        Name = "segment",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sort",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(-)?ga:.+",
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Mcf resource.</summary>
        public virtual McfResource Mcf { get; }

        /// <summary>The "mcf" collection of methods.</summary>
        public class McfResource
        {
            private const string Resource = "mcf";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public McfResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns Analytics Multi-Channel Funnels data for a view (profile).</summary>
            /// <param name="ids">
            /// Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the
            /// Analytics view (profile) ID.
            /// </param>
            /// <param name="startDate">
            /// Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as
            /// a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
            /// </param>
            /// <param name="endDate">
            /// End date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as a
            /// relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
            /// </param>
            /// <param name="metrics">
            /// A comma-separated list of Multi-Channel Funnels metrics. E.g.,
            /// 'mcf:totalConversions,mcf:totalConversionValue'. At least one metric must be specified.
            /// </param>
            public virtual GetRequest Get(string ids, string startDate, string endDate, string metrics)
            {
                return new GetRequest(this.service, ids, startDate, endDate, metrics);
            }

            /// <summary>Returns Analytics Multi-Channel Funnels data for a view (profile).</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.McfData>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string ids, string startDate, string endDate, string metrics) : base(service)
                {
                    Ids = ids;
                    StartDate = startDate;
                    EndDate = endDate;
                    Metrics = metrics;
                    InitParameters();
                }

                /// <summary>
                /// Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the
                /// Analytics view (profile) ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Ids { get; private set; }

                /// <summary>
                /// Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD,
                /// or as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate { get; private set; }

                /// <summary>
                /// End date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or
                /// as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("end-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate { get; private set; }

                /// <summary>
                /// A comma-separated list of Multi-Channel Funnels metrics. E.g.,
                /// 'mcf:totalConversions,mcf:totalConversionValue'. At least one metric must be specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Metrics { get; private set; }

                /// <summary>
                /// A comma-separated list of Multi-Channel Funnels dimensions. E.g., 'mcf:source,mcf:medium'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Dimensions { get; set; }

                /// <summary>
                /// A comma-separated list of dimension or metric filters to be applied to the Analytics data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filters { get; set; }

                /// <summary>The maximum number of entries to include in this feed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>The desired sampling level.</summary>
                [Google.Apis.Util.RequestParameterAttribute("samplingLevel", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SamplingLevelEnum> SamplingLevel { get; set; }

                /// <summary>The desired sampling level.</summary>
                public enum SamplingLevelEnum
                {
                    /// <summary>Returns response with a sample size that balances speed and accuracy.</summary>
                    [Google.Apis.Util.StringValueAttribute("DEFAULT")]
                    DEFAULT__ = 0,

                    /// <summary>Returns a fast response with a smaller sample size.</summary>
                    [Google.Apis.Util.StringValueAttribute("FASTER")]
                    FASTER = 1,

                    /// <summary>
                    /// Returns a more accurate response using a large sample size, but this may result in the response
                    /// being slower.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HIGHER_PRECISION")]
                    HIGHERPRECISION = 2,
                }

                /// <summary>
                /// A comma-separated list of dimensions or metrics that determine the sort order for the Analytics
                /// data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "data/mcf";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("ids", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ids",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"ga:[0-9]+",
                    });
                    RequestParameters.Add("start-date", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-date",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[0-9]{4}-[0-9]{2}-[0-9]{2}|today|yesterday|[0-9]+(daysAgo)",
                    });
                    RequestParameters.Add("end-date", new Google.Apis.Discovery.Parameter
                    {
                        Name = "end-date",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[0-9]{4}-[0-9]{2}-[0-9]{2}|today|yesterday|[0-9]+(daysAgo)",
                    });
                    RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metrics",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"mcf:.+",
                    });
                    RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimensions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(mcf:.+)?",
                    });
                    RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filters",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"mcf:.+",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("samplingLevel", new Google.Apis.Discovery.Parameter
                    {
                        Name = "samplingLevel",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sort",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(-)?mcf:.+",
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Realtime resource.</summary>
        public virtual RealtimeResource Realtime { get; }

        /// <summary>The "realtime" collection of methods.</summary>
        public class RealtimeResource
        {
            private const string Resource = "realtime";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RealtimeResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns real time data for a view (profile).</summary>
            /// <param name="ids">
            /// Unique table ID for retrieving real time data. Table ID is of the form ga:XXXX, where XXXX is the
            /// Analytics view (profile) ID.
            /// </param>
            /// <param name="metrics">
            /// A comma-separated list of real time metrics. E.g., 'rt:activeUsers'. At least one metric must be
            /// specified.
            /// </param>
            public virtual GetRequest Get(string ids, string metrics)
            {
                return new GetRequest(this.service, ids, metrics);
            }

            /// <summary>Returns real time data for a view (profile).</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RealtimeData>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string ids, string metrics) : base(service)
                {
                    Ids = ids;
                    Metrics = metrics;
                    InitParameters();
                }

                /// <summary>
                /// Unique table ID for retrieving real time data. Table ID is of the form ga:XXXX, where XXXX is the
                /// Analytics view (profile) ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Ids { get; private set; }

                /// <summary>
                /// A comma-separated list of real time metrics. E.g., 'rt:activeUsers'. At least one metric must be
                /// specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Metrics { get; private set; }

                /// <summary>A comma-separated list of real time dimensions. E.g., 'rt:medium,rt:city'.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Dimensions { get; set; }

                /// <summary>
                /// A comma-separated list of dimension or metric filters to be applied to real time data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filters { get; set; }

                /// <summary>The maximum number of entries to include in this feed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// A comma-separated list of dimensions or metrics that determine the sort order for real time data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "data/realtime";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("ids", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ids",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"ga:[0-9]+",
                    });
                    RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metrics",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(ga:.+)|(rt:.+)",
                    });
                    RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimensions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(ga:.+)|(rt:.+)",
                    });
                    RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filters",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(ga:.+)|(rt:.+)",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sort",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(-)?((ga:.+)|(rt:.+))",
                    });
                }
            }
        }
    }

    /// <summary>The "management" collection of methods.</summary>
    public class ManagementResource
    {
        private const string Resource = "management";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagementResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AccountSummaries = new AccountSummariesResource(service);
            AccountUserLinks = new AccountUserLinksResource(service);
            Accounts = new AccountsResource(service);
            ClientId = new ClientIdResource(service);
            CustomDataSources = new CustomDataSourcesResource(service);
            CustomDimensions = new CustomDimensionsResource(service);
            CustomMetrics = new CustomMetricsResource(service);
            Experiments = new ExperimentsResource(service);
            Filters = new FiltersResource(service);
            Goals = new GoalsResource(service);
            ProfileFilterLinks = new ProfileFilterLinksResource(service);
            ProfileUserLinks = new ProfileUserLinksResource(service);
            Profiles = new ProfilesResource(service);
            RemarketingAudience = new RemarketingAudienceResource(service);
            Segments = new SegmentsResource(service);
            UnsampledReports = new UnsampledReportsResource(service);
            Uploads = new UploadsResource(service);
            WebPropertyAdWordsLinks = new WebPropertyAdWordsLinksResource(service);
            Webproperties = new WebpropertiesResource(service);
            WebpropertyUserLinks = new WebpropertyUserLinksResource(service);
        }

        /// <summary>Gets the AccountSummaries resource.</summary>
        public virtual AccountSummariesResource AccountSummaries { get; }

        /// <summary>The "accountSummaries" collection of methods.</summary>
        public class AccountSummariesResource
        {
            private const string Resource = "accountSummaries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccountSummariesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists account summaries (lightweight tree comprised of accounts/properties/profiles) to which the user
            /// has access.
            /// </summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>
            /// Lists account summaries (lightweight tree comprised of accounts/properties/profiles) to which the user
            /// has access.
            /// </summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.AccountSummaries>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// The maximum number of account summaries to include in this response, where the largest acceptable
                /// value is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accountSummaries";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the AccountUserLinks resource.</summary>
        public virtual AccountUserLinksResource AccountUserLinks { get; }

        /// <summary>The "accountUserLinks" collection of methods.</summary>
        public class AccountUserLinksResource
        {
            private const string Resource = "accountUserLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccountUserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes a user from the given account.</summary>
            /// <param name="accountId">Account ID to delete the user link for.</param>
            /// <param name="linkId">Link ID to delete the user link for.</param>
            public virtual DeleteRequest Delete(string accountId, string linkId)
            {
                return new DeleteRequest(this.service, accountId, linkId);
            }

            /// <summary>Removes a user from the given account.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    LinkId = linkId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Link ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds a new user to the given account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the user link for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId)
            {
                return new InsertRequest(this.service, body, accountId);
            }

            /// <summary>Adds a new user to the given account.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/entityUserLinks";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists account-user links for a given account.</summary>
            /// <param name="accountId">Account ID to retrieve the user links for.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>Lists account-user links for a given account.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLinks>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve the user links for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The maximum number of account-user links to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first account-user link to retrieve. Use this parameter as a pagination mechanism
                /// along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/entityUserLinks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates permissions for an existing user on the given account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to update the account-user link for.</param>
            /// <param name="linkId">Link ID to update the account-user link for.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string linkId)
            {
                return new UpdateRequest(this.service, body, accountId, linkId);
            }

            /// <summary>Updates permissions for an existing user on the given account.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    LinkId = linkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to update the account-user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Link ID to update the account-user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

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
            }

            /// <summary>Lists all accounts to which the user has access.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Lists all accounts to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Accounts>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>The maximum number of accounts to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first account to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the ClientId resource.</summary>
        public virtual ClientIdResource ClientId { get; }

        /// <summary>The "clientId" collection of methods.</summary>
        public class ClientIdResource
        {
            private const string Resource = "clientId";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ClientIdResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Hashes the given Client ID.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual HashClientIdRequest HashClientId(Google.Apis.Analytics.v3.Data.HashClientIdRequest body)
            {
                return new HashClientIdRequest(this.service, body);
            }

            /// <summary>Hashes the given Client ID.</summary>
            public class HashClientIdRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.HashClientIdResponse>
            {
                /// <summary>Constructs a new HashClientId request.</summary>
                public HashClientIdRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.HashClientIdRequest body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.HashClientIdRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "hashClientId";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/clientId:hashClientId";

                /// <summary>Initializes HashClientId parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }
        }

        /// <summary>Gets the CustomDataSources resource.</summary>
        public virtual CustomDataSourcesResource CustomDataSources { get; }

        /// <summary>The "customDataSources" collection of methods.</summary>
        public class CustomDataSourcesResource
        {
            private const string Resource = "customDataSources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomDataSourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List custom data sources to which the user has access.</summary>
            /// <param name="accountId">Account Id for the custom data sources to retrieve.</param>
            /// <param name="webPropertyId">Web property Id for the custom data sources to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>List custom data sources to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDataSources>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>Account Id for the custom data sources to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id for the custom data sources to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of custom data sources to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// A 1-based index of the first custom data source to retrieve. Use this parameter as a pagination
                /// mechanism along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the CustomDimensions resource.</summary>
        public virtual CustomDimensionsResource CustomDimensions { get; }

        /// <summary>The "customDimensions" collection of methods.</summary>
        public class CustomDimensionsResource
        {
            private const string Resource = "customDimensions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomDimensionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get a custom dimension to which the user has access.</summary>
            /// <param name="accountId">Account ID for the custom dimension to retrieve.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimension to retrieve.</param>
            /// <param name="customDimensionId">The ID of the custom dimension to retrieve.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string customDimensionId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, customDimensionId);
            }

            /// <summary>Get a custom dimension to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDimension>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDimensionId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDimensionId = customDimensionId;
                    InitParameters();
                }

                /// <summary>Account ID for the custom dimension to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimension to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the custom dimension to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDimensionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDimensionId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDimensions/{customDimensionId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customDimensionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDimensionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new custom dimension.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom dimension to create.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimension to create.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Create a new custom dimension.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDimension>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom dimension to create.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimension to create.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDimensions";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists custom dimensions to which the user has access.</summary>
            /// <param name="accountId">Account ID for the custom dimensions to retrieve.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimensions to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists custom dimensions to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDimensions>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>Account ID for the custom dimensions to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimensions to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of custom dimensions to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDimensions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing custom dimension. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom dimension to update.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimension to update.</param>
            /// <param name="customDimensionId">Custom dimension ID for the custom dimension to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId, string customDimensionId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, customDimensionId);
            }

            /// <summary>Updates an existing custom dimension. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDimension>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId, string customDimensionId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDimensionId = customDimensionId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom dimension ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDimensionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDimensionId { get; private set; }

                /// <summary>
                /// Force the update and ignore any warnings related to the custom dimension being linked to a custom
                /// data source / data set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ignoreCustomDataSourceLinks", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IgnoreCustomDataSourceLinks { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDimensions/{customDimensionId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customDimensionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDimensionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ignoreCustomDataSourceLinks", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ignoreCustomDataSourceLinks",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing custom dimension.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom dimension to update.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimension to update.</param>
            /// <param name="customDimensionId">Custom dimension ID for the custom dimension to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId, string customDimensionId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, customDimensionId);
            }

            /// <summary>Updates an existing custom dimension.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomDimension>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomDimension body, string accountId, string webPropertyId, string customDimensionId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDimensionId = customDimensionId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom dimension ID for the custom dimension to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDimensionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDimensionId { get; private set; }

                /// <summary>
                /// Force the update and ignore any warnings related to the custom dimension being linked to a custom
                /// data source / data set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ignoreCustomDataSourceLinks", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IgnoreCustomDataSourceLinks { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDimensions/{customDimensionId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customDimensionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDimensionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ignoreCustomDataSourceLinks", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ignoreCustomDataSourceLinks",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the CustomMetrics resource.</summary>
        public virtual CustomMetricsResource CustomMetrics { get; }

        /// <summary>The "customMetrics" collection of methods.</summary>
        public class CustomMetricsResource
        {
            private const string Resource = "customMetrics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomMetricsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get a custom metric to which the user has access.</summary>
            /// <param name="accountId">Account ID for the custom metric to retrieve.</param>
            /// <param name="webPropertyId">Web property ID for the custom metric to retrieve.</param>
            /// <param name="customMetricId">The ID of the custom metric to retrieve.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string customMetricId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, customMetricId);
            }

            /// <summary>Get a custom metric to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomMetric>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customMetricId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomMetricId = customMetricId;
                    InitParameters();
                }

                /// <summary>Account ID for the custom metric to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom metric to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the custom metric to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customMetricId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomMetricId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customMetrics/{customMetricId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customMetricId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customMetricId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new custom metric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom metric to create.</param>
            /// <param name="webPropertyId">Web property ID for the custom dimension to create.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Create a new custom metric.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomMetric>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom metric to create.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom dimension to create.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customMetrics";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists custom metrics to which the user has access.</summary>
            /// <param name="accountId">Account ID for the custom metrics to retrieve.</param>
            /// <param name="webPropertyId">Web property ID for the custom metrics to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists custom metrics to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomMetrics>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>Account ID for the custom metrics to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom metrics to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of custom metrics to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customMetrics";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing custom metric. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom metric to update.</param>
            /// <param name="webPropertyId">Web property ID for the custom metric to update.</param>
            /// <param name="customMetricId">Custom metric ID for the custom metric to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId, string customMetricId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, customMetricId);
            }

            /// <summary>Updates an existing custom metric. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomMetric>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId, string customMetricId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomMetricId = customMetricId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom metric ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customMetricId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomMetricId { get; private set; }

                /// <summary>
                /// Force the update and ignore any warnings related to the custom metric being linked to a custom data
                /// source / data set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ignoreCustomDataSourceLinks", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IgnoreCustomDataSourceLinks { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customMetrics/{customMetricId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customMetricId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customMetricId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ignoreCustomDataSourceLinks", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ignoreCustomDataSourceLinks",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing custom metric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID for the custom metric to update.</param>
            /// <param name="webPropertyId">Web property ID for the custom metric to update.</param>
            /// <param name="customMetricId">Custom metric ID for the custom metric to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId, string customMetricId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, customMetricId);
            }

            /// <summary>Updates an existing custom metric.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.CustomMetric>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.CustomMetric body, string accountId, string webPropertyId, string customMetricId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomMetricId = customMetricId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom metric ID for the custom metric to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customMetricId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomMetricId { get; private set; }

                /// <summary>
                /// Force the update and ignore any warnings related to the custom metric being linked to a custom data
                /// source / data set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ignoreCustomDataSourceLinks", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IgnoreCustomDataSourceLinks { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.CustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customMetrics/{customMetricId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customMetricId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customMetricId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ignoreCustomDataSourceLinks", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ignoreCustomDataSourceLinks",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Experiments resource.</summary>
        public virtual ExperimentsResource Experiments { get; }

        /// <summary>The "experiments" collection of methods.</summary>
        public class ExperimentsResource
        {
            private const string Resource = "experiments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExperimentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete an experiment.</summary>
            /// <param name="accountId">Account ID to which the experiment belongs</param>
            /// <param name="webPropertyId">Web property ID to which the experiment belongs</param>
            /// <param name="profileId">View (Profile) ID to which the experiment belongs</param>
            /// <param name="experimentId">ID of the experiment to delete</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string profileId, string experimentId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, profileId, experimentId);
            }

            /// <summary>Delete an experiment.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string experimentId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    ExperimentId = experimentId;
                    InitParameters();
                }

                /// <summary>Account ID to which the experiment belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to which the experiment belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to which the experiment belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the experiment to delete</summary>
                [Google.Apis.Util.RequestParameterAttribute("experimentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExperimentId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments/{experimentId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("experimentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "experimentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns an experiment to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve the experiment for.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the experiment for.</param>
            /// <param name="profileId">View (Profile) ID to retrieve the experiment for.</param>
            /// <param name="experimentId">Experiment ID to retrieve the experiment for.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string profileId, string experimentId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, profileId, experimentId);
            }

            /// <summary>Returns an experiment to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Experiment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string experimentId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    ExperimentId = experimentId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to retrieve the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Experiment ID to retrieve the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("experimentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExperimentId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments/{experimentId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("experimentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "experimentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new experiment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the experiment for.</param>
            /// <param name="webPropertyId">Web property ID to create the experiment for.</param>
            /// <param name="profileId">View (Profile) ID to create the experiment for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Create a new experiment.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Experiment>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to create the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to create the experiment for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Experiment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists experiments to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve experiments for.</param>
            /// <param name="webPropertyId">Web property ID to retrieve experiments for.</param>
            /// <param name="profileId">View (Profile) ID to retrieve experiments for.</param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Lists experiments to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Experiments>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve experiments for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve experiments for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to retrieve experiments for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>The maximum number of experiments to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first experiment to retrieve. Use this parameter as a pagination mechanism along
                /// with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Update an existing experiment. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the experiment to update.</param>
            /// <param name="webPropertyId">Web property ID of the experiment to update.</param>
            /// <param name="profileId">View (Profile) ID of the experiment to update.</param>
            /// <param name="experimentId">Experiment ID of the experiment to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId, string experimentId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, profileId, experimentId);
            }

            /// <summary>Update an existing experiment. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Experiment>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId, string experimentId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    ExperimentId = experimentId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Experiment ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("experimentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExperimentId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Experiment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments/{experimentId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("experimentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "experimentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Update an existing experiment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the experiment to update.</param>
            /// <param name="webPropertyId">Web property ID of the experiment to update.</param>
            /// <param name="profileId">View (Profile) ID of the experiment to update.</param>
            /// <param name="experimentId">Experiment ID of the experiment to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId, string experimentId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, profileId, experimentId);
            }

            /// <summary>Update an existing experiment.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Experiment>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Experiment body, string accountId, string webPropertyId, string profileId, string experimentId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    ExperimentId = experimentId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Experiment ID of the experiment to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("experimentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExperimentId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Experiment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/experiments/{experimentId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("experimentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "experimentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Filters resource.</summary>
        public virtual FiltersResource Filters { get; }

        /// <summary>The "filters" collection of methods.</summary>
        public class FiltersResource
        {
            private const string Resource = "filters";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FiltersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete a filter.</summary>
            /// <param name="accountId">Account ID to delete the filter for.</param>
            /// <param name="filterId">ID of the filter to be deleted.</param>
            public virtual DeleteRequest Delete(string accountId, string filterId)
            {
                return new DeleteRequest(this.service, accountId, filterId);
            }

            /// <summary>Delete a filter.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filter>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string filterId) : base(service)
                {
                    AccountId = accountId;
                    FilterId = filterId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the filter for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>ID of the filter to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FilterId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters/{filterId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns filters to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve filters for.</param>
            /// <param name="filterId">Filter ID to retrieve filters for.</param>
            public virtual GetRequest Get(string accountId, string filterId)
            {
                return new GetRequest(this.service, accountId, filterId);
            }

            /// <summary>Returns filters to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filter>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string filterId) : base(service)
                {
                    AccountId = accountId;
                    FilterId = filterId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve filters for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Filter ID to retrieve filters for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FilterId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters/{filterId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new filter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create filter for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.Filter body, string accountId)
            {
                return new InsertRequest(this.service, body, accountId);
            }

            /// <summary>Create a new filter.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filter>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Filter body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create filter for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Filter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all filters for an account</summary>
            /// <param name="accountId">Account ID to retrieve filters for.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>Lists all filters for an account</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filters>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve filters for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The maximum number of filters to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing filter. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the filter belongs.</param>
            /// <param name="filterId">ID of the filter to be updated.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.Filter body, string accountId, string filterId)
            {
                return new PatchRequest(this.service, body, accountId, filterId);
            }

            /// <summary>Updates an existing filter. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filter>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Filter body, string accountId, string filterId) : base(service)
                {
                    AccountId = accountId;
                    FilterId = filterId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the filter belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>ID of the filter to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FilterId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Filter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters/{filterId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing filter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the filter belongs.</param>
            /// <param name="filterId">ID of the filter to be updated.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.Filter body, string accountId, string filterId)
            {
                return new UpdateRequest(this.service, body, accountId, filterId);
            }

            /// <summary>Updates an existing filter.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Filter>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Filter body, string accountId, string filterId) : base(service)
                {
                    AccountId = accountId;
                    FilterId = filterId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the filter belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>ID of the filter to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FilterId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Filter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/filters/{filterId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Goals resource.</summary>
        public virtual GoalsResource Goals { get; }

        /// <summary>The "goals" collection of methods.</summary>
        public class GoalsResource
        {
            private const string Resource = "goals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GoalsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a goal to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve the goal for.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the goal for.</param>
            /// <param name="profileId">View (Profile) ID to retrieve the goal for.</param>
            /// <param name="goalId">Goal ID to retrieve the goal for.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string profileId, string goalId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, profileId, goalId);
            }

            /// <summary>Gets a goal to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Goal>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string goalId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    GoalId = goalId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to retrieve the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Goal ID to retrieve the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("goalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GoalId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals/{goalId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("goalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "goalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new goal.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the goal for.</param>
            /// <param name="webPropertyId">Web property ID to create the goal for.</param>
            /// <param name="profileId">View (Profile) ID to create the goal for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Create a new goal.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Goal>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to create the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to create the goal for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Goal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists goals to which the user has access.</summary>
            /// <param name="accountId">
            /// Account ID to retrieve goals for. Can either be a specific account ID or '~all', which refers to all the
            /// accounts that user has access to.
            /// </param>
            /// <param name="webPropertyId">
            /// Web property ID to retrieve goals for. Can either be a specific web property ID or '~all', which refers
            /// to all the web properties that user has access to.
            /// </param>
            /// <param name="profileId">
            /// View (Profile) ID to retrieve goals for. Can either be a specific view (profile) ID or '~all', which
            /// refers to all the views (profiles) that user has access to.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Lists goals to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Goals>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>
                /// Account ID to retrieve goals for. Can either be a specific account ID or '~all', which refers to all
                /// the accounts that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web property ID to retrieve goals for. Can either be a specific web property ID or '~all', which
                /// refers to all the web properties that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>
                /// View (Profile) ID to retrieve goals for. Can either be a specific view (profile) ID or '~all', which
                /// refers to all the views (profiles) that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>The maximum number of goals to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first goal to retrieve. Use this parameter as a pagination mechanism along with the
                /// max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing goal. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to update the goal.</param>
            /// <param name="webPropertyId">Web property ID to update the goal.</param>
            /// <param name="profileId">View (Profile) ID to update the goal.</param>
            /// <param name="goalId">Index of the goal to be updated.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId, string goalId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, profileId, goalId);
            }

            /// <summary>Updates an existing goal. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Goal>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId, string goalId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    GoalId = goalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Index of the goal to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("goalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GoalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Goal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals/{goalId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("goalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "goalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing goal.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to update the goal.</param>
            /// <param name="webPropertyId">Web property ID to update the goal.</param>
            /// <param name="profileId">View (Profile) ID to update the goal.</param>
            /// <param name="goalId">Index of the goal to be updated.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId, string goalId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, profileId, goalId);
            }

            /// <summary>Updates an existing goal.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Goal>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Goal body, string accountId, string webPropertyId, string profileId, string goalId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    GoalId = goalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to update the goal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Index of the goal to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("goalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GoalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Goal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals/{goalId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("goalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "goalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the ProfileFilterLinks resource.</summary>
        public virtual ProfileFilterLinksResource ProfileFilterLinks { get; }

        /// <summary>The "profileFilterLinks" collection of methods.</summary>
        public class ProfileFilterLinksResource
        {
            private const string Resource = "profileFilterLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProfileFilterLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete a profile filter link.</summary>
            /// <param name="accountId">Account ID to which the profile filter link belongs.</param>
            /// <param name="webPropertyId">Web property Id to which the profile filter link belongs.</param>
            /// <param name="profileId">Profile ID to which the filter link belongs.</param>
            /// <param name="linkId">ID of the profile filter link to delete.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Delete a profile filter link.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    InitParameters();
                }

                /// <summary>Account ID to which the profile filter link belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id to which the profile filter link belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Profile ID to which the filter link belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the profile filter link to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks/{linkId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+:\d+",
                    });
                }
            }

            /// <summary>Returns a single profile filter link.</summary>
            /// <param name="accountId">Account ID to retrieve profile filter link for.</param>
            /// <param name="webPropertyId">Web property Id to retrieve profile filter link for.</param>
            /// <param name="profileId">Profile ID to retrieve filter link for.</param>
            /// <param name="linkId">ID of the profile filter link.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Returns a single profile filter link.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.ProfileFilterLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve profile filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id to retrieve profile filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Profile ID to retrieve filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the profile filter link.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks/{linkId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+:\d+",
                    });
                }
            }

            /// <summary>Create a new profile filter link.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create profile filter link for.</param>
            /// <param name="webPropertyId">Web property Id to create profile filter link for.</param>
            /// <param name="profileId">Profile ID to create filter link for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Create a new profile filter link.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.ProfileFilterLink>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create profile filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id to create profile filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Profile ID to create filter link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.ProfileFilterLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                }
            }

            /// <summary>Lists all profile filter links for a profile.</summary>
            /// <param name="accountId">Account ID to retrieve profile filter links for.</param>
            /// <param name="webPropertyId">
            /// Web property Id for profile filter links for. Can either be a specific web property ID or '~all', which
            /// refers to all the web properties that user has access to.
            /// </param>
            /// <param name="profileId">
            /// Profile ID to retrieve filter links for. Can either be a specific profile ID or '~all', which refers to
            /// all the profiles that user has access to.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Lists all profile filter links for a profile.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.ProfileFilterLinks>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve profile filter links for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web property Id for profile filter links for. Can either be a specific web property ID or '~all',
                /// which refers to all the web properties that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>
                /// Profile ID to retrieve filter links for. Can either be a specific profile ID or '~all', which refers
                /// to all the profiles that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>The maximum number of profile filter links to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Update an existing profile filter link. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which profile filter link belongs.</param>
            /// <param name="webPropertyId">Web property Id to which profile filter link belongs</param>
            /// <param name="profileId">Profile ID to which filter link belongs</param>
            /// <param name="linkId">ID of the profile filter link to be updated.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Update an existing profile filter link. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.ProfileFilterLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which profile filter link belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id to which profile filter link belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Profile ID to which filter link belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the profile filter link to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.ProfileFilterLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks/{linkId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+:\d+",
                    });
                }
            }

            /// <summary>Update an existing profile filter link.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which profile filter link belongs.</param>
            /// <param name="webPropertyId">Web property Id to which profile filter link belongs</param>
            /// <param name="profileId">Profile ID to which filter link belongs</param>
            /// <param name="linkId">ID of the profile filter link to be updated.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Update an existing profile filter link.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.ProfileFilterLink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.ProfileFilterLink body, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which profile filter link belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id to which profile filter link belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Profile ID to which filter link belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the profile filter link to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.ProfileFilterLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/profileFilterLinks/{linkId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+:\d+",
                    });
                }
            }
        }

        /// <summary>Gets the ProfileUserLinks resource.</summary>
        public virtual ProfileUserLinksResource ProfileUserLinks { get; }

        /// <summary>The "profileUserLinks" collection of methods.</summary>
        public class ProfileUserLinksResource
        {
            private const string Resource = "profileUserLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProfileUserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes a user from the given view (profile).</summary>
            /// <param name="accountId">Account ID to delete the user link for.</param>
            /// <param name="webPropertyId">Web Property ID to delete the user link for.</param>
            /// <param name="profileId">View (Profile) ID to delete the user link for.</param>
            /// <param name="linkId">Link ID to delete the user link for.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Removes a user from the given view (profile).</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web Property ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Link ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds a new user to the given view (profile).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the user link for.</param>
            /// <param name="webPropertyId">Web Property ID to create the user link for.</param>
            /// <param name="profileId">View (Profile) ID to create the user link for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string profileId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Adds a new user to the given view (profile).</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web Property ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/entityUserLinks";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists profile-user links for a given view (profile).</summary>
            /// <param name="accountId">Account ID which the given view (profile) belongs to.</param>
            /// <param name="webPropertyId">
            /// Web Property ID which the given view (profile) belongs to. Can either be a specific web property ID or
            /// '~all', which refers to all the web properties that user has access to.
            /// </param>
            /// <param name="profileId">
            /// View (Profile) ID to retrieve the profile-user links for. Can either be a specific profile ID or '~all',
            /// which refers to all the profiles that user has access to.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Lists profile-user links for a given view (profile).</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLinks>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>Account ID which the given view (profile) belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web Property ID which the given view (profile) belongs to. Can either be a specific web property ID
                /// or '~all', which refers to all the web properties that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>
                /// View (Profile) ID to retrieve the profile-user links for. Can either be a specific profile ID or
                /// '~all', which refers to all the profiles that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>The maximum number of profile-user links to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first profile-user link to retrieve. Use this parameter as a pagination mechanism
                /// along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/entityUserLinks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates permissions for an existing user on the given view (profile).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to update the user link for.</param>
            /// <param name="webPropertyId">Web Property ID to update the user link for.</param>
            /// <param name="profileId">View (Profile ID) to update the user link for.</param>
            /// <param name="linkId">Link ID to update the user link for.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string profileId, string linkId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, profileId, linkId);
            }

            /// <summary>Updates permissions for an existing user on the given view (profile).</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string profileId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    LinkId = linkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to update the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web Property ID to update the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile ID) to update the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Link ID to update the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Profiles resource.</summary>
        public virtual ProfilesResource Profiles { get; }

        /// <summary>The "profiles" collection of methods.</summary>
        public class ProfilesResource
        {
            private const string Resource = "profiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a view (profile).</summary>
            /// <param name="accountId">Account ID to delete the view (profile) for.</param>
            /// <param name="webPropertyId">Web property ID to delete the view (profile) for.</param>
            /// <param name="profileId">ID of the view (profile) to be deleted.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string profileId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Deletes a view (profile).</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to delete the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>ID of the view (profile) to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a view (profile) to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve the view (profile) for.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the view (profile) for.</param>
            /// <param name="profileId">View (Profile) ID to retrieve the view (profile) for.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string profileId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Gets a view (profile) to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Profile>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to retrieve the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"[0-9]+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-[0-9]+-[0-9]+",
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"[0-9]+",
                    });
                }
            }

            /// <summary>Create a new view (profile).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the view (profile) for.</param>
            /// <param name="webPropertyId">Web property ID to create the view (profile) for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Create a new view (profile).</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Profile>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to create the view (profile) for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Profile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists views (profiles) to which the user has access.</summary>
            /// <param name="accountId">
            /// Account ID for the view (profiles) to retrieve. Can either be a specific account ID or '~all', which
            /// refers to all the accounts to which the user has access.
            /// </param>
            /// <param name="webPropertyId">
            /// Web property ID for the views (profiles) to retrieve. Can either be a specific web property ID or
            /// '~all', which refers to all the web properties to which the user has access.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists views (profiles) to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Profiles>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>
                /// Account ID for the view (profiles) to retrieve. Can either be a specific account ID or '~all', which
                /// refers to all the accounts to which the user has access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web property ID for the views (profiles) to retrieve. Can either be a specific web property ID or
                /// '~all', which refers to all the web properties to which the user has access.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of views (profiles) to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing view (profile). This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the view (profile) belongs</param>
            /// <param name="webPropertyId">Web property ID to which the view (profile) belongs</param>
            /// <param name="profileId">ID of the view (profile) to be updated.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId, string profileId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Updates an existing view (profile). This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Profile>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the view (profile) belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to which the view (profile) belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>ID of the view (profile) to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Profile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing view (profile).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the view (profile) belongs</param>
            /// <param name="webPropertyId">Web property ID to which the view (profile) belongs</param>
            /// <param name="profileId">ID of the view (profile) to be updated.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId, string profileId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Updates an existing view (profile).</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Profile>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Profile body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the view (profile) belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to which the view (profile) belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>ID of the view (profile) to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Profile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the RemarketingAudience resource.</summary>
        public virtual RemarketingAudienceResource RemarketingAudience { get; }

        /// <summary>The "remarketingAudience" collection of methods.</summary>
        public class RemarketingAudienceResource
        {
            private const string Resource = "remarketingAudience";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RemarketingAudienceResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete a remarketing audience.</summary>
            /// <param name="accountId">Account ID to which the remarketing audience belongs.</param>
            /// <param name="webPropertyId">Web property ID to which the remarketing audience belongs.</param>
            /// <param name="remarketingAudienceId">The ID of the remarketing audience to delete.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string remarketingAudienceId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, remarketingAudienceId);
            }

            /// <summary>Delete a remarketing audience.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string remarketingAudienceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    RemarketingAudienceId = remarketingAudienceId;
                    InitParameters();
                }

                /// <summary>Account ID to which the remarketing audience belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to which the remarketing audience belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the remarketing audience to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("remarketingAudienceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string RemarketingAudienceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences/{remarketingAudienceId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("remarketingAudienceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "remarketingAudienceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a remarketing audience to which the user has access.</summary>
            /// <param name="accountId">The account ID of the remarketing audience to retrieve.</param>
            /// <param name="webPropertyId">The web property ID of the remarketing audience to retrieve.</param>
            /// <param name="remarketingAudienceId">The ID of the remarketing audience to retrieve.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string remarketingAudienceId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, remarketingAudienceId);
            }

            /// <summary>Gets a remarketing audience to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RemarketingAudience>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string remarketingAudienceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    RemarketingAudienceId = remarketingAudienceId;
                    InitParameters();
                }

                /// <summary>The account ID of the remarketing audience to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The web property ID of the remarketing audience to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the remarketing audience to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("remarketingAudienceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string RemarketingAudienceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences/{remarketingAudienceId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("remarketingAudienceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "remarketingAudienceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates a new remarketing audience.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The account ID for which to create the remarketing audience.</param>
            /// <param name="webPropertyId">Web property ID for which to create the remarketing audience.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Creates a new remarketing audience.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RemarketingAudience>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The account ID for which to create the remarketing audience.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID for which to create the remarketing audience.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.RemarketingAudience Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists remarketing audiences to which the user has access.</summary>
            /// <param name="accountId">The account ID of the remarketing audiences to retrieve.</param>
            /// <param name="webPropertyId">The web property ID of the remarketing audiences to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists remarketing audiences to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RemarketingAudiences>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>The account ID of the remarketing audiences to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The web property ID of the remarketing audiences to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of remarketing audiences to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Type { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                    {
                        Name = "type",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "all",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing remarketing audience. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The account ID of the remarketing audience to update.</param>
            /// <param name="webPropertyId">The web property ID of the remarketing audience to update.</param>
            /// <param name="remarketingAudienceId">The ID of the remarketing audience to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId, string remarketingAudienceId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, remarketingAudienceId);
            }

            /// <summary>Updates an existing remarketing audience. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RemarketingAudience>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId, string remarketingAudienceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    RemarketingAudienceId = remarketingAudienceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The account ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The web property ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("remarketingAudienceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string RemarketingAudienceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.RemarketingAudience Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences/{remarketingAudienceId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("remarketingAudienceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "remarketingAudienceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing remarketing audience.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The account ID of the remarketing audience to update.</param>
            /// <param name="webPropertyId">The web property ID of the remarketing audience to update.</param>
            /// <param name="remarketingAudienceId">The ID of the remarketing audience to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId, string remarketingAudienceId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, remarketingAudienceId);
            }

            /// <summary>Updates an existing remarketing audience.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.RemarketingAudience>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.RemarketingAudience body, string accountId, string webPropertyId, string remarketingAudienceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    RemarketingAudienceId = remarketingAudienceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The account ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The web property ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The ID of the remarketing audience to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("remarketingAudienceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string RemarketingAudienceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.RemarketingAudience Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/remarketingAudiences/{remarketingAudienceId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("remarketingAudienceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "remarketingAudienceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Segments resource.</summary>
        public virtual SegmentsResource Segments { get; }

        /// <summary>The "segments" collection of methods.</summary>
        public class SegmentsResource
        {
            private const string Resource = "segments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SegmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists segments to which the user has access.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Lists segments to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Segments>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>The maximum number of segments to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first segment to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/segments";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the UnsampledReports resource.</summary>
        public virtual UnsampledReportsResource UnsampledReports { get; }

        /// <summary>The "unsampledReports" collection of methods.</summary>
        public class UnsampledReportsResource
        {
            private const string Resource = "unsampledReports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UnsampledReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes an unsampled report.</summary>
            /// <param name="accountId">Account ID to delete the unsampled report for.</param>
            /// <param name="webPropertyId">Web property ID to delete the unsampled reports for.</param>
            /// <param name="profileId">View (Profile) ID to delete the unsampled report for.</param>
            /// <param name="unsampledReportId">ID of the unsampled report to be deleted.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string profileId, string unsampledReportId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, profileId, unsampledReportId);
            }

            /// <summary>Deletes an unsampled report.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string unsampledReportId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    UnsampledReportId = unsampledReportId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to delete the unsampled reports for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to delete the unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the unsampled report to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("unsampledReportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UnsampledReportId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/unsampledReports/{unsampledReportId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("unsampledReportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "unsampledReportId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns a single unsampled report.</summary>
            /// <param name="accountId">Account ID to retrieve unsampled report for.</param>
            /// <param name="webPropertyId">Web property ID to retrieve unsampled reports for.</param>
            /// <param name="profileId">View (Profile) ID to retrieve unsampled report for.</param>
            /// <param name="unsampledReportId">ID of the unsampled report to retrieve.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string profileId, string unsampledReportId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, profileId, unsampledReportId);
            }

            /// <summary>Returns a single unsampled report.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.UnsampledReport>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId, string unsampledReportId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    UnsampledReportId = unsampledReportId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve unsampled reports for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to retrieve unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>ID of the unsampled report to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("unsampledReportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UnsampledReportId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/unsampledReports/{unsampledReportId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("unsampledReportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "unsampledReportId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Create a new unsampled report.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the unsampled report for.</param>
            /// <param name="webPropertyId">Web property ID to create the unsampled report for.</param>
            /// <param name="profileId">View (Profile) ID to create the unsampled report for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.UnsampledReport body, string accountId, string webPropertyId, string profileId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId, profileId);
            }

            /// <summary>Create a new unsampled report.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.UnsampledReport>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.UnsampledReport body, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to create the unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>View (Profile) ID to create the unsampled report for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.UnsampledReport Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/unsampledReports";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists unsampled reports to which the user has access.</summary>
            /// <param name="accountId">
            /// Account ID to retrieve unsampled reports for. Must be a specific account ID, ~all is not supported.
            /// </param>
            /// <param name="webPropertyId">
            /// Web property ID to retrieve unsampled reports for. Must be a specific web property ID, ~all is not
            /// supported.
            /// </param>
            /// <param name="profileId">
            /// View (Profile) ID to retrieve unsampled reports for. Must be a specific view (profile) ID, ~all is not
            /// supported.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, profileId);
            }

            /// <summary>Lists unsampled reports to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.UnsampledReports>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    ProfileId = profileId;
                    InitParameters();
                }

                /// <summary>
                /// Account ID to retrieve unsampled reports for. Must be a specific account ID, ~all is not supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web property ID to retrieve unsampled reports for. Must be a specific web property ID, ~all is not
                /// supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>
                /// View (Profile) ID to retrieve unsampled reports for. Must be a specific view (profile) ID, ~all is
                /// not supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId { get; private set; }

                /// <summary>The maximum number of unsampled reports to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first unsampled report to retrieve. Use this parameter as a pagination mechanism
                /// along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/unsampledReports";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "profileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Uploads resource.</summary>
        public virtual UploadsResource Uploads { get; }

        /// <summary>The "uploads" collection of methods.</summary>
        public class UploadsResource
        {
            private const string Resource = "uploads";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UploadsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete data associated with a previous upload.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account Id for the uploads to be deleted.</param>
            /// <param name="webPropertyId">Web property Id for the uploads to be deleted.</param>
            /// <param name="customDataSourceId">Custom data source Id for the uploads to be deleted.</param>
            public virtual DeleteUploadDataRequest DeleteUploadData(Google.Apis.Analytics.v3.Data.AnalyticsDataimportDeleteUploadDataRequest body, string accountId, string webPropertyId, string customDataSourceId)
            {
                return new DeleteUploadDataRequest(this.service, body, accountId, webPropertyId, customDataSourceId);
            }

            /// <summary>Delete data associated with a previous upload.</summary>
            public class DeleteUploadDataRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new DeleteUploadData request.</summary>
                public DeleteUploadDataRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.AnalyticsDataimportDeleteUploadDataRequest body, string accountId, string webPropertyId, string customDataSourceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDataSourceId = customDataSourceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account Id for the uploads to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id for the uploads to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom data source Id for the uploads to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.AnalyticsDataimportDeleteUploadDataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteUploadData";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/deleteUploadData";

                /// <summary>Initializes DeleteUploadData parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("customDataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @".{22}",
                    });
                }
            }

            /// <summary>List uploads to which the user has access.</summary>
            /// <param name="accountId">Account Id for the upload to retrieve.</param>
            /// <param name="webPropertyId">Web property Id for the upload to retrieve.</param>
            /// <param name="customDataSourceId">Custom data source Id for upload to retrieve.</param>
            /// <param name="uploadId">Upload Id to retrieve.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string customDataSourceId, string uploadId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, customDataSourceId, uploadId);
            }

            /// <summary>List uploads to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Upload>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, string uploadId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDataSourceId = customDataSourceId;
                    UploadId = uploadId;
                    InitParameters();
                }

                /// <summary>Account Id for the upload to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id for the upload to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom data source Id for upload to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId { get; private set; }

                /// <summary>Upload Id to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UploadId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/uploads/{uploadId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("customDataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @".{22}",
                    });
                    RequestParameters.Add("uploadId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "uploadId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @".{22}",
                    });
                }
            }

            /// <summary>List uploads to which the user has access.</summary>
            /// <param name="accountId">Account Id for the uploads to retrieve.</param>
            /// <param name="webPropertyId">Web property Id for the uploads to retrieve.</param>
            /// <param name="customDataSourceId">Custom data source Id for uploads to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId, string customDataSourceId)
            {
                return new ListRequest(this.service, accountId, webPropertyId, customDataSourceId);
            }

            /// <summary>List uploads to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Uploads>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDataSourceId = customDataSourceId;
                    InitParameters();
                }

                /// <summary>Account Id for the uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property Id for the uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom data source Id for uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId { get; private set; }

                /// <summary>The maximum number of uploads to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// A 1-based index of the first upload to retrieve. Use this parameter as a pagination mechanism along
                /// with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/uploads";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-(\d+)-(\d+)",
                    });
                    RequestParameters.Add("customDataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @".{22}",
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Upload data for a custom data source.</summary>
            /// <param name="accountId">Account Id associated with the upload.</param>
            /// <param name="webPropertyId">Web property UA-string associated with the upload.</param>
            /// <param name="customDataSourceId">Custom data source Id to which the data being uploaded belongs.</param>
            public virtual UploadDataRequest UploadData(string accountId, string webPropertyId, string customDataSourceId)
            {
                return new UploadDataRequest(this.service, accountId, webPropertyId, customDataSourceId);
            }

            /// <summary>Upload data for a custom data source.</summary>
            public class UploadDataRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Upload>
            {
                /// <summary>Constructs a new UploadData request.</summary>
                public UploadDataRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDataSourceId = customDataSourceId;
                    InitParameters();
                }

                /// <summary>Account Id associated with the upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property UA-string associated with the upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom data source Id to which the data being uploaded belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "uploadData";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/uploads";

                /// <summary>Initializes UploadData parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-\d+-\d+",
                    });
                    RequestParameters.Add("customDataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customDataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Upload data for a custom data source.</summary>
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
            /// <param name="accountId">Account Id associated with the upload.</param>
            /// <param name="webPropertyId">Web property UA-string associated with the upload.</param>
            /// <param name="customDataSourceId">Custom data source Id to which the data being uploaded belongs.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadDataMediaUpload UploadData(string accountId, string webPropertyId, string customDataSourceId, System.IO.Stream stream, string contentType)
            {
                return new UploadDataMediaUpload(service, accountId, webPropertyId, customDataSourceId, stream, contentType);
            }

            /// <summary>UploadData media upload which supports resumable upload.</summary>
            public class UploadDataMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.Analytics.v3.Data.Upload>
            {
                /// <summary>Data format for the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AltEnum> Alt { get; set; }

                /// <summary>Data format for the response.</summary>
                public enum AltEnum
                {
                    /// <summary>Responses with Content-Type of application/json</summary>
                    [Google.Apis.Util.StringValueAttribute("json")]
                    Json = 0,
                }

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
                /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Deprecated. Please use quotaUser instead.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserIp { get; set; }

                /// <summary>Account Id associated with the upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property UA-string associated with the upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Custom data source Id to which the data being uploaded belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId { get; private set; }

                /// <summary>Constructs a new UploadData media upload instance.</summary>
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
                public UploadDataMediaUpload(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/uploads"), "POST", stream, contentType)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    CustomDataSourceId = customDataSourceId;
                }
            }
        }

        /// <summary>Gets the WebPropertyAdWordsLinks resource.</summary>
        public virtual WebPropertyAdWordsLinksResource WebPropertyAdWordsLinks { get; }

        /// <summary>The "webPropertyAdWordsLinks" collection of methods.</summary>
        public class WebPropertyAdWordsLinksResource
        {
            private const string Resource = "webPropertyAdWordsLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebPropertyAdWordsLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a web property-Google Ads link.</summary>
            /// <param name="accountId">ID of the account which the given web property belongs to.</param>
            /// <param name="webPropertyId">Web property ID to delete the Google Ads link for.</param>
            /// <param name="webPropertyAdWordsLinkId">Web property Google Ads link ID.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, webPropertyAdWordsLinkId);
            }

            /// <summary>Deletes a web property-Google Ads link.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    WebPropertyAdWordsLinkId = webPropertyAdWordsLinkId;
                    InitParameters();
                }

                /// <summary>ID of the account which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to delete the Google Ads link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Web property Google Ads link ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyAdWordsLinkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyAdWordsLinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks/{webPropertyAdWordsLinkId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyAdWordsLinkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyAdWordsLinkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns a web property-Google Ads link to which the user has access.</summary>
            /// <param name="accountId">ID of the account which the given web property belongs to.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the Google Ads link for.</param>
            /// <param name="webPropertyAdWordsLinkId">Web property-Google Ads link ID.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
            {
                return new GetRequest(this.service, accountId, webPropertyId, webPropertyAdWordsLinkId);
            }

            /// <summary>Returns a web property-Google Ads link to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityAdWordsLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    WebPropertyAdWordsLinkId = webPropertyAdWordsLinkId;
                    InitParameters();
                }

                /// <summary>ID of the account which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the Google Ads link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Web property-Google Ads link ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyAdWordsLinkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyAdWordsLinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks/{webPropertyAdWordsLinkId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyAdWordsLinkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyAdWordsLinkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates a webProperty-Google Ads link.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">ID of the Google Analytics account to create the link for.</param>
            /// <param name="webPropertyId">Web property ID to create the link for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Creates a webProperty-Google Ads link.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityAdWordsLink>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the Google Analytics account to create the link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to create the link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityAdWordsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists webProperty-Google Ads links for a given web property.</summary>
            /// <param name="accountId">ID of the account which the given web property belongs to.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the Google Ads links for.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists webProperty-Google Ads links for a given web property.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityAdWordsLinks>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>ID of the account which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the Google Ads links for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of webProperty-Google Ads links to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first webProperty-Google Ads link to retrieve. Use this parameter as a pagination
                /// mechanism along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"\d+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates an existing webProperty-Google Ads link. This method supports patch semantics.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">ID of the account which the given web property belongs to.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the Google Ads link for.</param>
            /// <param name="webPropertyAdWordsLinkId">Web property-Google Ads link ID.</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId, webPropertyAdWordsLinkId);
            }

            /// <summary>
            /// Updates an existing webProperty-Google Ads link. This method supports patch semantics.
            /// </summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityAdWordsLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId, string webPropertyAdWordsLinkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    WebPropertyAdWordsLinkId = webPropertyAdWordsLinkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the account which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the Google Ads link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Web property-Google Ads link ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyAdWordsLinkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyAdWordsLinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityAdWordsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks/{webPropertyAdWordsLinkId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyAdWordsLinkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyAdWordsLinkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing webProperty-Google Ads link.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">ID of the account which the given web property belongs to.</param>
            /// <param name="webPropertyId">Web property ID to retrieve the Google Ads link for.</param>
            /// <param name="webPropertyAdWordsLinkId">Web property-Google Ads link ID.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, webPropertyAdWordsLinkId);
            }

            /// <summary>Updates an existing webProperty-Google Ads link.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityAdWordsLink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityAdWordsLink body, string accountId, string webPropertyId, string webPropertyAdWordsLinkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    WebPropertyAdWordsLinkId = webPropertyAdWordsLinkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the account which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to retrieve the Google Ads link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Web property-Google Ads link ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyAdWordsLinkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyAdWordsLinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityAdWordsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityAdWordsLinks/{webPropertyAdWordsLinkId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyAdWordsLinkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyAdWordsLinkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Webproperties resource.</summary>
        public virtual WebpropertiesResource Webproperties { get; }

        /// <summary>The "webproperties" collection of methods.</summary>
        public class WebpropertiesResource
        {
            private const string Resource = "webproperties";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebpropertiesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a web property to which the user has access.</summary>
            /// <param name="accountId">Account ID to retrieve the web property for.</param>
            /// <param name="webPropertyId">ID to retrieve the web property for.</param>
            public virtual GetRequest Get(string accountId, string webPropertyId)
            {
                return new GetRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Gets a web property to which the user has access.</summary>
            public class GetRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Webproperty>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>Account ID to retrieve the web property for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>ID to retrieve the web property for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"[0-9]+",
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"UA-[0-9]+-[0-9]+",
                    });
                }
            }

            /// <summary>
            /// Create a new property if the account has fewer than 20 properties. Web properties are visible in the
            /// Google Analytics interface only if they have at least one profile.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the web property for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.Webproperty body, string accountId)
            {
                return new InsertRequest(this.service, body, accountId);
            }

            /// <summary>
            /// Create a new property if the account has fewer than 20 properties. Web properties are visible in the
            /// Google Analytics interface only if they have at least one profile.
            /// </summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Webproperty>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Webproperty body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the web property for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Webproperty Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists web properties to which the user has access.</summary>
            /// <param name="accountId">
            /// Account ID to retrieve web properties for. Can either be a specific account ID or '~all', which refers
            /// to all the accounts that user has access to.
            /// </param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>Lists web properties to which the user has access.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Webproperties>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>
                /// Account ID to retrieve web properties for. Can either be a specific account ID or '~all', which
                /// refers to all the accounts that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The maximum number of web properties to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with
                /// the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing web property. This method supports patch semantics.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the web property belongs</param>
            /// <param name="webPropertyId">Web property ID</param>
            public virtual PatchRequest Patch(Google.Apis.Analytics.v3.Data.Webproperty body, string accountId, string webPropertyId)
            {
                return new PatchRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Updates an existing web property. This method supports patch semantics.</summary>
            public class PatchRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Webproperty>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Webproperty body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the web property belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Webproperty Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing web property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to which the web property belongs</param>
            /// <param name="webPropertyId">Web property ID</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.Webproperty body, string accountId, string webPropertyId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Updates an existing web property.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Webproperty>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.Webproperty body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to which the web property belongs</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.Webproperty Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the WebpropertyUserLinks resource.</summary>
        public virtual WebpropertyUserLinksResource WebpropertyUserLinks { get; }

        /// <summary>The "webpropertyUserLinks" collection of methods.</summary>
        public class WebpropertyUserLinksResource
        {
            private const string Resource = "webpropertyUserLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebpropertyUserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes a user from the given web property.</summary>
            /// <param name="accountId">Account ID to delete the user link for.</param>
            /// <param name="webPropertyId">Web Property ID to delete the user link for.</param>
            /// <param name="linkId">Link ID to delete the user link for.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string linkId)
            {
                return new DeleteRequest(this.service, accountId, webPropertyId, linkId);
            }

            /// <summary>Removes a user from the given web property.</summary>
            public class DeleteRequest : AnalyticsBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    LinkId = linkId;
                    InitParameters();
                }

                /// <summary>Account ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web Property ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Link ID to delete the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds a new user to the given web property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to create the user link for.</param>
            /// <param name="webPropertyId">Web Property ID to create the user link for.</param>
            public virtual InsertRequest Insert(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId)
            {
                return new InsertRequest(this.service, body, accountId, webPropertyId);
            }

            /// <summary>Adds a new user to the given web property.</summary>
            public class InsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web Property ID to create the user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityUserLinks";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists webProperty-user links for a given web property.</summary>
            /// <param name="accountId">Account ID which the given web property belongs to.</param>
            /// <param name="webPropertyId">
            /// Web Property ID for the webProperty-user links to retrieve. Can either be a specific web property ID or
            /// '~all', which refers to all the web properties that user has access to.
            /// </param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(this.service, accountId, webPropertyId);
            }

            /// <summary>Lists webProperty-user links for a given web property.</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLinks>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    InitParameters();
                }

                /// <summary>Account ID which the given web property belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Web Property ID for the webProperty-user links to retrieve. Can either be a specific web property ID
                /// or '~all', which refers to all the web properties that user has access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>The maximum number of webProperty-user Links to include in this response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// An index of the first webProperty-user link to retrieve. Use this parameter as a pagination
                /// mechanism along with the max-results parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityUserLinks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("max-results", new Google.Apis.Discovery.Parameter
                    {
                        Name = "max-results",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start-index", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start-index",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates permissions for an existing user on the given web property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID to update the account-user link for.</param>
            /// <param name="webPropertyId">Web property ID to update the account-user link for.</param>
            /// <param name="linkId">Link ID to update the account-user link for.</param>
            public virtual UpdateRequest Update(Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string linkId)
            {
                return new UpdateRequest(this.service, body, accountId, webPropertyId, linkId);
            }

            /// <summary>Updates permissions for an existing user on the given web property.</summary>
            public class UpdateRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.EntityUserLink>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.EntityUserLink body, string accountId, string webPropertyId, string linkId) : base(service)
                {
                    AccountId = accountId;
                    WebPropertyId = webPropertyId;
                    LinkId = linkId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID to update the account-user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Web property ID to update the account-user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId { get; private set; }

                /// <summary>Link ID to update the account-user link for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LinkId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.EntityUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "management/accounts/{accountId}/webproperties/{webPropertyId}/entityUserLinks/{linkId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("webPropertyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "webPropertyId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "metadata" collection of methods.</summary>
    public class MetadataResource
    {
        private const string Resource = "metadata";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MetadataResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Columns = new ColumnsResource(service);
        }

        /// <summary>Gets the Columns resource.</summary>
        public virtual ColumnsResource Columns { get; }

        /// <summary>The "columns" collection of methods.</summary>
        public class ColumnsResource
        {
            private const string Resource = "columns";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ColumnsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all columns for a report type</summary>
            /// <param name="reportType">
            /// Report type. Allowed Values: 'ga'. Where 'ga' corresponds to the Core Reporting API
            /// </param>
            public virtual ListRequest List(string reportType)
            {
                return new ListRequest(this.service, reportType);
            }

            /// <summary>Lists all columns for a report type</summary>
            public class ListRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.Columns>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string reportType) : base(service)
                {
                    ReportType = reportType;
                    InitParameters();
                }

                /// <summary>
                /// Report type. Allowed Values: 'ga'. Where 'ga' corresponds to the Core Reporting API
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("reportType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ReportType { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "metadata/{reportType}/columns";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("reportType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reportType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"ga",
                    });
                }
            }
        }
    }

    /// <summary>The "provisioning" collection of methods.</summary>
    public class ProvisioningResource
    {
        private const string Resource = "provisioning";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProvisioningResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates an account ticket.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateAccountTicketRequest CreateAccountTicket(Google.Apis.Analytics.v3.Data.AccountTicket body)
        {
            return new CreateAccountTicketRequest(this.service, body);
        }

        /// <summary>Creates an account ticket.</summary>
        public class CreateAccountTicketRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.AccountTicket>
        {
            /// <summary>Constructs a new CreateAccountTicket request.</summary>
            public CreateAccountTicketRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.AccountTicket body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Analytics.v3.Data.AccountTicket Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createAccountTicket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "provisioning/createAccountTicket";

            /// <summary>Initializes CreateAccountTicket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Provision account.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateAccountTreeRequest CreateAccountTree(Google.Apis.Analytics.v3.Data.AccountTreeRequest body)
        {
            return new CreateAccountTreeRequest(this.service, body);
        }

        /// <summary>Provision account.</summary>
        public class CreateAccountTreeRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.AccountTreeResponse>
        {
            /// <summary>Constructs a new CreateAccountTree request.</summary>
            public CreateAccountTreeRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.AccountTreeRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Analytics.v3.Data.AccountTreeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createAccountTree";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "provisioning/createAccountTree";

            /// <summary>Initializes CreateAccountTree parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "userDeletion" collection of methods.</summary>
    public class UserDeletionResource
    {
        private const string Resource = "userDeletion";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserDeletionResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            UserDeletionRequest = new UserDeletionRequestResource(service);
        }

        /// <summary>Gets the UserDeletionRequest resource.</summary>
        public virtual UserDeletionRequestResource UserDeletionRequest { get; }

        /// <summary>The "userDeletionRequest" collection of methods.</summary>
        public class UserDeletionRequestResource
        {
            private const string Resource = "userDeletionRequest";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserDeletionRequestResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Insert or update a user deletion requests.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual UpsertRequest Upsert(Google.Apis.Analytics.v3.Data.UserDeletionRequest body)
            {
                return new UpsertRequest(this.service, body);
            }

            /// <summary>Insert or update a user deletion requests.</summary>
            public class UpsertRequest : AnalyticsBaseServiceRequest<Google.Apis.Analytics.v3.Data.UserDeletionRequest>
            {
                /// <summary>Constructs a new Upsert request.</summary>
                public UpsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Analytics.v3.Data.UserDeletionRequest body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Analytics.v3.Data.UserDeletionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upsert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "userDeletion/userDeletionRequests:upsert";

                /// <summary>Initializes Upsert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }
        }
    }
}
namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for Analytics account entry.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Child link for an account entry. Points to the list of web properties for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual ChildLinkData ChildLink { get; set; }

        /// <summary>Time the account was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Permissions the user has for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual PermissionsData Permissions { get; set; }

        /// <summary>Link for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Indicates whether this account is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>Time the account was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Child link for an account entry. Points to the list of web properties for this account.</summary>
        public class ChildLinkData
        {
            /// <summary>Link to the list of web properties for this account.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Type of the child link. Its value is "analytics#webproperties".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Permissions the user has for this account.</summary>
        public class PermissionsData
        {
            /// <summary>
            /// All the permissions that the user has for this account. These include any implied permissions (e.g.,
            /// EDIT implies VIEW).
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effective")]
            public virtual System.Collections.Generic.IList<string> Effective { get; set; }
        }
    }

    /// <summary>JSON template for a linked account.</summary>
    public class AccountRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("href")]
        public virtual string Href { get; set; }

        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Analytics account reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An AccountSummary collection lists a summary of accounts, properties and views (profiles) to which the user has
    /// access. Each resource in the collection corresponds to a single AccountSummary.
    /// </summary>
    public class AccountSummaries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of AccountSummaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AccountSummary> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this AccountSummary collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this AccountSummary collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics AccountSummary. An AccountSummary is a lightweight tree comprised of
    /// properties/profiles.
    /// </summary>
    public class AccountSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics AccountSummary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Indicates whether this account is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>List of web properties under this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webProperties")]
        public virtual System.Collections.Generic.IList<WebPropertySummary> WebProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics account ticket. The account ticket consists of the ticket ID and the basic
    /// information for the account, property and profile.
    /// </summary>
    public class AccountTicket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account for this ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; }

        /// <summary>Account ticket ID used to access the account ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for account ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>View (Profile) for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual Profile Profile { get; set; }

        /// <summary>
        /// Redirect URI where the user will be sent after accepting Terms of Service. Must be configured in APIs
        /// console as a callback URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Web property for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webproperty")]
        public virtual Webproperty Webproperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics account tree requests. The account tree request is used in the provisioning api
    /// to create an account, property, and view (profile). It contains the basic information required to make these
    /// fields.
    /// </summary>
    public class AccountTreeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        /// <summary>Resource type for account ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
        public virtual string ProfileName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("webpropertyName")]
        public virtual string WebpropertyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics account tree response. The account tree response is used in the provisioning api
    /// to return the result of creating an account, property, and view (profile).
    /// </summary>
    public class AccountTreeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; }

        /// <summary>Resource type for account ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>View (Profile) for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual Profile Profile { get; set; }

        /// <summary>Web property for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webproperty")]
        public virtual Webproperty Webproperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An account collection provides a list of Analytics accounts to which a user has access. The account collection
    /// is the entry point to all management information. Each resource in the collection corresponds to a single
    /// Analytics account.
    /// </summary>
    public class Accounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Account> Items { get; set; }

        /// <summary>
        /// The maximum number of entries the response can contain, regardless of the actual number of entries returned.
        /// Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the max-results
        /// query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Next link for this account collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Previous link for this account collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the entries, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Google Ads account.</summary>
    public class AdWordsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if auto-tagging is enabled on the Google Ads account. Read-only after the insert operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoTaggingEnabled")]
        public virtual System.Nullable<bool> AutoTaggingEnabled { get; set; }

        /// <summary>Customer ID. This field is required when creating a Google Ads link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>Resource type for Google Ads account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request template for the delete upload data request.</summary>
    public class AnalyticsDataimportDeleteUploadDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of upload UIDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDataImportUids")]
        public virtual System.Collections.Generic.IList<string> CustomDataImportUids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a metadata column.</summary>
    public class Column : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of attribute name and value for this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>Column id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists columns (dimensions and metrics) for a particular report type.</summary>
    public class Columns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of attributes names returned by columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeNames")]
        public virtual System.Collections.Generic.IList<string> AttributeNames { get; set; }

        /// <summary>
        /// Etag of collection. This etag can be compared with the last response etag to check if response has changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of columns for a report type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Column> Items { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Total number of columns returned in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }
    }

    /// <summary>JSON template for an Analytics custom data source.</summary>
    public class CustomDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this custom data source belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual ChildLinkData ChildLink { get; set; }

        /// <summary>Time this custom data source was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Description of custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Custom data source ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("importBehavior")]
        public virtual string ImportBehavior { get; set; }

        /// <summary>Resource type for Analytics custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parent link for this custom data source. Points to the web property to which this custom data source
        /// belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>IDs of views (profiles) linked to the custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profilesLinked")]
        public virtual System.Collections.Generic.IList<string> ProfilesLinked { get; set; }

        /// <summary>Collection of schema headers of the custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual System.Collections.Generic.IList<string> Schema { get; set; }

        /// <summary>Link for this Analytics custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Type of the custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time this custom data source was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Upload type of the custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadType")]
        public virtual string UploadType { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this custom data source belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class ChildLinkData
        {
            /// <summary>
            /// Link to the list of daily uploads for this custom data source. Link to the list of uploads for this
            /// custom data source.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#dailyUploads". Value is "analytics#uploads".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>
        /// Parent link for this custom data source. Points to the web property to which this custom data source
        /// belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the web property to which this custom data source belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#webproperty".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    /// <summary>
    /// Lists Analytics custom data sources to which the user has access. Each resource in the collection corresponds to
    /// a single Analytics custom data source.
    /// </summary>
    public class CustomDataSources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of custom data sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CustomDataSource> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this custom data source collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this custom data source collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Analytics Custom Dimension.</summary>
    public class CustomDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Boolean indicating whether the custom dimension is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>Time the custom dimension was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Custom dimension ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Index of the custom dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Kind value for a custom dimension. Set to "analytics#customDimension". It is a read-only field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the custom dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parent link for the custom dimension. Points to the property to which the custom dimension belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>Scope of the custom dimension: HIT, SESSION, USER or PRODUCT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Link for the custom dimension</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Time the custom dimension was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Property ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Parent link for the custom dimension. Points to the property to which the custom dimension belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the property to which the custom dimension belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Type of the parent link. Set to "analytics#webproperty".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    /// <summary>
    /// A custom dimension collection lists Analytics custom dimensions to which the user has access. Each resource in
    /// the collection corresponds to a single Analytics custom dimension.
    /// </summary>
    public class CustomDimensions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of custom dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CustomDimension> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this custom dimension collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this custom dimension collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Analytics Custom Metric.</summary>
    public class CustomMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Boolean indicating whether the custom metric is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>Time the custom metric was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Custom metric ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Index of the custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Kind value for a custom metric. Set to "analytics#customMetric". It is a read-only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Max value of custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max_value")]
        public virtual string MaxValue { get; set; }

        /// <summary>Min value of custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min_value")]
        public virtual string MinValue { get; set; }

        /// <summary>Name of the custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parent link for the custom metric. Points to the property to which the custom metric belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>Scope of the custom metric: HIT or PRODUCT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Link for the custom metric</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Data type of custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time the custom metric was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Property ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Parent link for the custom metric. Points to the property to which the custom metric belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the property to which the custom metric belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Type of the parent link. Set to "analytics#webproperty".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    /// <summary>
    /// A custom metric collection lists Analytics custom metrics to which the user has access. Each resource in the
    /// collection corresponds to a single Analytics custom metric.
    /// </summary>
    public class CustomMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of custom metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CustomMetric> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this custom metric collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this custom metric collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Analytics Entity Google Ads Link.</summary>
    public class EntityAdWordsLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of Google Ads client accounts. These cannot be MCC accounts. This field is required when creating a
        /// Google Ads link. It cannot be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adWordsAccounts")]
        public virtual System.Collections.Generic.IList<AdWordsAccount> AdWordsAccounts { get; set; }

        /// <summary>Web property being linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual EntityData Entity { get; set; }

        /// <summary>Entity Google Ads link ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for entity Google Ads link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the link. This field is required when creating a Google Ads link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>IDs of linked Views (Profiles) represented as strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileIds")]
        public virtual System.Collections.Generic.IList<string> ProfileIds { get; set; }

        /// <summary>URL link for this Google Analytics - Google Ads link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Web property being linked.</summary>
        public class EntityData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyRef")]
            public virtual WebPropertyRef WebPropertyRef { get; set; }
        }
    }

    /// <summary>
    /// An entity Google Ads link collection provides a list of GA-Google Ads links Each resource in this collection
    /// corresponds to a single link.
    /// </summary>
    public class EntityAdWordsLinks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of entity Google Ads links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<EntityAdWordsLink> Items { get; set; }

        /// <summary>
        /// The maximum number of entries the response can contain, regardless of the actual number of entries returned.
        /// Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the max-results
        /// query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Next link for this Google Ads link collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Previous link for this Google Ads link collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the entries, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics Entity-User Link. Returns permissions that a user has for an entity.
    /// </summary>
    public class EntityUserLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entity for this link. It can be an account, a web property, or a view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual EntityData Entity { get; set; }

        /// <summary>Entity user link ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for entity user link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Permissions the user has for this entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual PermissionsData Permissions { get; set; }

        /// <summary>Self link for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>User reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRef")]
        public virtual UserRef UserRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Entity for this link. It can be an account, a web property, or a view (profile).</summary>
        public class EntityData
        {
            /// <summary>Account for this link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accountRef")]
            public virtual AccountRef AccountRef { get; set; }

            /// <summary>View (Profile) for this link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileRef")]
            public virtual ProfileRef ProfileRef { get; set; }

            /// <summary>Web property for this link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyRef")]
            public virtual WebPropertyRef WebPropertyRef { get; set; }
        }

        /// <summary>Permissions the user has for this entity.</summary>
        public class PermissionsData
        {
            /// <summary>
            /// Effective permissions represent all the permissions that a user has for this entity. These include any
            /// implied permissions (e.g., EDIT implies VIEW) or inherited permissions from the parent entity. Effective
            /// permissions are read-only.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effective")]
            public virtual System.Collections.Generic.IList<string> Effective { get; set; }

            /// <summary>
            /// Permissions that a user has been assigned at this very level. Does not include any implied or inherited
            /// permissions. Local permissions are modifiable.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("local")]
            public virtual System.Collections.Generic.IList<string> Local { get; set; }
        }
    }

    /// <summary>
    /// An entity user link collection provides a list of Analytics ACL links Each resource in this collection
    /// corresponds to a single link.
    /// </summary>
    public class EntityUserLinks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of entity user links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<EntityUserLink> Items { get; set; }

        /// <summary>
        /// The maximum number of entries the response can contain, regardless of the actual number of entries returned.
        /// Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the max-results
        /// query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Next link for this account collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Previous link for this account collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the entries, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Analytics experiment resource.</summary>
    public class Experiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this experiment belongs. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Time the experiment was created. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Notes about this experiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// If true, the end user will be able to edit the experiment via the Google Analytics user interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editableInGaUi")]
        public virtual System.Nullable<bool> EditableInGaUi { get; set; }

        /// <summary>
        /// The ending time of the experiment (the time the status changed from RUNNING to ENDED). This field is present
        /// only if the experiment has ended. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual System.DateTime? EndTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Boolean specifying whether to distribute traffic evenly across all variations. If the value is False,
        /// content experiments follows the default behavior of adjusting traffic dynamically based on variation
        /// performance. Optional -- defaults to False. This field may not be changed for an experiment whose status is
        /// ENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equalWeighting")]
        public virtual System.Nullable<bool> EqualWeighting { get; set; }

        /// <summary>Experiment ID. Required for patch and update. Disallowed for create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Internal ID for the web property to which this experiment belongs. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for an Analytics experiment. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// An integer number in [3, 90]. Specifies the minimum length of the experiment. Can be changed for a running
        /// experiment. This field may not be changed for an experiments whose status is ENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumExperimentLengthInDays")]
        public virtual System.Nullable<int> MinimumExperimentLengthInDays { get; set; }

        /// <summary>
        /// Experiment name. This field may not be changed for an experiment whose status is ENDED. This field is
        /// required when creating an experiment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The metric that the experiment is optimizing. Valid values: "ga:goal(n)Completions", "ga:adsenseAdsClicks",
        /// "ga:adsenseAdsViewed", "ga:adsenseRevenue", "ga:bounces", "ga:pageviews", "ga:sessionDuration",
        /// "ga:transactions", "ga:transactionRevenue". This field is required if status is "RUNNING" and
        /// servingFramework is one of "REDIRECT" or "API".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectiveMetric")]
        public virtual string ObjectiveMetric { get; set; }

        /// <summary>
        /// Whether the objectiveMetric should be minimized or maximized. Possible values: "MAXIMUM", "MINIMUM".
        /// Optional--defaults to "MAXIMUM". Cannot be specified without objectiveMetric. Cannot be modified when status
        /// is "RUNNING" or "ENDED".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationType")]
        public virtual string OptimizationType { get; set; }

        /// <summary>
        /// Parent link for an experiment. Points to the view (profile) to which this experiment belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>View (Profile) ID to which this experiment belongs. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>
        /// Why the experiment ended. Possible values: "STOPPED_BY_USER", "WINNER_FOUND", "EXPERIMENT_EXPIRED",
        /// "ENDED_WITH_NO_WINNER", "GOAL_OBJECTIVE_CHANGED". "ENDED_WITH_NO_WINNER" means that the experiment didn't
        /// expire but no winner was projected to be found. If the experiment status is changed via the API to ENDED
        /// this field is set to STOPPED_BY_USER. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonExperimentEnded")]
        public virtual string ReasonExperimentEnded { get; set; }

        /// <summary>
        /// Boolean specifying whether variations URLS are rewritten to match those of the original. This field may not
        /// be changed for an experiments whose status is ENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewriteVariationUrlsAsOriginal")]
        public virtual System.Nullable<bool> RewriteVariationUrlsAsOriginal { get; set; }

        /// <summary>Link for this experiment. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// The framework used to serve the experiment variations and evaluate the results. One of:   - REDIRECT: Google
        /// Analytics redirects traffic to different variation pages, reports the chosen variation and evaluates the
        /// results. - API: Google Analytics chooses and reports the variation to serve and evaluates the results; the
        /// caller is responsible for serving the selected variation. - EXTERNAL: The variations will be served
        /// externally and the chosen variation reported to Google Analytics. The caller is responsible for serving the
        /// selected variation and evaluating the results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingFramework")]
        public virtual string ServingFramework { get; set; }

        /// <summary>The snippet of code to include on the control page(s). This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>
        /// The starting time of the experiment (the time the status changed from READY_TO_RUN to RUNNING). This field
        /// is present only if the experiment has started. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual System.DateTime? StartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Experiment status. Possible values: "DRAFT", "READY_TO_RUN", "RUNNING", "ENDED". Experiments can be created
        /// in the "DRAFT", "READY_TO_RUN" or "RUNNING" state. This field is required when creating an experiment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// A floating-point number in (0, 1]. Specifies the fraction of the traffic that participates in the
        /// experiment. Can be changed for a running experiment. This field may not be changed for an experiments whose
        /// status is ENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficCoverage")]
        public virtual System.Nullable<double> TrafficCoverage { get; set; }

        /// <summary>Time the experiment was last modified. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Array of variations. The first variation in the array is the original. The number of variations may not
        /// change once an experiment is in the RUNNING state. At least two variations are required before status can be
        /// set to RUNNING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variations")]
        public virtual System.Collections.Generic.IList<VariationsData> Variations { get; set; }

        /// <summary>
        /// Web property ID to which this experiment belongs. The web property ID is of the form UA-XXXXX-YY. This field
        /// is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>
        /// A floating-point number in (0, 1). Specifies the necessary confidence level to choose a winner. This field
        /// may not be changed for an experiments whose status is ENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("winnerConfidenceLevel")]
        public virtual System.Nullable<double> WinnerConfidenceLevel { get; set; }

        /// <summary>
        /// Boolean specifying whether a winner has been found for this experiment. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("winnerFound")]
        public virtual System.Nullable<bool> WinnerFound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Parent link for an experiment. Points to the view (profile) to which this experiment belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the view (profile) to which this experiment belongs. This field is read-only.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#profile". This field is read-only.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>
        /// Array of variations. The first variation in the array is the original. The number of variations may not
        /// change once an experiment is in the RUNNING state. At least two variations are required before status can be
        /// set to RUNNING.
        /// </summary>
        public class VariationsData
        {
            /// <summary>
            /// The name of the variation. This field is required when creating an experiment. This field may not be
            /// changed for an experiment whose status is ENDED.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>
            /// Status of the variation. Possible values: "ACTIVE", "INACTIVE". INACTIVE variations are not served. This
            /// field may not be changed for an experiment whose status is ENDED.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("status")]
            public virtual string Status { get; set; }

            /// <summary>
            /// The URL of the variation. This field may not be changed for an experiment whose status is RUNNING or
            /// ENDED.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }

            /// <summary>
            /// Weight that this variation should receive. Only present if the experiment is running. This field is
            /// read-only.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("weight")]
            public virtual System.Nullable<double> Weight { get; set; }

            /// <summary>
            /// True if the experiment has ended and this variation performed (statistically) significantly better than
            /// the original. This field is read-only.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("won")]
            public virtual System.Nullable<bool> Won { get; set; }
        }
    }

    /// <summary>
    /// An experiment collection lists Analytics experiments to which the user has access. Each view (profile) can have
    /// a set of experiments. Each resource in the Experiment collection corresponds to a single Analytics experiment.
    /// </summary>
    public class Experiments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of experiments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Experiment> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this experiment collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this experiment collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of resources in the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Analytics account filter.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this filter belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Details for the filter of the type ADVANCED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedDetails")]
        public virtual AdvancedDetailsData AdvancedDetails { get; set; }

        /// <summary>Time this filter was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Details for the filter of the type EXCLUDE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeDetails")]
        public virtual FilterExpression ExcludeDetails { get; set; }

        /// <summary>Filter ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Details for the filter of the type INCLUDE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeDetails")]
        public virtual FilterExpression IncludeDetails { get; set; }

        /// <summary>Resource type for Analytics filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Details for the filter of the type LOWER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowercaseDetails")]
        public virtual LowercaseDetailsData LowercaseDetails { get; set; }

        /// <summary>Name of this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Parent link for this filter. Points to the account to which this filter belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>Details for the filter of the type SEARCH_AND_REPLACE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchAndReplaceDetails")]
        public virtual SearchAndReplaceDetailsData SearchAndReplaceDetails { get; set; }

        /// <summary>Link for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Type of this filter. Possible values are INCLUDE, EXCLUDE, LOWERCASE, UPPERCASE, SEARCH_AND_REPLACE and
        /// ADVANCED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time this filter was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Details for the filter of the type UPPER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uppercaseDetails")]
        public virtual UppercaseDetailsData UppercaseDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Details for the filter of the type ADVANCED.</summary>
        public class AdvancedDetailsData
        {
            /// <summary>Indicates if the filter expressions are case sensitive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
            public virtual System.Nullable<bool> CaseSensitive { get; set; }

            /// <summary>Expression to extract from field A.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("extractA")]
            public virtual string ExtractA { get; set; }

            /// <summary>Expression to extract from field B.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("extractB")]
            public virtual string ExtractB { get; set; }

            /// <summary>Field A.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldA")]
            public virtual string FieldA { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldAIndex")]
            public virtual System.Nullable<int> FieldAIndex { get; set; }

            /// <summary>Indicates if field A is required to match.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldARequired")]
            public virtual System.Nullable<bool> FieldARequired { get; set; }

            /// <summary>Field B.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldB")]
            public virtual string FieldB { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldBIndex")]
            public virtual System.Nullable<int> FieldBIndex { get; set; }

            /// <summary>Indicates if field B is required to match.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldBRequired")]
            public virtual System.Nullable<bool> FieldBRequired { get; set; }

            /// <summary>Expression used to construct the output value.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("outputConstructor")]
            public virtual string OutputConstructor { get; set; }

            /// <summary>Output field.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("outputToField")]
            public virtual string OutputToField { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("outputToFieldIndex")]
            public virtual System.Nullable<int> OutputToFieldIndex { get; set; }

            /// <summary>
            /// Indicates if the existing value of the output field, if any, should be overridden by the output
            /// expression.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("overrideOutputField")]
            public virtual System.Nullable<bool> OverrideOutputField { get; set; }
        }

        /// <summary>Details for the filter of the type LOWER.</summary>
        public class LowercaseDetailsData
        {
            /// <summary>Field to use in the filter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("field")]
            public virtual string Field { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldIndex")]
            public virtual System.Nullable<int> FieldIndex { get; set; }
        }

        /// <summary>Parent link for this filter. Points to the account to which this filter belongs.</summary>
        public class ParentLinkData
        {
            /// <summary>Link to the account to which this filter belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#account".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Details for the filter of the type SEARCH_AND_REPLACE.</summary>
        public class SearchAndReplaceDetailsData
        {
            /// <summary>Determines if the filter is case sensitive.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
            public virtual System.Nullable<bool> CaseSensitive { get; set; }

            /// <summary>Field to use in the filter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("field")]
            public virtual string Field { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldIndex")]
            public virtual System.Nullable<int> FieldIndex { get; set; }

            /// <summary>Term to replace the search term with.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("replaceString")]
            public virtual string ReplaceString { get; set; }

            /// <summary>Term to search.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("searchString")]
            public virtual string SearchString { get; set; }
        }

        /// <summary>Details for the filter of the type UPPER.</summary>
        public class UppercaseDetailsData
        {
            /// <summary>Field to use in the filter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("field")]
            public virtual string Field { get; set; }

            /// <summary>The Index of the custom dimension. Required if field is a CUSTOM_DIMENSION.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldIndex")]
            public virtual System.Nullable<int> FieldIndex { get; set; }
        }
    }

    /// <summary>JSON template for an Analytics filter expression.</summary>
    public class FilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines if the filter is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Filter expression value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressionValue")]
        public virtual string ExpressionValue { get; set; }

        /// <summary>
        /// Field to filter. Possible values:   - Content and Traffic   - PAGE_REQUEST_URI,  - PAGE_HOSTNAME,  -
        /// PAGE_TITLE,  - REFERRAL,  - COST_DATA_URI (Campaign target URL),  - HIT_TYPE,  - INTERNAL_SEARCH_TERM,  -
        /// INTERNAL_SEARCH_TYPE,  - SOURCE_PROPERTY_TRACKING_ID,    - Campaign or AdGroup   - CAMPAIGN_SOURCE,  -
        /// CAMPAIGN_MEDIUM,  - CAMPAIGN_NAME,  - CAMPAIGN_AD_GROUP,  - CAMPAIGN_TERM,  - CAMPAIGN_CONTENT,  -
        /// CAMPAIGN_CODE,  - CAMPAIGN_REFERRAL_PATH,    - E-Commerce   - TRANSACTION_COUNTRY,  - TRANSACTION_REGION,  -
        /// TRANSACTION_CITY,  - TRANSACTION_AFFILIATION (Store or order location),  - ITEM_NAME,  - ITEM_CODE,  -
        /// ITEM_VARIATION,  - TRANSACTION_ID,  - TRANSACTION_CURRENCY_CODE,  - PRODUCT_ACTION_TYPE,    - Audience/Users
        ///   - BROWSER,  - BROWSER_VERSION,  - BROWSER_SIZE,  - PLATFORM,  - PLATFORM_VERSION,  - LANGUAGE,  -
        /// SCREEN_RESOLUTION,  - SCREEN_COLORS,  - JAVA_ENABLED (Boolean Field),  - FLASH_VERSION,  - GEO_SPEED
        /// (Connection speed),  - VISITOR_TYPE,  - GEO_ORGANIZATION (ISP organization),  - GEO_DOMAIN,  -
        /// GEO_IP_ADDRESS,  - GEO_IP_VERSION,    - Location   - GEO_COUNTRY,  - GEO_REGION,  - GEO_CITY,    - Event   -
        /// EVENT_CATEGORY,  - EVENT_ACTION,  - EVENT_LABEL,    - Other   - CUSTOM_FIELD_1,  - CUSTOM_FIELD_2,  -
        /// USER_DEFINED_VALUE,    - Application   - APP_ID,  - APP_INSTALLER_ID,  - APP_NAME,  - APP_VERSION,  -
        /// SCREEN,  - IS_APP (Boolean Field),  - IS_FATAL_EXCEPTION (Boolean Field),  - EXCEPTION_DESCRIPTION,    -
        /// Mobile device   - IS_MOBILE (Boolean Field, Deprecated. Use DEVICE_CATEGORY=mobile),  - IS_TABLET (Boolean
        /// Field, Deprecated. Use DEVICE_CATEGORY=tablet),  - DEVICE_CATEGORY,  - MOBILE_HAS_QWERTY_KEYBOARD (Boolean
        /// Field),  - MOBILE_HAS_NFC_SUPPORT (Boolean Field),  - MOBILE_HAS_CELLULAR_RADIO (Boolean Field),  -
        /// MOBILE_HAS_WIFI_SUPPORT (Boolean Field),  - MOBILE_BRAND_NAME,  - MOBILE_MODEL_NAME,  -
        /// MOBILE_MARKETING_NAME,  - MOBILE_POINTING_METHOD,    - Social   - SOCIAL_NETWORK,  - SOCIAL_ACTION,  -
        /// SOCIAL_ACTION_TARGET,    - Custom dimension   - CUSTOM_DIMENSION (See accompanying field index),
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The Index of the custom dimension. Set only if the field is a is CUSTOM_DIMENSION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldIndex")]
        public virtual System.Nullable<int> FieldIndex { get; set; }

        /// <summary>Kind value for filter expression</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Match type for this filter. Possible values are BEGINS_WITH, EQUAL, ENDS_WITH, CONTAINS, or MATCHES.
        /// GEO_DOMAIN, GEO_IP_ADDRESS, PAGE_REQUEST_URI, or PAGE_HOSTNAME filters can use any match type; all other
        /// filters must use MATCHES.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a profile filter link.</summary>
    public class FilterRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this filter belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Link for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("href")]
        public virtual string Href { get; set; }

        /// <summary>Filter ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind value for filter reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter collection lists filters created by users in an Analytics account. Each resource in the collection
    /// corresponds to a filter.
    /// </summary>
    public class Filters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Filter> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1,000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this filter collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this filter collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Analytics data for a given view (profile).</summary>
    public class GaData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual System.Collections.Generic.IList<ColumnHeadersData> ColumnHeaders { get; set; }

        /// <summary>Determines if Analytics data contains samples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsSampledData")]
        public virtual System.Nullable<bool> ContainsSampledData { get; set; }

        /// <summary>The last refreshed time in seconds for Analytics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLastRefreshed")]
        public virtual System.Nullable<long> DataLastRefreshed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataTable")]
        public virtual DataTableData DataTable { get; set; }

        /// <summary>Unique ID for this data response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The maximum number of rows the response can contain, regardless of the actual number of rows returned. Its
        /// value ranges from 1 to 10,000 with a value of 1000 by default, or otherwise specified by the max-results
        /// query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this Analytics data query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this Analytics data query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>Information for the view (profile), for which the Analytics data was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileInfo")]
        public virtual ProfileInfoData ProfileInfo { get; set; }

        /// <summary>Analytics data request query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual QueryData Query { get; set; }

        /// <summary>
        /// Analytics data rows, where each row contains a list of dimension values followed by the metric values. The
        /// order of dimensions and metrics is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<string>> Rows { get; set; }

        /// <summary>The number of samples used to calculate the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleSize")]
        public virtual System.Nullable<long> SampleSize { get; set; }

        /// <summary>Total size of the sample space from which the samples were selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleSpace")]
        public virtual System.Nullable<long> SampleSpace { get; set; }

        /// <summary>Link to this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The total number of rows for the query, regardless of the number of rows in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>
        /// Total values for the requested metrics over all the results, not just the results returned in this response.
        /// The order of the metric totals is same as the metric order specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalsForAllResults")]
        public virtual System.Collections.Generic.IDictionary<string, string> TotalsForAllResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        public class ColumnHeadersData
        {
            /// <summary>Column Type. Either DIMENSION or METRIC.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
            public virtual string ColumnType { get; set; }

            /// <summary>
            /// Data type. Dimension column headers have only STRING as the data type. Metric column headers have data
            /// types for metric values such as INTEGER, DOUBLE, CURRENCY etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
            public virtual string DataType { get; set; }

            /// <summary>Column name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }

        public class DataTableData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("cols")]
            public virtual System.Collections.Generic.IList<ColsData> Cols { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("rows")]
            public virtual System.Collections.Generic.IList<RowsData> Rows { get; set; }

            public class ColsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("id")]
                public virtual string Id { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("label")]
                public virtual string Label { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                public virtual string Type { get; set; }
            }

            public class RowsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("c")]
                public virtual System.Collections.Generic.IList<CData> C { get; set; }

                public class CData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("v")]
                    public virtual string V { get; set; }
                }
            }
        }

        /// <summary>Information for the view (profile), for which the Analytics data was requested.</summary>
        public class ProfileInfoData
        {
            /// <summary>Account ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
            public virtual string AccountId { get; set; }

            /// <summary>Internal ID for the web property to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
            public virtual string InternalWebPropertyId { get; set; }

            /// <summary>View (Profile) ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId { get; set; }

            /// <summary>View (Profile) name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
            public virtual string ProfileName { get; set; }

            /// <summary>Table ID for view (profile).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
            public virtual string TableId { get; set; }

            /// <summary>Web Property ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
            public virtual string WebPropertyId { get; set; }
        }

        /// <summary>Analytics data request query parameters.</summary>
        public class QueryData
        {
            /// <summary>List of analytics dimensions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
            public virtual string Dimensions { get; set; }

            /// <summary>End date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("end-date")]
            public virtual string EndDate { get; set; }

            /// <summary>Comma-separated list of dimension or metric filters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("filters")]
            public virtual string Filters { get; set; }

            /// <summary>Unique table ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ids")]
            public virtual string Ids { get; set; }

            /// <summary>Maximum results per page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("max-results")]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>List of analytics metrics.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
            public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

            /// <summary>Desired sampling level</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("samplingLevel")]
            public virtual string SamplingLevel { get; set; }

            /// <summary>Analytics advanced segment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("segment")]
            public virtual string Segment { get; set; }

            /// <summary>List of dimensions or metrics based on which Analytics data is sorted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sort")]
            public virtual System.Collections.Generic.IList<string> Sort { get; set; }

            /// <summary>Start date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-date")]
            public virtual string StartDate { get; set; }

            /// <summary>Start index.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-index")]
            public virtual System.Nullable<int> StartIndex { get; set; }
        }
    }

    /// <summary>JSON template for Analytics goal resource.</summary>
    public class Goal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this goal belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Determines whether this goal is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>Time this goal was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Details for the goal of the type EVENT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDetails")]
        public virtual EventDetailsData EventDetails { get; set; }

        /// <summary>Goal ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for the web property to which this goal belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for an Analytics goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Goal name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Parent link for a goal. Points to the view (profile) to which this goal belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>View (Profile) ID to which this goal belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>Link for this goal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Goal type. Possible values are URL_DESTINATION, VISIT_TIME_ON_SITE, VISIT_NUM_PAGES, AND EVENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time this goal was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Details for the goal of the type URL_DESTINATION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlDestinationDetails")]
        public virtual UrlDestinationDetailsData UrlDestinationDetails { get; set; }

        /// <summary>Goal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>Details for the goal of the type VISIT_NUM_PAGES.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitNumPagesDetails")]
        public virtual VisitNumPagesDetailsData VisitNumPagesDetails { get; set; }

        /// <summary>Details for the goal of the type VISIT_TIME_ON_SITE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitTimeOnSiteDetails")]
        public virtual VisitTimeOnSiteDetailsData VisitTimeOnSiteDetails { get; set; }

        /// <summary>
        /// Web property ID to which this goal belongs. The web property ID is of the form UA-XXXXX-YY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Details for the goal of the type EVENT.</summary>
        public class EventDetailsData
        {
            /// <summary>List of event conditions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventConditions")]
            public virtual System.Collections.Generic.IList<EventConditionsData> EventConditions { get; set; }

            /// <summary>Determines if the event value should be used as the value for this goal.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("useEventValue")]
            public virtual System.Nullable<bool> UseEventValue { get; set; }

            /// <summary>List of event conditions.</summary>
            public class EventConditionsData
            {
                /// <summary>Type of comparison. Possible values are LESS_THAN, GREATER_THAN or EQUAL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
                public virtual string ComparisonType { get; set; }

                /// <summary>Value used for this comparison.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
                public virtual System.Nullable<long> ComparisonValue { get; set; }

                /// <summary>Expression used for this match.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("expression")]
                public virtual string Expression { get; set; }

                /// <summary>
                /// Type of the match to be performed. Possible values are REGEXP, BEGINS_WITH, or EXACT.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
                public virtual string MatchType { get; set; }

                /// <summary>
                /// Type of this event condition. Possible values are CATEGORY, ACTION, LABEL, or VALUE.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                public virtual string Type { get; set; }
            }
        }

        /// <summary>Parent link for a goal. Points to the view (profile) to which this goal belongs.</summary>
        public class ParentLinkData
        {
            /// <summary>Link to the view (profile) to which this goal belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#profile".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Details for the goal of the type URL_DESTINATION.</summary>
        public class UrlDestinationDetailsData
        {
            /// <summary>Determines if the goal URL must exactly match the capitalization of visited URLs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
            public virtual System.Nullable<bool> CaseSensitive { get; set; }

            /// <summary>Determines if the first step in this goal is required.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("firstStepRequired")]
            public virtual System.Nullable<bool> FirstStepRequired { get; set; }

            /// <summary>Match type for the goal URL. Possible values are HEAD, EXACT, or REGEX.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
            public virtual string MatchType { get; set; }

            /// <summary>List of steps configured for this goal funnel.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("steps")]
            public virtual System.Collections.Generic.IList<StepsData> Steps { get; set; }

            /// <summary>URL for this goal.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }

            /// <summary>List of steps configured for this goal funnel.</summary>
            public class StepsData
            {
                /// <summary>Step name.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name { get; set; }

                /// <summary>Step number.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("number")]
                public virtual System.Nullable<int> Number { get; set; }

                /// <summary>URL for this step.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }
        }

        /// <summary>Details for the goal of the type VISIT_NUM_PAGES.</summary>
        public class VisitNumPagesDetailsData
        {
            /// <summary>Type of comparison. Possible values are LESS_THAN, GREATER_THAN, or EQUAL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
            public virtual string ComparisonType { get; set; }

            /// <summary>Value used for this comparison.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
            public virtual System.Nullable<long> ComparisonValue { get; set; }
        }

        /// <summary>Details for the goal of the type VISIT_TIME_ON_SITE.</summary>
        public class VisitTimeOnSiteDetailsData
        {
            /// <summary>Type of comparison. Possible values are LESS_THAN or GREATER_THAN.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
            public virtual string ComparisonType { get; set; }

            /// <summary>Value used for this comparison.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
            public virtual System.Nullable<long> ComparisonValue { get; set; }
        }
    }

    /// <summary>
    /// A goal collection lists Analytics goals to which the user has access. Each view (profile) can have a set of
    /// goals. Each resource in the Goal collection corresponds to a single Analytics goal.
    /// </summary>
    public class Goals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of goals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Goal> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this goal collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this goal collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of resources in the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a hash Client Id request resource.</summary>
    public class HashClientIdRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a hash Client Id response resource.</summary>
    public class HashClientIdResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hashedClientId")]
        public virtual string HashedClientId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Analytics Remarketing Include Conditions.</summary>
    public class IncludeConditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The look-back window lets you specify a time frame for evaluating the behavior that qualifies users for your
        /// audience. For example, if your filters include users from Central Asia, and Transactions Greater than 2, and
        /// you set the look-back window to 14 days, then any user from Central Asia whose cumulative transactions
        /// exceed 2 during the last 14 days is added to the audience.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysToLookBack")]
        public virtual System.Nullable<int> DaysToLookBack { get; set; }

        /// <summary>
        /// Boolean indicating whether this segment is a smart list. https://support.google.com/analytics/answer/4628577
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSmartList")]
        public virtual System.Nullable<bool> IsSmartList { get; set; }

        /// <summary>Resource type for include conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Number of days (in the range 1 to 540) a user remains in the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDurationDays")]
        public virtual System.Nullable<int> MembershipDurationDays { get; set; }

        /// <summary>The segment condition that will cause a user to be added to an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual string Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Analytics Remarketing Audience Foreign Link.</summary>
    public class LinkedForeignAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this linked foreign account belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Boolean indicating whether this is eligible for search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForSearch")]
        public virtual System.Nullable<bool> EligibleForSearch { get; set; }

        /// <summary>Entity ad account link ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for the web property to which this linked foreign account belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for linked foreign account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The foreign account ID. For example the an Google Ads `linkedAccountId` has the following format
        /// XXX-XXX-XXXX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccountId")]
        public virtual string LinkedAccountId { get; set; }

        /// <summary>Remarketing audience ID to which this linked foreign account belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remarketingAudienceId")]
        public virtual string RemarketingAudienceId { get; set; }

        /// <summary>The status of this foreign account link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The type of the foreign account. For example, `ADWORDS_LINKS`, `DBM_LINKS`, `MCC_LINKS` or `OPTIMIZE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this linked foreign account belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Multi-Channel Funnels data for a given view (profile).</summary>
    public class McfData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual System.Collections.Generic.IList<ColumnHeadersData> ColumnHeaders { get; set; }

        /// <summary>Determines if the Analytics data contains sampled data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsSampledData")]
        public virtual System.Nullable<bool> ContainsSampledData { get; set; }

        /// <summary>Unique ID for this data response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The maximum number of rows the response can contain, regardless of the actual number of rows returned. Its
        /// value ranges from 1 to 10,000 with a value of 1000 by default, or otherwise specified by the max-results
        /// query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this Analytics data query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this Analytics data query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>Information for the view (profile), for which the Analytics data was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileInfo")]
        public virtual ProfileInfoData ProfileInfo { get; set; }

        /// <summary>Analytics data request query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual QueryData Query { get; set; }

        /// <summary>
        /// Analytics data rows, where each row contains a list of dimension values followed by the metric values. The
        /// order of dimensions and metrics is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<RowsData>> Rows { get; set; }

        /// <summary>The number of samples used to calculate the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleSize")]
        public virtual System.Nullable<long> SampleSize { get; set; }

        /// <summary>Total size of the sample space from which the samples were selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleSpace")]
        public virtual System.Nullable<long> SampleSpace { get; set; }

        /// <summary>Link to this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The total number of rows for the query, regardless of the number of rows in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>
        /// Total values for the requested metrics over all the results, not just the results returned in this response.
        /// The order of the metric totals is same as the metric order specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalsForAllResults")]
        public virtual System.Collections.Generic.IDictionary<string, string> TotalsForAllResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        public class ColumnHeadersData
        {
            /// <summary>Column Type. Either DIMENSION or METRIC.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
            public virtual string ColumnType { get; set; }

            /// <summary>
            /// Data type. Dimension and metric values data types such as INTEGER, DOUBLE, CURRENCY, MCF_SEQUENCE etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
            public virtual string DataType { get; set; }

            /// <summary>Column name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }

        /// <summary>Information for the view (profile), for which the Analytics data was requested.</summary>
        public class ProfileInfoData
        {
            /// <summary>Account ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
            public virtual string AccountId { get; set; }

            /// <summary>Internal ID for the web property to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
            public virtual string InternalWebPropertyId { get; set; }

            /// <summary>View (Profile) ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId { get; set; }

            /// <summary>View (Profile) name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
            public virtual string ProfileName { get; set; }

            /// <summary>Table ID for view (profile).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
            public virtual string TableId { get; set; }

            /// <summary>Web Property ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
            public virtual string WebPropertyId { get; set; }
        }

        /// <summary>Analytics data request query parameters.</summary>
        public class QueryData
        {
            /// <summary>List of analytics dimensions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
            public virtual string Dimensions { get; set; }

            /// <summary>End date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("end-date")]
            public virtual string EndDate { get; set; }

            /// <summary>Comma-separated list of dimension or metric filters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("filters")]
            public virtual string Filters { get; set; }

            /// <summary>Unique table ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ids")]
            public virtual string Ids { get; set; }

            /// <summary>Maximum results per page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("max-results")]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>List of analytics metrics.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
            public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

            /// <summary>Desired sampling level</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("samplingLevel")]
            public virtual string SamplingLevel { get; set; }

            /// <summary>Analytics advanced segment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("segment")]
            public virtual string Segment { get; set; }

            /// <summary>List of dimensions or metrics based on which Analytics data is sorted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sort")]
            public virtual System.Collections.Generic.IList<string> Sort { get; set; }

            /// <summary>Start date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-date")]
            public virtual string StartDate { get; set; }

            /// <summary>Start index.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-index")]
            public virtual System.Nullable<int> StartIndex { get; set; }
        }

        /// <summary>
        /// Analytics data rows, where each row contains a list of dimension values followed by the metric values. The
        /// order of dimensions and metrics is same as specified in the request.
        /// </summary>
        public class RowsData
        {
            /// <summary>
            /// A conversion path dimension value, containing a list of interactions with their attributes.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("conversionPathValue")]
            public virtual System.Collections.Generic.IList<ConversionPathValueData> ConversionPathValue { get; set; }

            /// <summary>A primitive dimension value. A primitive metric value.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("primitiveValue")]
            public virtual string PrimitiveValue { get; set; }

            /// <summary>
            /// A conversion path dimension value, containing a list of interactions with their attributes.
            /// </summary>
            public class ConversionPathValueData
            {
                /// <summary>Type of an interaction on conversion path. Such as CLICK, IMPRESSION etc.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("interactionType")]
                public virtual string InteractionType { get; set; }

                /// <summary>Node value of an interaction on conversion path. Such as source, medium etc.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("nodeValue")]
                public virtual string NodeValue { get; set; }
            }
        }
    }

    /// <summary>JSON template for an Analytics view (profile).</summary>
    public class Profile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Indicates whether bot filtering is enabled for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botFilteringEnabled")]
        public virtual System.Nullable<bool> BotFilteringEnabled { get; set; }

        /// <summary>Child link for this view (profile). Points to the list of goals for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual ChildLinkData ChildLink { get; set; }

        /// <summary>Time this view (profile) was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The currency type associated with this view (profile), defaults to USD. The supported values are: USD, JPY,
        /// EUR, GBP, AUD, KRW, BRL, CNY, DKK, RUB, SEK, NOK, PLN, TRY, TWD, HKD, THB, IDR, ARS, MXN, VND, PHP, INR,
        /// CHF, CAD, CZK, NZD, HUF, BGN, LTL, ZAR, UAH, AED, BOB, CLP, COP, EGP, HRK, ILS, MAD, MYR, PEN, PKR, RON,
        /// RSD, SAR, SGD, VEF, LVL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>Default page for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPage")]
        public virtual string DefaultPage { get; set; }

        /// <summary>Indicates whether ecommerce tracking is enabled for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eCommerceTracking")]
        public virtual System.Nullable<bool> ECommerceTracking { get; set; }

        /// <summary>
        /// Indicates whether enhanced ecommerce tracking is enabled for this view (profile). This property can only be
        /// enabled if ecommerce tracking is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedECommerceTracking")]
        public virtual System.Nullable<bool> EnhancedECommerceTracking { get; set; }

        /// <summary>The query parameters that are excluded from this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeQueryParameters")]
        public virtual string ExcludeQueryParameters { get; set; }

        /// <summary>View (Profile) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for the web property to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for Analytics view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parent link for this view (profile). Points to the web property to which this view (profile) belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>Permissions the user has for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual PermissionsData Permissions { get; set; }

        /// <summary>Link for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Site search category parameters for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchCategoryParameters")]
        public virtual string SiteSearchCategoryParameters { get; set; }

        /// <summary>The site search query parameters for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchQueryParameters")]
        public virtual string SiteSearchQueryParameters { get; set; }

        /// <summary>Indicates whether this view (profile) is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>
        /// Whether or not Analytics will strip search category parameters from the URLs in your reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stripSiteSearchCategoryParameters")]
        public virtual System.Nullable<bool> StripSiteSearchCategoryParameters { get; set; }

        /// <summary>
        /// Whether or not Analytics will strip search query parameters from the URLs in your reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stripSiteSearchQueryParameters")]
        public virtual System.Nullable<bool> StripSiteSearchQueryParameters { get; set; }

        /// <summary>
        /// Time zone for which this view (profile) has been configured. Time zones are identified by strings from the
        /// TZ database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone { get; set; }

        /// <summary>View (Profile) type. Supported types: WEB or APP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time this view (profile) was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>Website URL for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Child link for this view (profile). Points to the list of goals for this view (profile).</summary>
        public class ChildLinkData
        {
            /// <summary>Link to the list of goals for this view (profile).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#goals".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>
        /// Parent link for this view (profile). Points to the web property to which this view (profile) belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the web property to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Value is "analytics#webproperty".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Permissions the user has for this view (profile).</summary>
        public class PermissionsData
        {
            /// <summary>
            /// All the permissions that the user has for this view (profile). These include any implied permissions
            /// (e.g., EDIT implies VIEW) or inherited permissions from the parent web property.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effective")]
            public virtual System.Collections.Generic.IList<string> Effective { get; set; }
        }
    }

    /// <summary>JSON template for an Analytics profile filter link.</summary>
    public class ProfileFilterLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter for this link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterRef")]
        public virtual FilterRef FilterRef { get; set; }

        /// <summary>Profile filter link ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>View (Profile) for this link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileRef")]
        public virtual ProfileRef ProfileRef { get; set; }

        /// <summary>
        /// The rank of this profile filter link relative to the other filters linked to the same profile. For readonly
        /// (i.e., list and get) operations, the rank always starts at 1. For write (i.e., create, update, or delete)
        /// operations, you may specify a value between 0 and 255 inclusively, [0, 255]. In order to insert a link at
        /// the end of the list, either don't specify a rank or set a rank to a number greater than the largest rank in
        /// the list. In order to insert a link to the beginning of the list specify a rank that is less than or equal
        /// to 1. The new link will move all existing filters with the same or lower rank down the list. After the link
        /// is inserted/updated/deleted all profile filter links will be renumbered starting at 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<int> Rank { get; set; }

        /// <summary>Link for this profile filter link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A profile filter link collection lists profile filter links between profiles and filters. Each resource in the
    /// collection corresponds to a profile filter link.
    /// </summary>
    public class ProfileFilterLinks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of profile filter links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ProfileFilterLink> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1,000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this profile filter link collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this profile filter link collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a linked view (profile).</summary>
    public class ProfileRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Link for this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("href")]
        public virtual string Href { get; set; }

        /// <summary>View (Profile) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for the web property to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Analytics view (profile) reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this view (profile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this view (profile) belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics ProfileSummary. ProfileSummary returns basic information (i.e., summary) for a
    /// profile.
    /// </summary>
    public class ProfileSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>View (profile) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics ProfileSummary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>View (profile) name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Indicates whether this view (profile) is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>View (Profile) type. Supported types: WEB or APP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A view (profile) collection lists Analytics views (profiles) to which the user has access. Each resource in the
    /// collection corresponds to a single Analytics view (profile).
    /// </summary>
    public class Profiles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of views (profiles).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Profile> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this view (profile) collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this view (profile) collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Real time data for a given view (profile).</summary>
    public class RealtimeData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual System.Collections.Generic.IList<ColumnHeadersData> ColumnHeaders { get; set; }

        /// <summary>Unique ID for this data response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Information for the view (profile), for which the real time data was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileInfo")]
        public virtual ProfileInfoData ProfileInfo { get; set; }

        /// <summary>Real time data request query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual QueryData Query { get; set; }

        /// <summary>
        /// Real time data rows, where each row contains a list of dimension values followed by the metric values. The
        /// order of dimensions and metrics is same as specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<string>> Rows { get; set; }

        /// <summary>Link to this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The total number of rows for the query, regardless of the number of rows in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>
        /// Total values for the requested metrics over all the results, not just the results returned in this response.
        /// The order of the metric totals is same as the metric order specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalsForAllResults")]
        public virtual System.Collections.Generic.IDictionary<string, string> TotalsForAllResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Column headers that list dimension names followed by the metric names. The order of dimensions and metrics
        /// is same as specified in the request.
        /// </summary>
        public class ColumnHeadersData
        {
            /// <summary>Column Type. Either DIMENSION or METRIC.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
            public virtual string ColumnType { get; set; }

            /// <summary>
            /// Data type. Dimension column headers have only STRING as the data type. Metric column headers have data
            /// types for metric values such as INTEGER, DOUBLE, CURRENCY etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
            public virtual string DataType { get; set; }

            /// <summary>Column name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }

        /// <summary>Information for the view (profile), for which the real time data was requested.</summary>
        public class ProfileInfoData
        {
            /// <summary>Account ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
            public virtual string AccountId { get; set; }

            /// <summary>Internal ID for the web property to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
            public virtual string InternalWebPropertyId { get; set; }

            /// <summary>View (Profile) ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId { get; set; }

            /// <summary>View (Profile) name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
            public virtual string ProfileName { get; set; }

            /// <summary>Table ID for view (profile).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
            public virtual string TableId { get; set; }

            /// <summary>Web Property ID to which this view (profile) belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
            public virtual string WebPropertyId { get; set; }
        }

        /// <summary>Real time data request query parameters.</summary>
        public class QueryData
        {
            /// <summary>List of real time dimensions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
            public virtual string Dimensions { get; set; }

            /// <summary>Comma-separated list of dimension or metric filters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("filters")]
            public virtual string Filters { get; set; }

            /// <summary>Unique table ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ids")]
            public virtual string Ids { get; set; }

            /// <summary>Maximum results per page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("max-results")]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>List of real time metrics.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
            public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

            /// <summary>List of dimensions or metrics based on which real time data is sorted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sort")]
            public virtual System.Collections.Generic.IList<string> Sort { get; set; }
        }
    }

    /// <summary>JSON template for an Analytics remarketing audience.</summary>
    public class RemarketingAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this remarketing audience belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The simple audience definition that will cause a user to be added to an audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceDefinition")]
        public virtual AudienceDefinitionData AudienceDefinition { get; set; }

        /// <summary>The type of audience, either SIMPLE or STATE_BASED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceType")]
        public virtual string AudienceType { get; set; }

        /// <summary>Time this remarketing audience was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The description of this remarketing audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Remarketing Audience ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for the web property to which this remarketing audience belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The linked ad accounts associated with this remarketing audience. A remarketing audience can have only one
        /// linkedAdAccount currently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAdAccounts")]
        public virtual System.Collections.Generic.IList<LinkedForeignAccount> LinkedAdAccounts { get; set; }

        /// <summary>The views (profiles) that this remarketing audience is linked to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedViews")]
        public virtual System.Collections.Generic.IList<string> LinkedViews { get; set; }

        /// <summary>The name of this remarketing audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A state based audience definition that will cause a user to be added or removed from an audience.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateBasedAudienceDefinition")]
        public virtual StateBasedAudienceDefinitionData StateBasedAudienceDefinition { get; set; }

        /// <summary>Time this remarketing audience was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this remarketing audience belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The simple audience definition that will cause a user to be added to an audience.</summary>
        public class AudienceDefinitionData
        {
            /// <summary>Defines the conditions to include users to the audience.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("includeConditions")]
            public virtual IncludeConditions IncludeConditions { get; set; }
        }

        /// <summary>
        /// A state based audience definition that will cause a user to be added or removed from an audience.
        /// </summary>
        public class StateBasedAudienceDefinitionData
        {
            /// <summary>Defines the conditions to exclude users from the audience.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("excludeConditions")]
            public virtual ExcludeConditionsData ExcludeConditions { get; set; }

            /// <summary>Defines the conditions to include users to the audience.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("includeConditions")]
            public virtual IncludeConditions IncludeConditions { get; set; }

            /// <summary>Defines the conditions to exclude users from the audience.</summary>
            public class ExcludeConditionsData
            {
                /// <summary>Whether to make the exclusion TEMPORARY or PERMANENT.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("exclusionDuration")]
                public virtual string ExclusionDuration { get; set; }

                /// <summary>The segment condition that will cause a user to be removed from an audience.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("segment")]
                public virtual string Segment { get; set; }
            }
        }
    }

    /// <summary>
    /// A remarketing audience collection lists Analytics remarketing audiences to which the user has access. Each
    /// resource in the collection corresponds to a single Analytics remarketing audience.
    /// </summary>
    public class RemarketingAudiences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of remarketing audiences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<RemarketingAudience> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this remarketing audience collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this view (profile) collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Analytics segment.</summary>
    public class Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time the segment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Segment definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual string Definition { get; set; }

        /// <summary>Segment ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Segment name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Segment ID. Can be used with the 'segment' parameter in Core Reporting API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>Link for this segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Type for a segment. Possible values are "BUILT_IN" or "CUSTOM".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Time the segment was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An segment collection lists Analytics segments that the user has access to. Each resource in the collection
    /// corresponds to a single Analytics segment.
    /// </summary>
    public class Segments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Segment> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type for segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this segment collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this segment collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Analytics unsampled report resource.</summary>
    public class UnsampledReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this unsampled report belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Download details for a file stored in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageDownloadDetails")]
        public virtual CloudStorageDownloadDetailsData CloudStorageDownloadDetails { get; set; }

        /// <summary>Time this unsampled report was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The dimensions for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual string Dimensions { get; set; }

        /// <summary>
        /// The type of download you need to use for the report data file. Possible values include `GOOGLE_DRIVE` and
        /// `GOOGLE_CLOUD_STORAGE`. If the value is `GOOGLE_DRIVE`, see the `driveDownloadDetails` field. If the value
        /// is `GOOGLE_CLOUD_STORAGE`, see the `cloudStorageDownloadDetails` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadType")]
        public virtual string DownloadType { get; set; }

        /// <summary>Download details for a file stored in Google Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDownloadDetails")]
        public virtual DriveDownloadDetailsData DriveDownloadDetails { get; set; }

        /// <summary>The end date for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end-date")]
        public virtual string EndDate { get; set; }

        /// <summary>The filters for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual string Filters { get; set; }

        /// <summary>Unsampled report ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for an Analytics unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The metrics for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual string Metrics { get; set; }

        /// <summary>View (Profile) ID to which this unsampled report belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>The segment for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual string Segment { get; set; }

        /// <summary>Link for this unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The start date for the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start-date")]
        public virtual string StartDate { get; set; }

        /// <summary>Status of this unsampled report. Possible values are PENDING, COMPLETED, or FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Title of the unsampled report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Time this unsampled report was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Web property ID to which this unsampled report belongs. The web property ID is of the form UA-XXXXX-YY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Download details for a file stored in Google Cloud Storage.</summary>
        public class CloudStorageDownloadDetailsData
        {
            /// <summary>Id of the bucket the file object is stored in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bucketId")]
            public virtual string BucketId { get; set; }

            /// <summary>Id of the file object containing the report data.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
            public virtual string ObjectId { get; set; }
        }

        /// <summary>Download details for a file stored in Google Drive.</summary>
        public class DriveDownloadDetailsData
        {
            /// <summary>Id of the document/file containing the report data.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
            public virtual string DocumentId { get; set; }
        }
    }

    /// <summary>
    /// An unsampled report collection lists Analytics unsampled reports to which the user has access. Each view
    /// (profile) can have a set of unsampled reports. Each resource in the unsampled report collection corresponds to a
    /// single Analytics unsampled report.
    /// </summary>
    public class UnsampledReports : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of unsampled reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<UnsampledReport> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this unsampled report collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this unsampled report collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of resources in the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata returned for an upload operation.</summary>
    public class Upload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account Id to which this upload belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>Custom data source Id to which this data import belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDataSourceId")]
        public virtual string CustomDataSourceId { get; set; }

        /// <summary>Data import errors collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<string> Errors { get; set; }

        /// <summary>A unique ID for this upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for Analytics upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Upload status. Possible values: PENDING, COMPLETED, FAILED, DELETING, DELETED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Time this file is uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTime")]
        public virtual string UploadTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UploadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UploadTimeDateTimeOffset instead.")]
        public virtual System.DateTime? UploadTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Upload collection lists Analytics uploads to which the user has access. Each custom data source can have a set
    /// of uploads. Each resource in the upload collection corresponds to a single Analytics data upload.
    /// </summary>
    public class Uploads : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Upload> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this upload collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this upload collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of resources in the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a user deletion request resource.</summary>
    public class UserDeletionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This marks the point in time for which all user data before should be deleted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionRequestTime")]
        public virtual string DeletionRequestTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DeletionRequestTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeletionRequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(DeletionRequestTimeRaw);
            set => DeletionRequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="DeletionRequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeletionRequestTimeDateTimeOffset instead.")]
        public virtual System.DateTime? DeletionRequestTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(DeletionRequestTimeRaw);
            set => DeletionRequestTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Firebase Project Id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseProjectId")]
        public virtual string FirebaseProjectId { get; set; }

        /// <summary>User ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual IdData Id { get; set; }

        /// <summary>Value is "analytics#userDeletionRequest".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Property ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyId")]
        public virtual string PropertyId { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>User ID.</summary>
        public class IdData
        {
            /// <summary>Type of user</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>The User's id</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("userId")]
            public virtual string UserId { get; set; }
        }
    }

    /// <summary>JSON template for a user reference.</summary>
    public class UserRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email ID of this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>User ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a web property reference.</summary>
    public class WebPropertyRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this web property belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Link for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("href")]
        public virtual string Href { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Analytics web property reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON template for an Analytics WebPropertySummary. WebPropertySummary returns basic information (i.e., summary)
    /// for a web property.
    /// </summary>
    public class WebPropertySummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Web property ID of the form UA-XXXXX-YY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Internal ID for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for Analytics WebPropertySummary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Level for this web property. Possible values are STANDARD or PREMIUM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>Web property name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of profiles under this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profiles")]
        public virtual System.Collections.Generic.IList<ProfileSummary> Profiles { get; set; }

        /// <summary>Indicates whether this web property is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>Website url for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A web property collection lists Analytics web properties to which the user has access. Each resource in the
    /// collection corresponds to a single Analytics web property.
    /// </summary>
    public class Webproperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of web properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Webproperty> Items { get; set; }

        /// <summary>
        /// The maximum number of resources the response can contain, regardless of the actual number of resources
        /// returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the
        /// max-results query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<int> ItemsPerPage { get; set; }

        /// <summary>Collection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Link to next page for this web property collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink { get; set; }

        /// <summary>Link to previous page for this web property collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink { get; set; }

        /// <summary>
        /// The starting index of the resources, which is 1 by default or otherwise specified by the start-index query
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The total number of results for the query, regardless of the number of results in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an Analytics web property.</summary>
    public class Webproperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account ID to which this web property belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Child link for this web property. Points to the list of views (profiles) for this web property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual ChildLinkData ChildLink { get; set; }

        /// <summary>Time this web property was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string CreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedDateTimeOffset instead.")]
        public virtual System.DateTime? Created
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedRaw);
            set => CreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Set to true to reset the retention period of the user identifier with each new event from that user (thus
        /// setting the expiration date to current time plus retention period). Set to false to delete data associated
        /// with the user identifier automatically after the rentention period. This property cannot be set on insert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionResetOnNewActivity")]
        public virtual System.Nullable<bool> DataRetentionResetOnNewActivity { get; set; }

        /// <summary>
        /// The length of time for which user and event data is retained. This property cannot be set on insert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionTtl")]
        public virtual string DataRetentionTtl { get; set; }

        /// <summary>Default view (profile) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultProfileId")]
        public virtual System.Nullable<long> DefaultProfileId { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The industry vertical/category selected for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industryVertical")]
        public virtual string IndustryVertical { get; set; }

        /// <summary>Internal ID for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        public virtual string InternalWebPropertyId { get; set; }

        /// <summary>Resource type for Analytics WebProperty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Level for this web property. Possible values are STANDARD or PREMIUM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>Name of this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parent link for this web property. Points to the account to which this web property belongs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual ParentLinkData ParentLink { get; set; }

        /// <summary>Permissions the user has for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual PermissionsData Permissions { get; set; }

        /// <summary>View (Profile) count for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileCount")]
        public virtual System.Nullable<int> ProfileCount { get; set; }

        /// <summary>Link for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Indicates whether this web property is starred or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>Time this web property was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Website url for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Child link for this web property. Points to the list of views (profiles) for this web property.
        /// </summary>
        public class ChildLinkData
        {
            /// <summary>Link to the list of views (profiles) for this web property.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Type of the parent link. Its value is "analytics#profiles".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>
        /// Parent link for this web property. Points to the account to which this web property belongs.
        /// </summary>
        public class ParentLinkData
        {
            /// <summary>Link to the account for this web property.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href { get; set; }

            /// <summary>Type of the parent link. Its value is "analytics#account".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Permissions the user has for this web property.</summary>
        public class PermissionsData
        {
            /// <summary>
            /// All the permissions that the user has for this web property. These include any implied permissions
            /// (e.g., EDIT implies VIEW) or inherited permissions from the parent account.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effective")]
            public virtual System.Collections.Generic.IList<string> Effective { get; set; }
        }
    }
}
