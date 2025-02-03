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

namespace Google.Apis.CloudRuntimeConfig.v1beta1
{
    /// <summary>The CloudRuntimeConfig Service.</summary>
    public class CloudRuntimeConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRuntimeConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRuntimeConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://runtimeconfig.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://runtimeconfig.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "runtimeconfig";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Runtime Configuration API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google Cloud Platform services' runtime configuration</summary>
            public static string Cloudruntimeconfig = "https://www.googleapis.com/auth/cloudruntimeconfig";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Runtime Configuration API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google Cloud Platform services' runtime configuration</summary>
            public const string Cloudruntimeconfig = "https://www.googleapis.com/auth/cloudruntimeconfig";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudRuntimeConfig requests.</summary>
    public abstract class CloudRuntimeConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRuntimeConfigBaseServiceRequest instance.</summary>
        protected CloudRuntimeConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRuntimeConfig parameter list.</summary>
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
            Configs = new ConfigsResource(service);
        }

        /// <summary>Gets the Configs resource.</summary>
        public virtual ConfigsResource Configs { get; }

        /// <summary>The "configs" collection of methods.</summary>
        public class ConfigsResource
        {
            private const string Resource = "configs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
                Variables = new VariablesResource(service);
                Waiters = new WaitersResource(service);
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/operations/.*$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+/operations/.*$",
                        });
                    }
                }
            }

            /// <summary>Gets the Variables resource.</summary>
            public virtual VariablesResource Variables { get; }

            /// <summary>The "variables" collection of methods.</summary>
            public class VariablesResource
            {
                private const string Resource = "variables";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VariablesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a variable within the given configuration. You cannot create a variable with a name that is
                /// a prefix of an existing variable name, or a name that has an existing variable name as a prefix. To
                /// learn more about creating a variable, read the [Setting and Getting
                /// Data](/deployment-manager/runtime-configurator/set-and-get-variables) documentation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The path to the RutimeConfig resource that this variable should belong to. The configuration must
                /// exist beforehand; the path must be in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a variable within the given configuration. You cannot create a variable with a name that is
                /// a prefix of an existing variable name, or a name that has an existing variable name as a prefix. To
                /// learn more about creating a variable, read the [Setting and Getting
                /// Data](/deployment-manager/runtime-configurator/set-and-get-variables) documentation.
                /// </summary>
                public class CreateRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The path to the RutimeConfig resource that this variable should belong to. The configuration
                    /// must exist beforehand; the path must be in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional but recommended unique `request_id`. If the server receives two `create()` requests
                    /// with the same `request_id`, then the second request will be ignored and the first resource
                    /// created and stored in the backend is returned. Empty `request_id` fields are ignored. It is
                    /// responsibility of the client to ensure uniqueness of the `request_id` strings. `request_id`
                    /// strings are limited to 64 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/variables";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a variable or multiple variables. If you specify a variable name, then that variable is
                /// deleted. If you specify a prefix and `recursive` is true, then all variables with that prefix are
                /// deleted. You must set a `recursive` to true if you delete variables by prefix.
                /// </summary>
                /// <param name="name">
                /// The name of the variable to delete, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a variable or multiple variables. If you specify a variable name, then that variable is
                /// deleted. If you specify a prefix and `recursive` is true, then all variables with that prefix are
                /// deleted. You must set a `recursive` to true if you delete variables by prefix.
                /// </summary>
                public class DeleteRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the variable to delete, in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Set to `true` to recursively delete multiple variables with the same prefix.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("recursive", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Recursive { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/variables/.*$",
                        });
                        RequestParameters.Add("recursive", new Google.Apis.Discovery.Parameter
                        {
                            Name = "recursive",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets information about a single variable.</summary>
                /// <param name="name">
                /// The name of the variable to return, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIBLE_NAME]`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a single variable.</summary>
                public class GetRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the variable to return, in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIBLE_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/variables/.*$",
                        });
                    }
                }

                /// <summary>
                /// Lists variables within given a configuration, matching any provided filters. This only lists
                /// variable names, not the values, unless `return_values` is true, in which case only variables that
                /// user has IAM permission to GetVariable will be returned.
                /// </summary>
                /// <param name="parent">
                /// The path to the RuntimeConfig resource for which you want to list variables. The configuration must
                /// exist beforehand; the path must be in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists variables within given a configuration, matching any provided filters. This only lists
                /// variable names, not the values, unless `return_values` is true, in which case only variables that
                /// user has IAM permission to GetVariable will be returned.
                /// </summary>
                public class ListRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.ListVariablesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The path to the RuntimeConfig resource for which you want to list variables. The configuration
                    /// must exist beforehand; the path must be in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filters variables by matching the specified filter. For example:
                    /// `projects/example-project/config/[CONFIG_NAME]/variables/example-variable`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Specifies the number of results to return per page. If there are fewer elements than the
                    /// specified number, returns all elements.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Specifies a page token to use. Set `pageToken` to a `nextPageToken` returned by a previous list
                    /// request to get the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// The flag indicates whether the user wants to return values of variables. If true, then only
                    /// those variables that user has IAM GetVariable permission will be returned along with their
                    /// values.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnValues", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnValues { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/variables";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+$",
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
                        RequestParameters.Add("returnValues", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnValues",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+/variables/.*$",
                        });
                    }
                }

                /// <summary>Updates an existing variable with a new value.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the variable to update, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable body, string name)
                {
                    return new UpdateRequest(this.service, body, name);
                }

                /// <summary>Updates an existing variable with a new value.</summary>
                public class UpdateRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the variable to update, in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/variables/.*$",
                        });
                    }
                }

                /// <summary>
                /// Watches a specific variable and waits for a change in the variable's value. When there is a change,
                /// this method returns the new value or times out. If a variable is deleted while being watched, the
                /// `variableState` state is set to `DELETED` and the method returns the last known variable `value`. If
                /// you set the deadline for watching to a larger value than internal timeout (60 seconds), the current
                /// variable value is returned and the `variableState` will be `VARIABLE_STATE_UNSPECIFIED`. To learn
                /// more about creating a watcher, read the [Watching a Variable for
                /// Changes](/deployment-manager/runtime-configurator/watching-a-variable) documentation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the variable to watch, in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </param>
                public virtual WatchRequest Watch(Google.Apis.CloudRuntimeConfig.v1beta1.Data.WatchVariableRequest body, string name)
                {
                    return new WatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Watches a specific variable and waits for a change in the variable's value. When there is a change,
                /// this method returns the new value or times out. If a variable is deleted while being watched, the
                /// `variableState` state is set to `DELETED` and the method returns the last known variable `value`. If
                /// you set the deadline for watching to a larger value than internal timeout (60 seconds), the current
                /// variable value is returned and the `variableState` will be `VARIABLE_STATE_UNSPECIFIED`. To learn
                /// more about creating a watcher, read the [Watching a Variable for
                /// Changes](/deployment-manager/runtime-configurator/watching-a-variable) documentation.
                /// </summary>
                public class WatchRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Variable>
                {
                    /// <summary>Constructs a new Watch request.</summary>
                    public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.WatchVariableRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the variable to watch, in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.WatchVariableRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "watch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:watch";

                    /// <summary>Initializes Watch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+/variables/.*$",
                        });
                    }
                }
            }

            /// <summary>Gets the Waiters resource.</summary>
            public virtual WaitersResource Waiters { get; }

            /// <summary>The "waiters" collection of methods.</summary>
            public class WaitersResource
            {
                private const string Resource = "waiters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WaitersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a Waiter resource. This operation returns a long-running Operation resource which can be
                /// polled for completion. However, a waiter with the given name will exist (and can be retrieved) prior
                /// to the operation completing. If the operation fails, the failed Waiter resource will still exist and
                /// must be deleted prior to subsequent creation attempts.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The path to the configuration that will own the waiter. The configuration must exist beforehand; the
                /// path must be in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRuntimeConfig.v1beta1.Data.Waiter body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a Waiter resource. This operation returns a long-running Operation resource which can be
                /// polled for completion. However, a waiter with the given name will exist (and can be retrieved) prior
                /// to the operation completing. If the operation fails, the failed Waiter resource will still exist and
                /// must be deleted prior to subsequent creation attempts.
                /// </summary>
                public class CreateRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.Waiter body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The path to the configuration that will own the waiter. The configuration must exist beforehand;
                    /// the path must be in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional but recommended unique `request_id`. If the server receives two `create()` requests
                    /// with the same `request_id`, then the second request will be ignored and the first resource
                    /// created and stored in the backend is returned. Empty `request_id` fields are ignored. It is
                    /// responsibility of the client to ensure uniqueness of the `request_id` strings. `request_id`
                    /// strings are limited to 64 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.Waiter Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/waiters";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the waiter with the specified name.</summary>
                /// <param name="name">
                /// The Waiter resource to delete, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/waiters/[WAITER_NAME]`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the waiter with the specified name.</summary>
                public class DeleteRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The Waiter resource to delete, in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/waiters/[WAITER_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/waiters/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets information about a single waiter.</summary>
                /// <param name="name">
                /// The fully-qualified name of the Waiter resource object to retrieve, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/waiters/[WAITER_NAME]`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a single waiter.</summary>
                public class GetRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Waiter>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully-qualified name of the Waiter resource object to retrieve, in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]/waiters/[WAITER_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/configs/[^/]+/waiters/[^/]+$",
                        });
                    }
                }

                /// <summary>List waiters within the given configuration.</summary>
                /// <param name="parent">
                /// The path to the configuration for which you want to get a list of waiters. The configuration must
                /// exist beforehand; the path must be in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List waiters within the given configuration.</summary>
                public class ListRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.ListWaitersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The path to the configuration for which you want to get a list of waiters. The configuration
                    /// must exist beforehand; the path must be in the format:
                    /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Specifies the number of results to return per page. If there are fewer elements than the
                    /// specified number, returns all elements.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Specifies a page token to use. Set `pageToken` to a `nextPageToken` returned by a previous list
                    /// request to get the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/waiters";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+$",
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
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/configs/[^/]+/waiters/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new RuntimeConfig resource. The configuration name must be unique within project.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The [project ID](https://support.google.com/cloud/answer/6158840?hl=en&amp;amp;ref_topic=6158848) for
            /// this request, in the format `projects/[PROJECT_ID]`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new RuntimeConfig resource. The configuration name must be unique within project.
            /// </summary>
            public class CreateRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The [project ID](https://support.google.com/cloud/answer/6158840?hl=en&amp;amp;ref_topic=6158848)
                /// for this request, in the format `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// An optional but recommended unique `request_id`. If the server receives two `create()` requests with
                /// the same `request_id`, then the second request will be ignored and the first resource created and
                /// stored in the backend is returned. Empty `request_id` fields are ignored. It is responsibility of
                /// the client to ensure uniqueness of the `request_id` strings. `request_id` strings are limited to 64
                /// characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/configs";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a RuntimeConfig resource.</summary>
            /// <param name="name">
            /// The RuntimeConfig resource to delete, in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a RuntimeConfig resource.</summary>
            public class DeleteRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The RuntimeConfig resource to delete, in the format: `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a RuntimeConfig resource.</summary>
            /// <param name="name">
            /// The name of the RuntimeConfig resource to retrieve, in the format:
            /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a RuntimeConfig resource.</summary>
            public class GetRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the RuntimeConfig resource to retrieve, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                    RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.requestedPolicyVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the RuntimeConfig resources within project.</summary>
            /// <param name="parent">
            /// The [project ID](https://support.google.com/cloud/answer/6158840?hl=en&amp;amp;ref_topic=6158848) for
            /// this request, in the format `projects/[PROJECT_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all the RuntimeConfig resources within project.</summary>
            public class ListRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.ListConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The [project ID](https://support.google.com/cloud/answer/6158840?hl=en&amp;amp;ref_topic=6158848)
                /// for this request, in the format `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Specifies the number of results to return per page. If there are fewer elements than the specified
                /// number, returns all elements.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Specifies a page token to use. Set `pageToken` to a `nextPageToken` returned by a previous list
                /// request to get the next page of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/configs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRuntimeConfig.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRuntimeConfig.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRuntimeConfig.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                }
            }

            /// <summary>Updates a RuntimeConfig resource. The configuration must exist beforehand.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the RuntimeConfig resource to update, in the format:
            /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>Updates a RuntimeConfig resource. The configuration must exist beforehand.</summary>
            public class UpdateRequest : CloudRuntimeConfigBaseServiceRequest<Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the RuntimeConfig resource to update, in the format:
                /// `projects/[PROJECT_ID]/configs/[CONFIG_NAME]`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRuntimeConfig.v1beta1.Data.RuntimeConfig Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/configs/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudRuntimeConfig.v1beta1.Data
{
    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Cardinality condition for the Waiter resource. A cardinality condition is met when the number of variables
    /// under a specified path prefix reaches a predefined number. For example, if you set a Cardinality condition where
    /// the `path` is set to `/foo` and the number of paths is set to `2`, the following variables would meet the
    /// condition in a RuntimeConfig resource: + `/foo/variable1 = "value1"` + `/foo/variable2 = "value2"` +
    /// `/bar/variable3 = "value3"` It would not satisfy the same condition with the `number` set to `3`, however,
    /// because there is only 2 paths that start with `/foo`. Cardinality conditions are recursive; all subtrees under
    /// the specific path prefix are counted.
    /// </summary>
    public class Cardinality : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number variables under the `path` that must exist to meet this condition. Defaults to 1 if not
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>The root of the variable subtree to monitor. For example, `/foo`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

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

    /// <summary>The condition that a Waiter resource is waiting for.</summary>
    public class EndCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cardinality of the `EndCondition`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual Cardinality Cardinality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ListConfigs()` returns the following response. The order of returned objects is arbitrary; that is, it is not
    /// ordered in any particular way.
    /// </summary>
    public class ListConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of the configurations in the project. The order of returned objects is arbitrary; that is, it is not
        /// ordered in any particular way.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<RuntimeConfig> Configs { get; set; }

        /// <summary>
        /// This token allows you to get the next page of results for list requests. If the number of results is larger
        /// than `pageSize`, use the `nextPageToken` as a value for the query parameter `pageToken` in the next list
        /// request. Subsequent list requests will have their own `nextPageToken` to continue paging through the results
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListVariables()` method.</summary>
    public class ListVariablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This token allows you to get the next page of results for list requests. If the number of results is larger
        /// than `pageSize`, use the `nextPageToken` as a value for the query parameter `pageToken` in the next list
        /// request. Subsequent list requests will have their own `nextPageToken` to continue paging through the results
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of variables and their values. The order of returned variable objects is arbitrary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IList<Variable> Variables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListWaiters()` method. Order of returned waiter objects is arbitrary.</summary>
    public class ListWaitersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This token allows you to get the next page of results for list requests. If the number of results is larger
        /// than `pageSize`, use the `nextPageToken` as a value for the query parameter `pageToken` in the next list
        /// request. Subsequent list requests will have their own `nextPageToken` to continue paging through the results
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Found waiters in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waiters")]
        public virtual System.Collections.Generic.IList<Waiter> Waiters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// A RuntimeConfig resource is the primary resource in the Cloud RuntimeConfig service. A RuntimeConfig resource
    /// consists of metadata and a hierarchy of variables.
    /// </summary>
    public class RuntimeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional description of the RuntimeConfig object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The resource name of a runtime config. The name must have the format:
        /// projects/[PROJECT_ID]/configs/[CONFIG_NAME] The `[PROJECT_ID]` must be a valid project ID, and
        /// `[CONFIG_NAME]` is an arbitrary name that matches the `[0-9A-Za-z](?:[_.A-Za-z0-9-]{0,62}[_.A-Za-z0-9])?`
        /// regular expression. The length of `[CONFIG_NAME]` must be less than 64 characters. You pick the
        /// RuntimeConfig resource name, but the server will validate that the name adheres to this format. After you
        /// create the resource, you cannot change the resource's name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a single variable within a RuntimeConfig resource. The name denotes the hierarchical variable name.
    /// For example, `ports/serving_port` is a valid variable name. The variable value is an opaque string and only leaf
    /// variables can have values (that is, variables that do not have any child variables).
    /// </summary>
    public class Variable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the variable resource, in the format:
        /// projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME] The `[PROJECT_ID]` must be a valid
        /// project ID, `[CONFIG_NAME]` must be a valid RuntimeConfig resource and `[VARIABLE_NAME]` follows Unix file
        /// system file path naming. The `[VARIABLE_NAME]` can contain ASCII letters, numbers, slashes and dashes.
        /// Slashes are used as path element separators and are not part of the `[VARIABLE_NAME]` itself, so
        /// `[VARIABLE_NAME]` must contain at least one non-slash character. Multiple slashes are coalesced into single
        /// slash character. Each path segment should match [0-9A-Za-z](?:[_.A-Za-z0-9-]{0,62}[_.A-Za-z0-9])? regular
        /// expression. The length of a `[VARIABLE_NAME]` must be less than 256 characters. Once you create a variable,
        /// you cannot change the variable name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The current state of the variable. The variable state indicates the outcome of the
        /// `variables().watch` call and is visible through the `get` and `list` calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The string value of the variable. The length of the value must be less than 4096 bytes. Empty values are
        /// also accepted. For example, `text: "my text value"`. The string must be valid UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time of the last variable update. Timestamp will be UTC timestamp.</summary>
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

        /// <summary>
        /// The binary value of the variable. The length of the value must be less than 4096 bytes. Empty values are
        /// also accepted. The value must be base64 encoded, and must comply with IETF RFC4648
        /// (https://www.ietf.org/rfc/rfc4648.txt). Only one of `value` or `text` can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Waiter resource waits for some end condition within a RuntimeConfig resource to be met before it returns. For
    /// example, assume you have a distributed system where each node writes to a Variable resource indicating the
    /// node's readiness as part of the startup process. You then configure a Waiter resource with the success condition
    /// set to wait until some number of nodes have checked in. Afterwards, your application runs some arbitrary code
    /// after the condition has been met and the waiter returns successfully. Once created, a Waiter resource is
    /// immutable. To learn more about using waiters, read the [Creating a
    /// Waiter](/deployment-manager/runtime-configurator/creating-a-waiter) documentation.
    /// </summary>
    public class Waiter : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The instant at which this Waiter resource was created. Adding the value of `timeout` to this
        /// instant yields the timeout deadline for the waiter.
        /// </summary>
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

        /// <summary>
        /// Output only. If the value is `false`, it means the waiter is still waiting for one of its conditions to be
        /// met. If true, the waiter has finished. If the waiter finished due to a timeout or failure, `error` will be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>Output only. If the waiter ended due to a failure or timeout, this value will be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// [Optional] The failure condition of this waiter. If this condition is met, `done` will be set to `true` and
        /// the `error` code will be set to `ABORTED`. The failure condition takes precedence over the success
        /// condition. If both conditions are met, a failure will be indicated. This value is optional; if no failure
        /// condition is set, the only failure scenario will be a timeout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failure")]
        public virtual EndCondition Failure { get; set; }

        /// <summary>
        /// The name of the Waiter resource, in the format:
        /// projects/[PROJECT_ID]/configs/[CONFIG_NAME]/waiters/[WAITER_NAME] The `[PROJECT_ID]` must be a valid Google
        /// Cloud project ID, the `[CONFIG_NAME]` must be a valid RuntimeConfig resource, the `[WAITER_NAME]` must match
        /// RFC 1035 segment specification, and the length of `[WAITER_NAME]` must be less than 64 bytes. After you
        /// create a Waiter resource, you cannot change the resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// [Required] The success condition. If this condition is met, `done` will be set to `true` and the `error`
        /// value will remain unset. The failure condition takes precedence over the success condition. If both
        /// conditions are met, a failure will be indicated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual EndCondition Success { get; set; }

        /// <summary>
        /// [Required] Specifies the timeout of the waiter in seconds, beginning from the instant that
        /// `waiters().create` method is called. If this time elapses before the success or failure conditions are met,
        /// the waiter fails and sets the `error` code to `DEADLINE_EXCEEDED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `WatchVariable()` method.</summary>
    public class WatchVariableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _newerThanRaw;

        private object _newerThan;

        /// <summary>
        /// If specified, checks the current timestamp of the variable and if the current timestamp is newer than
        /// `newerThan` timestamp, the method returns immediately. If not specified or the variable has an older
        /// timestamp, the watcher waits for a the value to change before returning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newerThan")]
        public virtual string NewerThanRaw
        {
            get => _newerThanRaw;
            set
            {
                _newerThan = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _newerThanRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NewerThanRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NewerThanDateTimeOffset instead.")]
        public virtual object NewerThan
        {
            get => _newerThan;
            set
            {
                _newerThanRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _newerThan = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NewerThanRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NewerThanDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NewerThanRaw);
            set => NewerThanRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
