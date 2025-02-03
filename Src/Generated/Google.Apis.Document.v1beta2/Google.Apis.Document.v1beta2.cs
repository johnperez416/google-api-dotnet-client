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

namespace Google.Apis.Document.v1beta2
{
    /// <summary>The Document Service.</summary>
    public class DocumentService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DocumentService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DocumentService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://documentai.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://documentai.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "documentai";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Document AI API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Document AI API.</summary>
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

    /// <summary>A base abstract class for Document requests.</summary>
    public abstract class DocumentBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DocumentBaseServiceRequest instance.</summary>
        protected DocumentBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Document parameter list.</summary>
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
            Documents = new DocumentsResource(service);
            Locations = new LocationsResource(service);
            Operations = new OperationsResource(service);
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }

        /// <summary>The "documents" collection of methods.</summary>
        public class DocumentsResource
        {
            private const string Resource = "documents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DocumentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
            /// [Document] format.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`. If
            /// no location is specified, a region will be chosen automatically.
            /// </param>
            public virtual BatchProcessRequest BatchProcess(Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest body, string parent)
            {
                return new BatchProcessRequest(this.service, body, parent);
            }

            /// <summary>
            /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
            /// [Document] format.
            /// </summary>
            public class BatchProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new BatchProcess request.</summary>
                public BatchProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`.
                /// If no location is specified, a region will be chosen automatically.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchProcess";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+parent}/documents:batchProcess";

                /// <summary>Initializes BatchProcess parameter list.</summary>
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
                }
            }

            /// <summary>Processes a single document.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`. If
            /// no location is specified, a region will be chosen automatically. This field is only populated when used
            /// in ProcessDocument method.
            /// </param>
            public virtual ProcessRequest Process(Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest body, string parent)
            {
                return new ProcessRequest(this.service, body, parent);
            }

            /// <summary>Processes a single document.</summary>
            public class ProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2Document>
            {
                /// <summary>Constructs a new Process request.</summary>
                public ProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`.
                /// If no location is specified, a region will be chosen automatically. This field is only populated
                /// when used in ProcessDocument method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "process";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+parent}/documents:process";

                /// <summary>Initializes Process parameter list.</summary>
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
                Documents = new DocumentsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Documents resource.</summary>
            public virtual DocumentsResource Documents { get; }

            /// <summary>The "documents" collection of methods.</summary>
            public class DocumentsResource
            {
                private const string Resource = "documents";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DocumentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
                /// [Document] format.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`.
                /// If no location is specified, a region will be chosen automatically.
                /// </param>
                public virtual BatchProcessRequest BatchProcess(Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest body, string parent)
                {
                    return new BatchProcessRequest(this.service, body, parent);
                }

                /// <summary>
                /// LRO endpoint to batch process many documents. The output is written to Cloud Storage as JSON in the
                /// [Document] format.
                /// </summary>
                public class BatchProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new BatchProcess request.</summary>
                    public BatchProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no location is specified, a region will be
                    /// chosen automatically.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchProcess";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/documents:batchProcess";

                    /// <summary>Initializes BatchProcess parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Processes a single document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`.
                /// If no location is specified, a region will be chosen automatically. This field is only populated
                /// when used in ProcessDocument method.
                /// </param>
                public virtual ProcessRequest Process(Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest body, string parent)
                {
                    return new ProcessRequest(this.service, body, parent);
                }

                /// <summary>Processes a single document.</summary>
                public class ProcessRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2Document>
                {
                    /// <summary>Constructs a new Process request.</summary>
                    public ProcessRequest(Google.Apis.Services.IClientService service, Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Target project and location to make a call. Format:
                    /// `projects/{project-id}/locations/{location-id}`. If no location is specified, a region will be
                    /// chosen automatically. This field is only populated when used in ProcessDocument method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Document.v1beta2.Data.GoogleCloudDocumentaiV1beta2ProcessDocumentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "process";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+parent}/documents:process";

                    /// <summary>Initializes Process parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
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
                public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v1beta2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }
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
            public class GetRequest : DocumentBaseServiceRequest<Google.Apis.Document.v1beta2.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v1beta2/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Document.v1beta2.Data
{
    /// <summary>Metadata of the auto-labeling documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of individual auto-labeling statuses of the dataset documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualAutoLabelStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadataIndividualAutoLabelStatus> IndividualAutoLabelStatuses { get; set; }

        /// <summary>Total number of the auto-labeling documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of individual documents in the auto-labeling process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsMetadataIndividualAutoLabelStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the auto-labeled document. This will replace the gcs_uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of the document auto-labeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of AutoLabelDocuments method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3AutoLabelDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Total number of documents that failed to be deleted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDocumentCount")]
        public virtual System.Nullable<int> ErrorDocumentCount { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchDeleteStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus> IndividualBatchDeleteStatuses { get; set; }

        /// <summary>Total number of documents deleting from dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch delete process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of deleting the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the delete documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchDeleteDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The destination dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destDatasetType")]
        public virtual string DestDatasetType { get; set; }

        /// <summary>The destination dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destSplitType")]
        public virtual string DestSplitType { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchMoveStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadataIndividualBatchMoveStatus> IndividualBatchMoveStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch move process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsMetadataIndividualBatchMoveStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of moving the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the batch move documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchMoveDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchUpdateStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadataIndividualBatchUpdateStatus> IndividualBatchUpdateStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch update process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsMetadataIndividualBatchUpdateStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of updating the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the batch update documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3BatchUpdateDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The long-running operation metadata for the CreateLabelerPool method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3CreateLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for DeleteLabelerPool.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document Identifier.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A document id within user-managed Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedDocId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentIdGCSManagedDocumentId GcsManagedDocId { get; set; }

        /// <summary>Points to a specific revision of the document if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionRef")]
        public virtual GoogleCloudDocumentaiUiv1beta3RevisionRef RevisionRef { get; set; }

        /// <summary>A document id within unmanaged dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDocId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentIdUnmanagedDocumentId UnmanagedDocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a document uniquely within the scope of a dataset in the user-managed Cloud Storage option.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentIdGCSManagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id of the document (indexed) managed by Content Warehouse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwDocId")]
        public virtual string CwDocId { get; set; }

        /// <summary>Required. The Cloud Storage URI where the actual document is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a document uniquely within the scope of a dataset in unmanaged option.</summary>
    public class GoogleCloudDocumentaiUiv1beta3DocumentIdUnmanagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docId")]
        public virtual string DocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the batch export documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualExportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataIndividualExportStatus> IndividualExportStatuses { get; set; }

        /// <summary>The list of statistics for each dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitExportStats")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataSplitExportStat> SplitExportStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the export process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataIndividualExportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The path to source docproto of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>
        /// The output_gcs_destination of the exported document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status of the exporting of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The statistic representing a dataset split type for this export.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsMetadataSplitExportStat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dataset split type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitType")]
        public virtual string SplitType { get; set; }

        /// <summary>Total number of documents with the given dataset split type to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of ExportDocuments method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata message associated with the ExportProcessorVersion operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The common metadata about the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message associated with the ExportProcessorVersion operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ExportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage URI containing the output artifacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the import document operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Validation statuses of the batch documents import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importConfigValidationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataImportConfigValidationResult> ImportConfigValidationResults { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualImportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataIndividualImportStatus> IndividualImportStatuses { get; set; }

        /// <summary>Total number of the documents that are qualified for importing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The validation status of each import config. Status is set to an error if there are no documents to import in
    /// the `import_config`, or `OK` if the operation will try to proceed with at least one document.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataImportConfigValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI specified in the import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The validation status of import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the import process.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsMetadataIndividualImportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The document id of imported document if it was successful, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDocumentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId OutputDocumentId { get; set; }

        /// <summary>
        /// The output_gcs_destination of the processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status of the importing of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the import document operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata for the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ImportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination processor version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata proto of `ResyncDataset` method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>
        /// The list of dataset resync statuses. Not checked when ResyncDatasetRequest.dataset_documents is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetResyncStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataDatasetResyncStatus> DatasetResyncStatuses { get; set; }

        /// <summary>
        /// The list of document resync statuses. The same document could have multiple
        /// `individual_document_resync_statuses` if it has multiple inconsistencies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualDocumentResyncStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataIndividualDocumentResyncStatus> IndividualDocumentResyncStatuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resync status against inconsistency types on the dataset level.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataDatasetResyncStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the inconsistency of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetInconsistencyType")]
        public virtual string DatasetInconsistencyType { get; set; }

        /// <summary>
        /// The status of resyncing the dataset with regards to the detected inconsistency. Empty if
        /// ResyncDatasetRequest.validate_only is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resync status for each document per inconsistency type.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetMetadataIndividualDocumentResyncStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiUiv1beta3DocumentId DocumentId { get; set; }

        /// <summary>The type of document inconsistency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentInconsistencyType")]
        public virtual string DocumentInconsistencyType { get; set; }

        /// <summary>
        /// The status of resyncing the document with regards to the detected inconsistency. Empty if
        /// ResyncDatasetRequest.validate_only is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto of ResyncDataset method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3ResyncDatasetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The revision reference specifies which revision on the document to read.</summary>
    public class GoogleCloudDocumentaiUiv1beta3RevisionRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reads the revision generated by the processor version. The format takes the full resource name of processor
        /// version.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestProcessorVersion")]
        public virtual string LatestProcessorVersion { get; set; }

        /// <summary>Reads the revision by the predefined case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCase")]
        public virtual string RevisionCase { get; set; }

        /// <summary>Reads the revision given by the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the sample documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the sample documents operation.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of sampling documents in test split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTestStatus")]
        public virtual GoogleRpcStatus SampleTestStatus { get; set; }

        /// <summary>The status of sampling documents in training split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTrainingStatus")]
        public virtual GoogleRpcStatus SampleTrainingStatus { get; set; }

        /// <summary>The result of the sampling process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedDocuments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponseSelectedDocument> SelectedDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3SampleDocumentsResponseSelectedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An internal identifier for document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiUiv1beta3TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiUiv1beta3UpdateDatasetOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for updating the human review configuration.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UpdateHumanReviewConfigMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for UpdateLabelerPool.</summary>
    public class GoogleCloudDocumentaiUiv1beta3UpdateLabelerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiUiv1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualProcessStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1BatchProcessMetadataIndividualProcessStatus> IndividualProcessStatuses { get; set; }

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The status of a each individual document in the batch process.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessMetadataIndividualProcessStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of human review on the processed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewStatus")]
        public virtual GoogleCloudDocumentaiV1HumanReviewStatus HumanReviewStatus { get; set; }

        /// <summary>
        /// The source of the document, same as the input_gcs_source field in the request when the batch process
        /// started.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>
        /// The Cloud Storage output destination (in the request as DocumentOutputConfig.GcsOutputConfig.gcs_uri) of the
        /// processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status processing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1BatchProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiV1CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiV1DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of human review on a processed document.</summary>
    public class GoogleCloudDocumentaiV1HumanReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. This field is populated only when the state
        /// is `HUMAN_REVIEW_IN_PROGRESS`. It has the same response type and metadata as the long-running operation
        /// returned by ReviewDocument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The state of human review on the processing request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the human review state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1ReviewDocumentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The Crowd Compute question ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1ReviewDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage uri for the human reviewed document if the review is succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual string GcsDestination { get; set; }

        /// <summary>The reason why the review is rejected by reviewer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectionReason")]
        public virtual string RejectionReason { get; set; }

        /// <summary>The state of the review operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiV1TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encodes the detailed information of a barcode.</summary>
    public class GoogleCloudDocumentaiV1beta1Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Format of a barcode. The supported formats are: - `CODE_128`: Code 128 type. - `CODE_39`: Code 39 type. -
        /// `CODE_93`: Code 93 type. - `CODABAR`: Codabar type. - `DATA_MATRIX`: 2D Data Matrix type. - `ITF`: ITF type.
        /// - `EAN_13`: EAN-13 type. - `EAN_8`: EAN-8 type. - `QR_CODE`: 2D QR code type. - `UPC_A`: UPC-A type. -
        /// `UPC_E`: UPC-E type. - `PDF417`: PDF417 type. - `AZTEC`: 2D Aztec code type. - `DATABAR`: GS1 DataBar code
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Raw value encoded in the barcode. For example: `'MEBKM:TITLE:Google;URL:https://www.google.com;;'`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawValue")]
        public virtual string RawValue { get; set; }

        /// <summary>
        /// Value format describes the format of the value that a barcode encodes. The supported formats are: -
        /// `CONTACT_INFO`: Contact information. - `EMAIL`: Email address. - `ISBN`: ISBN identifier. - `PHONE`: Phone
        /// number. - `PRODUCT`: Product. - `SMS`: SMS message. - `TEXT`: Text string. - `URL`: URL address. - `WIFI`:
        /// Wifi information. - `GEO`: Geo-localization. - `CALENDAR_EVENT`: Calendar event. - `DRIVER_LICENSE`:
        /// Driver's license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFormat")]
        public virtual string ValueFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to an batch document processing request. This is returned in the LRO Operation after the operation is
    /// complete.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1BatchProcessDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Responses for each individual document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1ProcessDocumentResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudDocumentaiV1beta1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Document represents the canonical document resource in Document AI. It is an interchange format that provides
    /// insights into documents and allows for collaboration between users and Document AI to iterate and optimize for
    /// quality.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document chunked based on chunking config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkedDocument")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentChunkedDocument ChunkedDocument { get; set; }

        /// <summary>
        /// Optional. Inline document content, represented as a stream of bytes. Note: As with all `bytes` fields,
        /// protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Parsed layout of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLayout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentDocumentLayout DocumentLayout { get; set; }

        /// <summary>
        /// A list of entities detected on Document.text. For document shards, entities in this list may cross shard
        /// boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentEntity> Entities { get; set; }

        /// <summary>Placeholder. Relationship among Document.entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityRelations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentEntityRelation> EntityRelations { get; set; }

        /// <summary>Any error that occurred while processing this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// An IANA published [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Visual page layout for the Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPage> Pages { get; set; }

        /// <summary>Placeholder. Revision history of this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentRevision> Revisions { get; set; }

        /// <summary>
        /// Information about the sharding if this document is sharded part of a larger document. If the document is not
        /// sharded, this message is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardInfo")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentShardInfo ShardInfo { get; set; }

        /// <summary>Optional. UTF-8 encoded text in reading order from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Placeholder. A list of text corrections made to Document.text. This is usually used for annotating
        /// corrections to OCR mistakes. Text changes for a given revision may not overlap with each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textChanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentTextChange> TextChanges { get; set; }

        /// <summary>Styles for the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyles")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentStyle> TextStyles { get; set; }

        /// <summary>
        /// Optional. Currently supports Google Cloud Storage URI of the form `gs://bucket_name/object_name`. Object
        /// versioning is not supported. For more information, refer to [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the chunks that the document is divided into.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentChunkedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of chunks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunk> Chunks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a chunk.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkId")]
        public virtual string ChunkId { get; set; }

        /// <summary>Text content of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Page footers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFooters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageFooter> PageFooters { get; set; }

        /// <summary>Page headers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageHeader> PageHeaders { get; set; }

        /// <summary>Page span of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBlockIds")]
        public virtual System.Collections.Generic.IList<string> SourceBlockIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page footer associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Footer in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page header associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Header in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the chunk starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentChunkedDocumentChunkChunkPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where chunk ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where chunk starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the parsed layout of a document as a collection of blocks that the document is divided into.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a block. A block could be one of the various types (text, table, list) supported.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockId")]
        public virtual string BlockId { get; set; }

        /// <summary>Block consisting of list content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listBlock")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock ListBlock { get; set; }

        /// <summary>Page span of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan PageSpan { get; set; }

        /// <summary>Block consisting of table content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBlock")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock TableBlock { get; set; }

        /// <summary>Block consisting of text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBlock")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock TextBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list type block.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List entries that constitute a list block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry> ListEntries { get; set; }

        /// <summary>Type of the list_entries (if exist). Available options are `ordered` and `unordered`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an entry in the list.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list entry is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the block starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where block ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where block starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a table type block.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows containing main table content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> BodyRows { get; set; }

        /// <summary>Table caption/title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Header rows at the top of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a cell in a table row.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A table cell is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row in a table.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A table row is a list of table cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a text type block.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A text block could further have child blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>Text content stored in the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Type of the text in the block. Available options are: `paragraph`, `subtitle`, `heading-1`, `heading-2`,
        /// `heading-3`, `heading-4`, `heading-5`, `header`, `footer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity that could be a phrase in the text or a property that belongs to the document. It is a known entity
    /// type, such as a person, an organization, or location.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Confidence of detected Schema entity. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Canonical id. This will be a unique value in the entity list for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Deprecated. Use `id` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionId")]
        public virtual string MentionId { get; set; }

        /// <summary>Optional. Text value of the entity e.g. `1600 Amphitheatre Pkwy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionText")]
        public virtual string MentionText { get; set; }

        /// <summary>
        /// Optional. Normalized entity value. Absent if the extracted value could not be converted or the type (e.g.
        /// address) is not supported for certain parsers. This field is also only populated for certain supported
        /// document types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedValue")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentEntityNormalizedValue NormalizedValue { get; set; }

        /// <summary>
        /// Optional. Represents the provenance of this entity wrt. the location on the page where it was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageAnchor")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageAnchor PageAnchor { get; set; }

        /// <summary>
        /// Optional. Entities can be nested to form a hierarchical data structure representing the content in the
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentEntity> Properties { get; set; }

        /// <summary>Optional. The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>Optional. Whether the entity will be redacted for de-identification purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redacted")]
        public virtual System.Nullable<bool> Redacted { get; set; }

        /// <summary>Optional. Provenance of the entity. Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>Required. Entity type from a schema e.g. `Address`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parsed and normalized entity value.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentEntityNormalizedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Postal address. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/postal_address.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressValue")]
        public virtual GoogleTypePostalAddress AddressValue { get; set; }

        /// <summary>Boolean value. Can be used for entities with binary values, or for checkboxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>
        /// Date value. Includes year, month, day. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/date.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual GoogleTypeDate DateValue { get; set; }

        /// <summary>
        /// DateTime value. Includes date, time, and timezone. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/datetime.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>Float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<int> IntegerValue { get; set; }

        /// <summary>
        /// Money value. See also: https://github.com/googleapis/googleapis/blob/master/google/type/money.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual GoogleTypeMoney MoneyValue { get; set; }

        /// <summary>
        /// Optional. An optional field to store a normalized string. For some entity types, one of respective
        /// `structured_value` fields may also be populated. Also not all the types of `structured_value` will be
        /// normalized. For example, some processors may not generate `float` or `integer` normalized text by default.
        /// Below are sample formats mapped to structured values. - Money/Currency type (`money_value`) is in the ISO
        /// 4217 text format. - Date type (`date_value`) is in the ISO 8601 text format. - Datetime type
        /// (`datetime_value`) is in the ISO 8601 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Relationship between Entities.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentEntityRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>Relationship description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>Subject entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectId")]
        public virtual string SubjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page in a Document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of visually detected text blocks on the page. A block has a set of lines (collected into paragraphs)
        /// that have a common line-spacing and orientation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageBlock> Blocks { get; set; }

        /// <summary>A list of detected barcodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBarcodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedBarcode> DetectedBarcodes { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Physical dimension of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageDimension Dimension { get; set; }

        /// <summary>A list of visually detected form fields on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageFormField> FormFields { get; set; }

        /// <summary>
        /// Rendered image for this page. This image is preprocessed to remove any skew, rotation, and distortions such
        /// that the annotation bounding boxes can be upright and axis-aligned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageImage Image { get; set; }

        /// <summary>Image quality scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageQualityScores")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageImageQualityScores ImageQualityScores { get; set; }

        /// <summary>Layout for the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>
        /// A list of visually detected text lines on the page. A collection of tokens that a human would perceive as a
        /// line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lines")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageLine> Lines { get; set; }

        /// <summary>
        /// 1-based index for current Page in a parent Document. Useful when a page is taken out of a Document for
        /// individual processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// A list of visually detected text paragraphs on the page. A collection of lines that a human would perceive
        /// as a paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageParagraph> Paragraphs { get; set; }

        /// <summary>The history of this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>A list of visually detected symbols on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageSymbol> Symbols { get; set; }

        /// <summary>A list of visually detected tables on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageTable> Tables { get; set; }

        /// <summary>A list of visually detected tokens on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageToken> Tokens { get; set; }

        /// <summary>
        /// Transformation matrices that were applied to the original document image to produce Page.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transforms")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageMatrix> Transforms { get; set; }

        /// <summary>A list of detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualElements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageVisualElement> VisualElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Referencing the visual context of the entity in the Document.pages. Page anchors can be cross-page, consist of
    /// multiple bounding polygons and optionally reference specific layout element types.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One or more references to visual page elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageRefs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageAnchorPageRef> PageRefs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weak reference to a page element within a document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageAnchorPageRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifies the bounding polygon of a layout element on the page. If `layout_type` is set, the
        /// bounding polygon must be exactly the same to the layout element it's referring to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Optional. Confidence of detected page element, if applicable. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Deprecated. Use PageRef.bounding_poly instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutId")]
        public virtual string LayoutId { get; set; }

        /// <summary>Optional. The type of the layout element that is being referenced if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutType")]
        public virtual string LayoutType { get; set; }

        /// <summary>
        /// Required. Index into the Document.pages element, for example using `Document.pages` to locate the related
        /// page element. This field is skipped when its value is the default `0`. See
        /// https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("page")]
        public virtual System.Nullable<long> Page { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A block has a set of lines (collected into paragraphs) that have a common line-spacing and orientation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected barcode.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageDetectedBarcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed barcode information of the DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual GoogleCloudDocumentaiV1beta1Barcode Barcode { get; set; }

        /// <summary>Layout for DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The [BCP-47 language code](https://www.unicode.org/reports/tr35/#Unicode_locale_identifier), such as `en-US`
        /// or `sr-Latn`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension for the page.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<float> Height { get; set; }

        /// <summary>Dimension unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Page width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<float> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form field detected on the page.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageFormField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Created for Labeling UI to export key text. If corrections were made to the text identified by the
        /// `field_name.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedKeyText")]
        public virtual string CorrectedKeyText { get; set; }

        /// <summary>
        /// Created for Labeling UI to export value text. If corrections were made to the text identified by the
        /// `field_value.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedValueText")]
        public virtual string CorrectedValueText { get; set; }

        /// <summary>
        /// Layout for the FormField name. e.g. `Address`, `Email`, `Grand total`, `Phone number`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout FieldName { get; set; }

        /// <summary>Layout for the FormField value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldValue")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout FieldValue { get; set; }

        /// <summary>A list of detected languages for name together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> NameDetectedLanguages { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>A list of detected languages for value together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> ValueDetectedLanguages { get; set; }

        /// <summary>
        /// If the value is non-textual, this field represents the type. Current valid values are: - blank (this
        /// indicates the `field_value` is normal text) - `unfilled_checkbox` - `filled_checkbox`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rendered image contents for this page.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Raw byte content of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Height of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>
        /// Encoding [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml) for the
        /// image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Width of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image quality scores for the page image.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageImageQualityScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected defects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDefects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageImageQualityScoresDetectedDefect> DetectedDefects { get; set; }

        /// <summary>The overall quality score. Range `[0, 1]` where `1` is perfect quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityScore")]
        public virtual System.Nullable<float> QualityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image Quality Defects</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageImageQualityScoresDetectedDefect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence of detected defect. Range `[0, 1]` where `1` indicates strong confidence that the defect exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Name of the defect type. Supported values are: - `quality/defect_blurry` - `quality/defect_noisy` -
        /// `quality/defect_dark` - `quality/defect_faint` - `quality/defect_text_too_small` -
        /// `quality/defect_document_cutoff` - `quality/defect_text_cutoff` - `quality/defect_glare`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Visual element describing a layout unit on a page.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// Confidence of the current Layout within context of the object this layout is for. e.g. confidence can be for
        /// a single token, a table, a visual element, etc. depending on context. Range `[0, 1]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Detected orientation for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of tokens that a human would perceive as a line. Does not cross column boundaries, can be
    /// horizontal, vertical, etc.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation for transformation matrix, intended to be compatible and used with OpenCV format for image
    /// manipulation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cols")]
        public virtual System.Nullable<int> Cols { get; set; }

        /// <summary>The matrix data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Number of rows in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>
        /// This encodes information about what data type the matrix uses. For example, 0 (CV_8U) is an unsigned 8-bit
        /// image. For the full list of OpenCV primitive data types, please refer to
        /// https://docs.opencv.org/4.3.0/d1/d1b/group__core__hal__interface.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Nullable<int> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of lines that a human would perceive as a paragraph.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected symbol.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageSymbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table representation similar to HTML table structure.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageTableTableRow> BodyRows { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Header rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageTableTableRow> HeaderRows { get; set; }

        /// <summary>Layout for Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cell representation inside the table.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageTableTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for TableCell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of table cells.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageTableTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageTableTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected token.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break at the end of a Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageTokenDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentProvenance Provenance { get; set; }

        /// <summary>Text style attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleInfo")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageTokenStyleInfo StyleInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected break at the end of a Token.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageTokenDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font and other text style attributes.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageTokenStyleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color of the background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Whether the text is bold (equivalent to font_weight is at least `700`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>Font size in points (`1` point is `¹⁄₇₂` inches).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual System.Nullable<int> FontSize { get; set; }

        /// <summary>Name or style of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontType")]
        public virtual string FontType { get; set; }

        /// <summary>
        /// TrueType weight on a scale `100` (thin) to `1000` (ultra-heavy). Normal is `400`, bold is `700`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual System.Nullable<int> FontWeight { get; set; }

        /// <summary>Whether the text is handwritten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handwritten")]
        public virtual System.Nullable<bool> Handwritten { get; set; }

        /// <summary>Whether the text is italic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>Letter spacing in points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("letterSpacing")]
        public virtual System.Nullable<double> LetterSpacing { get; set; }

        /// <summary>Font size in pixels, equal to _unrounded font_size_ * _resolution_ ÷ `72.0`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFontSize")]
        public virtual System.Nullable<double> PixelFontSize { get; set; }

        /// <summary>Whether the text is in small caps. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallcaps")]
        public virtual System.Nullable<bool> Smallcaps { get; set; }

        /// <summary>Whether the text is strikethrough. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikeout")]
        public virtual System.Nullable<bool> Strikeout { get; set; }

        /// <summary>Whether the text is a subscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscript")]
        public virtual System.Nullable<bool> Subscript { get; set; }

        /// <summary>Whether the text is a superscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superscript")]
        public virtual System.Nullable<bool> Superscript { get; set; }

        /// <summary>Color of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual GoogleTypeColor TextColor { get; set; }

        /// <summary>Whether the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underlined")]
        public virtual System.Nullable<bool> Underlined { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentPageVisualElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentPageLayout Layout { get; set; }

        /// <summary>Type of the VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structure to identify provenance relationships between annotations in different revisions.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Id of this operation. Needs to be unique within the scope of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>References to the original elements that are replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentProvenanceParent> Parents { get; set; }

        /// <summary>The index of the revision that produced this element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The type of provenance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The parent element the current element is based on. Used for referencing/aligning, removal and replacement
    /// operations.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentProvenanceParent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the parent provenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>
        /// The index of the parent item in the corresponding item list (eg. list of entities, properties within
        /// entities, etc.) in the parent revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The index of the index into current revision's parent_ids list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains past or forward revisions of this document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the change was made by a person specify the name or id of that person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The time that the revision was created, internally generated by doc proto storage at the time of create.
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

        /// <summary>Human Review information of this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReview")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentRevisionHumanReview HumanReview { get; set; }

        /// <summary>
        /// Id of the revision, internally generated by doc proto storage. Unique within the context of the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. This can include one or more parent (when documents are
        /// merged.) This field represents the index into the `revisions` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Parent { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. Must include all the ids that have anything to do with this
        /// revision - eg. there are `provenance.parent.revision` fields that index into this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentIds")]
        public virtual System.Collections.Generic.IList<string> ParentIds { get; set; }

        /// <summary>If the annotation was made by processor identify the processor by its resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processor")]
        public virtual string Processor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Human Review information of the document.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentRevisionHumanReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human review state. e.g. `requested`, `succeeded`, `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the rejection reason
        /// when the state is `rejected`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a large document, sharding may be performed to produce several document shards. Each document shard contains
    /// this field to detail which shard it is.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentShardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>The 0-based index of this shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardIndex")]
        public virtual System.Nullable<long> ShardIndex { get; set; }

        /// <summary>The index of the first character in Document.text in the overall document global text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOffset")]
        public virtual System.Nullable<long> TextOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation for common text style attributes. This adheres to CSS conventions as much as possible.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Text color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Font family such as `Arial`, `Times New Roman`. https://www.w3schools.com/cssref/pr_font_font-family.asp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>Font size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentStyleFontSize FontSize { get; set; }

        /// <summary>
        /// [Font weight](https://www.w3schools.com/cssref/pr_font_weight.asp). Possible values are `normal`, `bold`,
        /// `bolder`, and `lighter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual string FontWeight { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>
        /// [Text decoration](https://www.w3schools.com/cssref/pr_text_text-decoration.asp). Follows CSS standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDecoration")]
        public virtual string TextDecoration { get; set; }

        /// <summary>
        /// [Text style](https://www.w3schools.com/cssref/pr_font_font-style.asp). Possible values are `normal`,
        /// `italic`, and `oblique`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual string TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font size with unit.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentStyleFontSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Font size for the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<float> Size { get; set; }

        /// <summary>Unit for the font size. Follows CSS naming (such as `in`, `px`, and `pt`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Text reference indexing into the Document.text.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentTextAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the content of the text span so that users do not have to look it up in the text_segments. It is
        /// always populated for formFields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The text segments from the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textSegments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentTextAnchorTextSegment> TextSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text segment in the Document.text. The indices may be out of bounds which indicate that the text extends into
    /// another document shard for large sharded documents. See ShardInfo.text_offset
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1DocumentTextAnchorTextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TextSegment half open end UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<long> EndIndex { get; set; }

        /// <summary>TextSegment start UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<long> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message is used for text changes aka. OCR corrections.</summary>
    public class GoogleCloudDocumentaiV1beta1DocumentTextChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that replaces the text identified in the `text_anchor`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedText")]
        public virtual string ChangedText { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta1DocumentProvenance> Provenance { get; set; }

        /// <summary>
        /// Provenance of the correction. Text anchor indexing into the Document.text. There can only be a single
        /// `TextAnchor.text_segments` element. If the start and end index of the text segment are the same, the text
        /// change is inserted before that index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output file will be written to.</summary>
    public class GoogleCloudDocumentaiV1beta1GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input file will be read from.</summary>
    public class GoogleCloudDocumentaiV1beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudDocumentaiV1beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Google Cloud Storage location to read the input from. This must be a single file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDocumentaiV1beta1GcsSource GcsSource { get; set; }

        /// <summary>
        /// Required. Mimetype of the input. Current supported mimetypes are application/pdf, image/tiff, and image/gif.
        /// In addition, application/json type is supported for requests with ProcessDocumentRequest.automl_params field
        /// set. The JSON file needs to be in Document format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains metadata for the BatchProcessDocuments operation.</summary>
    public class GoogleCloudDocumentaiV1beta1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudDocumentaiV1beta1OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Google Cloud Storage location to write the output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDocumentaiV1beta1GcsDestination GcsDestination { get; set; }

        /// <summary>
        /// The max number of pages to include into each output Document shard JSON on Google Cloud Storage. The valid
        /// range is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages,
        /// 100 parsed pages will be produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
        /// containing 20 parsed pages will be written under the prefix OutputConfig.gcs_destination.uri and suffix
        /// pages-x-to-y.json where x and y are 1-indexed page numbers. Example GCS outputs with 157 pages and
        /// pages_per_shard = 50: pages-001-to-050.json pages-051-to-100.json pages-101-to-150.json
        /// pages-151-to-157.json
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesPerShard")]
        public virtual System.Nullable<int> PagesPerShard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a single document processing request.</summary>
    public class GoogleCloudDocumentaiV1beta1ProcessDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the input file. This is the same as the corresponding input config in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudDocumentaiV1beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// The output location of the parsed responses. The responses are written to this location as JSON-serialized
        /// `Document` objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDocumentaiV1beta1OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta1Vertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to control AutoML model prediction behavior.</summary>
    public class GoogleCloudDocumentaiV1beta2AutoMlParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of the AutoML model. Format:
        /// `projects/{project-id}/locations/{location-id}/models/{model-id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encodes the detailed information of a barcode.</summary>
    public class GoogleCloudDocumentaiV1beta2Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Format of a barcode. The supported formats are: - `CODE_128`: Code 128 type. - `CODE_39`: Code 39 type. -
        /// `CODE_93`: Code 93 type. - `CODABAR`: Codabar type. - `DATA_MATRIX`: 2D Data Matrix type. - `ITF`: ITF type.
        /// - `EAN_13`: EAN-13 type. - `EAN_8`: EAN-8 type. - `QR_CODE`: 2D QR code type. - `UPC_A`: UPC-A type. -
        /// `UPC_E`: UPC-E type. - `PDF417`: PDF417 type. - `AZTEC`: 2D Aztec code type. - `DATABAR`: GS1 DataBar code
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Raw value encoded in the barcode. For example: `'MEBKM:TITLE:Google;URL:https://www.google.com;;'`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawValue")]
        public virtual string RawValue { get; set; }

        /// <summary>
        /// Value format describes the format of the value that a barcode encodes. The supported formats are: -
        /// `CONTACT_INFO`: Contact information. - `EMAIL`: Email address. - `ISBN`: ISBN identifier. - `PHONE`: Phone
        /// number. - `PRODUCT`: Product. - `SMS`: SMS message. - `TEXT`: Text string. - `URL`: URL address. - `WIFI`:
        /// Wifi information. - `GEO`: Geo-localization. - `CALENDAR_EVENT`: Calendar event. - `DRIVER_LICENSE`:
        /// Driver's license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFormat")]
        public virtual string ValueFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to batch process documents as an asynchronous operation. The output is written to Cloud Storage as JSON
    /// in the [Document] format.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2BatchProcessDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Individual requests for each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2ProcessDocumentRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to an batch document processing request. This is returned in the LRO Operation after the operation is
    /// complete.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2BatchProcessDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Responses for each individual document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2ProcessDocumentResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudDocumentaiV1beta2BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Document represents the canonical document resource in Document AI. It is an interchange format that provides
    /// insights into documents and allows for collaboration between users and Document AI to iterate and optimize for
    /// quality.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document chunked based on chunking config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkedDocument")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentChunkedDocument ChunkedDocument { get; set; }

        /// <summary>
        /// Optional. Inline document content, represented as a stream of bytes. Note: As with all `bytes` fields,
        /// protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Parsed layout of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLayout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentDocumentLayout DocumentLayout { get; set; }

        /// <summary>
        /// A list of entities detected on Document.text. For document shards, entities in this list may cross shard
        /// boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentEntity> Entities { get; set; }

        /// <summary>Placeholder. Relationship among Document.entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityRelations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentEntityRelation> EntityRelations { get; set; }

        /// <summary>Any error that occurred while processing this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Labels for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentLabel> Labels { get; set; }

        /// <summary>
        /// An IANA published [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Visual page layout for the Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPage> Pages { get; set; }

        /// <summary>Placeholder. Revision history of this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentRevision> Revisions { get; set; }

        /// <summary>
        /// Information about the sharding if this document is sharded part of a larger document. If the document is not
        /// sharded, this message is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardInfo")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentShardInfo ShardInfo { get; set; }

        /// <summary>Optional. UTF-8 encoded text in reading order from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Placeholder. A list of text corrections made to Document.text. This is usually used for annotating
        /// corrections to OCR mistakes. Text changes for a given revision may not overlap with each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textChanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentTextChange> TextChanges { get; set; }

        /// <summary>Styles for the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyles")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentStyle> TextStyles { get; set; }

        /// <summary>
        /// Optional. Currently supports Google Cloud Storage URI of the form `gs://bucket_name/object_name`. Object
        /// versioning is not supported. For more information, refer to [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the chunks that the document is divided into.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentChunkedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of chunks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunk> Chunks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a chunk.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkId")]
        public virtual string ChunkId { get; set; }

        /// <summary>Text content of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Page footers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFooters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageFooter> PageFooters { get; set; }

        /// <summary>Page headers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageHeader> PageHeaders { get; set; }

        /// <summary>Page span of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBlockIds")]
        public virtual System.Collections.Generic.IList<string> SourceBlockIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page footer associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Footer in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page header associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Header in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the chunk starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentChunkedDocumentChunkChunkPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where chunk ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where chunk starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the parsed layout of a document as a collection of blocks that the document is divided into.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a block. A block could be one of the various types (text, table, list) supported.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockId")]
        public virtual string BlockId { get; set; }

        /// <summary>Block consisting of list content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listBlock")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock ListBlock { get; set; }

        /// <summary>Page span of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan PageSpan { get; set; }

        /// <summary>Block consisting of table content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBlock")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock TableBlock { get; set; }

        /// <summary>Block consisting of text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBlock")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock TextBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list type block.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List entries that constitute a list block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry> ListEntries { get; set; }

        /// <summary>Type of the list_entries (if exist). Available options are `ordered` and `unordered`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an entry in the list.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list entry is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the block starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where block ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where block starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a table type block.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows containing main table content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> BodyRows { get; set; }

        /// <summary>Table caption/title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Header rows at the top of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a cell in a table row.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A table cell is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row in a table.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A table row is a list of table cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a text type block.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A text block could further have child blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>Text content stored in the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Type of the text in the block. Available options are: `paragraph`, `subtitle`, `heading-1`, `heading-2`,
        /// `heading-3`, `heading-4`, `heading-5`, `header`, `footer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity that could be a phrase in the text or a property that belongs to the document. It is a known entity
    /// type, such as a person, an organization, or location.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Confidence of detected Schema entity. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Canonical id. This will be a unique value in the entity list for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Deprecated. Use `id` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionId")]
        public virtual string MentionId { get; set; }

        /// <summary>Optional. Text value of the entity e.g. `1600 Amphitheatre Pkwy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionText")]
        public virtual string MentionText { get; set; }

        /// <summary>
        /// Optional. Normalized entity value. Absent if the extracted value could not be converted or the type (e.g.
        /// address) is not supported for certain parsers. This field is also only populated for certain supported
        /// document types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedValue")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentEntityNormalizedValue NormalizedValue { get; set; }

        /// <summary>
        /// Optional. Represents the provenance of this entity wrt. the location on the page where it was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageAnchor")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageAnchor PageAnchor { get; set; }

        /// <summary>
        /// Optional. Entities can be nested to form a hierarchical data structure representing the content in the
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentEntity> Properties { get; set; }

        /// <summary>Optional. The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>Optional. Whether the entity will be redacted for de-identification purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redacted")]
        public virtual System.Nullable<bool> Redacted { get; set; }

        /// <summary>Optional. Provenance of the entity. Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>Required. Entity type from a schema e.g. `Address`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parsed and normalized entity value.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentEntityNormalizedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Postal address. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/postal_address.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressValue")]
        public virtual GoogleTypePostalAddress AddressValue { get; set; }

        /// <summary>Boolean value. Can be used for entities with binary values, or for checkboxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>
        /// Date value. Includes year, month, day. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/date.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual GoogleTypeDate DateValue { get; set; }

        /// <summary>
        /// DateTime value. Includes date, time, and timezone. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/datetime.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>Float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<int> IntegerValue { get; set; }

        /// <summary>
        /// Money value. See also: https://github.com/googleapis/googleapis/blob/master/google/type/money.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual GoogleTypeMoney MoneyValue { get; set; }

        /// <summary>
        /// Optional. An optional field to store a normalized string. For some entity types, one of respective
        /// `structured_value` fields may also be populated. Also not all the types of `structured_value` will be
        /// normalized. For example, some processors may not generate `float` or `integer` normalized text by default.
        /// Below are sample formats mapped to structured values. - Money/Currency type (`money_value`) is in the ISO
        /// 4217 text format. - Date type (`date_value`) is in the ISO 8601 text format. - Datetime type
        /// (`datetime_value`) is in the ISO 8601 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Relationship between Entities.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentEntityRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>Relationship description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>Subject entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectId")]
        public virtual string SubjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Label attaches schema information and/or other metadata to segments within a Document. Multiple Labels on a
    /// single field can denote either different labels, different instances of the same label created at different
    /// times, or some combination of both.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Label is generated AutoML model. This field stores the full resource name of the AutoML model. Format:
        /// `projects/{project-id}/locations/{location-id}/models/{model-id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automlModel")]
        public virtual string AutomlModel { get; set; }

        /// <summary>Confidence score between 0 and 1 for label assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Name of the label. When the label is generated from AutoML Text Classification model, this field represents
        /// the name of the category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page in a Document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of visually detected text blocks on the page. A block has a set of lines (collected into paragraphs)
        /// that have a common line-spacing and orientation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageBlock> Blocks { get; set; }

        /// <summary>A list of detected barcodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBarcodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedBarcode> DetectedBarcodes { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Physical dimension of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageDimension Dimension { get; set; }

        /// <summary>A list of visually detected form fields on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageFormField> FormFields { get; set; }

        /// <summary>
        /// Rendered image for this page. This image is preprocessed to remove any skew, rotation, and distortions such
        /// that the annotation bounding boxes can be upright and axis-aligned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageImage Image { get; set; }

        /// <summary>Image quality scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageQualityScores")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageImageQualityScores ImageQualityScores { get; set; }

        /// <summary>Layout for the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>
        /// A list of visually detected text lines on the page. A collection of tokens that a human would perceive as a
        /// line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lines")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageLine> Lines { get; set; }

        /// <summary>
        /// 1-based index for current Page in a parent Document. Useful when a page is taken out of a Document for
        /// individual processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// A list of visually detected text paragraphs on the page. A collection of lines that a human would perceive
        /// as a paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageParagraph> Paragraphs { get; set; }

        /// <summary>The history of this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>A list of visually detected symbols on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageSymbol> Symbols { get; set; }

        /// <summary>A list of visually detected tables on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageTable> Tables { get; set; }

        /// <summary>A list of visually detected tokens on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageToken> Tokens { get; set; }

        /// <summary>
        /// Transformation matrices that were applied to the original document image to produce Page.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transforms")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageMatrix> Transforms { get; set; }

        /// <summary>A list of detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualElements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageVisualElement> VisualElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Referencing the visual context of the entity in the Document.pages. Page anchors can be cross-page, consist of
    /// multiple bounding polygons and optionally reference specific layout element types.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One or more references to visual page elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageRefs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageAnchorPageRef> PageRefs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weak reference to a page element within a document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageAnchorPageRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifies the bounding polygon of a layout element on the page. If `layout_type` is set, the
        /// bounding polygon must be exactly the same to the layout element it's referring to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta2BoundingPoly BoundingPoly { get; set; }

        /// <summary>Optional. Confidence of detected page element, if applicable. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Deprecated. Use PageRef.bounding_poly instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutId")]
        public virtual string LayoutId { get; set; }

        /// <summary>Optional. The type of the layout element that is being referenced if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutType")]
        public virtual string LayoutType { get; set; }

        /// <summary>
        /// Required. Index into the Document.pages element, for example using `Document.pages` to locate the related
        /// page element. This field is skipped when its value is the default `0`. See
        /// https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("page")]
        public virtual System.Nullable<long> Page { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A block has a set of lines (collected into paragraphs) that have a common line-spacing and orientation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected barcode.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageDetectedBarcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed barcode information of the DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual GoogleCloudDocumentaiV1beta2Barcode Barcode { get; set; }

        /// <summary>Layout for DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The [BCP-47 language code](https://www.unicode.org/reports/tr35/#Unicode_locale_identifier), such as `en-US`
        /// or `sr-Latn`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension for the page.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<float> Height { get; set; }

        /// <summary>Dimension unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Page width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<float> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form field detected on the page.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageFormField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Created for Labeling UI to export key text. If corrections were made to the text identified by the
        /// `field_name.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedKeyText")]
        public virtual string CorrectedKeyText { get; set; }

        /// <summary>
        /// Created for Labeling UI to export value text. If corrections were made to the text identified by the
        /// `field_value.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedValueText")]
        public virtual string CorrectedValueText { get; set; }

        /// <summary>
        /// Layout for the FormField name. e.g. `Address`, `Email`, `Grand total`, `Phone number`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout FieldName { get; set; }

        /// <summary>Layout for the FormField value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldValue")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout FieldValue { get; set; }

        /// <summary>A list of detected languages for name together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> NameDetectedLanguages { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>A list of detected languages for value together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> ValueDetectedLanguages { get; set; }

        /// <summary>
        /// If the value is non-textual, this field represents the type. Current valid values are: - blank (this
        /// indicates the `field_value` is normal text) - `unfilled_checkbox` - `filled_checkbox`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rendered image contents for this page.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Raw byte content of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Height of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>
        /// Encoding [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml) for the
        /// image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Width of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image quality scores for the page image.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageImageQualityScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected defects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDefects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageImageQualityScoresDetectedDefect> DetectedDefects { get; set; }

        /// <summary>The overall quality score. Range `[0, 1]` where `1` is perfect quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityScore")]
        public virtual System.Nullable<float> QualityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image Quality Defects</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageImageQualityScoresDetectedDefect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence of detected defect. Range `[0, 1]` where `1` indicates strong confidence that the defect exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Name of the defect type. Supported values are: - `quality/defect_blurry` - `quality/defect_noisy` -
        /// `quality/defect_dark` - `quality/defect_faint` - `quality/defect_text_too_small` -
        /// `quality/defect_document_cutoff` - `quality/defect_text_cutoff` - `quality/defect_glare`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Visual element describing a layout unit on a page.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1beta2BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// Confidence of the current Layout within context of the object this layout is for. e.g. confidence can be for
        /// a single token, a table, a visual element, etc. depending on context. Range `[0, 1]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Detected orientation for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of tokens that a human would perceive as a line. Does not cross column boundaries, can be
    /// horizontal, vertical, etc.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation for transformation matrix, intended to be compatible and used with OpenCV format for image
    /// manipulation.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cols")]
        public virtual System.Nullable<int> Cols { get; set; }

        /// <summary>The matrix data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Number of rows in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>
        /// This encodes information about what data type the matrix uses. For example, 0 (CV_8U) is an unsigned 8-bit
        /// image. For the full list of OpenCV primitive data types, please refer to
        /// https://docs.opencv.org/4.3.0/d1/d1b/group__core__hal__interface.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Nullable<int> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of lines that a human would perceive as a paragraph.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected symbol.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageSymbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table representation similar to HTML table structure.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageTableTableRow> BodyRows { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Header rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageTableTableRow> HeaderRows { get; set; }

        /// <summary>Layout for Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cell representation inside the table.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageTableTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for TableCell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of table cells.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageTableTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageTableTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected token.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break at the end of a Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageTokenDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentProvenance Provenance { get; set; }

        /// <summary>Text style attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleInfo")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageTokenStyleInfo StyleInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected break at the end of a Token.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageTokenDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font and other text style attributes.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageTokenStyleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color of the background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Whether the text is bold (equivalent to font_weight is at least `700`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>Font size in points (`1` point is `¹⁄₇₂` inches).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual System.Nullable<int> FontSize { get; set; }

        /// <summary>Name or style of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontType")]
        public virtual string FontType { get; set; }

        /// <summary>
        /// TrueType weight on a scale `100` (thin) to `1000` (ultra-heavy). Normal is `400`, bold is `700`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual System.Nullable<int> FontWeight { get; set; }

        /// <summary>Whether the text is handwritten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handwritten")]
        public virtual System.Nullable<bool> Handwritten { get; set; }

        /// <summary>Whether the text is italic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>Letter spacing in points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("letterSpacing")]
        public virtual System.Nullable<double> LetterSpacing { get; set; }

        /// <summary>Font size in pixels, equal to _unrounded font_size_ * _resolution_ ÷ `72.0`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFontSize")]
        public virtual System.Nullable<double> PixelFontSize { get; set; }

        /// <summary>Whether the text is in small caps. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallcaps")]
        public virtual System.Nullable<bool> Smallcaps { get; set; }

        /// <summary>Whether the text is strikethrough. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikeout")]
        public virtual System.Nullable<bool> Strikeout { get; set; }

        /// <summary>Whether the text is a subscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscript")]
        public virtual System.Nullable<bool> Subscript { get; set; }

        /// <summary>Whether the text is a superscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superscript")]
        public virtual System.Nullable<bool> Superscript { get; set; }

        /// <summary>Color of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual GoogleTypeColor TextColor { get; set; }

        /// <summary>Whether the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underlined")]
        public virtual System.Nullable<bool> Underlined { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentPageVisualElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentPageLayout Layout { get; set; }

        /// <summary>Type of the VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structure to identify provenance relationships between annotations in different revisions.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Id of this operation. Needs to be unique within the scope of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>References to the original elements that are replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentProvenanceParent> Parents { get; set; }

        /// <summary>The index of the revision that produced this element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The type of provenance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The parent element the current element is based on. Used for referencing/aligning, removal and replacement
    /// operations.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentProvenanceParent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the parent provenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>
        /// The index of the parent item in the corresponding item list (eg. list of entities, properties within
        /// entities, etc.) in the parent revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The index of the index into current revision's parent_ids list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains past or forward revisions of this document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the change was made by a person specify the name or id of that person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The time that the revision was created, internally generated by doc proto storage at the time of create.
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

        /// <summary>Human Review information of this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReview")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentRevisionHumanReview HumanReview { get; set; }

        /// <summary>
        /// Id of the revision, internally generated by doc proto storage. Unique within the context of the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. This can include one or more parent (when documents are
        /// merged.) This field represents the index into the `revisions` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Parent { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. Must include all the ids that have anything to do with this
        /// revision - eg. there are `provenance.parent.revision` fields that index into this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentIds")]
        public virtual System.Collections.Generic.IList<string> ParentIds { get; set; }

        /// <summary>If the annotation was made by processor identify the processor by its resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processor")]
        public virtual string Processor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Human Review information of the document.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentRevisionHumanReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human review state. e.g. `requested`, `succeeded`, `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the rejection reason
        /// when the state is `rejected`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a large document, sharding may be performed to produce several document shards. Each document shard contains
    /// this field to detail which shard it is.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentShardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>The 0-based index of this shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardIndex")]
        public virtual System.Nullable<long> ShardIndex { get; set; }

        /// <summary>The index of the first character in Document.text in the overall document global text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOffset")]
        public virtual System.Nullable<long> TextOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation for common text style attributes. This adheres to CSS conventions as much as possible.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Text color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Font family such as `Arial`, `Times New Roman`. https://www.w3schools.com/cssref/pr_font_font-family.asp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>Font size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentStyleFontSize FontSize { get; set; }

        /// <summary>
        /// [Font weight](https://www.w3schools.com/cssref/pr_font_weight.asp). Possible values are `normal`, `bold`,
        /// `bolder`, and `lighter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual string FontWeight { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>
        /// [Text decoration](https://www.w3schools.com/cssref/pr_text_text-decoration.asp). Follows CSS standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDecoration")]
        public virtual string TextDecoration { get; set; }

        /// <summary>
        /// [Text style](https://www.w3schools.com/cssref/pr_font_font-style.asp). Possible values are `normal`,
        /// `italic`, and `oblique`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual string TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font size with unit.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentStyleFontSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Font size for the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<float> Size { get; set; }

        /// <summary>Unit for the font size. Follows CSS naming (such as `in`, `px`, and `pt`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Text reference indexing into the Document.text.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentTextAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the content of the text span so that users do not have to look it up in the text_segments. It is
        /// always populated for formFields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The text segments from the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textSegments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentTextAnchorTextSegment> TextSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text segment in the Document.text. The indices may be out of bounds which indicate that the text extends into
    /// another document shard for large sharded documents. See ShardInfo.text_offset
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2DocumentTextAnchorTextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TextSegment half open end UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<long> EndIndex { get; set; }

        /// <summary>TextSegment start UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<long> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message is used for text changes aka. OCR corrections.</summary>
    public class GoogleCloudDocumentaiV1beta2DocumentTextChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that replaces the text identified in the `text_anchor`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedText")]
        public virtual string ChangedText { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2DocumentProvenance> Provenance { get; set; }

        /// <summary>
        /// Provenance of the correction. Text anchor indexing into the Document.text. There can only be a single
        /// `TextAnchor.text_segments` element. If the start and end index of the text segment are the same, the text
        /// change is inserted before that index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1beta2DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to control entity extraction behavior.</summary>
    public class GoogleCloudDocumentaiV1beta2EntityExtractionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to enable entity extraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Model version of the entity extraction. Default is "builtin/stable". Specify "builtin/latest" for the latest
        /// model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to control form extraction behavior.</summary>
    public class GoogleCloudDocumentaiV1beta2FormExtractionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to enable form extraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValuePairHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2KeyValuePairHint> KeyValuePairHints { get; set; }

        /// <summary>
        /// Model version of the form extraction system. Default is "builtin/stable". Specify "builtin/latest" for the
        /// latest model. For custom form models, specify: "custom/{model_name}". Model name format is
        /// "bucket_name/path/to/modeldir" corresponding to "gs://bucket_name/path/to/modeldir" where annotated examples
        /// are stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the output file will be written to.</summary>
    public class GoogleCloudDocumentaiV1beta2GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage location where the input file will be read from.</summary>
    public class GoogleCloudDocumentaiV1beta2GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired input location and metadata.</summary>
    public class GoogleCloudDocumentaiV1beta2InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Content in bytes, represented as a stream of bytes. Note: As with all `bytes` fields, proto buffer messages
        /// use a pure binary representation, whereas JSON representations use base64. This field only works for
        /// synchronous ProcessDocument method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>The Google Cloud Storage location to read the input from. This must be a single file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDocumentaiV1beta2GcsSource GcsSource { get; set; }

        /// <summary>
        /// Required. Mimetype of the input. Current supported mimetypes are application/pdf, image/tiff, and image/gif.
        /// In addition, application/json type is supported for requests with ProcessDocumentRequest.automl_params field
        /// set. The JSON file needs to be in Document format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reserved for future use.</summary>
    public class GoogleCloudDocumentaiV1beta2KeyValuePairHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key text for the hint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Type of the value. This is case-insensitive, and could be one of: ADDRESS, LOCATION, ORGANIZATION, PERSON,
        /// PHONE_NUMBER, ID, NUMBER, EMAIL, PRICE, TERMS, DATE, NAME. Types not in this list will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueTypes")]
        public virtual System.Collections.Generic.IList<string> ValueTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to control Optical Character Recognition (OCR) behavior.</summary>
    public class GoogleCloudDocumentaiV1beta2OcrParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of languages to use for OCR. In most cases, an empty value yields the best results since it enables
        /// automatic language detection. For languages based on the Latin alphabet, setting `language_hints` is not
        /// needed. In rare cases, when the language of the text in the image is known, setting a hint will help get
        /// better results (although it will be a significant hindrance if the hint is wrong). Document processing
        /// returns an error if one or more of the specified languages is not one of the supported languages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageHints")]
        public virtual System.Collections.Generic.IList<string> LanguageHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains metadata for the BatchProcessDocuments operation.</summary>
    public class GoogleCloudDocumentaiV1beta2OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The desired output location and metadata.</summary>
    public class GoogleCloudDocumentaiV1beta2OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Google Cloud Storage location to write the output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudDocumentaiV1beta2GcsDestination GcsDestination { get; set; }

        /// <summary>
        /// The max number of pages to include into each output Document shard JSON on Google Cloud Storage. The valid
        /// range is [1, 100]. If not specified, the default value is 20. For example, for one pdf file with 100 pages,
        /// 100 parsed pages will be produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
        /// containing 20 parsed pages will be written under the prefix OutputConfig.gcs_destination.uri and suffix
        /// pages-x-to-y.json where x and y are 1-indexed page numbers. Example GCS outputs with 157 pages and
        /// pages_per_shard = 50: pages-001-to-050.json pages-051-to-100.json pages-101-to-150.json
        /// pages-151-to-157.json
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagesPerShard")]
        public virtual System.Nullable<int> PagesPerShard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to process one document.</summary>
    public class GoogleCloudDocumentaiV1beta2ProcessDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Controls AutoML model prediction behavior. AutoMlParams cannot be used together with other Params.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automlParams")]
        public virtual GoogleCloudDocumentaiV1beta2AutoMlParams AutomlParams { get; set; }

        /// <summary>
        /// Specifies a known document type for deeper structure detection. Valid values are currently "general" and
        /// "invoice". If not provided, "general"\ is used as default. If any other value is given, the request is
        /// rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentType")]
        public virtual string DocumentType { get; set; }

        /// <summary>
        /// Controls entity extraction behavior. If not specified, the system will decide reasonable defaults.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityExtractionParams")]
        public virtual GoogleCloudDocumentaiV1beta2EntityExtractionParams EntityExtractionParams { get; set; }

        /// <summary>
        /// Controls form extraction behavior. If not specified, the system will decide reasonable defaults.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formExtractionParams")]
        public virtual GoogleCloudDocumentaiV1beta2FormExtractionParams FormExtractionParams { get; set; }

        /// <summary>Required. Information about the input file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudDocumentaiV1beta2InputConfig InputConfig { get; set; }

        /// <summary>Controls OCR behavior. If not specified, the system will decide reasonable defaults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocrParams")]
        public virtual GoogleCloudDocumentaiV1beta2OcrParams OcrParams { get; set; }

        /// <summary>The desired output location. This field is only needed in BatchProcessDocumentsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDocumentaiV1beta2OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Target project and location to make a call. Format: `projects/{project-id}/locations/{location-id}`. If no
        /// location is specified, a region will be chosen automatically. This field is only populated when used in
        /// ProcessDocument method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Controls table extraction behavior. If not specified, the system will decide reasonable defaults.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableExtractionParams")]
        public virtual GoogleCloudDocumentaiV1beta2TableExtractionParams TableExtractionParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a single document processing request.</summary>
    public class GoogleCloudDocumentaiV1beta2ProcessDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the input file. This is the same as the corresponding input config in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudDocumentaiV1beta2InputConfig InputConfig { get; set; }

        /// <summary>
        /// The output location of the parsed responses. The responses are written to this location as JSON-serialized
        /// `Document` objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GoogleCloudDocumentaiV1beta2OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A hint for a table bounding box on the page for table parsing.</summary>
    public class GoogleCloudDocumentaiV1beta2TableBoundHint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Bounding box hint for a table on this page. The coordinates must be normalized to [0,1] and the bounding box
        /// must be an axis-aligned rectangle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual GoogleCloudDocumentaiV1beta2BoundingPoly BoundingBox { get; set; }

        /// <summary>
        /// Optional. Page number for multi-paged inputs this hint applies to. If not provided, this hint will apply to
        /// all pages by default. This value is 1-based.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to control table extraction behavior.</summary>
    public class GoogleCloudDocumentaiV1beta2TableExtractionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to enable table extraction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerHints")]
        public virtual System.Collections.Generic.IList<string> HeaderHints { get; set; }

        /// <summary>
        /// Model version of the table extraction system. Default is "builtin/stable". Specify "builtin/latest" for the
        /// latest model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>
        /// Optional. Table bounding box hints that can be provided to complex cases which our algorithm cannot locate
        /// the table(s) in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBoundHints")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta2TableBoundHint> TableBoundHints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta2Vertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Total number of documents that failed to be deleted in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDocumentCount")]
        public virtual System.Nullable<int> ErrorDocumentCount { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualBatchDeleteStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus> IndividualBatchDeleteStatuses { get; set; }

        /// <summary>Total number of documents deleting from dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the batch delete process.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsMetadataIndividualBatchDeleteStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentId DocumentId { get; set; }

        /// <summary>The status of deleting the document in storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the delete documents operation.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchDeleteDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualProcessStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3BatchProcessMetadataIndividualProcessStatus> IndividualProcessStatuses { get; set; }

        /// <summary>The state of the current batch processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>The status of a each individual document in the batch process.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessMetadataIndividualProcessStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. If the human review process isn't triggered,
        /// this field will be empty. It has the same response type and metadata as the long-running operation returned
        /// by the ReviewDocument method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The status of human review on the processed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewStatus")]
        public virtual GoogleCloudDocumentaiV1beta3HumanReviewStatus HumanReviewStatus { get; set; }

        /// <summary>
        /// The source of the document, same as the input_gcs_source field in the request when the batch process
        /// started.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>
        /// The Cloud Storage output destination (in the request as DocumentOutputConfig.GcsOutputConfig.gcs_uri) of the
        /// processed document if it was successful, otherwise empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsDestination")]
        public virtual string OutputGcsDestination { get; set; }

        /// <summary>The status processing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchProcessDocuments.</summary>
    public class GoogleCloudDocumentaiV1beta3BatchProcessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The common metadata for long running operations.</summary>
    public class GoogleCloudDocumentaiV1beta3CommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>A related resource to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the current state of processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>A singleton resource under a Processor which configures a collection of documents.</summary>
    public class GoogleCloudDocumentaiV1beta3Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deprecated. Warehouse-based dataset configuration is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentWarehouseConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetDocumentWarehouseConfig DocumentWarehouseConfig { get; set; }

        /// <summary>
        /// Optional. User-managed Cloud Storage dataset configuration. Use this configuration if the dataset documents
        /// are stored under a user-managed Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetGCSManagedConfig GcsManagedConfig { get; set; }

        /// <summary>
        /// Dataset resource name. Format: `projects/{project}/locations/{location}/processors/{processor}/dataset`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Optional. A lightweight indexing source with low latency and high reliability, but lacking advanced features
        /// like CMEK and content-based search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spannerIndexingConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetSpannerIndexingConfig SpannerIndexingConfig { get; set; }

        /// <summary>Required. State of the dataset. Ignored when updating dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Unmanaged dataset configuration. Use this configuration if the dataset documents are managed by
        /// the document service internally (not user-managed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDatasetConfig")]
        public virtual GoogleCloudDocumentaiV1beta3DatasetUnmanagedDatasetConfig UnmanagedDatasetConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to the Document AI Warehouse-based implementation.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetDocumentWarehouseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The collection in Document AI Warehouse associated with the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collection")]
        public virtual string Collection { get; set; }

        /// <summary>Output only. The schema in Document AI Warehouse associated with the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to the Cloud Storage-based implementation.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetGCSManagedConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Cloud Storage URI (a directory) where the documents belonging to the dataset must be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual GoogleCloudDocumentaiV1beta3GcsPrefix GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to spanner-based indexing.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetSpannerIndexingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration specific to an unmanaged dataset.</summary>
    public class GoogleCloudDocumentaiV1beta3DatasetUnmanagedDatasetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeleteProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeleteProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeleteProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the DeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3DeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the DisableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3DisableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DisableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DisableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document Identifier.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A document id within user-managed Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsManagedDocId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentIdGCSManagedDocumentId GcsManagedDocId { get; set; }

        /// <summary>Points to a specific revision of the document if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionRef")]
        public virtual GoogleCloudDocumentaiV1beta3RevisionRef RevisionRef { get; set; }

        /// <summary>A document id within unmanaged dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmanagedDocId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentIdUnmanagedDocumentId UnmanagedDocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a document uniquely within the scope of a dataset in the user-managed Cloud Storage option.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3DocumentIdGCSManagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id of the document (indexed) managed by Content Warehouse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwDocId")]
        public virtual string CwDocId { get; set; }

        /// <summary>Required. The Cloud Storage URI where the actual document is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a document uniquely within the scope of a dataset in unmanaged option.</summary>
    public class GoogleCloudDocumentaiV1beta3DocumentIdUnmanagedDocumentId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docId")]
        public virtual string DocId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the EnableProcessor method.</summary>
    public class GoogleCloudDocumentaiV1beta3EnableProcessorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the EnableProcessor method. Intentionally empty proto for adding fields in future.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3EnableProcessorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the EvaluateProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3EvaluateProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the created evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluation")]
        public virtual string Evaluation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies all documents on Cloud Storage with a common prefix.</summary>
    public class GoogleCloudDocumentaiV1beta3GcsPrefix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI prefix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUriPrefix")]
        public virtual string GcsUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of human review on a processed document.</summary>
    public class GoogleCloudDocumentaiV1beta3HumanReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the operation triggered by the processed document. This field is populated only when the state
        /// is `HUMAN_REVIEW_IN_PROGRESS`. It has the same response type and metadata as the long-running operation
        /// returned by ReviewDocument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReviewOperation")]
        public virtual string HumanReviewOperation { get; set; }

        /// <summary>The state of human review on the processing request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A message providing more details about the human review state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the import document operation.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>Validation statuses of the batch documents import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importConfigValidationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataImportConfigValidationResult> ImportConfigValidationResults { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualImportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataIndividualImportStatus> IndividualImportStatuses { get; set; }

        /// <summary>Total number of the documents that are qualified for importing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDocumentCount")]
        public virtual System.Nullable<int> TotalDocumentCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The validation status of each import config. Status is set to an error if there are no documents to import in
    /// the `import_config`, or `OK` if the operation will try to proceed with at least one document.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataImportConfigValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI specified in the import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The validation status of import config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of each individual document in the import process.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsMetadataIndividualImportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source Cloud Storage URI of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGcsSource")]
        public virtual string InputGcsSource { get; set; }

        /// <summary>The document id of imported document if it was successful, otherwise empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDocumentId")]
        public virtual GoogleCloudDocumentaiV1beta3DocumentId OutputDocumentId { get; set; }

        /// <summary>The status of the importing of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the import document operation.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata for the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ImportProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3ImportProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination processor version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ReviewDocumentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the operation.</summary>
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

        /// <summary>The Crowd Compute question ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>Used only when Operation.done is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the error message if
        /// the operation is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last update time of the operation.</summary>
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

    /// <summary>Response message for the ReviewDocument method.</summary>
    public class GoogleCloudDocumentaiV1beta3ReviewDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage uri for the human reviewed document if the review is succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual string GcsDestination { get; set; }

        /// <summary>The reason why the review is rejected by reviewer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectionReason")]
        public virtual string RejectionReason { get; set; }

        /// <summary>The state of the review operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The revision reference specifies which revision on the document to read.</summary>
    public class GoogleCloudDocumentaiV1beta3RevisionRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reads the revision generated by the processor version. The format takes the full resource name of processor
        /// version.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestProcessorVersion")]
        public virtual string LatestProcessorVersion { get; set; }

        /// <summary>Reads the revision by the predefined case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCase")]
        public virtual string RevisionCase { get; set; }

        /// <summary>Reads the revision given by the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the SetDefaultProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3SetDefaultProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata that represents a processor version being created.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The test dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation TestDatasetValidation { get; set; }

        /// <summary>The training dataset validation information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingDatasetValidation")]
        public virtual GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation TrainingDatasetValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The dataset validation information. This includes any and all errors with documents and the dataset.
    /// </summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionMetadataDatasetValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of dataset errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrorCount")]
        public virtual System.Nullable<int> DatasetErrorCount { get; set; }

        /// <summary>
        /// Error information for the dataset as a whole. A maximum of 10 dataset errors will be returned. A single
        /// dataset error is terminal for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DatasetErrors { get; set; }

        /// <summary>The total number of document errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrorCount")]
        public virtual System.Nullable<int> DocumentErrorCount { get; set; }

        /// <summary>
        /// Error information pertaining to specific documents. A maximum of 10 document errors will be returned. Any
        /// document with errors will not be used throughout training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentErrors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> DocumentErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for TrainProcessorVersion.</summary>
    public class GoogleCloudDocumentaiV1beta3TrainProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the processor version produced by training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorVersion")]
        public virtual string ProcessorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The long-running operation metadata for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3UndeployProcessorVersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the UndeployProcessorVersion method.</summary>
    public class GoogleCloudDocumentaiV1beta3UndeployProcessorVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDocumentaiV1beta3UpdateDatasetOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic metadata of the long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonMetadata")]
        public virtual GoogleCloudDocumentaiV1beta3CommonOperationMetadata CommonMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class GoogleTypeColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class GoogleTypeDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GoogleTypeTimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class GoogleTypePostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
