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

namespace Google.Apis.YouTubeAnalytics.v2
{
    /// <summary>The YouTubeAnalytics Service.</summary>
    public class YouTubeAnalyticsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public YouTubeAnalyticsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public YouTubeAnalyticsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            GroupItems = new GroupItemsResource(this);
            Groups = new GroupsResource(this);
            Reports = new ReportsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://youtubeanalytics.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://youtubeanalytics.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "youtubeAnalytics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the YouTube Analytics API.</summary>
        public class Scope
        {
            /// <summary>Manage your YouTube account</summary>
            public static string Youtube = "https://www.googleapis.com/auth/youtube";

            /// <summary>View your YouTube account</summary>
            public static string YoutubeReadonly = "https://www.googleapis.com/auth/youtube.readonly";

            /// <summary>View and manage your assets and associated content on YouTube</summary>
            public static string Youtubepartner = "https://www.googleapis.com/auth/youtubepartner";

            /// <summary>View monetary and non-monetary YouTube Analytics reports for your YouTube content</summary>
            public static string YtAnalyticsMonetaryReadonly = "https://www.googleapis.com/auth/yt-analytics-monetary.readonly";

            /// <summary>View YouTube Analytics reports for your YouTube content</summary>
            public static string YtAnalyticsReadonly = "https://www.googleapis.com/auth/yt-analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the YouTube Analytics API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your YouTube account</summary>
            public const string Youtube = "https://www.googleapis.com/auth/youtube";

            /// <summary>View your YouTube account</summary>
            public const string YoutubeReadonly = "https://www.googleapis.com/auth/youtube.readonly";

            /// <summary>View and manage your assets and associated content on YouTube</summary>
            public const string Youtubepartner = "https://www.googleapis.com/auth/youtubepartner";

            /// <summary>View monetary and non-monetary YouTube Analytics reports for your YouTube content</summary>
            public const string YtAnalyticsMonetaryReadonly = "https://www.googleapis.com/auth/yt-analytics-monetary.readonly";

            /// <summary>View YouTube Analytics reports for your YouTube content</summary>
            public const string YtAnalyticsReadonly = "https://www.googleapis.com/auth/yt-analytics.readonly";
        }

