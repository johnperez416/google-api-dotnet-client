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

namespace Google.Apis.Safebrowsing.v4
{
    /// <summary>The Safebrowsing Service.</summary>
    public class SafebrowsingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SafebrowsingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SafebrowsingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            EncodedFullHashes = new EncodedFullHashesResource(this);
            EncodedUpdates = new EncodedUpdatesResource(this);
            FullHashes = new FullHashesResource(this);
            ThreatHits = new ThreatHitsResource(this);
            ThreatListUpdates = new ThreatListUpdatesResource(this);
            ThreatLists = new ThreatListsResource(this);
            ThreatMatches = new ThreatMatchesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://safebrowsing.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://safebrowsing.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "safebrowsing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the EncodedFullHashes resource.</summary>
        public virtual EncodedFullHashesResource EncodedFullHashes { get; }

        /// <summary>Gets the EncodedUpdates resource.</summary>
        public virtual EncodedUpdatesResource EncodedUpdates { get; }

        /// <summary>Gets the FullHashes resource.</summary>
        public virtual FullHashesResource FullHashes { get; }

        /// <summary>Gets the ThreatHits resource.</summary>
        public virtual ThreatHitsResource ThreatHits { get; }

        /// <summary>Gets the ThreatListUpdates resource.</summary>
        public virtual ThreatListUpdatesResource ThreatListUpdates { get; }

        /// <summary>Gets the ThreatLists resource.</summary>
        public virtual ThreatListsResource ThreatLists { get; }

