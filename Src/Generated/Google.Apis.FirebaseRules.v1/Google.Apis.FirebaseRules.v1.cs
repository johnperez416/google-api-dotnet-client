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

namespace Google.Apis.FirebaseRules.v1
{
    /// <summary>The FirebaseRules Service.</summary>
    public class FirebaseRulesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseRulesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseRulesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebaserules.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebaserules.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebaserules";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Rules API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public static string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Rules API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public const string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseRules requests.</summary>
    public abstract class FirebaseRulesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseRulesBaseServiceRequest instance.</summary>
        protected FirebaseRulesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseRules parameter list.</summary>
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
            Releases = new ReleasesResource(service);
            Rulesets = new RulesetsResource(service);
        }

        /// <summary>Gets the Releases resource.</summary>
        public virtual ReleasesResource Releases { get; }

        /// <summary>The "releases" collection of methods.</summary>
        public class ReleasesResource
        {
            private const string Resource = "releases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReleasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Create a `Release`. Release names should reflect the developer's deployment practices. For example, the
            /// release name may include the environment name, application name, application version, or any other name
            /// meaningful to the developer. Once a `Release` refers to a `Ruleset`, the rules can be enforced by
            /// Firebase Rules-enabled services. More than one `Release` may be 'live' concurrently. Consider the
            /// following three `Release` names for `projects/foo` and the `Ruleset` to which they refer. Release Name
            /// -&amp;gt; Ruleset Name * projects/foo/releases/prod -&amp;gt; projects/foo/rulesets/uuid123 *
            /// projects/foo/releases/prod/beta -&amp;gt; projects/foo/rulesets/uuid123 * projects/foo/releases/prod/v23
            /// -&amp;gt; projects/foo/rulesets/uuid456 The relationships reflect a `Ruleset` rollout in progress. The
            /// `prod` and `prod/beta` releases refer to the same `Ruleset`. However, `prod/v23` refers to a new
            /// `Ruleset`. The `Ruleset` reference for a `Release` may be updated using the UpdateRelease method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name for the project which owns this `Release`. Format: `projects/{project_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseRules.v1.Data.Release body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Create a `Release`. Release names should reflect the developer's deployment practices. For example, the
            /// release name may include the environment name, application name, application version, or any other name
            /// meaningful to the developer. Once a `Release` refers to a `Ruleset`, the rules can be enforced by
            /// Firebase Rules-enabled services. More than one `Release` may be 'live' concurrently. Consider the
            /// following three `Release` names for `projects/foo` and the `Ruleset` to which they refer. Release Name
            /// -&amp;gt; Ruleset Name * projects/foo/releases/prod -&amp;gt; projects/foo/rulesets/uuid123 *
            /// projects/foo/releases/prod/beta -&amp;gt; projects/foo/rulesets/uuid123 * projects/foo/releases/prod/v23
            /// -&amp;gt; projects/foo/rulesets/uuid456 The relationships reflect a `Ruleset` rollout in progress. The
            /// `prod` and `prod/beta` releases refer to the same `Ruleset`. However, `prod/v23` refers to a new
            /// `Ruleset`. The `Ruleset` reference for a `Release` may be updated using the UpdateRelease method.
            /// </summary>
            public class CreateRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Release>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRules.v1.Data.Release body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the project which owns this `Release`. Format: `projects/{project_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseRules.v1.Data.Release Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/releases";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Delete a `Release` by resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the `Release` to delete. Format:
            /// `projects/{project_id}/releases/{release_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete a `Release` by resource name.</summary>
            public class DeleteRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the `Release` to delete. Format:
                /// `projects/{project_id}/releases/{release_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/releases/.*$",
                    });
                }
            }

            /// <summary>Get a `Release` by name.</summary>
            /// <param name="name">
            /// Required. Resource name of the `Release`. Format: `projects/{project_id}/releases/{release_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a `Release` by name.</summary>
            public class GetRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Release>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the `Release`. Format: `projects/{project_id}/releases/{release_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/releases/.*$",
                    });
                }
            }

            /// <summary>Get the `Release` executable to use when enforcing rules.</summary>
            /// <param name="name">
            /// Required. Resource name of the `Release`. Format: `projects/{project_id}/releases/{release_id}`
            /// </param>
            public virtual GetExecutableRequest GetExecutable(string name)
            {
                return new GetExecutableRequest(this.service, name);
            }

            /// <summary>Get the `Release` executable to use when enforcing rules.</summary>
            public class GetExecutableRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.GetReleaseExecutableResponse>
            {
                /// <summary>Constructs a new GetExecutable request.</summary>
                public GetExecutableRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the `Release`. Format: `projects/{project_id}/releases/{release_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The requested runtime executable version. Defaults to FIREBASE_RULES_EXECUTABLE_V1.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("executableVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ExecutableVersionEnum> ExecutableVersion { get; set; }

                /// <summary>
                /// Optional. The requested runtime executable version. Defaults to FIREBASE_RULES_EXECUTABLE_V1.
                /// </summary>
                public enum ExecutableVersionEnum
                {
                    /// <summary>Executable format unspecified. Defaults to FIREBASE_RULES_EXECUTABLE_V1</summary>
                    [Google.Apis.Util.StringValueAttribute("RELEASE_EXECUTABLE_VERSION_UNSPECIFIED")]
                    RELEASEEXECUTABLEVERSIONUNSPECIFIED = 0,

                    /// <summary>
                    /// Firebase Rules syntax 'rules2' executable versions: Custom AST for use with Java clients.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FIREBASE_RULES_EXECUTABLE_V1")]
                    FIREBASERULESEXECUTABLEV1 = 1,

                    /// <summary>CEL-based executable for use with C++ clients.</summary>
                    [Google.Apis.Util.StringValueAttribute("FIREBASE_RULES_EXECUTABLE_V2")]
                    FIREBASERULESEXECUTABLEV2 = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getExecutable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:getExecutable";

                /// <summary>Initializes GetExecutable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/releases/.*$",
                    });
                    RequestParameters.Add("executableVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "executableVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// List the `Release` values for a project. This list may optionally be filtered by `Release` name,
            /// `Ruleset` name, `TestSuite` name, or any combination thereof.
            /// </summary>
            /// <param name="name">Required. Resource name for the project. Format: `projects/{project_id}`</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// List the `Release` values for a project. This list may optionally be filtered by `Release` name,
            /// `Ruleset` name, `TestSuite` name, or any combination thereof.
            /// </summary>
            public class ListRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.ListReleasesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name for the project. Format: `projects/{project_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. `Release` filter. The list method supports filters with restrictions on the
                /// `Release.name`, and `Release.ruleset_name`. Example 1: A filter of 'name=prod*' might return
                /// `Release`s with names within 'projects/foo' prefixed with 'prod': Name -&amp;gt; Ruleset Name: *
                /// projects/foo/releases/prod -&amp;gt; projects/foo/rulesets/uuid1234 * projects/foo/releases/prod/v1
                /// -&amp;gt; projects/foo/rulesets/uuid1234 * projects/foo/releases/prod/v2 -&amp;gt;
                /// projects/foo/rulesets/uuid8888 Example 2: A filter of `name=prod* ruleset_name=uuid1234` would
                /// return only `Release` instances for 'projects/foo' with names prefixed with 'prod' referring to the
                /// same `Ruleset` name of 'uuid1234': Name -&amp;gt; Ruleset Name: * projects/foo/releases/prod
                /// -&amp;gt; projects/foo/rulesets/1234 * projects/foo/releases/prod/v1 -&amp;gt;
                /// projects/foo/rulesets/1234 In the examples, the filter parameters refer to the search filters are
                /// relative to the project. Fully qualified prefixed may also be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Page size to load. Maximum of 100. Defaults to 10. Note: `page_size` is just a hint and
                /// the service may choose to load fewer than `page_size` results due to the size of the output. To
                /// traverse all of the releases, the caller should iterate until the `page_token` on the response is
                /// empty.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Next page token for the next batch of `Release` instances.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/releases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>
            /// Update a `Release` via PATCH. Only updates to `ruleset_name` will be honored. `Release` rename is not
            /// supported. To create a `Release` use the CreateRelease method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name for the project which owns this `Release`. Format: `projects/{project_id}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseRules.v1.Data.UpdateReleaseRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Update a `Release` via PATCH. Only updates to `ruleset_name` will be honored. `Release` rename is not
            /// supported. To create a `Release` use the CreateRelease method.
            /// </summary>
            public class PatchRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Release>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRules.v1.Data.UpdateReleaseRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the project which owns this `Release`. Format: `projects/{project_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseRules.v1.Data.UpdateReleaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/releases/.*$",
                    });
                }
            }
        }

        /// <summary>Gets the Rulesets resource.</summary>
        public virtual RulesetsResource Rulesets { get; }

        /// <summary>The "rulesets" collection of methods.</summary>
        public class RulesetsResource
        {
            private const string Resource = "rulesets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RulesetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Create a `Ruleset` from `Source`. The `Ruleset` is given a unique generated name which is returned to
            /// the caller. `Source` containing syntactic or semantics errors will result in an error response
            /// indicating the first error encountered. For a detailed view of `Source` issues, use TestRuleset.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name for Project which owns this `Ruleset`. Format: `projects/{project_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseRules.v1.Data.Ruleset body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Create a `Ruleset` from `Source`. The `Ruleset` is given a unique generated name which is returned to
            /// the caller. `Source` containing syntactic or semantics errors will result in an error response
            /// indicating the first error encountered. For a detailed view of `Source` issues, use TestRuleset.
            /// </summary>
            public class CreateRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Ruleset>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRules.v1.Data.Ruleset body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for Project which owns this `Ruleset`. Format: `projects/{project_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseRules.v1.Data.Ruleset Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/rulesets";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Delete a `Ruleset` by resource name. If the `Ruleset` is referenced by a `Release` the operation will
            /// fail.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the ruleset to delete. Format: `projects/{project_id}/rulesets/{ruleset_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Delete a `Ruleset` by resource name. If the `Ruleset` is referenced by a `Release` the operation will
            /// fail.
            /// </summary>
            public class DeleteRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the ruleset to delete. Format:
                /// `projects/{project_id}/rulesets/{ruleset_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/rulesets/[^/]+$",
                    });
                }
            }

            /// <summary>Get a `Ruleset` by name including the full `Source` contents.</summary>
            /// <param name="name">
            /// Required. Resource name for the ruleset to get. Format: `projects/{project_id}/rulesets/{ruleset_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a `Ruleset` by name including the full `Source` contents.</summary>
            public class GetRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.Ruleset>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the ruleset to get. Format:
                /// `projects/{project_id}/rulesets/{ruleset_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/rulesets/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// List `Ruleset` metadata only and optionally filter the results by `Ruleset` name. The full `Source`
            /// contents of a `Ruleset` may be retrieved with GetRuleset.
            /// </summary>
            /// <param name="name">Required. Resource name for the project. Format: `projects/{project_id}`</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// List `Ruleset` metadata only and optionally filter the results by `Ruleset` name. The full `Source`
            /// contents of a `Ruleset` may be retrieved with GetRuleset.
            /// </summary>
            public class ListRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.ListRulesetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name for the project. Format: `projects/{project_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. `Ruleset` filter. The list method supports filters with restrictions on `Ruleset.name`.
                /// Filters on `Ruleset.create_time` should use the `date` function which parses strings that conform to
                /// the RFC 3339 date/time specifications. Example: `create_time &amp;gt; date("2017-01-01T00:00:00Z")
                /// AND name=UUID-*`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Page size to load. Maximum of 100. Defaults to 10. Note: `page_size` is just a hint and
                /// the service may choose to load less than `page_size` due to the size of the output. To traverse all
                /// of the releases, caller should iterate until the `page_token` is empty.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Next page token for loading the next batch of `Ruleset` instances.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/rulesets";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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

        /// <summary>
        /// Test `Source` for syntactic and semantic correctness. Issues present, if any, will be returned to the caller
        /// with a description, severity, and source location. The test method may be executed with `Source` or a
        /// `Ruleset` name. Passing `Source` is useful for unit testing new rules. Passing a `Ruleset` name is useful
        /// for regression testing an existing rule. The following is an example of `Source` that permits users to
        /// upload images to a bucket bearing their user id and matching the correct metadata: _*Example*_ // Users are
        /// allowed to subscribe and unsubscribe to the blog. service firebase.storage { match
        /// /users/{userId}/images/{imageName} { allow write: if userId == request.auth.uid &amp;amp;&amp;amp;
        /// (imageName.matches('*.png$') || imageName.matches('*.jpg$')) &amp;amp;&amp;amp;
        /// resource.mimeType.matches('^image/') } }
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Tests may either provide `source` or a `Ruleset` resource name. For tests against `source`, the
        /// resource name must refer to the project: Format: `projects/{project_id}` For tests against a `Ruleset`, this
        /// must be the `Ruleset` resource name: Format: `projects/{project_id}/rulesets/{ruleset_id}`
        /// </param>
        public virtual TestRequest Test(Google.Apis.FirebaseRules.v1.Data.TestRulesetRequest body, string name)
        {
            return new TestRequest(this.service, body, name);
        }

        /// <summary>
        /// Test `Source` for syntactic and semantic correctness. Issues present, if any, will be returned to the caller
        /// with a description, severity, and source location. The test method may be executed with `Source` or a
        /// `Ruleset` name. Passing `Source` is useful for unit testing new rules. Passing a `Ruleset` name is useful
        /// for regression testing an existing rule. The following is an example of `Source` that permits users to
        /// upload images to a bucket bearing their user id and matching the correct metadata: _*Example*_ // Users are
        /// allowed to subscribe and unsubscribe to the blog. service firebase.storage { match
        /// /users/{userId}/images/{imageName} { allow write: if userId == request.auth.uid &amp;amp;&amp;amp;
        /// (imageName.matches('*.png$') || imageName.matches('*.jpg$')) &amp;amp;&amp;amp;
        /// resource.mimeType.matches('^image/') } }
        /// </summary>
        public class TestRequest : FirebaseRulesBaseServiceRequest<Google.Apis.FirebaseRules.v1.Data.TestRulesetResponse>
        {
            /// <summary>Constructs a new Test request.</summary>
            public TestRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseRules.v1.Data.TestRulesetRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Tests may either provide `source` or a `Ruleset` resource name. For tests against `source`,
            /// the resource name must refer to the project: Format: `projects/{project_id}` For tests against a
            /// `Ruleset`, this must be the `Ruleset` resource name: Format:
            /// `projects/{project_id}/rulesets/{ruleset_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseRules.v1.Data.TestRulesetRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "test";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:test";

            /// <summary>Initializes Test parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/.*$",
                });
            }
        }
    }
}
namespace Google.Apis.FirebaseRules.v1.Data
{
    /// <summary>Arg matchers for the mock function.</summary>
    public class Arg : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Argument matches any value provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anyValue")]
        public virtual Empty AnyValue { get; set; }