        /// <summary>Gets the GroupItems resource.</summary>
        public virtual GroupItemsResource GroupItems { get; }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }
    }

    /// <summary>A base abstract class for YouTubeAnalytics requests.</summary>
    public abstract class YouTubeAnalyticsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new YouTubeAnalyticsBaseServiceRequest instance.</summary>
        protected YouTubeAnalyticsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes YouTubeAnalytics parameter list.</summary>
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

    /// <summary>The "groupItems" collection of methods.</summary>
    public class GroupItemsResource
    {
        private const string Resource = "groupItems";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GroupItemsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes an item from a group.</summary>
        public virtual DeleteRequest Delete()
        {
            return new DeleteRequest(this.service);
        }

        /// <summary>Removes an item from a group.</summary>
        public class DeleteRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.EmptyResponse>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The `id` parameter specifies the YouTube group item ID of the group item that is being deleted.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groupItems";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
            }
        }

        /// <summary>Creates a group item.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.YouTubeAnalytics.v2.Data.GroupItem body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Creates a group item.</summary>
        public class InsertRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.GroupItem>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTubeAnalytics.v2.Data.GroupItem body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTubeAnalytics.v2.Data.GroupItem Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groupItems";

            /// <summary>Initializes Insert parameter list.</summary>
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

        /// <summary>Returns a collection of group items that match the API request parameters.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a collection of group items that match the API request parameters.</summary>
        public class ListRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.ListGroupItemsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The `groupId` parameter specifies the unique ID of the group for which you want to retrieve group items.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupId { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groupItems";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupId",
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
            }
        }
    }

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

        /// <summary>Deletes a group.</summary>
        public virtual DeleteRequest Delete()
        {
            return new DeleteRequest(this.service);
        }

        /// <summary>Deletes a group.</summary>
        public class DeleteRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.EmptyResponse>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The `id` parameter specifies the YouTube group ID of the group that is being deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groups";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
            }
        }

        /// <summary>Creates a group.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.YouTubeAnalytics.v2.Data.Group body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Creates a group.</summary>
        public class InsertRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.Group>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTubeAnalytics.v2.Data.Group body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTubeAnalytics.v2.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groups";

            /// <summary>Initializes Insert parameter list.</summary>
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

        /// <summary>
        /// Returns a collection of groups that match the API request parameters. For example, you can retrieve all
        /// groups that the authenticated user owns, or you can retrieve one or more groups by their unique IDs.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Returns a collection of groups that match the API request parameters. For example, you can retrieve all
        /// groups that the authenticated user owns, or you can retrieve one or more groups by their unique IDs.
        /// </summary>
        public class ListRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.ListGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The `id` parameter specifies a comma-separated list of the YouTube group ID(s) for the resource(s) that
            /// are being retrieved. Each group must be owned by the authenticated user. In a `group` resource, the `id`
            /// property specifies the group's YouTube group ID. Note that if you do not specify a value for the `id`
            /// parameter, then you must set the `mine` parameter to `true`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. Set this parameter's value to true to
            /// retrieve all groups owned by the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// The `pageToken` parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the `nextPageToken` property identifies the next page that can be retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
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

        /// <summary>Modifies a group. For example, you could change a group's title.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateRequest Update(Google.Apis.YouTubeAnalytics.v2.Data.Group body)
        {
            return new UpdateRequest(this.service, body);
        }

        /// <summary>Modifies a group. For example, you could change a group's title.</summary>
        public class UpdateRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.Group>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTubeAnalytics.v2.Data.Group body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. **Note:** This parameter is intended
            /// exclusively for YouTube content partners that own and manage many different YouTube channels. The
            /// `onBehalfOfContentOwner` parameter indicates that the request's authorization credentials identify a
            /// YouTube user who is acting on behalf of the content owner specified in the parameter value. It allows
            /// content owners to authenticate once and get access to all their video and channel data, without having
            /// to provide authentication credentials for each individual channel. The account that the user
            /// authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTubeAnalytics.v2.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/groups";

            /// <summary>Initializes Update parameter list.</summary>
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
    }

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

        /// <summary>Retrieve your YouTube Analytics reports.</summary>
        public virtual QueryRequest Query()
        {
            return new QueryRequest(this.service);
        }

        /// <summary>Retrieve your YouTube Analytics reports.</summary>
        public class QueryRequest : YouTubeAnalyticsBaseServiceRequest<Google.Apis.YouTubeAnalytics.v2.Data.QueryResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The currency to which financial metrics should be converted. The default is US Dollar (USD). If the
            /// result contains no financial metrics, this flag will be ignored. Responds with an error if the specified
            /// currency is not recognized.", pattern: [A-Z]{3}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("currency", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Currency { get; set; }

            /// <summary>
            /// A comma-separated list of YouTube Analytics dimensions, such as `views` or `ageGroup,gender`. See the
            /// [Available Reports](/youtube/analytics/v2/available_reports) document for a list of the reports that you
            /// can retrieve and the dimensions used for those reports. Also see the
            /// [Dimensions](/youtube/analytics/v2/dimsmets/dims) document for definitions of those dimensions."
            /// pattern: [0-9a-zA-Z,]+
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Dimensions { get; set; }

            /// <summary>
            /// The end date for fetching YouTube Analytics data. The value should be in `YYYY-MM-DD` format. required:
            /// true, pattern: [0-9]{4}-[0-9]{2}-[0-9]{2}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; set; }

            /// <summary>
            /// A list of filters that should be applied when retrieving YouTube Analytics data. The [Available
            /// Reports](/youtube/analytics/v2/available_reports) document identifies the dimensions that can be used to
            /// filter each report, and the [Dimensions](/youtube/analytics/v2/dimsmets/dims) document defines those
            /// dimensions. If a request uses multiple filters, join them together with a semicolon (`;`), and the
            /// returned result table will satisfy both filters. For example, a filters parameter value of
            /// `video==dMH0bHeiRNg;country==IT` restricts the result set to include data for the given video in
            /// Italy.",
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filters { get; set; }

            /// <summary>
            /// Identifies the YouTube channel or content owner for which you are retrieving YouTube Analytics data. -
            /// To request data for a YouTube user, set the `ids` parameter value to `channel==CHANNEL_ID`, where
            /// `CHANNEL_ID` specifies the unique YouTube channel ID. - To request data for a YouTube CMS content owner,
            /// set the `ids` parameter value to `contentOwner==OWNER_NAME`, where `OWNER_NAME` is the CMS name of the
            /// content owner. required: true, pattern: [a-zA-Z]+==[a-zA-Z0-9_+-]+
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Ids { get; set; }

            /// <summary>
            /// If set to true historical data (i.e. channel data from before the linking of the channel to the content
            /// owner) will be retrieved.",
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeHistoricalChannelData", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeHistoricalChannelData { get; set; }

            /// <summary>The maximum number of rows to include in the response.", minValue: 1</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// A comma-separated list of YouTube Analytics metrics, such as `views` or `likes,dislikes`. See the
            /// [Available Reports](/youtube/analytics/v2/available_reports) document for a list of the reports that you
            /// can retrieve and the metrics available in each report, and see the
            /// [Metrics](/youtube/analytics/v2/dimsmets/mets) document for definitions of those metrics. required:
            /// true, pattern: [0-9a-zA-Z,]+
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Metrics { get; set; }

            /// <summary>
            /// A comma-separated list of dimensions or metrics that determine the sort order for YouTube Analytics
            /// data. By default the sort order is ascending. The '`-`' prefix causes descending sort order.", pattern:
            /// [-0-9a-zA-Z,]+
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Sort { get; set; }

            /// <summary>
            /// The start date for fetching YouTube Analytics data. The value should be in `YYYY-MM-DD` format.
            /// required: true, pattern: "[0-9]{4}-[0-9]{2}-[0-9]{2}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            /// <summary>
            /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with the
            /// max-results parameter (one-based, inclusive).", minValue: 1
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "query";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/reports";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("currency", new Google.Apis.Discovery.Parameter
                {
                    Name = "currency",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                {
                    Name = "dimensions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                {
                    Name = "filters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ids", new Google.Apis.Discovery.Parameter
                {
                    Name = "ids",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeHistoricalChannelData", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeHistoricalChannelData",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                {
                    Name = "metrics",
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
                    Pattern = null,
                });
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.YouTubeAnalytics.v2.Data
{
    /// <summary>Empty response.</summary>
    public class EmptyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apiary error details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes one specific error.</summary>
    public class ErrorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Error arguments, to be used when building user-friendly error messages given the error domain and code.
        /// Different error codes require different arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argument")]
        public virtual System.Collections.Generic.IList<string> Argument { get; set; }

        /// <summary>
        /// Error code in the error domain. This should correspond to a value of the enum type whose name is in domain.
        /// See the core error domain in error_domain.proto.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Debugging information, which should not be shared externally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
        public virtual string DebugInfo { get; set; }

        /// <summary>
        /// Error domain. RoSy services can define their own domain and error codes. This should normally be the name of
        /// an enum type, such as: gdata.CoreErrorDomain
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// A short explanation for the error, which can be shared outside Google. Please set domain, code and arguments
        /// whenever possible instead of this error message so that external APIs can build safe error messages
        /// themselves. External messages built in a RoSy interface will most likely refer to information and concepts
        /// that are not available externally and should not be exposed. It is safer if external APIs can understand the
        /// errors and decide what the error message should look like.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalErrorMessage")]
        public virtual string ExternalErrorMessage { get; set; }

        /// <summary>
        /// Location of the error, as specified by the location type. If location_type is PATH, this should be a path to
        /// a field that's relative to the request, using FieldPath notation (net/proto2/util/public/field_path.h).
        /// Examples: authenticated_user.gaia_id resource.address[2].country
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request Error information. The presence of an error field signals that the operation has failed.
    /// </summary>
    public class Errors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Global error code. Deprecated and ignored. Set custom error codes in ErrorProto.domain and ErrorProto.code
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Specific error description and codes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual System.Collections.Generic.IList<ErrorProto> Error { get; set; }

        /// <summary>
        /// Request identifier generated by the service, which can be used to identify the error in the logs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `contentDetails` object contains additional information about the group, such as the number and type of
        /// items that it contains.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual GroupContentDetails ContentDetails { get; set; }

        /// <summary>Apiary error details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>The Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies the API resource's type. The value will be `youtube#group`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The `snippet` object contains basic information about the group, including its creation date and name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual GroupSnippet Snippet { get; set; }
    }

    /// <summary>A group's content details.</summary>
    public class GroupContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of items in the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCount")]
        public virtual System.Nullable<ulong> ItemCount { get; set; }

        /// <summary>
        /// The type of resources that the group contains. Valid values for this property are: * `youtube#channel` *
        /// `youtube#playlist` * `youtube#video` * `youtubePartner#asset`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemType")]
        public virtual string ItemType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group item.</summary>
    public class GroupItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apiary error details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>The Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the group that contains the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the `channel`, `video`, `playlist`, or `asset` resource that
        /// is included in the group. Note that this ID refers specifically to the inclusion of that resource in a
        /// particular group and is different than the channel ID, video ID, playlist ID, or asset ID that uniquely
        /// identifies the resource itself. The `resource.id` property's value specifies the unique channel, video,
        /// playlist, or asset ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies the API resource's type. The value will be `youtube#groupItem`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The `resource` object contains information that identifies the item being added to the group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GroupItemResource Resource { get; set; }
    }

    public class GroupItemResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The channel, video, playlist, or asset ID that YouTube uses to uniquely identify the item that is being
        /// added to the group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies the type of resource being added to the group. Valid values for this property are: *
        /// `youtube#channel` * `youtube#playlist` * `youtube#video` * `youtubePartner#asset`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group snippet.</summary>
    public class GroupSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _publishedAtRaw;

        private object _publishedAt;

        /// <summary>
        /// The date and time that the group was created. The value is specified in ISO 8601 (YYYY-MM-DDThh:mm:ss.sZ)
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw
        {
            get => _publishedAtRaw;
            set
            {
                _publishedAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishedAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishedAtDateTimeOffset instead.")]
        public virtual object PublishedAt
        {
            get => _publishedAt;
            set
            {
                _publishedAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishedAt = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishedAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The group name. The value must be a non-empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GroupsService.ListGroupItems.</summary>
    public class ListGroupItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apiary error details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>The Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// A list of groups that match the API request parameters. Each item in the list represents a `groupItem`
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GroupItem> Items { get; set; }

        /// <summary>Identifies the API resource's type. The value will be `youtube#groupItemListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    /// <summary>Response message for GroupsService.ListGroups.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apiary error details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>The Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// A list of groups that match the API request parameters. Each item in the list represents a `group` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Group> Items { get; set; }

        /// <summary>Identifies the API resource's type. The value will be `youtube#groupListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the `pageToken` parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>Response message for TargetedQueriesService.Query.</summary>
    public class QueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This value specifies information about the data returned in the `rows` fields. Each item in the
        /// `columnHeaders` list identifies a field returned in the `rows` value, which contains a list of
        /// comma-delimited data. The `columnHeaders` list will begin with the dimensions specified in the API request,
        /// which will be followed by the metrics specified in the API request. The order of both dimensions and metrics
        /// will match the ordering in the API request. For example, if the API request contains the parameters
        /// `dimensions=ageGroup,gender&amp;amp;metrics=viewerPercentage`, the API response will return columns in this
        /// order: `ageGroup`, `gender`, `viewerPercentage`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual System.Collections.Generic.IList<ResultTableColumnHeader> ColumnHeaders { get; set; }

        /// <summary>When set, indicates that the operation failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual Errors Errors { get; set; }

        /// <summary>
        /// This value specifies the type of data included in the API response. For the query method, the kind property
        /// value will be `youtubeAnalytics#resultTable`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The list contains all rows of the result table. Each item in the list is an array that contains
        /// comma-delimited data corresponding to a single row of data. The order of the comma-delimited data fields
        /// will match the order of the columns listed in the `columnHeaders` field. If no data is available for the
        /// given query, the `rows` element will be omitted from the response. The response for a query with the `day`
        /// dimension will not contain rows for the most recent days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The description of a column of the result table.</summary>
    public class ResultTableColumnHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the column (`DIMENSION` or `METRIC`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
        public virtual string ColumnType { get; set; }

        /// <summary>The type of the data in the column (`STRING`, `INTEGER`, `FLOAT`, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>The name of the dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