        /// <summary>Gets the ThreatMatches resource.</summary>
        public virtual ThreatMatchesResource ThreatMatches { get; }
    }

    /// <summary>A base abstract class for Safebrowsing requests.</summary>
    public abstract class SafebrowsingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SafebrowsingBaseServiceRequest instance.</summary>
        protected SafebrowsingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Safebrowsing parameter list.</summary>
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

    /// <summary>The "encodedFullHashes" collection of methods.</summary>
    public class EncodedFullHashesResource
    {
        private const string Resource = "encodedFullHashes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EncodedFullHashesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary></summary>
        /// <param name="encodedRequest">A serialized FindFullHashesRequest proto.</param>
        public virtual GetRequest Get(string encodedRequest)
        {
            return new GetRequest(this.service, encodedRequest);
        }

        /// <summary></summary>
        public class GetRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindFullHashesResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string encodedRequest) : base(service)
            {
                EncodedRequest = encodedRequest;
                InitParameters();
            }

            /// <summary>A serialized FindFullHashesRequest proto.</summary>
            [Google.Apis.Util.RequestParameterAttribute("encodedRequest", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EncodedRequest { get; private set; }

            /// <summary>
            /// A client ID that (hopefully) uniquely identifies the client implementation of the Safe Browsing API.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientId { get; set; }

            /// <summary>The version of the client implementation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientVersion { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/encodedFullHashes/{encodedRequest}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("encodedRequest", new Google.Apis.Discovery.Parameter
                {
                    Name = "encodedRequest",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "encodedUpdates" collection of methods.</summary>
    public class EncodedUpdatesResource
    {
        private const string Resource = "encodedUpdates";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EncodedUpdatesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary></summary>
        /// <param name="encodedRequest">A serialized FetchThreatListUpdatesRequest proto.</param>
        public virtual GetRequest Get(string encodedRequest)
        {
            return new GetRequest(this.service, encodedRequest);
        }

        /// <summary></summary>
        public class GetRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FetchThreatListUpdatesResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string encodedRequest) : base(service)
            {
                EncodedRequest = encodedRequest;
                InitParameters();
            }

            /// <summary>A serialized FetchThreatListUpdatesRequest proto.</summary>
            [Google.Apis.Util.RequestParameterAttribute("encodedRequest", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EncodedRequest { get; private set; }

            /// <summary>
            /// A client ID that uniquely identifies the client implementation of the Safe Browsing API.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientId { get; set; }

            /// <summary>The version of the client implementation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientVersion { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/encodedUpdates/{encodedRequest}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("encodedRequest", new Google.Apis.Discovery.Parameter
                {
                    Name = "encodedRequest",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "fullHashes" collection of methods.</summary>
    public class FullHashesResource
    {
        private const string Resource = "fullHashes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FullHashesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Finds the full hashes that match the requested hash prefixes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual FindRequest Find(Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindFullHashesRequest body)
        {
            return new FindRequest(this.service, body);
        }

        /// <summary>Finds the full hashes that match the requested hash prefixes.</summary>
        public class FindRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindFullHashesResponse>
        {
            /// <summary>Constructs a new Find request.</summary>
            public FindRequest(Google.Apis.Services.IClientService service, Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindFullHashesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindFullHashesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "find";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/fullHashes:find";

            /// <summary>Initializes Find parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "threatHits" collection of methods.</summary>
    public class ThreatHitsResource
    {
        private const string Resource = "threatHits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThreatHitsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Reports a Safe Browsing threat list hit to Google. Only projects with TRUSTED_REPORTER visibility can use
        /// this method.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4ThreatHit body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Reports a Safe Browsing threat list hit to Google. Only projects with TRUSTED_REPORTER visibility can use
        /// this method.
        /// </summary>
        public class CreateRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4ThreatHit body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4ThreatHit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/threatHits";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "threatListUpdates" collection of methods.</summary>
    public class ThreatListUpdatesResource
    {
        private const string Resource = "threatListUpdates";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThreatListUpdatesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Fetches the most recent threat list updates. A client can request updates for multiple lists at once.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual FetchRequest Fetch(Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequest body)
        {
            return new FetchRequest(this.service, body);
        }

        /// <summary>
        /// Fetches the most recent threat list updates. A client can request updates for multiple lists at once.
        /// </summary>
        public class FetchRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FetchThreatListUpdatesResponse>
        {
            /// <summary>Constructs a new Fetch request.</summary>
            public FetchRequest(Google.Apis.Services.IClientService service, Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/threatListUpdates:fetch";

            /// <summary>Initializes Fetch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "threatLists" collection of methods.</summary>
    public class ThreatListsResource
    {
        private const string Resource = "threatLists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThreatListsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists the Safe Browsing threat lists available for download.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists the Safe Browsing threat lists available for download.</summary>
        public class ListRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4ListThreatListsResponse>
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
            public override string RestPath => "v4/threatLists";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "threatMatches" collection of methods.</summary>
    public class ThreatMatchesResource
    {
        private const string Resource = "threatMatches";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThreatMatchesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Finds the threat entries that match the Safe Browsing lists.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual FindRequest Find(Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindThreatMatchesRequest body)
        {
            return new FindRequest(this.service, body);
        }

        /// <summary>Finds the threat entries that match the Safe Browsing lists.</summary>
        public class FindRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindThreatMatchesResponse>
        {
            /// <summary>Constructs a new Find request.</summary>
            public FindRequest(Google.Apis.Services.IClientService service, Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindThreatMatchesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Safebrowsing.v4.Data.GoogleSecuritySafebrowsingV4FindThreatMatchesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "find";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/threatMatches:find";

            /// <summary>Initializes Find parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Safebrowsing.v4.Data
{
    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The expected state of a client's local database.</summary>
    public class GoogleSecuritySafebrowsingV4Checksum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The SHA256 hash of the client state; that is, of the sorted list of all hashes present in the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The client metadata associated with Safe Browsing API requests.</summary>
    public class GoogleSecuritySafebrowsingV4ClientInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A client ID that (hopefully) uniquely identifies the client implementation of the Safe Browsing API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The version of the client implementation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a Safe Browsing API update request. Clients can request updates for multiple lists in a single
    /// request. The server may not respond to all requests, if the server has no updates for that list. NOTE: Field
    /// index 2 is unused. NEXT: 5
    /// </summary>
    public class GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual GoogleSecuritySafebrowsingV4ClientInfo Client { get; set; }

        /// <summary>The requested threat list updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listUpdateRequests")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequestListUpdateRequest> ListUpdateRequests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single list update request.</summary>
    public class GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequestListUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The constraints associated with this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequestListUpdateRequestConstraints Constraints { get; set; }

        /// <summary>The type of platform at risk by entries present in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>
        /// The current state of the client for the requested list (the encrypted client state that was received from
        /// the last successful list update).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The types of entries present in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryType")]
        public virtual string ThreatEntryType { get; set; }

        /// <summary>The type of threat posed by entries present in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The constraints for this update.</summary>
    public class GoogleSecuritySafebrowsingV4FetchThreatListUpdatesRequestListUpdateRequestConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A client's physical location, expressed as a ISO 31166-1 alpha-2 region code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceLocation")]
        public virtual string DeviceLocation { get; set; }

        /// <summary>Requests the lists for a specific language. Expects ISO 639 alpha-2 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// Sets the maximum number of entries that the client is willing to have in the local database for the
        /// specified list. This should be a power of 2 between 2**10 and 2**20. If zero, no database size limit is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDatabaseEntries")]
        public virtual System.Nullable<int> MaxDatabaseEntries { get; set; }

        /// <summary>
        /// The maximum size in number of entries. The update will not contain more entries than this value. This should
        /// be a power of 2 between 2**10 and 2**20. If zero, no update size limit is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUpdateEntries")]
        public virtual System.Nullable<int> MaxUpdateEntries { get; set; }

        /// <summary>
        /// Requests the list for a specific geographic location. If not set the server may pick that value based on the
        /// user's IP address. Expects ISO 3166-1 alpha-2 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The compression types supported by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedCompressions")]
        public virtual System.Collections.Generic.IList<string> SupportedCompressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSecuritySafebrowsingV4FetchThreatListUpdatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list updates requested by the clients. The number of responses here may be less than the number of
        /// requests sent by clients. This is the case, for example, if the server has no updates for a particular list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listUpdateResponses")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4FetchThreatListUpdatesResponseListUpdateResponse> ListUpdateResponses { get; set; }

        /// <summary>
        /// The minimum duration the client must wait before issuing any update request. If this field is not set
        /// clients may update as soon as they want.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumWaitDuration")]
        public virtual object MinimumWaitDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An update to an individual list.</summary>
    public class GoogleSecuritySafebrowsingV4FetchThreatListUpdatesResponseListUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A set of entries to add to a local threat type's list. Repeated to allow for a combination of compressed and
        /// raw data to be sent in a single response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additions")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatEntrySet> Additions { get; set; }

        /// <summary>
        /// The expected SHA256 hash of the client state; that is, of the sorted list of all hashes present in the
        /// database after applying the provided update. If the client state doesn't match the expected state, the
        /// client must disregard this update and retry later.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual GoogleSecuritySafebrowsingV4Checksum Checksum { get; set; }

        /// <summary>The new client state, in encrypted format. Opaque to clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newClientState")]
        public virtual string NewClientState { get; set; }

        /// <summary>The platform type for which data is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>
        /// A set of entries to remove from a local threat type's list. In practice, this field is empty or contains
        /// exactly one ThreatEntrySet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removals")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatEntrySet> Removals { get; set; }

        /// <summary>
        /// The type of response. This may indicate that an action is required by the client when the response is
        /// received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseType")]
        public virtual string ResponseType { get; set; }

        /// <summary>The format of the threats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryType")]
        public virtual string ThreatEntryType { get; set; }

        /// <summary>The threat type for which data is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to return full hashes matched by the provided hash prefixes.</summary>
    public class GoogleSecuritySafebrowsingV4FindFullHashesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Client metadata associated with callers of higher-level APIs built on top of the client's implementation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiClient")]
        public virtual GoogleSecuritySafebrowsingV4ClientInfo ApiClient { get; set; }

        /// <summary>The client metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual GoogleSecuritySafebrowsingV4ClientInfo Client { get; set; }

        /// <summary>The current client states for each of the client's local threat lists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientStates")]
        public virtual System.Collections.Generic.IList<string> ClientStates { get; set; }

        /// <summary>The lists and hashes to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatInfo")]
        public virtual GoogleSecuritySafebrowsingV4ThreatInfo ThreatInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSecuritySafebrowsingV4FindFullHashesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full hashes that matched the requested prefixes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatMatch> Matches { get; set; }

        /// <summary>
        /// The minimum duration the client must wait before issuing any find hashes request. If this field is not set,
        /// clients can issue a request as soon as they want.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumWaitDuration")]
        public virtual object MinimumWaitDuration { get; set; }

        /// <summary>
        /// For requested entities that did not match the threat list, how long to cache the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeCacheDuration")]
        public virtual object NegativeCacheDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to check entries against lists.</summary>
    public class GoogleSecuritySafebrowsingV4FindThreatMatchesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual GoogleSecuritySafebrowsingV4ClientInfo Client { get; set; }

        /// <summary>The lists and entries to be checked for matches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatInfo")]
        public virtual GoogleSecuritySafebrowsingV4ThreatInfo ThreatInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSecuritySafebrowsingV4FindThreatMatchesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The threat list matches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSecuritySafebrowsingV4ListThreatListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The lists available for download by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatLists")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatListDescriptor> ThreatLists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The uncompressed threat entries in hash format of a particular prefix length. Hashes can be anywhere from 4 to
    /// 32 bytes in size. A large majority are 4 bytes, but some hashes are lengthened if they collide with the hash of
    /// a popular URL. Used for sending ThreatEntrySet to clients that do not support compression, or when sending
    /// non-4-byte hashes to clients that do support compression.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4RawHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of bytes for each prefix encoded below. This field can be anywhere from 4 (shortest prefix) to 32
        /// (full SHA256 hash).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixSize")]
        public virtual System.Nullable<int> PrefixSize { get; set; }

        /// <summary>
        /// The hashes, in binary format, concatenated into one long string. Hashes are sorted in lexicographic order.
        /// For JSON API users, hashes are base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawHashes")]
        public virtual string RawHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of raw indices to remove from a local list.</summary>
    public class GoogleSecuritySafebrowsingV4RawIndices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The indices to remove from a lexicographically-sorted local list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Indices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Rice-Golomb encoded data. Used for sending compressed 4-byte hashes or compressed removal indices.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4RiceDeltaEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The offset of the first entry in the encoded data, or, if only a single integer was encoded, that single
        /// integer's value. If the field is empty or missing, assume zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual System.Nullable<long> FirstValue { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numEntries")]
        public virtual System.Nullable<int> NumEntries { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter, which is a number between 2 and 28. This field is missing (that is, zero) if
        /// `num_entries` is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An individual threat; for example, a malicious URL or its hash representation. Only one of these fields should
    /// be set.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4ThreatEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The digest of an executable in SHA256 format. The API supports both binary and hex digests. For JSON
        /// requests, digests are base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// A hash prefix, consisting of the most significant 4-32 bytes of a SHA256 hash. This field is in binary
        /// format. For JSON requests, hashes are base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>A URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata associated with a specific threat entry. The client is expected to know the metadata key/value
    /// pairs associated with each threat type.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4ThreatEntryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metadata entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatEntryMetadataMetadataEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single metadata entry.</summary>
    public class GoogleSecuritySafebrowsingV4ThreatEntryMetadataMetadataEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metadata entry key. For JSON requests, the key is base64-encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The metadata entry value. For JSON requests, the value is base64-encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of threats that should be added or removed from a client's local database.</summary>
    public class GoogleSecuritySafebrowsingV4ThreatEntrySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The compression type for the entries in this set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressionType")]
        public virtual string CompressionType { get; set; }

        /// <summary>The raw SHA256-formatted entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawHashes")]
        public virtual GoogleSecuritySafebrowsingV4RawHashes RawHashes { get; set; }

        /// <summary>The raw removal indices for a local list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawIndices")]
        public virtual GoogleSecuritySafebrowsingV4RawIndices RawIndices { get; set; }

        /// <summary>
        /// The encoded 4-byte prefixes of SHA256-formatted entries, using a Golomb-Rice encoding. The hashes are
        /// converted to uint32, sorted in ascending order, then delta encoded and stored as encoded_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceHashes")]
        public virtual GoogleSecuritySafebrowsingV4RiceDeltaEncoding RiceHashes { get; set; }

        /// <summary>
        /// The encoded local, lexicographically-sorted list indices, using a Golomb-Rice encoding. Used for sending
        /// compressed removal indices. The removal indices (uint32) are sorted in ascending order, then delta encoded
        /// and stored as encoded_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceIndices")]
        public virtual GoogleSecuritySafebrowsingV4RiceDeltaEncoding RiceIndices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleSecuritySafebrowsingV4ThreatHit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client-reported identification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientInfo")]
        public virtual GoogleSecuritySafebrowsingV4ClientInfo ClientInfo { get; set; }

        /// <summary>
        /// The threat entry responsible for the hit. Full hash should be reported for hash-based hits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entry")]
        public virtual GoogleSecuritySafebrowsingV4ThreatEntry Entry { get; set; }

        /// <summary>The platform type reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>The resources related to the threat hit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatHitThreatSource> Resources { get; set; }

        /// <summary>The threat type reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>Details about the user that encountered the threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleSecuritySafebrowsingV4ThreatHitUserInfo UserInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single resource related to a threat hit.</summary>
    public class GoogleSecuritySafebrowsingV4ThreatHitThreatSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Referrer of the resource. Only set if the referrer is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrer")]
        public virtual string Referrer { get; set; }

        /// <summary>The remote IP of the resource in ASCII format. Either IPv4 or IPv6.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIp")]
        public virtual string RemoteIp { get; set; }

        /// <summary>The type of source reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The URL of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the user that encountered the threat.</summary>
    public class GoogleSecuritySafebrowsingV4ThreatHitUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The UN M.49 region code associated with the user's location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Unique user identifier defined by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The information regarding one or more threats that a client submits when checking for matches in threat lists.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4ThreatInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The platform types to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformTypes")]
        public virtual System.Collections.Generic.IList<string> PlatformTypes { get; set; }

        /// <summary>The threat entries to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntries")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV4ThreatEntry> ThreatEntries { get; set; }

        /// <summary>The entry types to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatEntryTypes { get; set; }

        /// <summary>The threat types to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes an individual threat list. A list is defined by three parameters: the type of threat posed, the type
    /// of platform targeted by the threat, and the type of entries in the list.
    /// </summary>
    public class GoogleSecuritySafebrowsingV4ThreatListDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The platform type targeted by the list's entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>The entry types contained in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryType")]
        public virtual string ThreatEntryType { get; set; }

        /// <summary>The threat type posed by the list's entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A match when checking a threat entry in the Safe Browsing threat lists.</summary>
    public class GoogleSecuritySafebrowsingV4ThreatMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cache lifetime for the returned match. Clients must not cache this response for more than this duration
        /// to avoid false positives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheDuration")]
        public virtual object CacheDuration { get; set; }

        /// <summary>The platform type matching this threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>The threat matching this threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threat")]
        public virtual GoogleSecuritySafebrowsingV4ThreatEntry Threat { get; set; }

        /// <summary>Optional metadata associated with this threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryMetadata")]
        public virtual GoogleSecuritySafebrowsingV4ThreatEntryMetadata ThreatEntryMetadata { get; set; }

        /// <summary>The threat entry type matching this threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatEntryType")]
        public virtual string ThreatEntryType { get; set; }

        /// <summary>The threat type matching this threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