        /// <summary>Argument exactly matches value provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactValue")]
        public virtual object ExactValue { get; set; }

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

    /// <summary>
    /// Describes where in a file an expression is found and what it was evaluated to over the course of its use.
    /// </summary>
    public class ExpressionReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subexpressions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("children")]
        public virtual System.Collections.Generic.IList<ExpressionReport> Children { get; set; }

        /// <summary>Position of expression in original rules source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePosition")]
        public virtual SourcePosition SourcePosition { get; set; }

        /// <summary>Values that this expression evaluated to when encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<ValueCount> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`File` containing source content.</summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Textual Content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Fingerprint (e.g. github sha) associated with the `File`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Required. File name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a service-defined function call that was invoked during test execution.</summary>
    public class FunctionCall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The arguments that were provided to the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<object> Args { get; set; }

        /// <summary>Name of the function invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Mock function definition. Mocks must refer to a function declared by the target service. The type of the
    /// function args and result will be inferred at test time. If either the arg or result values are not compatible
    /// with function type declaration, the request will be considered invalid. More than one `FunctionMock` may be
    /// provided for a given function name so long as the `Arg` matchers are distinct. There may be only one function
    /// for a given overload where all `Arg` values are `Arg.any_value`.
    /// </summary>
    public class FunctionMock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of `Arg` values to match. The order in which the arguments are provided is the order in which they
        /// must appear in the function invocation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<Arg> Args { get; set; }

        /// <summary>
        /// The name of the function. The function name must match one provided by a service declaration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>The mock result of the function call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual Result Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirebaseRulesService.GetReleaseExecutable</summary>
    public class GetReleaseExecutableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Executable view of the `Ruleset` referenced by the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executable")]
        public virtual string Executable { get; set; }

        /// <summary>The Rules runtime version of the executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executableVersion")]
        public virtual string ExecutableVersion { get; set; }

        /// <summary>`Language` used to generate the executable bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>`Ruleset` name associated with the `Release` executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesetName")]
        public virtual string RulesetName { get; set; }

        private string _syncTimeRaw;

        private object _syncTime;

        /// <summary>
        /// Optional, indicates the freshness of the result. The response is guaranteed to be the latest within an
        /// interval up to the sync_time (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncTime")]
        public virtual string SyncTimeRaw
        {
            get => _syncTimeRaw;
            set
            {
                _syncTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _syncTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SyncTimeDateTimeOffset instead.")]
        public virtual object SyncTime
        {
            get => _syncTime;
            set
            {
                _syncTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _syncTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SyncTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SyncTimeRaw);
            set => SyncTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Timestamp for the most recent `Release.update_time`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issues include warnings, errors, and deprecation notices.</summary>
    public class Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Short error description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Position of the issue in the `Source`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePosition")]
        public virtual SourcePosition SourcePosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirebaseRulesService.ListReleases.</summary>
    public class ListReleasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of `Release` instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<Release> Releases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirebaseRulesService.ListRulesets.</summary>
    public class ListRulesetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of `Ruleset` instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesets")]
        public virtual System.Collections.Generic.IList<Ruleset> Rulesets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a Ruleset.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Services that this ruleset has declarations for (e.g., "cloud.firestore"). There may be 0+ of these.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Release` is a named reference to a `Ruleset`. Once a `Release` refers to a `Ruleset`, rules-enabled services
    /// will be able to enforce the `Ruleset`.
    /// </summary>
    public class Release : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the release was created.</summary>
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

        /// <summary>Required. Format: `projects/{project_id}/releases/{release_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist for the `Release` to
        /// be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesetName")]
        public virtual string RulesetName { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time the release was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Possible result values from the function mock invocation.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result is undefined, meaning the result could not be computed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undefined")]
        public virtual Empty Undefined { get; set; }

        /// <summary>
        /// The result is an actual value. The type of the value must match that of the type declared by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Ruleset` is an immutable copy of `Source` with a globally unique identifier and a creation time.
    /// </summary>
    public class Ruleset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Intended resource to which this Ruleset should be released. May be left blank to signify the
        /// resource associated with the default release. Expected format: firestore.googleapis.com/projects//databases/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentPoint")]
        public virtual string AttachmentPoint { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the `Ruleset` was created.</summary>
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

        /// <summary>Output only. The metadata for this ruleset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>
        /// Output only. Name of the `Ruleset`. The ruleset_id is auto generated by the service. Format:
        /// `projects/{project_id}/rulesets/{ruleset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. `Source` for the `Ruleset`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`Source` is one or more `File` messages comprising a logical set of rules.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. `File` set constituting the `Source` bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Position in the `Source` content including its line, column number, and an index of the `File` in the `Source`
    /// message. Used for debug purposes.
    /// </summary>
    public class SourcePosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>First column on the source line associated with the source fragment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual System.Nullable<int> Column { get; set; }

        /// <summary>Start position relative to the beginning of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentOffset")]
        public virtual System.Nullable<int> CurrentOffset { get; set; }

        /// <summary>End position relative to the beginning of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<int> EndOffset { get; set; }

        /// <summary>Name of the `File`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>Line number of the source fragment. 1-based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<int> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `TestCase` messages provide the request context and an expectation as to whether the given context will be
    /// allowed or denied. Test cases may specify the `request`, `resource`, and `function_mocks` to mock a function
    /// call to a service-provided function. The `request` object represents context present at request-time. The
    /// `resource` is the value of the target resource as it appears in persistent storage before the request is
    /// executed.
    /// </summary>
    public class TestCase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Test expectation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectation")]
        public virtual string Expectation { get; set; }

        /// <summary>Specifies what should be included in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressionReportLevel")]
        public virtual string ExpressionReportLevel { get; set; }

        /// <summary>
        /// Optional function mocks for service-defined functions. If not set, any service defined function is expected
        /// to return an error, which may or may not influence the test outcome.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionMocks")]
        public virtual System.Collections.Generic.IList<FunctionMock> FunctionMocks { get; set; }

        /// <summary>Specifies whether paths (such as request.path) are encoded and how.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathEncoding")]
        public virtual string PathEncoding { get; set; }

        /// <summary>
        /// Request context. The exact format of the request context is service-dependent. See the appropriate service
        /// documentation for information about the supported fields and types on the request. Minimally, all services
        /// support the following fields and types: Request field | Type ---------------|----------------- auth.uid |
        /// `string` auth.token | `map` headers | `map` method | `string` params | `map` path | `string` time |
        /// `google.protobuf.Timestamp` If the request value is not well-formed for the service, the request will be
        /// rejected as an invalid argument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual object Request { get; set; }

        /// <summary>
        /// Optional resource value as it appears in persistent storage before the request is fulfilled. The resource
        /// type depends on the `request.path` value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual object Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Test result message containing the state of the test as well as a description and source position for test
    /// failures.
    /// </summary>
    public class TestResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Debug messages related to test execution issues encountered during evaluation. Debug messages may be related
        /// to too many or too few invocations of function mocks or to runtime errors that occur during evaluation. For
        /// example:
        /// ```
        /// Unable to read variable [name: "resource"]
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugMessages")]
        public virtual System.Collections.Generic.IList<string> DebugMessages { get; set; }

        /// <summary>
        /// Position in the `Source` or `Ruleset` where the principle runtime error occurs. Evaluation of an expression
        /// may result in an error. Rules are deny by default, so a `DENY` expectation when an error is generated is
        /// valid. When there is a `DENY` with an error, the `SourcePosition` is returned. E.g. `error_position { line:
        /// 19 column: 37 }`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorPosition")]
        public virtual SourcePosition ErrorPosition { get; set; }

        /// <summary>
        /// The mapping from expression in the ruleset AST to the values they were evaluated to. Partially-nested to
        /// mirror AST structure. Note that this field is actually tracking expressions and not permission statements in
        /// contrast to the "visited_expressions" field above. Literal expressions are omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressionReports")]
        public virtual System.Collections.Generic.IList<ExpressionReport> ExpressionReports { get; set; }

        /// <summary>
        /// The set of function calls made to service-defined methods. Function calls are included in the order in which
        /// they are encountered during evaluation, are provided for both mocked and unmocked functions, and included on
        /// the response regardless of the test `state`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCalls")]
        public virtual System.Collections.Generic.IList<FunctionCall> FunctionCalls { get; set; }

        /// <summary>State of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The set of visited permission expressions for a given test. This returns the positions and evaluation
        /// results of all visited permission expressions which were relevant to the test case, e.g.
        /// ```
        /// match /path {
        /// allow read if: }
        /// ```
        /// For a detailed report of the intermediate evaluation states, see the
        /// `expression_reports` field
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitedExpressions")]
        public virtual System.Collections.Generic.IList<VisitedExpression> VisitedExpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirebaseRulesService.TestRuleset.</summary>
    public class TestRulesetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional `Source` to be checked for correctness. This field must not be set when the resource name
        /// refers to a `Ruleset`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>
        /// Required. The tests to execute against the `Source`. When `Source` is provided inline, the test cases will
        /// only be run if the `Source` is syntactically and semantically valid. Inline `TestSuite` to run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSuite")]
        public virtual TestSuite TestSuite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirebaseRulesService.TestRuleset.</summary>
    public class TestRulesetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Syntactic and semantic `Source` issues of varying severity. Issues of `ERROR` severity will prevent tests
        /// from executing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<Issue> Issues { get; set; }

        /// <summary>
        /// The set of test results given the test cases in the `TestSuite`. The results will appear in the same order
        /// as the test cases appear in the `TestSuite`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testResults")]
        public virtual System.Collections.Generic.IList<TestResult> TestResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `TestSuite` is a collection of `TestCase` instances that validate the logical correctness of a `Ruleset`. The
    /// `TestSuite` may be referenced in-line within a `TestRuleset` invocation or as part of a `Release` object as a
    /// pre-release check.
    /// </summary>
    public class TestSuite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of test cases associated with the `TestSuite`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCases")]
        public virtual System.Collections.Generic.IList<TestCase> TestCases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirebaseRulesService.UpdateRelease.</summary>
    public class UpdateReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. `Release` to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual Release Release { get; set; }

        /// <summary>Optional. Specifies which fields to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tuple for how many times an Expression was evaluated to a particular ExpressionValue.</summary>
    public class ValueCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount of times that expression returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The return value of the expression</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Store the position and access outcome for an expression visited in rules.</summary>
    public class VisitedExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Position in the `Source` or `Ruleset` where an expression was visited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePosition")]
        public virtual SourcePosition SourcePosition { get; set; }

        /// <summary>The evaluated value for the visited expression, e.g. true/false</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
