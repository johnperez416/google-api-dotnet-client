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

namespace Google.Apis.SiteVerification.v1
{
    /// <summary>The SiteVerification Service.</summary>
    public class SiteVerificationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SiteVerificationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SiteVerificationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            WebResource = new WebResourceResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://www.googleapis.com/siteVerification/v1/");
            BatchUri = GetEffectiveUri(null, "https://www.googleapis.com/batch/siteVerification/v1");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "siteVerification";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "siteVerification/v1/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/siteVerification/v1";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Site Verification API.</summary>
        public class Scope
        {
            /// <summary>Manage the list of sites and domains you control</summary>
            public static string Siteverification = "https://www.googleapis.com/auth/siteverification";

            /// <summary>Manage your new site verifications with Google</summary>
            public static string SiteverificationVerifyOnly = "https://www.googleapis.com/auth/siteverification.verify_only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Site Verification API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage the list of sites and domains you control</summary>
            public const string Siteverification = "https://www.googleapis.com/auth/siteverification";

            /// <summary>Manage your new site verifications with Google</summary>
            public const string SiteverificationVerifyOnly = "https://www.googleapis.com/auth/siteverification.verify_only";
        }

        /// <summary>Gets the WebResource resource.</summary>
        public virtual WebResourceResource WebResource { get; }
    }

    /// <summary>A base abstract class for SiteVerification requests.</summary>
    public abstract class SiteVerificationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SiteVerificationBaseServiceRequest instance.</summary>
        protected SiteVerificationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SiteVerification parameter list.</summary>
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

    /// <summary>The "webResource" collection of methods.</summary>
    public class WebResourceResource
    {
        private const string Resource = "webResource";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WebResourceResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Relinquish ownership of a website or domain.</summary>
        /// <param name="id">The id of a verified site or domain.</param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(this.service, id);
        }

        /// <summary>Relinquish ownership of a website or domain.</summary>
        public class DeleteRequest : SiteVerificationBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webResource/{id}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get the most current data for a website or domain.</summary>
        /// <param name="id">The id of a verified site or domain.</param>
        public virtual GetRequest Get(string id)
        {
            return new GetRequest(this.service, id);
        }

        /// <summary>Get the most current data for a website or domain.</summary>
        public class GetRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webResource/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get a verification token for placing on a website or domain.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual GetTokenRequest GetToken(Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceGettokenRequest body)
        {
            return new GetTokenRequest(this.service, body);
        }

        /// <summary>Get a verification token for placing on a website or domain.</summary>
        public class GetTokenRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceGettokenResponse>
        {
            /// <summary>Constructs a new GetToken request.</summary>
            public GetTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceGettokenRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceGettokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "token";

            /// <summary>Initializes GetToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Attempt verification of a website or domain.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="verificationMethod">The method to use for verifying a site or domain.</param>
        public virtual InsertRequest Insert(Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string verificationMethod)
        {
            return new InsertRequest(this.service, body, verificationMethod);
        }

        /// <summary>Attempt verification of a website or domain.</summary>
        public class InsertRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string verificationMethod) : base(service)
            {
                VerificationMethod = verificationMethod;
                Body = body;
                InitParameters();
            }

            /// <summary>The method to use for verifying a site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("verificationMethod", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VerificationMethod { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webResource";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("verificationMethod", new Google.Apis.Discovery.Parameter
                {
                    Name = "verificationMethod",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get the list of your verified websites and domains.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Get the list of your verified websites and domains.</summary>
        public class ListRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceListResponse>
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
            public override string RestPath => "webResource";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Modify the list of owners for your website or domain. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The id of a verified site or domain.</param>
        public virtual PatchRequest Patch(Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string id)
        {
            return new PatchRequest(this.service, body, id);
        }

        /// <summary>
        /// Modify the list of owners for your website or domain. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webResource/{id}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Modify the list of owners for your website or domain.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The id of a verified site or domain.</param>
        public virtual UpdateRequest Update(Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string id)
        {
            return new UpdateRequest(this.service, body, id);
        }

        /// <summary>Modify the list of owners for your website or domain.</summary>
        public class UpdateRequest : SiteVerificationBaseServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource body, string id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SiteVerification.v1.Data.SiteVerificationWebResourceResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webResource/{id}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.SiteVerification.v1.Data
{
    public class SiteVerificationWebResourceGettokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The site for which a verification token will be generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual SiteData Site { get; set; }

        /// <summary>
        /// The verification method that will be used to verify this site. For sites, 'FILE' or 'META' methods may be
        /// used. For domains, only 'DNS' may be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationMethod")]
        public virtual string VerificationMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The site for which a verification token will be generated.</summary>
        public class SiteData
        {
            /// <summary>
            /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is set to
            /// INET_DOMAIN, the site identifier is a domain name.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
            public virtual string Identifier { get; set; }

            /// <summary>The type of resource to be verified. Can be SITE or INET_DOMAIN (domain name).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    public class SiteVerificationWebResourceGettokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The verification method to use in conjunction with this token. For FILE, the token should be placed in the
        /// top-level directory of the site, stored inside a file of the same name. For META, the token should be placed
        /// in the HEAD tag of the default page that is loaded for the site. For DNS, the token should be placed in a
        /// TXT record of the domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// The verification token. The token must be placed appropriately in order for verification to succeed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SiteVerificationWebResourceListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of sites that are owned by the authenticated user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SiteVerificationWebResourceResource> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SiteVerificationWebResourceResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The string used to identify this site. This value should be used in the "id" portion of the REST URL for the
        /// Get, Update, and Delete operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The email addresses of all verified owners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owners")]
        public virtual System.Collections.Generic.IList<string> Owners { get; set; }

        /// <summary>The address and type of a site that is verified or will be verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual SiteData Site { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The address and type of a site that is verified or will be verified.</summary>
        public class SiteData
        {
            /// <summary>
            /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is set to
            /// INET_DOMAIN, the site identifier is a domain name.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
            public virtual string Identifier { get; set; }

            /// <summary>The site type. Can be SITE or INET_DOMAIN (domain name).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }
}
