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

namespace Google.Apis.Indexing.v3
{
    /// <summary>The Indexing Service.</summary>
    public class IndexingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IndexingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IndexingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            UrlNotifications = new UrlNotificationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://indexing.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://indexing.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "indexing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Web Search Indexing API.</summary>
        public class Scope
        {
            /// <summary>Submit data to Google for indexing</summary>
            public static string Indexing = "https://www.googleapis.com/auth/indexing";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Web Search Indexing API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Submit data to Google for indexing</summary>
            public const string Indexing = "https://www.googleapis.com/auth/indexing";
        }

        /// <summary>Gets the UrlNotifications resource.</summary>
        public virtual UrlNotificationsResource UrlNotifications { get; }
    }

    /// <summary>A base abstract class for Indexing requests.</summary>
    public abstract class IndexingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IndexingBaseServiceRequest instance.</summary>
        protected IndexingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Indexing parameter list.</summary>
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

    /// <summary>The "urlNotifications" collection of methods.</summary>
    public class UrlNotificationsResource
    {
        private const string Resource = "urlNotifications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrlNotificationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets metadata about a Web Document. This method can _only_ be used to query URLs that were previously seen
        /// in successful Indexing API notifications. Includes the latest `UrlNotification` received via this API.
        /// </summary>
        public virtual GetMetadataRequest GetMetadata()
        {
            return new GetMetadataRequest(this.service);
        }

        /// <summary>
        /// Gets metadata about a Web Document. This method can _only_ be used to query URLs that were previously seen
        /// in successful Indexing API notifications. Includes the latest `UrlNotification` received via this API.
        /// </summary>
        public class GetMetadataRequest : IndexingBaseServiceRequest<Google.Apis.Indexing.v3.Data.UrlNotificationMetadata>
        {
            /// <summary>Constructs a new GetMetadata request.</summary>
            public GetMetadataRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>URL that is being queried.</summary>
            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getMetadata";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/urlNotifications/metadata";

            /// <summary>Initializes GetMetadata parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("url", new Google.Apis.Discovery.Parameter
                {
                    Name = "url",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Notifies that a URL has been updated or deleted.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual PublishRequest Publish(Google.Apis.Indexing.v3.Data.UrlNotification body)
        {
            return new PublishRequest(this.service, body);
        }

        /// <summary>Notifies that a URL has been updated or deleted.</summary>
        public class PublishRequest : IndexingBaseServiceRequest<Google.Apis.Indexing.v3.Data.PublishUrlNotificationResponse>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Indexing.v3.Data.UrlNotification body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Indexing.v3.Data.UrlNotification Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/urlNotifications:publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Indexing.v3.Data
{
    /// <summary>Output for PublishUrlNotification</summary>
    public class PublishUrlNotificationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the notification events received for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlNotificationMetadata")]
        public virtual UrlNotificationMetadata UrlNotificationMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `UrlNotification` is the resource used in all Indexing API calls. It describes one event in the life cycle of a
    /// Web Document.
    /// </summary>
    public class UrlNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _notifyTimeRaw;

        private object _notifyTime;

        /// <summary>
        /// Creation timestamp for this notification. Users should _not_ specify it, the field is ignored at the request
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyTime")]
        public virtual string NotifyTimeRaw
        {
            get => _notifyTimeRaw;
            set
            {
                _notifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotifyTimeDateTimeOffset instead.")]
        public virtual object NotifyTime
        {
            get => _notifyTime;
            set
            {
                _notifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notifyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotifyTimeRaw);
            set => NotifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The URL life cycle event that Google is being notified about.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The object of this notification. The URL must be owned by the publisher of this notification and, in case of
        /// `URL_UPDATED` notifications, it _must_ be crawlable by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of the most recent Indexing API notifications successfully received, for a given URL.</summary>
    public class UrlNotificationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Latest notification received with type `URL_REMOVED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRemove")]
        public virtual UrlNotification LatestRemove { get; set; }

        /// <summary>Latest notification received with type `URL_UPDATED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestUpdate")]
        public virtual UrlNotification LatestUpdate { get; set; }

        /// <summary>URL to which this metadata refers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
