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

namespace Google.Apis.DomainsRDAP.v1
{
    /// <summary>The DomainsRDAP Service.</summary>
    public class DomainsRDAPService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DomainsRDAPService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DomainsRDAPService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Autnum = new AutnumResource(this);
            Domain = new DomainResource(this);
            Entity = new EntityResource(this);
            Ip = new IpResource(this);
            Nameserver = new NameserverResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://domainsrdap.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://domainsrdap.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "domainsrdap";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Autnum resource.</summary>
        public virtual AutnumResource Autnum { get; }

        /// <summary>Gets the Domain resource.</summary>
        public virtual DomainResource Domain { get; }

        /// <summary>Gets the Entity resource.</summary>
        public virtual EntityResource Entity { get; }

        /// <summary>Gets the Ip resource.</summary>
        public virtual IpResource Ip { get; }

        /// <summary>Gets the Nameserver resource.</summary>
        public virtual NameserverResource Nameserver { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for DomainsRDAP requests.</summary>
    public abstract class DomainsRDAPBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DomainsRDAPBaseServiceRequest instance.</summary>
        protected DomainsRDAPBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DomainsRDAP parameter list.</summary>
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

    /// <summary>The "autnum" collection of methods.</summary>
    public class AutnumResource
    {
        private const string Resource = "autnum";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AutnumResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        /// <param name="autnumId"><c>null</c></param>
        public virtual GetRequest Get(string autnumId)
        {
            return new GetRequest(this.service, autnumId);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string autnumId) : base(service)
            {
                AutnumId = autnumId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("autnumId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AutnumId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/autnum/{autnumId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("autnumId", new Google.Apis.Discovery.Parameter
                {
                    Name = "autnumId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "domain" collection of methods.</summary>
    public class DomainResource
    {
        private const string Resource = "domain";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Look up RDAP information for a domain by name.</summary>
        /// <param name="domainName">Full domain name to look up. Example: "example.com"</param>
        public virtual GetRequest Get(string domainName)
        {
            return new GetRequest(this.service, domainName);
        }

        /// <summary>Look up RDAP information for a domain by name.</summary>
        public class GetRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.HttpBody>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string domainName) : base(service)
            {
                DomainName = domainName;
                InitParameters();
            }

            /// <summary>Full domain name to look up. Example: "example.com"</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/domain/{+domainName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                {
                    Name = "domainName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "entity" collection of methods.</summary>
    public class EntityResource
    {
        private const string Resource = "entity";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EntityResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        /// <param name="entityId"><c>null</c></param>
        public virtual GetRequest Get(string entityId)
        {
            return new GetRequest(this.service, entityId);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string entityId) : base(service)
            {
                EntityId = entityId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("entityId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EntityId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/entity/{entityId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("entityId", new Google.Apis.Discovery.Parameter
                {
                    Name = "entityId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "ip" collection of methods.</summary>
    public class IpResource
    {
        private const string Resource = "ip";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IpResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        /// <param name="ipId"><c>null</c></param>
        /// <param name="ipId1"><c>null</c></param>
        public virtual GetRequest Get(string ipId, string ipId1)
        {
            return new GetRequest(this.service, ipId, ipId1);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string ipId, string ipId1) : base(service)
            {
                IpId = ipId;
                IpId1 = ipId1;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("ipId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string IpId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("ipId1", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string IpId1 { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/ip/{ipId}/{ipId1}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("ipId", new Google.Apis.Discovery.Parameter
                {
                    Name = "ipId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ipId1", new Google.Apis.Discovery.Parameter
                {
                    Name = "ipId1",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "nameserver" collection of methods.</summary>
    public class NameserverResource
    {
        private const string Resource = "nameserver";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NameserverResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        /// <param name="nameserverId"><c>null</c></param>
        public virtual GetRequest Get(string nameserverId)
        {
            return new GetRequest(this.service, nameserverId);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string nameserverId) : base(service)
            {
                NameserverId = nameserverId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("nameserverId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string NameserverId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/nameserver/{nameserverId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("nameserverId", new Google.Apis.Discovery.Parameter
                {
                    Name = "nameserverId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public virtual GetDomainsRequest GetDomains()
        {
            return new GetDomainsRequest(this.service);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetDomainsRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new GetDomains request.</summary>
            public GetDomainsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDomains";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/domains";

            /// <summary>Initializes GetDomains parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public virtual GetEntitiesRequest GetEntities()
        {
            return new GetEntitiesRequest(this.service);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetEntitiesRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new GetEntities request.</summary>
            public GetEntitiesRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEntities";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/entities";

            /// <summary>Initializes GetEntities parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Get help information for the RDAP API, including links to documentation.</summary>
        public virtual GetHelpRequest GetHelp()
        {
            return new GetHelpRequest(this.service);
        }

        /// <summary>Get help information for the RDAP API, including links to documentation.</summary>
        public class GetHelpRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.HttpBody>
        {
            /// <summary>Constructs a new GetHelp request.</summary>
            public GetHelpRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getHelp";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/help";

            /// <summary>Initializes GetHelp parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public virtual GetIpRequest GetIp()
        {
            return new GetIpRequest(this.service);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetIpRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.HttpBody>
        {
            /// <summary>Constructs a new GetIp request.</summary>
            public GetIpRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIp";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/ip";

            /// <summary>Initializes GetIp parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public virtual GetNameserversRequest GetNameservers()
        {
            return new GetNameserversRequest(this.service);
        }

        /// <summary>
        /// The RDAP API recognizes this command from the RDAP specification but does not support it. The response is a
        /// formatted 501 error.
        /// </summary>
        public class GetNameserversRequest : DomainsRDAPBaseServiceRequest<Google.Apis.DomainsRDAP.v1.Data.RdapResponse>
        {
            /// <summary>Constructs a new GetNameservers request.</summary>
            public GetNameserversRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getNameservers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/nameservers";

            /// <summary>Initializes GetNameservers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.DomainsRDAP.v1.Data
{
    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Links object defined in [section 4.2 of RFC 7483](https://tools.ietf.org/html/rfc7483#section-4.2).
    /// </summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target URL of a link. Example: "http://example.com/previous".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("href")]
        public virtual string Href { get; set; }

        /// <summary>Language code of a link. Example: "en".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hreflang")]
        public virtual string Hreflang { get; set; }

        /// <summary>Media type of the link destination. Example: "screen".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("media")]
        public virtual string Media { get; set; }

        /// <summary>Relation type of a link. Example: "previous".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rel")]
        public virtual string Rel { get; set; }

        /// <summary>Title of this link. Example: "title".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Content type of the link. Example: "application/json".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>URL giving context for the link. Example: "http://example.com/current".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Notices object defined in [section 4.3 of RFC 7483](https://tools.ietf.org/html/rfc7483#section-4.3).
    /// </summary>
    public class Notice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the notice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual System.Collections.Generic.IList<string> Description { get; set; }

        /// <summary>Link to a document containing more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<Link> Links { get; set; }

        /// <summary>Title of a notice. Example: "Terms of Service".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Type values defined in [section 10.2.1 of RFC 7483](https://tools.ietf.org/html/rfc7483#section-10.2.1)
        /// specific to a whole response: "result set truncated due to authorization", "result set truncated due to
        /// excessive load", "result set truncated due to unexplainable reasons".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a general RDAP query.</summary>
    public class RdapResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual System.Collections.Generic.IList<string> Description { get; set; }

        /// <summary>Error HTTP code. Example: "501".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Nullable<int> ErrorCode { get; set; }

        /// <summary>HTTP response with content type set to "application/json+rdap".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonResponse")]
        public virtual HttpBody JsonResponse { get; set; }

        /// <summary>
        /// Error language code. Error response info fields are defined in [section 6 of RFC
        /// 7483](https://tools.ietf.org/html/rfc7483#section-6).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lang")]
        public virtual string Lang { get; set; }

        /// <summary>Notices applying to this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notices")]
        public virtual System.Collections.Generic.IList<Notice> Notices { get; set; }

        /// <summary>RDAP conformance level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdapConformance")]
        public virtual System.Collections.Generic.IList<string> RdapConformance { get; set; }

        /// <summary>Error title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
