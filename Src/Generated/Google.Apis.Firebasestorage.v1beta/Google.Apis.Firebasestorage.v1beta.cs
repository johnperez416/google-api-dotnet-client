// Copyright 2025 Google LLC
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

namespace Google.Apis.Firebasestorage.v1beta
{
    /// <summary>The Firebasestorage Service.</summary>
    public class FirebasestorageService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebasestorageService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebasestorageService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebasestorage.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebasestorage.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebasestorage";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Storage for Firebase API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Storage for Firebase API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Firebasestorage requests.</summary>
    public abstract class FirebasestorageBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebasestorageBaseServiceRequest instance.</summary>
        protected FirebasestorageBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Firebasestorage parameter list.</summary>
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
            Buckets = new BucketsResource(service);
            DefaultBucket = new DefaultBucketResource(service);
        }

        /// <summary>Gets the Buckets resource.</summary>
        public virtual BucketsResource Buckets { get; }

        /// <summary>The "buckets" collection of methods.</summary>
        public class BucketsResource
        {
            private const string Resource = "buckets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BucketsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Links a Google Cloud Storage bucket to a Firebase project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="bucket">
            /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
            /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
            /// </param>
            public virtual AddFirebaseRequest AddFirebase(Google.Apis.Firebasestorage.v1beta.Data.AddFirebaseRequest body, string bucket)
            {
                return new AddFirebaseRequest(this.service, body, bucket);
            }

            /// <summary>Links a Google Cloud Storage bucket to a Firebase project.</summary>
            public class AddFirebaseRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.Bucket>
            {
                /// <summary>Constructs a new AddFirebase request.</summary>
                public AddFirebaseRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebasestorage.v1beta.Data.AddFirebaseRequest body, string bucket) : base(service)
                {
                    Bucket = bucket;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
                /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Bucket { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebasestorage.v1beta.Data.AddFirebaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addFirebase";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+bucket}:addFirebase";

                /// <summary>Initializes AddFirebase parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bucket",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/buckets/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single linked storage bucket.</summary>
            /// <param name="name">
            /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
            /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single linked storage bucket.</summary>
            public class GetRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.Bucket>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
                /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/buckets/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the linked storage buckets for a project.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent Firebase project, `projects/{project_id_or_number}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the linked storage buckets for a project.</summary>
            public class ListRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.ListBucketsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent Firebase project, `projects/{project_id_or_number}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of buckets to return. If not set, the server will use a reasonable default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListBuckets` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListBuckets` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/buckets";

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

            /// <summary>Unlinks a linked Google Cloud Storage bucket from a Firebase project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="bucket">
            /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
            /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
            /// </param>
            public virtual RemoveFirebaseRequest RemoveFirebase(Google.Apis.Firebasestorage.v1beta.Data.RemoveFirebaseRequest body, string bucket)
            {
                return new RemoveFirebaseRequest(this.service, body, bucket);
            }

            /// <summary>Unlinks a linked Google Cloud Storage bucket from a Firebase project.</summary>
            public class RemoveFirebaseRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.Empty>
            {
                /// <summary>Constructs a new RemoveFirebase request.</summary>
                public RemoveFirebaseRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebasestorage.v1beta.Data.RemoveFirebaseRequest body, string bucket) : base(service)
                {
                    Bucket = bucket;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the bucket, mirrors the ID of the underlying Google Cloud Storage bucket,
                /// `projects/{project_id_or_number}/buckets/{bucket_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Bucket { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebasestorage.v1beta.Data.RemoveFirebaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "removeFirebase";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+bucket}:removeFirebase";

                /// <summary>Initializes RemoveFirebase parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bucket",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/buckets/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the DefaultBucket resource.</summary>
        public virtual DefaultBucketResource DefaultBucket { get; }

        /// <summary>The "defaultBucket" collection of methods.</summary>
        public class DefaultBucketResource
        {
            private const string Resource = "defaultBucket";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DefaultBucketResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a Spark tier-eligible Cloud Storage bucket and links it to your Firebase project. If the default
            /// bucket already exists, this method will re-link it to your Firebase project. See
            /// https://firebase.google.com/pricing for pricing details.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where the default bucket will be created,
            /// `projects/{project_id_or_number}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Firebasestorage.v1beta.Data.DefaultBucket body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a Spark tier-eligible Cloud Storage bucket and links it to your Firebase project. If the default
            /// bucket already exists, this method will re-link it to your Firebase project. See
            /// https://firebase.google.com/pricing for pricing details.
            /// </summary>
            public class CreateRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.DefaultBucket>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebasestorage.v1beta.Data.DefaultBucket body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where the default bucket will be created,
                /// `projects/{project_id_or_number}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebasestorage.v1beta.Data.DefaultBucket Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/defaultBucket";

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
                }
            }
        }

        /// <summary>Unlinks and deletes the default bucket.</summary>
        /// <param name="name">
        /// Required. The name of the default bucket to delete, `projects/{project_id_or_number}/defaultBucket`.
        /// </param>
        public virtual DeleteDefaultBucketRequest DeleteDefaultBucket(string name)
        {
            return new DeleteDefaultBucketRequest(this.service, name);
        }

        /// <summary>Unlinks and deletes the default bucket.</summary>
        public class DeleteDefaultBucketRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.Empty>
        {
            /// <summary>Constructs a new DeleteDefaultBucket request.</summary>
            public DeleteDefaultBucketRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the default bucket to delete, `projects/{project_id_or_number}/defaultBucket`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteDefaultBucket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes DeleteDefaultBucket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/defaultBucket$",
                });
            }
        }

        /// <summary>Gets the default bucket.</summary>
        /// <param name="name">
        /// Required. The name of the default bucket to retrieve, `projects/{project_id_or_number}/defaultBucket`.
        /// </param>
        public virtual GetDefaultBucketRequest GetDefaultBucket(string name)
        {
            return new GetDefaultBucketRequest(this.service, name);
        }

        /// <summary>Gets the default bucket.</summary>
        public class GetDefaultBucketRequest : FirebasestorageBaseServiceRequest<Google.Apis.Firebasestorage.v1beta.Data.DefaultBucket>
        {
            /// <summary>Constructs a new GetDefaultBucket request.</summary>
            public GetDefaultBucketRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the default bucket to retrieve, `projects/{project_id_or_number}/defaultBucket`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDefaultBucket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetDefaultBucket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/defaultBucket$",
                });
            }
        }
    }
}
namespace Google.Apis.Firebasestorage.v1beta.Data
{
    /// <summary>The request used to link a Google Cloud Storage bucket to a Firebase project.</summary>
    public class AddFirebaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A storage bucket and its relation to a parent Firebase project.</summary>
    public class Bucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Spark tier-eligible Cloud Storage bucket. One per project. This resource exists if the underlying Cloud Storage
    /// bucket exists and it is linked to your Firebase project. See https://firebase.google.com/pricing for pricing
    /// details.
    /// </summary>
    public class DefaultBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Underlying bucket resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual Bucket Bucket { get; set; }

        /// <summary>Immutable. Location of the default bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Resource name of the default bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Storage class of the default bucket. Supported values are available at
        /// https://cloud.google.com/storage/docs/storage-classes#classes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

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

    /// <summary>The response returned by `ListBuckets`.</summary>
    public class ListBucketsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of linked buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<Bucket> Buckets { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request used to unlink a Google Cloud Storage bucket from a Firebase project.</summary>
    public class RemoveFirebaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
