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

namespace Google.Apis.Books.v1
{
    /// <summary>The Books Service.</summary>
    public class BooksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BooksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BooksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Bookshelves = new BookshelvesResource(this);
            Cloudloading = new CloudloadingResource(this);
            Dictionary = new DictionaryResource(this);
            Familysharing = new FamilysharingResource(this);
            Layers = new LayersResource(this);
            Myconfig = new MyconfigResource(this);
            Mylibrary = new MylibraryResource(this);
            Notification = new NotificationResource(this);
            Onboarding = new OnboardingResource(this);
            Personalizedstream = new PersonalizedstreamResource(this);
            Promooffer = new PromoofferResource(this);
            Series = new SeriesResource(this);
            Volumes = new VolumesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://books.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://books.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "books";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Books API.</summary>
        public class Scope
        {
            /// <summary>Manage your books</summary>
            public static string Books = "https://www.googleapis.com/auth/books";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Books API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your books</summary>
            public const string Books = "https://www.googleapis.com/auth/books";
        }

        /// <summary>Gets the Bookshelves resource.</summary>
        public virtual BookshelvesResource Bookshelves { get; }

        /// <summary>Gets the Cloudloading resource.</summary>
        public virtual CloudloadingResource Cloudloading { get; }

        /// <summary>Gets the Dictionary resource.</summary>
        public virtual DictionaryResource Dictionary { get; }

        /// <summary>Gets the Familysharing resource.</summary>
        public virtual FamilysharingResource Familysharing { get; }

        /// <summary>Gets the Layers resource.</summary>
        public virtual LayersResource Layers { get; }

        /// <summary>Gets the Myconfig resource.</summary>
        public virtual MyconfigResource Myconfig { get; }

        /// <summary>Gets the Mylibrary resource.</summary>
        public virtual MylibraryResource Mylibrary { get; }

        /// <summary>Gets the Notification resource.</summary>
        public virtual NotificationResource Notification { get; }

        /// <summary>Gets the Onboarding resource.</summary>
        public virtual OnboardingResource Onboarding { get; }

        /// <summary>Gets the Personalizedstream resource.</summary>
        public virtual PersonalizedstreamResource Personalizedstream { get; }

        /// <summary>Gets the Promooffer resource.</summary>
        public virtual PromoofferResource Promooffer { get; }

        /// <summary>Gets the Series resource.</summary>
        public virtual SeriesResource Series { get; }

        /// <summary>Gets the Volumes resource.</summary>
        public virtual VolumesResource Volumes { get; }
    }

    /// <summary>A base abstract class for Books requests.</summary>
    public abstract class BooksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BooksBaseServiceRequest instance.</summary>
        protected BooksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Books parameter list.</summary>
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

    /// <summary>The "bookshelves" collection of methods.</summary>
    public class BookshelvesResource
    {
        private const string Resource = "bookshelves";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BookshelvesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Volumes = new VolumesResource(service);
        }

        /// <summary>Gets the Volumes resource.</summary>
        public virtual VolumesResource Volumes { get; }

        /// <summary>The "volumes" collection of methods.</summary>
        public class VolumesResource
        {
            private const string Resource = "volumes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VolumesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves volumes in a specific bookshelf for the specified user.</summary>
            /// <param name="userId">ID of user for whom to retrieve bookshelf volumes.</param>
            /// <param name="shelf">ID of bookshelf to retrieve volumes.</param>
            public virtual ListRequest List(string userId, string shelf)
            {
                return new ListRequest(this.service, userId, shelf);
            }

            /// <summary>Retrieves volumes in a specific bookshelf for the specified user.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId, string shelf) : base(service)
                {
                    UserId = userId;
                    Shelf = shelf;
                    InitParameters();
                }

                /// <summary>ID of user for whom to retrieve bookshelf volumes.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>ID of bookshelf to retrieve volumes.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>Maximum number of results to return</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Set to true to show pre-ordered books. Defaults to false.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showPreorders", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowPreorders { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Index of the first element to return (starts at 0)</summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/users/{userId}/bookshelves/{shelf}/volumes";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
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
                    RequestParameters.Add("showPreorders", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showPreorders",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
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

        /// <summary>Retrieves metadata for a specific bookshelf for the specified user.</summary>
        /// <param name="userId">ID of user for whom to retrieve bookshelves.</param>
        /// <param name="shelf">ID of bookshelf to retrieve.</param>
        public virtual GetRequest Get(string userId, string shelf)
        {
            return new GetRequest(this.service, userId, shelf);
        }

        /// <summary>Retrieves metadata for a specific bookshelf for the specified user.</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Bookshelf>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId, string shelf) : base(service)
            {
                UserId = userId;
                Shelf = shelf;
                InitParameters();
            }

            /// <summary>ID of user for whom to retrieve bookshelves.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>ID of bookshelf to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Shelf { get; private set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/users/{userId}/bookshelves/{shelf}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                {
                    Name = "shelf",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of public bookshelves for the specified user.</summary>
        /// <param name="userId">ID of user for whom to retrieve bookshelves.</param>
        public virtual ListRequest List(string userId)
        {
            return new ListRequest(this.service, userId);
        }

        /// <summary>Retrieves a list of public bookshelves for the specified user.</summary>
        public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Bookshelves>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            /// <summary>ID of user for whom to retrieve bookshelves.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/users/{userId}/bookshelves";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "cloudloading" collection of methods.</summary>
    public class CloudloadingResource
    {
        private const string Resource = "cloudloading";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CloudloadingResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Add a user-upload volume and triggers processing.</summary>
        public virtual AddBookRequest AddBook()
        {
            return new AddBookRequest(this.service);
        }

        /// <summary>Add a user-upload volume and triggers processing.</summary>
        public class AddBookRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.BooksCloudloadingResource>
        {
            /// <summary>Constructs a new AddBook request.</summary>
            public AddBookRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>A drive document id. The upload_client_token must not be set.</summary>
            [Google.Apis.Util.RequestParameterAttribute("drive_document_id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveDocumentId { get; set; }

            /// <summary>The document MIME type. It can be set only if the drive_document_id is set.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mime_type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string MimeType { get; set; }

            /// <summary>The document name. It can be set only if the drive_document_id is set.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Scotty upload token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_client_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadClientToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addBook";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/cloudloading/addBook";

            /// <summary>Initializes AddBook parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("drive_document_id", new Google.Apis.Discovery.Parameter
                {
                    Name = "drive_document_id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mime_type", new Google.Apis.Discovery.Parameter
                {
                    Name = "mime_type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("upload_client_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_client_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Remove the book and its contents</summary>
        /// <param name="volumeId">The id of the book to be removed.</param>
        public virtual DeleteBookRequest DeleteBook(string volumeId)
        {
            return new DeleteBookRequest(this.service, volumeId);
        }

        /// <summary>Remove the book and its contents</summary>
        public class DeleteBookRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
        {
            /// <summary>Constructs a new DeleteBook request.</summary>
            public DeleteBookRequest(Google.Apis.Services.IClientService service, string volumeId) : base(service)
            {
                VolumeId = volumeId;
                InitParameters();
            }

            /// <summary>The id of the book to be removed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VolumeId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteBook";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/cloudloading/deleteBook";

            /// <summary>Initializes DeleteBook parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a user-upload volume.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateBookRequest UpdateBook(Google.Apis.Books.v1.Data.BooksCloudloadingResource body)
        {
            return new UpdateBookRequest(this.service, body);
        }

        /// <summary>Updates a user-upload volume.</summary>
        public class UpdateBookRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.BooksCloudloadingResource>
        {
            /// <summary>Constructs a new UpdateBook request.</summary>
            public UpdateBookRequest(Google.Apis.Services.IClientService service, Google.Apis.Books.v1.Data.BooksCloudloadingResource body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Books.v1.Data.BooksCloudloadingResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateBook";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/cloudloading/updateBook";

            /// <summary>Initializes UpdateBook parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "dictionary" collection of methods.</summary>
    public class DictionaryResource
    {
        private const string Resource = "dictionary";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DictionaryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns a list of offline dictionary metadata available</summary>
        /// <param name="cpksver">The device/version ID from which to request the data.</param>
        public virtual ListOfflineMetadataRequest ListOfflineMetadata(string cpksver)
        {
            return new ListOfflineMetadataRequest(this.service, cpksver);
        }

        /// <summary>Returns a list of offline dictionary metadata available</summary>
        public class ListOfflineMetadataRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Metadata>
        {
            /// <summary>Constructs a new ListOfflineMetadata request.</summary>
            public ListOfflineMetadataRequest(Google.Apis.Services.IClientService service, string cpksver) : base(service)
            {
                Cpksver = cpksver;
                InitParameters();
            }

            /// <summary>The device/version ID from which to request the data.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cpksver", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cpksver { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listOfflineMetadata";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/dictionary/listOfflineMetadata";

            /// <summary>Initializes ListOfflineMetadata parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("cpksver", new Google.Apis.Discovery.Parameter
                {
                    Name = "cpksver",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "familysharing" collection of methods.</summary>
    public class FamilysharingResource
    {
        private const string Resource = "familysharing";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FamilysharingResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets information regarding the family that the user is part of.</summary>
        public virtual GetFamilyInfoRequest GetFamilyInfo()
        {
            return new GetFamilyInfoRequest(this.service);
        }

        /// <summary>Gets information regarding the family that the user is part of.</summary>
        public class GetFamilyInfoRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.FamilyInfo>
        {
            /// <summary>Constructs a new GetFamilyInfo request.</summary>
            public GetFamilyInfoRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getFamilyInfo";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/familysharing/getFamilyInfo";

            /// <summary>Initializes GetFamilyInfo parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Initiates sharing of the content with the user's family. Empty response indicates success.
        /// </summary>
        public virtual ShareRequest Share()
        {
            return new ShareRequest(this.service);
        }

        /// <summary>
        /// Initiates sharing of the content with the user's family. Empty response indicates success.
        /// </summary>
        public class ShareRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
        {
            /// <summary>Constructs a new Share request.</summary>
            public ShareRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The docid to share.</summary>
            [Google.Apis.Util.RequestParameterAttribute("docId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DocId { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>The volume to share.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VolumeId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "share";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/familysharing/share";

            /// <summary>Initializes Share parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("docId", new Google.Apis.Discovery.Parameter
                {
                    Name = "docId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Initiates revoking content that has already been shared with the user's family. Empty response indicates
        /// success.
        /// </summary>
        public virtual UnshareRequest Unshare()
        {
            return new UnshareRequest(this.service);
        }

        /// <summary>
        /// Initiates revoking content that has already been shared with the user's family. Empty response indicates
        /// success.
        /// </summary>
        public class UnshareRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
        {
            /// <summary>Constructs a new Unshare request.</summary>
            public UnshareRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The docid to unshare.</summary>
            [Google.Apis.Util.RequestParameterAttribute("docId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DocId { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>The volume to unshare.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VolumeId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unshare";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/familysharing/unshare";

            /// <summary>Initializes Unshare parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("docId", new Google.Apis.Discovery.Parameter
                {
                    Name = "docId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "layers" collection of methods.</summary>
    public class LayersResource
    {
        private const string Resource = "layers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LayersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AnnotationData = new AnnotationDataResource(service);
            VolumeAnnotations = new VolumeAnnotationsResource(service);
        }

        /// <summary>Gets the AnnotationData resource.</summary>
        public virtual AnnotationDataResource AnnotationData { get; }

        /// <summary>The "annotationData" collection of methods.</summary>
        public class AnnotationDataResource
        {
            private const string Resource = "annotationData";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnnotationDataResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the annotation data.</summary>
            /// <param name="volumeId">The volume to retrieve annotations for.</param>
            /// <param name="layerId">The ID for the layer to get the annotations.</param>
            /// <param name="annotationDataId">The ID of the annotation data to retrieve.</param>
            /// <param name="contentVersion">The content version for the volume you are trying to retrieve.</param>
            public virtual GetRequest Get(string volumeId, string layerId, string annotationDataId, string contentVersion)
            {
                return new GetRequest(this.service, volumeId, layerId, annotationDataId, contentVersion);
            }

            /// <summary>Gets the annotation data.</summary>
            public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.DictionaryAnnotationdata>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string volumeId, string layerId, string annotationDataId, string contentVersion) : base(service)
                {
                    VolumeId = volumeId;
                    LayerId = layerId;
                    AnnotationDataId = annotationDataId;
                    ContentVersion = contentVersion;
                    InitParameters();
                }

                /// <summary>The volume to retrieve annotations for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The ID for the layer to get the annotations.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LayerId { get; private set; }

                /// <summary>The ID of the annotation data to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationDataId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AnnotationDataId { get; private set; }

                /// <summary>The content version for the volume you are trying to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; private set; }

                /// <summary>For the dictionary layer. Whether or not to allow web definitions.</summary>
                [Google.Apis.Util.RequestParameterAttribute("allowWebDefinitions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AllowWebDefinitions { get; set; }

                /// <summary>
                /// The requested pixel height for any images. If height is provided width must also be provided.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("h", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> H { get; set; }

                /// <summary>
                /// The locale information for the data. ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>The requested scale for the image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Scale { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>
                /// The requested pixel width for any images. If width is provided height must also be provided.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("w", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> W { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/{volumeId}/layers/{layerId}/data/{annotationDataId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("annotationDataId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationDataId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("allowWebDefinitions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "allowWebDefinitions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("h", new Google.Apis.Discovery.Parameter
                    {
                        Name = "h",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("scale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("w", new Google.Apis.Discovery.Parameter
                    {
                        Name = "w",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the annotation data for a volume and layer.</summary>
            /// <param name="volumeId">The volume to retrieve annotation data for.</param>
            /// <param name="layerId">The ID for the layer to get the annotation data.</param>
            /// <param name="contentVersion">The content version for the requested volume.</param>
            public virtual ListRequest List(string volumeId, string layerId, string contentVersion)
            {
                return new ListRequest(this.service, volumeId, layerId, contentVersion);
            }

            /// <summary>Gets the annotation data for a volume and layer.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Annotationsdata>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string volumeId, string layerId, string contentVersion) : base(service)
                {
                    VolumeId = volumeId;
                    LayerId = layerId;
                    ContentVersion = contentVersion;
                    InitParameters();
                }

                /// <summary>The volume to retrieve annotation data for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The ID for the layer to get the annotation data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LayerId { get; private set; }

                /// <summary>The content version for the requested volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; private set; }

                /// <summary>
                /// The list of Annotation Data Ids to retrieve. Pagination is ignored if this is set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationDataId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> AnnotationDataId { get; set; }

                /// <summary>
                /// The requested pixel height for any images. If height is provided width must also be provided.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("h", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> H { get; set; }

                /// <summary>
                /// The locale information for the data. ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>Maximum number of results to return</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>The value of the nextToken from the previous page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The requested scale for the image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Scale { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>
                /// RFC 3339 timestamp to restrict to items updated prior to this timestamp (exclusive).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMax", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMax { get; set; }

                /// <summary>RFC 3339 timestamp to restrict to items updated since this timestamp (inclusive).</summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMin", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMin { get; set; }

                /// <summary>
                /// The requested pixel width for any images. If width is provided height must also be provided.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("w", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> W { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/{volumeId}/layers/{layerId}/data";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("annotationDataId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationDataId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("h", new Google.Apis.Discovery.Parameter
                    {
                        Name = "h",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
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
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("scale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMax", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMax",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMin", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMin",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("w", new Google.Apis.Discovery.Parameter
                    {
                        Name = "w",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the VolumeAnnotations resource.</summary>
        public virtual VolumeAnnotationsResource VolumeAnnotations { get; }

        /// <summary>The "volumeAnnotations" collection of methods.</summary>
        public class VolumeAnnotationsResource
        {
            private const string Resource = "volumeAnnotations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VolumeAnnotationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the volume annotation.</summary>
            /// <param name="volumeId">The volume to retrieve annotations for.</param>
            /// <param name="layerId">The ID for the layer to get the annotations.</param>
            /// <param name="annotationId">The ID of the volume annotation to retrieve.</param>
            public virtual GetRequest Get(string volumeId, string layerId, string annotationId)
            {
                return new GetRequest(this.service, volumeId, layerId, annotationId);
            }

            /// <summary>Gets the volume annotation.</summary>
            public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumeannotation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string volumeId, string layerId, string annotationId) : base(service)
                {
                    VolumeId = volumeId;
                    LayerId = layerId;
                    AnnotationId = annotationId;
                    InitParameters();
                }

                /// <summary>The volume to retrieve annotations for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The ID for the layer to get the annotations.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LayerId { get; private set; }

                /// <summary>The ID of the volume annotation to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AnnotationId { get; private set; }

                /// <summary>
                /// The locale information for the data. ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/{volumeId}/layers/{layerId}/annotations/{annotationId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("annotationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the volume annotations for a volume and layer.</summary>
            /// <param name="volumeId">The volume to retrieve annotations for.</param>
            /// <param name="layerId">The ID for the layer to get the annotations.</param>
            /// <param name="contentVersion">The content version for the requested volume.</param>
            public virtual ListRequest List(string volumeId, string layerId, string contentVersion)
            {
                return new ListRequest(this.service, volumeId, layerId, contentVersion);
            }

            /// <summary>Gets the volume annotations for a volume and layer.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumeannotations>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string volumeId, string layerId, string contentVersion) : base(service)
                {
                    VolumeId = volumeId;
                    LayerId = layerId;
                    ContentVersion = contentVersion;
                    InitParameters();
                }

                /// <summary>The volume to retrieve annotations for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The ID for the layer to get the annotations.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LayerId { get; private set; }

                /// <summary>The content version for the requested volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; private set; }

                /// <summary>The end offset to end retrieving data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endOffset", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndOffset { get; set; }

                /// <summary>The end position to end retrieving data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endPosition", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndPosition { get; set; }

                /// <summary>
                /// The locale information for the data. ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>Maximum number of results to return</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>The value of the nextToken from the previous page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Set to true to return deleted annotations. updatedMin must be in the request to use this. Defaults
                /// to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>The start offset to start retrieving data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startOffset", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartOffset { get; set; }

                /// <summary>The start position to start retrieving data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startPosition", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartPosition { get; set; }

                /// <summary>
                /// RFC 3339 timestamp to restrict to items updated prior to this timestamp (exclusive).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMax", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMax { get; set; }

                /// <summary>RFC 3339 timestamp to restrict to items updated since this timestamp (inclusive).</summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMin", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMin { get; set; }

                /// <summary>The version of the volume annotations that you are requesting.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeAnnotationsVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeAnnotationsVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/{volumeId}/layers/{layerId}";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endOffset", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endOffset",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endPosition", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endPosition",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
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
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startOffset", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startOffset",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startPosition", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startPosition",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMax", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMax",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMin", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMin",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeAnnotationsVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeAnnotationsVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the layer summary for a volume.</summary>
        /// <param name="volumeId">The volume to retrieve layers for.</param>
        /// <param name="summaryId">The ID for the layer to get the summary for.</param>
        public virtual GetRequest Get(string volumeId, string summaryId)
        {
            return new GetRequest(this.service, volumeId, summaryId);
        }

        /// <summary>Gets the layer summary for a volume.</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Layersummary>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string volumeId, string summaryId) : base(service)
            {
                VolumeId = volumeId;
                SummaryId = summaryId;
                InitParameters();
            }

            /// <summary>The volume to retrieve layers for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string VolumeId { get; private set; }

            /// <summary>The ID for the layer to get the summary for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("summaryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SummaryId { get; private set; }

            /// <summary>The content version for the requested volume.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContentVersion { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/volumes/{volumeId}/layersummary/{summaryId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("summaryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "summaryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "contentVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List the layer summaries for a volume.</summary>
        /// <param name="volumeId">The volume to retrieve layers for.</param>
        public virtual ListRequest List(string volumeId)
        {
            return new ListRequest(this.service, volumeId);
        }

        /// <summary>List the layer summaries for a volume.</summary>
        public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Layersummaries>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string volumeId) : base(service)
            {
                VolumeId = volumeId;
                InitParameters();
            }

            /// <summary>The volume to retrieve layers for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string VolumeId { get; private set; }

            /// <summary>The content version for the requested volume.</summary>
            [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContentVersion { get; set; }

            /// <summary>Maximum number of results to return</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The value of the nextToken from the previous page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/volumes/{volumeId}/layersummary";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "contentVersion",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "myconfig" collection of methods.</summary>
    public class MyconfigResource
    {
        private const string Resource = "myconfig";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MyconfigResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the current settings for the user.</summary>
        public virtual GetUserSettingsRequest GetUserSettings()
        {
            return new GetUserSettingsRequest(this.service);
        }

        /// <summary>Gets the current settings for the user.</summary>
        public class GetUserSettingsRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Usersettings>
        {
            /// <summary>Constructs a new GetUserSettings request.</summary>
            public GetUserSettingsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Unused. Added only to workaround TEX mandatory request template requirement</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getUserSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/myconfig/getUserSettings";

            /// <summary>Initializes GetUserSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("country", new Google.Apis.Discovery.Parameter
                {
                    Name = "country",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Release downloaded content access restriction.</summary>
        /// <param name="cpksver">The device/version ID from which to release the restriction.</param>
        /// <param name="volumeIds">The volume(s) to release restrictions for.</param>
        public virtual ReleaseDownloadAccessRequest ReleaseDownloadAccess(string cpksver, Google.Apis.Util.Repeatable<string> volumeIds)
        {
            return new ReleaseDownloadAccessRequest(this.service, cpksver, volumeIds);
        }

        /// <summary>Release downloaded content access restriction.</summary>
        public class ReleaseDownloadAccessRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.DownloadAccesses>
        {
            /// <summary>Constructs a new ReleaseDownloadAccess request.</summary>
            public ReleaseDownloadAccessRequest(Google.Apis.Services.IClientService service, string cpksver, Google.Apis.Util.Repeatable<string> volumeIds) : base(service)
            {
                Cpksver = cpksver;
                VolumeIds = volumeIds;
                InitParameters();
            }

            /// <summary>The device/version ID from which to release the restriction.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cpksver", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cpksver { get; private set; }

            /// <summary>The volume(s) to release restrictions for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeIds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> VolumeIds { get; private set; }

            /// <summary>ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "releaseDownloadAccess";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/myconfig/releaseDownloadAccess";

            /// <summary>Initializes ReleaseDownloadAccess parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("cpksver", new Google.Apis.Discovery.Parameter
                {
                    Name = "cpksver",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeIds", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeIds",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Request concurrent and download access restrictions.</summary>
        /// <param name="cpksver">The device/version ID from which to request the restrictions.</param>
        /// <param name="nonce">The client nonce value.</param>
        /// <param name="source">String to identify the originator of this request.</param>
        /// <param name="volumeId">The volume to request concurrent/download restrictions for.</param>
        public virtual RequestAccessRequest RequestAccess(string cpksver, string nonce, string source, string volumeId)
        {
            return new RequestAccessRequest(this.service, cpksver, nonce, source, volumeId);
        }

        /// <summary>Request concurrent and download access restrictions.</summary>
        public class RequestAccessRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.RequestAccessData>
        {
            /// <summary>Constructs a new RequestAccess request.</summary>
            public RequestAccessRequest(Google.Apis.Services.IClientService service, string cpksver, string nonce, string source, string volumeId) : base(service)
            {
                Cpksver = cpksver;
                Nonce = nonce;
                Source = source;
                VolumeId = volumeId;
                InitParameters();
            }

            /// <summary>The device/version ID from which to request the restrictions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cpksver", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cpksver { get; private set; }

            /// <summary>The client nonce value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("nonce", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Nonce { get; private set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; private set; }

            /// <summary>The volume to request concurrent/download restrictions for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VolumeId { get; private set; }

            /// <summary>The type of access license to request. If not specified, the default is BOTH.</summary>
            [Google.Apis.Util.RequestParameterAttribute("licenseTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<LicenseTypesEnum> LicenseTypes { get; set; }

            /// <summary>The type of access license to request. If not specified, the default is BOTH.</summary>
            public enum LicenseTypesEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LICENSE_TYPES_UNDEFINED")]
                LICENSETYPESUNDEFINED = 0,

                /// <summary>Both concurrent and download licenses.</summary>
                [Google.Apis.Util.StringValueAttribute("BOTH")]
                BOTH = 1,

                /// <summary>Concurrent access license.</summary>
                [Google.Apis.Util.StringValueAttribute("CONCURRENT")]
                CONCURRENT = 2,

                /// <summary>Offline download access license.</summary>
                [Google.Apis.Util.StringValueAttribute("DOWNLOAD")]
                DOWNLOAD = 3,
            }

            /// <summary>ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "requestAccess";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/myconfig/requestAccess";

            /// <summary>Initializes RequestAccess parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("cpksver", new Google.Apis.Discovery.Parameter
                {
                    Name = "cpksver",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("nonce", new Google.Apis.Discovery.Parameter
                {
                    Name = "nonce",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("licenseTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "licenseTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Request downloaded content access for specified volumes on the My eBooks shelf.</summary>
        /// <param name="cpksver">The device/version ID from which to release the restriction.</param>
        /// <param name="nonce">The client nonce value.</param>
        /// <param name="source">String to identify the originator of this request.</param>
        public virtual SyncVolumeLicensesRequest SyncVolumeLicenses(string cpksver, string nonce, string source)
        {
            return new SyncVolumeLicensesRequest(this.service, cpksver, nonce, source);
        }

        /// <summary>Request downloaded content access for specified volumes on the My eBooks shelf.</summary>
        public class SyncVolumeLicensesRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
        {
            /// <summary>Constructs a new SyncVolumeLicenses request.</summary>
            public SyncVolumeLicensesRequest(Google.Apis.Services.IClientService service, string cpksver, string nonce, string source) : base(service)
            {
                Cpksver = cpksver;
                Nonce = nonce;
                Source = source;
                InitParameters();
            }

            /// <summary>The device/version ID from which to release the restriction.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cpksver", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cpksver { get; private set; }

            /// <summary>The client nonce value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("nonce", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Nonce { get; private set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; private set; }

            /// <summary>List of features supported by the client, i.e., 'RENTALS'</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="FeaturesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("features", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<FeaturesEnum> Features { get; set; }

            /// <summary>List of features supported by the client, i.e., 'RENTALS'</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Features"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("features", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<FeaturesEnum> FeaturesList { get; set; }

            /// <summary>List of features supported by the client, i.e., 'RENTALS'</summary>
            public enum FeaturesEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("FEATURES_UNDEFINED")]
                FEATURESUNDEFINED = 0,

                /// <summary>Client supports rentals.</summary>
                [Google.Apis.Util.StringValueAttribute("RENTALS")]
                RENTALS = 1,
            }

            /// <summary>Set to true to include non-comics series. Defaults to false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeNonComicsSeries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeNonComicsSeries { get; set; }

            /// <summary>ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>Set to true to show pre-ordered books. Defaults to false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("showPreorders", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowPreorders { get; set; }

            /// <summary>The volume(s) to request download restrictions for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeIds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> VolumeIds { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "syncVolumeLicenses";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/myconfig/syncVolumeLicenses";

            /// <summary>Initializes SyncVolumeLicenses parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("cpksver", new Google.Apis.Discovery.Parameter
                {
                    Name = "cpksver",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("nonce", new Google.Apis.Discovery.Parameter
                {
                    Name = "nonce",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("features", new Google.Apis.Discovery.Parameter
                {
                    Name = "features",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeNonComicsSeries", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeNonComicsSeries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("showPreorders", new Google.Apis.Discovery.Parameter
                {
                    Name = "showPreorders",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeIds", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeIds",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the settings for the user. If a sub-object is specified, it will overwrite the existing sub-object
        /// stored in the server. Unspecified sub-objects will retain the existing value.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateUserSettingsRequest UpdateUserSettings(Google.Apis.Books.v1.Data.Usersettings body)
        {
            return new UpdateUserSettingsRequest(this.service, body);
        }

        /// <summary>
        /// Sets the settings for the user. If a sub-object is specified, it will overwrite the existing sub-object
        /// stored in the server. Unspecified sub-objects will retain the existing value.
        /// </summary>
        public class UpdateUserSettingsRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Usersettings>
        {
            /// <summary>Constructs a new UpdateUserSettings request.</summary>
            public UpdateUserSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Books.v1.Data.Usersettings body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Books.v1.Data.Usersettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateUserSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/myconfig/updateUserSettings";

            /// <summary>Initializes UpdateUserSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "mylibrary" collection of methods.</summary>
    public class MylibraryResource
    {
        private const string Resource = "mylibrary";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MylibraryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Annotations = new AnnotationsResource(service);
            Bookshelves = new BookshelvesResource(service);
            Readingpositions = new ReadingpositionsResource(service);
        }

        /// <summary>Gets the Annotations resource.</summary>
        public virtual AnnotationsResource Annotations { get; }

        /// <summary>The "annotations" collection of methods.</summary>
        public class AnnotationsResource
        {
            private const string Resource = "annotations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnnotationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes an annotation.</summary>
            /// <param name="annotationId">The ID for the annotation to delete.</param>
            public virtual DeleteRequest Delete(string annotationId)
            {
                return new DeleteRequest(this.service, annotationId);
            }

            /// <summary>Deletes an annotation.</summary>
            public class DeleteRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string annotationId) : base(service)
                {
                    AnnotationId = annotationId;
                    InitParameters();
                }

                /// <summary>The ID for the annotation to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AnnotationId { get; private set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/annotations/{annotationId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("annotationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Inserts a new annotation.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual InsertRequest Insert(Google.Apis.Books.v1.Data.Annotation body)
            {
                return new InsertRequest(this.service, body);
            }

            /// <summary>Inserts a new annotation.</summary>
            public class InsertRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Annotation>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Books.v1.Data.Annotation body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID for the annotation to insert.</summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AnnotationId { get; set; }

                /// <summary>ISO-3166-1 code to override the IP-based location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Country { get; set; }

                /// <summary>
                /// Requests that only the summary of the specified layer be provided in the response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showOnlySummaryInResponse", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowOnlySummaryInResponse { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Books.v1.Data.Annotation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/annotations";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("annotationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showOnlySummaryInResponse", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showOnlySummaryInResponse",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of annotations, possibly filtered.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Retrieves a list of annotations, possibly filtered.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Annotations>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>The content version for the requested volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; set; }

                /// <summary>The layer ID to limit annotation by.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LayerId { get; set; }

                /// <summary>The layer ID(s) to limit annotation by.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> LayerIds { get; set; }

                /// <summary>Maximum number of results to return</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>The value of the nextToken from the previous page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Set to true to return deleted annotations. updatedMin must be in the request to use this. Defaults
                /// to false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>
                /// RFC 3339 timestamp to restrict to items updated prior to this timestamp (exclusive).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMax", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMax { get; set; }

                /// <summary>RFC 3339 timestamp to restrict to items updated since this timestamp (inclusive).</summary>
                [Google.Apis.Util.RequestParameterAttribute("updatedMin", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UpdatedMin { get; set; }

                /// <summary>The volume to restrict annotations to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/annotations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("layerIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerIds",
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
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMax", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMax",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updatedMin", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updatedMin",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the summary of specified layers.</summary>
            /// <param name="layerIds">Array of layer IDs to get the summary for.</param>
            /// <param name="volumeId">Volume id to get the summary for.</param>
            public virtual SummaryRequest Summary(Google.Apis.Util.Repeatable<string> layerIds, string volumeId)
            {
                return new SummaryRequest(this.service, layerIds, volumeId);
            }

            /// <summary>Gets the summary of specified layers.</summary>
            public class SummaryRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.AnnotationsSummary>
            {
                /// <summary>Constructs a new Summary request.</summary>
                public SummaryRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> layerIds, string volumeId) : base(service)
                {
                    LayerIds = layerIds;
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>Array of layer IDs to get the summary for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("layerIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> LayerIds { get; private set; }

                /// <summary>Volume id to get the summary for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; private set; }

                /// <summary>Optional. String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "summary";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/annotations/summary";

                /// <summary>Initializes Summary parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("layerIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "layerIds",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing annotation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="annotationId">The ID for the annotation to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Books.v1.Data.Annotation body, string annotationId)
            {
                return new UpdateRequest(this.service, body, annotationId);
            }

            /// <summary>Updates an existing annotation.</summary>
            public class UpdateRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Annotation>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Books.v1.Data.Annotation body, string annotationId) : base(service)
                {
                    AnnotationId = annotationId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID for the annotation to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("annotationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AnnotationId { get; private set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Books.v1.Data.Annotation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/annotations/{annotationId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("annotationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "annotationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Bookshelves resource.</summary>
        public virtual BookshelvesResource Bookshelves { get; }

        /// <summary>The "bookshelves" collection of methods.</summary>
        public class BookshelvesResource
        {
            private const string Resource = "bookshelves";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BookshelvesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Volumes = new VolumesResource(service);
            }

            /// <summary>Gets the Volumes resource.</summary>
            public virtual VolumesResource Volumes { get; }

            /// <summary>The "volumes" collection of methods.</summary>
            public class VolumesResource
            {
                private const string Resource = "volumes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VolumesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets volume information for volumes on a bookshelf.</summary>
                /// <param name="shelf">The bookshelf ID or name retrieve volumes for.</param>
                public virtual ListRequest List(string shelf)
                {
                    return new ListRequest(this.service, shelf);
                }

                /// <summary>Gets volume information for volumes on a bookshelf.</summary>
                public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string shelf) : base(service)
                    {
                        Shelf = shelf;
                        InitParameters();
                    }

                    /// <summary>The bookshelf ID or name retrieve volumes for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Shelf { get; private set; }

                    /// <summary>ISO-3166-1 code to override the IP-based location.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Country { get; set; }

                    /// <summary>Maximum number of results to return</summary>
                    [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> MaxResults { get; set; }

                    /// <summary>Restrict information returned to a set of selected fields.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

                    /// <summary>Restrict information returned to a set of selected fields.</summary>
                    public enum ProjectionEnum
                    {
                        /// <summary></summary>
                        [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                        PROJECTIONUNDEFINED = 0,

                        /// <summary>Includes all volume data.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 1,

                        /// <summary>Includes a subset of fields in volumeInfo and accessInfo.</summary>
                        [Google.Apis.Util.StringValueAttribute("LITE")]
                        LITE = 2,
                    }

                    /// <summary>Full-text search query string in this bookshelf.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Q { get; set; }

                    /// <summary>Set to true to show pre-ordered books. Defaults to false.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showPreorders", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowPreorders { get; set; }

                    /// <summary>String to identify the originator of this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Source { get; set; }

                    /// <summary>Index of the first element to return (starts at 0)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> StartIndex { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}/volumes";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                        {
                            Name = "shelf",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("country", new Google.Apis.Discovery.Parameter
                        {
                            Name = "country",
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
                        RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projection",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                        {
                            Name = "q",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("showPreorders", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showPreorders",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                        {
                            Name = "source",
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

            /// <summary>Adds a volume to a bookshelf.</summary>
            /// <param name="shelf">ID of bookshelf to which to add a volume.</param>
            /// <param name="volumeId">ID of volume to add.</param>
            public virtual AddVolumeRequest AddVolume(string shelf, string volumeId)
            {
                return new AddVolumeRequest(this.service, shelf, volumeId);
            }

            /// <summary>Adds a volume to a bookshelf.</summary>
            public class AddVolumeRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new AddVolume request.</summary>
                public AddVolumeRequest(Google.Apis.Services.IClientService service, string shelf, string volumeId) : base(service)
                {
                    Shelf = shelf;
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>ID of bookshelf to which to add a volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>ID of volume to add.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The reason for which the book is added to the library.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reason", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ReasonEnum> Reason { get; set; }

                /// <summary>The reason for which the book is added to the library.</summary>
                public enum ReasonEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("REASON_UNDEFINED")]
                    REASONUNDEFINED = 0,

                    /// <summary>Volumes added from the PREX flow on iOS.</summary>
                    [Google.Apis.Util.StringValueAttribute("IOS_PREX")]
                    IOSPREX = 1,

                    /// <summary>Volumes added from the Search flow on iOS.</summary>
                    [Google.Apis.Util.StringValueAttribute("IOS_SEARCH")]
                    IOSSEARCH = 2,

                    /// <summary>Volumes added from the Onboarding flow.</summary>
                    [Google.Apis.Util.StringValueAttribute("ONBOARDING")]
                    ONBOARDING = 3,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addVolume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}/addVolume";

                /// <summary>Initializes AddVolume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reason", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reason",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Clears all volumes from a bookshelf.</summary>
            /// <param name="shelf">ID of bookshelf from which to remove a volume.</param>
            public virtual ClearVolumesRequest ClearVolumes(string shelf)
            {
                return new ClearVolumesRequest(this.service, shelf);
            }

            /// <summary>Clears all volumes from a bookshelf.</summary>
            public class ClearVolumesRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new ClearVolumes request.</summary>
                public ClearVolumesRequest(Google.Apis.Services.IClientService service, string shelf) : base(service)
                {
                    Shelf = shelf;
                    InitParameters();
                }

                /// <summary>ID of bookshelf from which to remove a volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "clearVolumes";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}/clearVolumes";

                /// <summary>Initializes ClearVolumes parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves metadata for a specific bookshelf belonging to the authenticated user.</summary>
            /// <param name="shelf">ID of bookshelf to retrieve.</param>
            public virtual GetRequest Get(string shelf)
            {
                return new GetRequest(this.service, shelf);
            }

            /// <summary>Retrieves metadata for a specific bookshelf belonging to the authenticated user.</summary>
            public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Bookshelf>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string shelf) : base(service)
                {
                    Shelf = shelf;
                    InitParameters();
                }

                /// <summary>ID of bookshelf to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of bookshelves belonging to the authenticated user.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Retrieves a list of bookshelves belonging to the authenticated user.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Bookshelves>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Moves a volume within a bookshelf.</summary>
            /// <param name="shelf">ID of bookshelf with the volume.</param>
            /// <param name="volumeId">ID of volume to move.</param>
            /// <param name="volumePosition">
            /// Position on shelf to move the item (0 puts the item before the current first item, 1 puts it between the
            /// first and the second and so on.)
            /// </param>
            public virtual MoveVolumeRequest MoveVolume(string shelf, string volumeId, int volumePosition)
            {
                return new MoveVolumeRequest(this.service, shelf, volumeId, volumePosition);
            }

            /// <summary>Moves a volume within a bookshelf.</summary>
            public class MoveVolumeRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new MoveVolume request.</summary>
                public MoveVolumeRequest(Google.Apis.Services.IClientService service, string shelf, string volumeId, int volumePosition) : base(service)
                {
                    Shelf = shelf;
                    VolumeId = volumeId;
                    VolumePosition = volumePosition;
                    InitParameters();
                }

                /// <summary>ID of bookshelf with the volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>ID of volume to move.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; private set; }

                /// <summary>
                /// Position on shelf to move the item (0 puts the item before the current first item, 1 puts it between
                /// the first and the second and so on.)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("volumePosition", Google.Apis.Util.RequestParameterType.Query)]
                public virtual int VolumePosition { get; private set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "moveVolume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}/moveVolume";

                /// <summary>Initializes MoveVolume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumePosition", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumePosition",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Removes a volume from a bookshelf.</summary>
            /// <param name="shelf">ID of bookshelf from which to remove a volume.</param>
            /// <param name="volumeId">ID of volume to remove.</param>
            public virtual RemoveVolumeRequest RemoveVolume(string shelf, string volumeId)
            {
                return new RemoveVolumeRequest(this.service, shelf, volumeId);
            }

            /// <summary>Removes a volume from a bookshelf.</summary>
            public class RemoveVolumeRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new RemoveVolume request.</summary>
                public RemoveVolumeRequest(Google.Apis.Services.IClientService service, string shelf, string volumeId) : base(service)
                {
                    Shelf = shelf;
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>ID of bookshelf from which to remove a volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("shelf", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Shelf { get; private set; }

                /// <summary>ID of volume to remove.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; private set; }

                /// <summary>The reason for which the book is removed from the library.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reason", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ReasonEnum> Reason { get; set; }

                /// <summary>The reason for which the book is removed from the library.</summary>
                public enum ReasonEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("REASON_UNDEFINED")]
                    REASONUNDEFINED = 0,

                    /// <summary>Samples removed from the Onboarding flow.</summary>
                    [Google.Apis.Util.StringValueAttribute("ONBOARDING")]
                    ONBOARDING = 1,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "removeVolume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/bookshelves/{shelf}/removeVolume";

                /// <summary>Initializes RemoveVolume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("shelf", new Google.Apis.Discovery.Parameter
                    {
                        Name = "shelf",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reason", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reason",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Readingpositions resource.</summary>
        public virtual ReadingpositionsResource Readingpositions { get; }

        /// <summary>The "readingpositions" collection of methods.</summary>
        public class ReadingpositionsResource
        {
            private const string Resource = "readingpositions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReadingpositionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves my reading position information for a volume.</summary>
            /// <param name="volumeId">ID of volume for which to retrieve a reading position.</param>
            public virtual GetRequest Get(string volumeId)
            {
                return new GetRequest(this.service, volumeId);
            }

            /// <summary>Retrieves my reading position information for a volume.</summary>
            public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.ReadingPosition>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string volumeId) : base(service)
                {
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>ID of volume for which to retrieve a reading position.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>Volume content version for which this reading position is requested.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/readingpositions/{volumeId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Sets my reading position information for a volume.</summary>
            /// <param name="volumeId">ID of volume for which to update the reading position.</param>
            /// <param name="position">Position string for the new volume reading position.</param>
            /// <param name="timestamp">RFC 3339 UTC format timestamp associated with this reading position.</param>
            public virtual SetPositionRequest SetPosition(string volumeId, string position, string timestamp)
            {
                return new SetPositionRequest(this.service, volumeId, position, timestamp);
            }

            /// <summary>Sets my reading position information for a volume.</summary>
            public class SetPositionRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
            {
                /// <summary>Constructs a new SetPosition request.</summary>
                public SetPositionRequest(Google.Apis.Services.IClientService service, string volumeId, string position, string timestamp) : base(service)
                {
                    VolumeId = volumeId;
                    Position = position;
                    Timestamp = timestamp;
                    InitParameters();
                }

                /// <summary>ID of volume for which to update the reading position.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>Position string for the new volume reading position.</summary>
                [Google.Apis.Util.RequestParameterAttribute("position", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Position { get; private set; }

                /// <summary>RFC 3339 UTC format timestamp associated with this reading position.</summary>
                [Google.Apis.Util.RequestParameterAttribute("timestamp", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Timestamp { get; private set; }

                /// <summary>Action that caused this reading position to be set.</summary>
                [Google.Apis.Util.RequestParameterAttribute("action", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ActionEnum> Action { get; set; }

                /// <summary>Action that caused this reading position to be set.</summary>
                public enum ActionEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("ACTION_UNDEFINED")]
                    ACTIONUNDEFINED = 0,

                    /// <summary>User chose bookmark within volume.</summary>
                    [Google.Apis.Util.StringValueAttribute("bookmark")]
                    Bookmark = 1,

                    /// <summary>User selected chapter from list.</summary>
                    [Google.Apis.Util.StringValueAttribute("chapter")]
                    Chapter = 2,

                    /// <summary>Next page event.</summary>
                    [Google.Apis.Util.StringValueAttribute("next-page")]
                    NextPage = 3,

                    /// <summary>Previous page event.</summary>
                    [Google.Apis.Util.StringValueAttribute("prev-page")]
                    PrevPage = 4,

                    /// <summary>User navigated to page.</summary>
                    [Google.Apis.Util.StringValueAttribute("scroll")]
                    Scroll = 5,

                    /// <summary>User chose search results within volume.</summary>
                    [Google.Apis.Util.StringValueAttribute("search")]
                    Search = 6,
                }

                /// <summary>Volume content version for which this reading position applies.</summary>
                [Google.Apis.Util.RequestParameterAttribute("contentVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ContentVersion { get; set; }

                /// <summary>Random persistent device cookie optional on set position.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deviceCookie", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DeviceCookie { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setPosition";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/mylibrary/readingpositions/{volumeId}/setPosition";

                /// <summary>Initializes SetPosition parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("position", new Google.Apis.Discovery.Parameter
                    {
                        Name = "position",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("timestamp", new Google.Apis.Discovery.Parameter
                    {
                        Name = "timestamp",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("action", new Google.Apis.Discovery.Parameter
                    {
                        Name = "action",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("contentVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "contentVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deviceCookie", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceCookie",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "notification" collection of methods.</summary>
    public class NotificationResource
    {
        private const string Resource = "notification";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NotificationResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns notification details for a given notification id.</summary>
        /// <param name="notificationId">String to identify the notification.</param>
        public virtual GetRequest Get(string notificationId)
        {
            return new GetRequest(this.service, notificationId);
        }

        /// <summary>Returns notification details for a given notification id.</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Notification>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string notificationId) : base(service)
            {
                NotificationId = notificationId;
                InitParameters();
            }

            /// <summary>String to identify the notification.</summary>
            [Google.Apis.Util.RequestParameterAttribute("notification_id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string NotificationId { get; private set; }

            /// <summary>
            /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating notification title and
            /// body.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/notification/get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("notification_id", new Google.Apis.Discovery.Parameter
                {
                    Name = "notification_id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "onboarding" collection of methods.</summary>
    public class OnboardingResource
    {
        private const string Resource = "onboarding";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OnboardingResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>List categories for onboarding experience.</summary>
        public virtual ListCategoriesRequest ListCategories()
        {
            return new ListCategoriesRequest(this.service);
        }

        /// <summary>List categories for onboarding experience.</summary>
        public class ListCategoriesRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Category>
        {
            /// <summary>Constructs a new ListCategories request.</summary>
            public ListCategoriesRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>ISO-639-1 language and ISO-3166-1 country code. Default is en-US if unset.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listCategories";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/onboarding/listCategories";

            /// <summary>Initializes ListCategories parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List available volumes under categories for onboarding experience.</summary>
        public virtual ListCategoryVolumesRequest ListCategoryVolumes()
        {
            return new ListCategoryVolumesRequest(this.service);
        }

        /// <summary>List available volumes under categories for onboarding experience.</summary>
        public class ListCategoryVolumesRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volume2>
        {
            /// <summary>Constructs a new ListCategoryVolumes request.</summary>
            public ListCategoryVolumesRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>List of category ids requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("categoryId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> CategoryId { get; set; }

            /// <summary>ISO-639-1 language and ISO-3166-1 country code. Default is en-US if unset.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>
            /// The maximum allowed maturity rating of returned volumes. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxAllowedMaturityRating", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MaxAllowedMaturityRatingEnum> MaxAllowedMaturityRating { get; set; }

            /// <summary>
            /// The maximum allowed maturity rating of returned volumes. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            public enum MaxAllowedMaturityRatingEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("MAX_ALLOWED_MATURITY_RATING_UNDEFINED")]
                MAXALLOWEDMATURITYRATINGUNDEFINED = 0,

                /// <summary>Show books which are rated mature or lower.</summary>
                [Google.Apis.Util.StringValueAttribute("MATURE")]
                MATURE = 1,

                /// <summary>Show books which are rated not mature.</summary>
                [Google.Apis.Util.StringValueAttribute("not-mature")]
                NotMature = 2,
            }

            /// <summary>Number of maximum results per page to be included in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> PageSize { get; set; }

            /// <summary>The value of the nextToken from the previous page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listCategoryVolumes";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/onboarding/listCategoryVolumes";

            /// <summary>Initializes ListCategoryVolumes parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("categoryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "categoryId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxAllowedMaturityRating", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxAllowedMaturityRating",
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

    /// <summary>The "personalizedstream" collection of methods.</summary>
    public class PersonalizedstreamResource
    {
        private const string Resource = "personalizedstream";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PersonalizedstreamResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns a stream of personalized book clusters</summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(this.service);
        }

        /// <summary>Returns a stream of personalized book clusters</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Discoveryclusters>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating recommendations.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>
            /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxAllowedMaturityRating", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MaxAllowedMaturityRatingEnum> MaxAllowedMaturityRating { get; set; }

            /// <summary>
            /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            public enum MaxAllowedMaturityRatingEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("MAX_ALLOWED_MATURITY_RATING_UNDEFINED")]
                MAXALLOWEDMATURITYRATINGUNDEFINED = 0,

                /// <summary>Show books which are rated mature or lower.</summary>
                [Google.Apis.Util.StringValueAttribute("MATURE")]
                MATURE = 1,

                /// <summary>Show books which are rated not mature.</summary>
                [Google.Apis.Util.StringValueAttribute("not-mature")]
                NotMature = 2,
            }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/personalizedstream/get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxAllowedMaturityRating", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxAllowedMaturityRating",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "promooffer" collection of methods.</summary>
    public class PromoofferResource
    {
        private const string Resource = "promooffer";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PromoofferResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Accepts the promo offer.</summary>
        public virtual AcceptRequest Accept()
        {
            return new AcceptRequest(this.service);
        }

        /// <summary>Accepts the promo offer.</summary>
        public class AcceptRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
        {
            /// <summary>Constructs a new Accept request.</summary>
            public AcceptRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>device android_id</summary>
            [Google.Apis.Util.RequestParameterAttribute("androidId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AndroidId { get; set; }

            /// <summary>device device</summary>
            [Google.Apis.Util.RequestParameterAttribute("device", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Device { get; set; }

            /// <summary>device manufacturer</summary>
            [Google.Apis.Util.RequestParameterAttribute("manufacturer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Manufacturer { get; set; }

            /// <summary>device model</summary>
            [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Model { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OfferId { get; set; }

            /// <summary>device product</summary>
            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Product { get; set; }

            /// <summary>device serial</summary>
            [Google.Apis.Util.RequestParameterAttribute("serial", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Serial { get; set; }

            /// <summary>Volume id to exercise the offer</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VolumeId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "accept";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/promooffer/accept";

            /// <summary>Initializes Accept parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("androidId", new Google.Apis.Discovery.Parameter
                {
                    Name = "androidId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("device", new Google.Apis.Discovery.Parameter
                {
                    Name = "device",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("manufacturer", new Google.Apis.Discovery.Parameter
                {
                    Name = "manufacturer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                {
                    Name = "model",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "offerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                {
                    Name = "product",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("serial", new Google.Apis.Discovery.Parameter
                {
                    Name = "serial",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Marks the promo offer as dismissed.</summary>
        public virtual DismissRequest Dismiss()
        {
            return new DismissRequest(this.service);
        }

        /// <summary>Marks the promo offer as dismissed.</summary>
        public class DismissRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Empty>
        {
            /// <summary>Constructs a new Dismiss request.</summary>
            public DismissRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>device android_id</summary>
            [Google.Apis.Util.RequestParameterAttribute("androidId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AndroidId { get; set; }

            /// <summary>device device</summary>
            [Google.Apis.Util.RequestParameterAttribute("device", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Device { get; set; }

            /// <summary>device manufacturer</summary>
            [Google.Apis.Util.RequestParameterAttribute("manufacturer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Manufacturer { get; set; }

            /// <summary>device model</summary>
            [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Model { get; set; }

            /// <summary>Offer to dimiss</summary>
            [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OfferId { get; set; }

            /// <summary>device product</summary>
            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Product { get; set; }

            /// <summary>device serial</summary>
            [Google.Apis.Util.RequestParameterAttribute("serial", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Serial { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "dismiss";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/promooffer/dismiss";

            /// <summary>Initializes Dismiss parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("androidId", new Google.Apis.Discovery.Parameter
                {
                    Name = "androidId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("device", new Google.Apis.Discovery.Parameter
                {
                    Name = "device",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("manufacturer", new Google.Apis.Discovery.Parameter
                {
                    Name = "manufacturer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                {
                    Name = "model",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "offerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                {
                    Name = "product",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("serial", new Google.Apis.Discovery.Parameter
                {
                    Name = "serial",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns a list of promo offers available to the user</summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(this.service);
        }

        /// <summary>Returns a list of promo offers available to the user</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Offers>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>device android_id</summary>
            [Google.Apis.Util.RequestParameterAttribute("androidId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AndroidId { get; set; }

            /// <summary>device device</summary>
            [Google.Apis.Util.RequestParameterAttribute("device", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Device { get; set; }

            /// <summary>device manufacturer</summary>
            [Google.Apis.Util.RequestParameterAttribute("manufacturer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Manufacturer { get; set; }

            /// <summary>device model</summary>
            [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Model { get; set; }

            /// <summary>device product</summary>
            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Product { get; set; }

            /// <summary>device serial</summary>
            [Google.Apis.Util.RequestParameterAttribute("serial", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Serial { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/promooffer/get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("androidId", new Google.Apis.Discovery.Parameter
                {
                    Name = "androidId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("device", new Google.Apis.Discovery.Parameter
                {
                    Name = "device",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("manufacturer", new Google.Apis.Discovery.Parameter
                {
                    Name = "manufacturer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                {
                    Name = "model",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                {
                    Name = "product",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("serial", new Google.Apis.Discovery.Parameter
                {
                    Name = "serial",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "series" collection of methods.</summary>
    public class SeriesResource
    {
        private const string Resource = "series";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SeriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Membership = new MembershipResource(service);
        }

        /// <summary>Gets the Membership resource.</summary>
        public virtual MembershipResource Membership { get; }

        /// <summary>The "membership" collection of methods.</summary>
        public class MembershipResource
        {
            private const string Resource = "membership";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembershipResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns Series membership data given the series id.</summary>
            /// <param name="seriesId">String that identifies the series</param>
            public virtual GetRequest Get(string seriesId)
            {
                return new GetRequest(this.service, seriesId);
            }

            /// <summary>Returns Series membership data given the series id.</summary>
            public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Seriesmembership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string seriesId) : base(service)
                {
                    SeriesId = seriesId;
                    InitParameters();
                }

                /// <summary>String that identifies the series</summary>
                [Google.Apis.Util.RequestParameterAttribute("series_id", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SeriesId { get; private set; }

                /// <summary>Number of maximum results per page to be included in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("page_size", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PageSize { get; set; }

                /// <summary>The value of the nextToken from the previous page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("page_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/series/membership/get";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("series_id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "series_id",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("page_size", new Google.Apis.Discovery.Parameter
                    {
                        Name = "page_size",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("page_token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "page_token",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Returns Series metadata for the given series ids.</summary>
        /// <param name="seriesId">String that identifies the series</param>
        public virtual GetRequest Get(Google.Apis.Util.Repeatable<string> seriesId)
        {
            return new GetRequest(this.service, seriesId);
        }

        /// <summary>Returns Series metadata for the given series ids.</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Series>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> seriesId) : base(service)
            {
                SeriesId = seriesId;
                InitParameters();
            }

            /// <summary>String that identifies the series</summary>
            [Google.Apis.Util.RequestParameterAttribute("series_id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> SeriesId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/series/get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("series_id", new Google.Apis.Discovery.Parameter
                {
                    Name = "series_id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "volumes" collection of methods.</summary>
    public class VolumesResource
    {
        private const string Resource = "volumes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VolumesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Associated = new AssociatedResource(service);
            Mybooks = new MybooksResource(service);
            Recommended = new RecommendedResource(service);
            Useruploaded = new UseruploadedResource(service);
        }

        /// <summary>Gets the Associated resource.</summary>
        public virtual AssociatedResource Associated { get; }

        /// <summary>The "associated" collection of methods.</summary>
        public class AssociatedResource
        {
            private const string Resource = "associated";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssociatedResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Return a list of associated books.</summary>
            /// <param name="volumeId">ID of the source volume.</param>
            public virtual ListRequest List(string volumeId)
            {
                return new ListRequest(this.service, volumeId);
            }

            /// <summary>Return a list of associated books.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string volumeId) : base(service)
                {
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>ID of the source volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string VolumeId { get; private set; }

                /// <summary>Association type.</summary>
                [Google.Apis.Util.RequestParameterAttribute("association", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AssociationEnum> Association { get; set; }

                /// <summary>Association type.</summary>
                public enum AssociationEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("ASSOCIATION_UNDEFINED")]
                    ASSOCIATIONUNDEFINED = 0,

                    /// <summary>Recommendations for display end-of-sample.</summary>
                    [Google.Apis.Util.StringValueAttribute("end-of-sample")]
                    EndOfSample = 1,

                    /// <summary>Recommendations for display end-of-volume.</summary>
                    [Google.Apis.Util.StringValueAttribute("end-of-volume")]
                    EndOfVolume = 2,

                    /// <summary>Related volumes for Play Store.</summary>
                    [Google.Apis.Util.StringValueAttribute("related-for-play")]
                    RelatedForPlay = 3,
                }

                /// <summary>
                /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating recommendations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>
                /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating
                /// are filtered out.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxAllowedMaturityRating", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MaxAllowedMaturityRatingEnum> MaxAllowedMaturityRating { get; set; }

                /// <summary>
                /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating
                /// are filtered out.
                /// </summary>
                public enum MaxAllowedMaturityRatingEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("MAX_ALLOWED_MATURITY_RATING_UNDEFINED")]
                    MAXALLOWEDMATURITYRATINGUNDEFINED = 0,

                    /// <summary>Show books which are rated mature or lower.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATURE")]
                    MATURE = 1,

                    /// <summary>Show books which are rated not mature.</summary>
                    [Google.Apis.Util.StringValueAttribute("not-mature")]
                    NotMature = 2,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/{volumeId}/associated";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("association", new Google.Apis.Discovery.Parameter
                    {
                        Name = "association",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxAllowedMaturityRating", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxAllowedMaturityRating",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Mybooks resource.</summary>
        public virtual MybooksResource Mybooks { get; }

        /// <summary>The "mybooks" collection of methods.</summary>
        public class MybooksResource
        {
            private const string Resource = "mybooks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MybooksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Return a list of books in My Library.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Return a list of books in My Library.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>How the book was acquired</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="AcquireMethodList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("acquireMethod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AcquireMethodEnum> AcquireMethod { get; set; }

                /// <summary>How the book was acquired</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="AcquireMethod"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("acquireMethod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<AcquireMethodEnum> AcquireMethodList { get; set; }

                /// <summary>How the book was acquired</summary>
                public enum AcquireMethodEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("ACQUIRE_METHOD_UNDEFINED")]
                    ACQUIREMETHODUNDEFINED = 0,

                    /// <summary>Books acquired via Family Sharing</summary>
                    [Google.Apis.Util.StringValueAttribute("FAMILY_SHARED")]
                    FAMILYSHARED = 1,

                    /// <summary>Preordered books (not yet available)</summary>
                    [Google.Apis.Util.StringValueAttribute("PREORDERED")]
                    PREORDERED = 2,

                    /// <summary>User-rented books past their expiration time</summary>
                    [Google.Apis.Util.StringValueAttribute("PREVIOUSLY_RENTED")]
                    PREVIOUSLYRENTED = 3,

                    /// <summary>Public domain books</summary>
                    [Google.Apis.Util.StringValueAttribute("PUBLIC_DOMAIN")]
                    PUBLICDOMAIN = 4,

                    /// <summary>Purchased books</summary>
                    [Google.Apis.Util.StringValueAttribute("PURCHASED")]
                    PURCHASED = 5,

                    /// <summary>User-rented books</summary>
                    [Google.Apis.Util.StringValueAttribute("RENTED")]
                    RENTED = 6,

                    /// <summary>Sample books</summary>
                    [Google.Apis.Util.StringValueAttribute("SAMPLE")]
                    SAMPLE = 7,

                    /// <summary>User uploaded books</summary>
                    [Google.Apis.Util.StringValueAttribute("UPLOADED")]
                    UPLOADED = 8,
                }

                /// <summary>ISO-3166-1 code to override the IP-based location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Country { get; set; }

                /// <summary>
                /// ISO-639-1 language and ISO-3166-1 country code. Ex:'en_US'. Used for generating recommendations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// The processing state of the user uploaded volumes to be returned. Applicable only if the UPLOADED is
                /// specified in the acquireMethod.
                /// </summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="ProcessingStateList"/> to
                /// set multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("processingState", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ProcessingStateEnum> ProcessingState { get; set; }

                /// <summary>
                /// The processing state of the user uploaded volumes to be returned. Applicable only if the UPLOADED is
                /// specified in the acquireMethod.
                /// </summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="ProcessingState"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("processingState", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<ProcessingStateEnum> ProcessingStateList { get; set; }

                /// <summary>
                /// The processing state of the user uploaded volumes to be returned. Applicable only if the UPLOADED is
                /// specified in the acquireMethod.
                /// </summary>
                public enum ProcessingStateEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("PROCESSING_STATE_UNDEFINED")]
                    PROCESSINGSTATEUNDEFINED = 0,

                    /// <summary>The volume processing hase failed.</summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETED_FAILED")]
                    COMPLETEDFAILED = 1,

                    /// <summary>The volume processing was completed.</summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETED_SUCCESS")]
                    COMPLETEDSUCCESS = 2,

                    /// <summary>The volume processing is not completed.</summary>
                    [Google.Apis.Util.StringValueAttribute("RUNNING")]
                    RUNNING = 3,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Index of the first result to return (starts at 0)</summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/mybooks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("acquireMethod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "acquireMethod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("country", new Google.Apis.Discovery.Parameter
                    {
                        Name = "country",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
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
                    RequestParameters.Add("processingState", new Google.Apis.Discovery.Parameter
                    {
                        Name = "processingState",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
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

        /// <summary>Gets the Recommended resource.</summary>
        public virtual RecommendedResource Recommended { get; }

        /// <summary>The "recommended" collection of methods.</summary>
        public class RecommendedResource
        {
            private const string Resource = "recommended";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RecommendedResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Return a list of recommended books for the current user.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Return a list of recommended books for the current user.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating recommendations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>
                /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating
                /// are filtered out.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxAllowedMaturityRating", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MaxAllowedMaturityRatingEnum> MaxAllowedMaturityRating { get; set; }

                /// <summary>
                /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating
                /// are filtered out.
                /// </summary>
                public enum MaxAllowedMaturityRatingEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("MAX_ALLOWED_MATURITY_RATING_UNDEFINED")]
                    MAXALLOWEDMATURITYRATINGUNDEFINED = 0,

                    /// <summary>Show books which are rated mature or lower.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATURE")]
                    MATURE = 1,

                    /// <summary>Show books which are rated not mature.</summary>
                    [Google.Apis.Util.StringValueAttribute("not-mature")]
                    NotMature = 2,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/recommended";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxAllowedMaturityRating", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxAllowedMaturityRating",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Rate a recommended book for the current user.</summary>
            /// <param name="rating">Rating to be given to the volume.</param>
            /// <param name="volumeId">ID of the source volume.</param>
            public virtual RateRequest Rate(RateRequest.RatingEnum rating, string volumeId)
            {
                return new RateRequest(this.service, rating, volumeId);
            }

            /// <summary>Rate a recommended book for the current user.</summary>
            public class RateRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.BooksVolumesRecommendedRateResponse>
            {
                /// <summary>Constructs a new Rate request.</summary>
                public RateRequest(Google.Apis.Services.IClientService service, RatingEnum rating, string volumeId) : base(service)
                {
                    Rating = rating;
                    VolumeId = volumeId;
                    InitParameters();
                }

                /// <summary>Rating to be given to the volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("rating", Google.Apis.Util.RequestParameterType.Query)]
                public virtual RatingEnum Rating { get; private set; }

                /// <summary>Rating to be given to the volume.</summary>
                public enum RatingEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("RATING_UNDEFINED")]
                    RATINGUNDEFINED = 0,

                    /// <summary>Rating indicating a dismissal due to ownership.</summary>
                    [Google.Apis.Util.StringValueAttribute("HAVE_IT")]
                    HAVEIT = 1,

                    /// <summary>Rating indicating a negative dismissal of a volume.</summary>
                    [Google.Apis.Util.StringValueAttribute("NOT_INTERESTED")]
                    NOTINTERESTED = 2,
                }

                /// <summary>ID of the source volume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string VolumeId { get; private set; }

                /// <summary>
                /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating recommendations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "rate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/recommended/rate";

                /// <summary>Initializes Rate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("rating", new Google.Apis.Discovery.Parameter
                    {
                        Name = "rating",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Useruploaded resource.</summary>
        public virtual UseruploadedResource Useruploaded { get; }

        /// <summary>The "useruploaded" collection of methods.</summary>
        public class UseruploadedResource
        {
            private const string Resource = "useruploaded";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UseruploadedResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Return a list of books uploaded by the current user.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>Return a list of books uploaded by the current user.</summary>
            public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// ISO-639-1 language and ISO-3166-1 country code. Ex: 'en_US'. Used for generating recommendations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>The processing state of the user uploaded volumes to be returned.</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="ProcessingStateList"/> to
                /// set multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("processingState", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ProcessingStateEnum> ProcessingState { get; set; }

                /// <summary>The processing state of the user uploaded volumes to be returned.</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="ProcessingState"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("processingState", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<ProcessingStateEnum> ProcessingStateList { get; set; }

                /// <summary>The processing state of the user uploaded volumes to be returned.</summary>
                public enum ProcessingStateEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("PROCESSING_STATE_UNDEFINED")]
                    PROCESSINGSTATEUNDEFINED = 0,

                    /// <summary>The volume processing hase failed.</summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETED_FAILED")]
                    COMPLETEDFAILED = 1,

                    /// <summary>The volume processing was completed.</summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETED_SUCCESS")]
                    COMPLETEDSUCCESS = 2,

                    /// <summary>The volume processing is not completed.</summary>
                    [Google.Apis.Util.StringValueAttribute("RUNNING")]
                    RUNNING = 3,
                }

                /// <summary>String to identify the originator of this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Source { get; set; }

                /// <summary>Index of the first result to return (starts at 0)</summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>
                /// The ids of the volumes to be returned. If not specified all that match the processingState are
                /// returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> VolumeId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "books/v1/volumes/useruploaded";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
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
                    RequestParameters.Add("processingState", new Google.Apis.Discovery.Parameter
                    {
                        Name = "processingState",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
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
                    RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "volumeId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets volume information for a single volume.</summary>
        /// <param name="volumeId">ID of volume to retrieve.</param>
        public virtual GetRequest Get(string volumeId)
        {
            return new GetRequest(this.service, volumeId);
        }

        /// <summary>Gets volume information for a single volume.</summary>
        public class GetRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volume>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string volumeId) : base(service)
            {
                VolumeId = volumeId;
                InitParameters();
            }

            /// <summary>ID of volume to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string VolumeId { get; private set; }

            /// <summary>ISO-3166-1 code to override the IP-based location.</summary>
            [Google.Apis.Util.RequestParameterAttribute("country", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Country { get; set; }

            /// <summary>Set to true to include non-comics series. Defaults to false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeNonComicsSeries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeNonComicsSeries { get; set; }

            /// <summary>Brand results for partner ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Partner { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED = 0,

                /// <summary>Includes all volume data.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,

                /// <summary>Includes a subset of fields in volumeInfo and accessInfo.</summary>
                [Google.Apis.Util.StringValueAttribute("LITE")]
                LITE = 2,
            }

            /// <summary>string to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("user_library_consistent_read", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UserLibraryConsistentRead { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/volumes/{volumeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "volumeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("country", new Google.Apis.Discovery.Parameter
                {
                    Name = "country",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeNonComicsSeries", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeNonComicsSeries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partner", new Google.Apis.Discovery.Parameter
                {
                    Name = "partner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("user_library_consistent_read", new Google.Apis.Discovery.Parameter
                {
                    Name = "user_library_consistent_read",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Performs a book search.</summary>
        /// <param name="q">Full-text search query string.</param>
        public virtual ListRequest List(string q)
        {
            return new ListRequest(this.service, q);
        }

        /// <summary>Performs a book search.</summary>
        public class ListRequest : BooksBaseServiceRequest<Google.Apis.Books.v1.Data.Volumes>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string q) : base(service)
            {
                Q = q;
                InitParameters();
            }

            /// <summary>Full-text search query string.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; private set; }

            /// <summary>Restrict to volumes by download availability.</summary>
            [Google.Apis.Util.RequestParameterAttribute("download", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DownloadEnum> Download { get; set; }

            /// <summary>Restrict to volumes by download availability.</summary>
            public enum DownloadEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DOWNLOAD_UNDEFINED")]
                DOWNLOADUNDEFINED = 0,

                /// <summary>All volumes with epub.</summary>
                [Google.Apis.Util.StringValueAttribute("EPUB")]
                EPUB = 1,
            }

            /// <summary>Filter search results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<FilterEnum> Filter { get; set; }

            /// <summary>Filter search results.</summary>
            public enum FilterEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("FILTER_UNDEFINED")]
                FILTERUNDEFINED = 0,

                /// <summary>All Google eBooks.</summary>
                [Google.Apis.Util.StringValueAttribute("ebooks")]
                Ebooks = 1,

                /// <summary>Google eBook with full volume text viewability.</summary>
                [Google.Apis.Util.StringValueAttribute("free-ebooks")]
                FreeEbooks = 2,

                /// <summary>Public can view entire volume text.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 3,

                /// <summary>Google eBook with a price.</summary>
                [Google.Apis.Util.StringValueAttribute("paid-ebooks")]
                PaidEbooks = 4,

                /// <summary>Public able to see parts of text.</summary>
                [Google.Apis.Util.StringValueAttribute("partial")]
                Partial = 5,
            }

            /// <summary>Restrict results to books with this language code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("langRestrict", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LangRestrict { get; set; }

            /// <summary>Restrict search to this user's library.</summary>
            [Google.Apis.Util.RequestParameterAttribute("libraryRestrict", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<LibraryRestrictEnum> LibraryRestrict { get; set; }

            /// <summary>Restrict search to this user's library.</summary>
            public enum LibraryRestrictEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIBRARY_RESTRICT_UNDEFINED")]
                LIBRARYRESTRICTUNDEFINED = 0,

                /// <summary>Restrict to the user's library, any shelf.</summary>
                [Google.Apis.Util.StringValueAttribute("my-library")]
                MyLibrary = 1,

                /// <summary>Do not restrict based on user's library.</summary>
                [Google.Apis.Util.StringValueAttribute("no-restrict")]
                NoRestrict = 2,
            }

            /// <summary>
            /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxAllowedMaturityRating", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MaxAllowedMaturityRatingEnum> MaxAllowedMaturityRating { get; set; }

            /// <summary>
            /// The maximum allowed maturity rating of returned recommendations. Books with a higher maturity rating are
            /// filtered out.
            /// </summary>
            public enum MaxAllowedMaturityRatingEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("MAX_ALLOWED_MATURITY_RATING_UNDEFINED")]
                MAXALLOWEDMATURITYRATINGUNDEFINED = 0,

                /// <summary>Show books which are rated mature or lower.</summary>
                [Google.Apis.Util.StringValueAttribute("MATURE")]
                MATURE = 1,

                /// <summary>Show books which are rated not mature.</summary>
                [Google.Apis.Util.StringValueAttribute("not-mature")]
                NotMature = 2,
            }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Sort search results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Sort search results.</summary>
            public enum OrderByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ORDER_BY_UNDEFINED")]
                ORDERBYUNDEFINED = 0,

                /// <summary>Most recently published.</summary>
                [Google.Apis.Util.StringValueAttribute("newest")]
                Newest = 1,

                /// <summary>Relevance to search terms.</summary>
                [Google.Apis.Util.StringValueAttribute("relevance")]
                Relevance = 2,
            }

            /// <summary>Restrict and brand results for partner ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("partner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Partner { get; set; }

            /// <summary>Restrict to books or magazines.</summary>
            [Google.Apis.Util.RequestParameterAttribute("printType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PrintTypeEnum> PrintType { get; set; }

            /// <summary>Restrict to books or magazines.</summary>
            public enum PrintTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PRINT_TYPE_UNDEFINED")]
                PRINTTYPEUNDEFINED = 0,

                /// <summary>All volume content types.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL")]
                ALL = 1,

                /// <summary>Just books.</summary>
                [Google.Apis.Util.StringValueAttribute("BOOKS")]
                BOOKS = 2,

                /// <summary>Just magazines.</summary>
                [Google.Apis.Util.StringValueAttribute("MAGAZINES")]
                MAGAZINES = 3,
            }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED = 0,

                /// <summary>Includes all volume data.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,

                /// <summary>Includes a subset of fields in volumeInfo and accessInfo.</summary>
                [Google.Apis.Util.StringValueAttribute("LITE")]
                LITE = 2,
            }

            /// <summary>Set to true to show books available for preorder. Defaults to false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("showPreorders", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowPreorders { get; set; }

            /// <summary>String to identify the originator of this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Index of the first result to return (starts at 0)</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "books/v1/volumes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("download", new Google.Apis.Discovery.Parameter
                {
                    Name = "download",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("langRestrict", new Google.Apis.Discovery.Parameter
                {
                    Name = "langRestrict",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("libraryRestrict", new Google.Apis.Discovery.Parameter
                {
                    Name = "libraryRestrict",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxAllowedMaturityRating", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxAllowedMaturityRating",
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
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("partner", new Google.Apis.Discovery.Parameter
                {
                    Name = "partner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("printType", new Google.Apis.Discovery.Parameter
                {
                    Name = "printType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("showPreorders", new Google.Apis.Discovery.Parameter
                {
                    Name = "showPreorders",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                {
                    Name = "source",
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
namespace Google.Apis.Books.v1.Data
{
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Anchor text after excerpt. For requests, if the user bookmarked a screen that has no flowing text on it,
        /// then this field should be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterSelectedText")]
        public virtual string AfterSelectedText { get; set; }

        /// <summary>
        /// Anchor text before excerpt. For requests, if the user bookmarked a screen that has no flowing text on it,
        /// then this field should be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeSelectedText")]
        public virtual string BeforeSelectedText { get; set; }

        /// <summary>Selection ranges sent from the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersionRanges")]
        public virtual ClientVersionRangesData ClientVersionRanges { get; set; }

        /// <summary>Timestamp for the created time of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created { get; set; }

        /// <summary>Selection ranges for the most recent content version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersionRanges")]
        public virtual CurrentVersionRangesData CurrentVersionRanges { get; set; }

        /// <summary>User-created data for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Indicates that this annotation is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>The highlight style for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highlightStyle")]
        public virtual string HighlightStyle { get; set; }

        /// <summary>Id of this annotation, in the form of a GUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The layer this annotation is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
        public virtual string LayerId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("layerSummary")]
        public virtual LayerSummaryData LayerSummary { get; set; }

        /// <summary>Pages that this annotation spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageIds")]
        public virtual System.Collections.Generic.IList<string> PageIds { get; set; }

        /// <summary>Excerpt from the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedText")]
        public virtual string SelectedText { get; set; }

        /// <summary>URL to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Timestamp for the last time this annotation was modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The volume that this annotation belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Selection ranges sent from the client.</summary>
        public class ClientVersionRangesData
        {
            /// <summary>Range in CFI format for this annotation sent by client.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cfiRange")]
            public virtual BooksAnnotationsRange CfiRange { get; set; }

            /// <summary>Content version the client sent in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contentVersion")]
            public virtual string ContentVersion { get; set; }

            /// <summary>Range in GB image format for this annotation sent by client.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbImageRange")]
            public virtual BooksAnnotationsRange GbImageRange { get; set; }

            /// <summary>Range in GB text format for this annotation sent by client.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbTextRange")]
            public virtual BooksAnnotationsRange GbTextRange { get; set; }

            /// <summary>Range in image CFI format for this annotation sent by client.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("imageCfiRange")]
            public virtual BooksAnnotationsRange ImageCfiRange { get; set; }
        }

        /// <summary>Selection ranges for the most recent content version.</summary>
        public class CurrentVersionRangesData
        {
            /// <summary>Range in CFI format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cfiRange")]
            public virtual BooksAnnotationsRange CfiRange { get; set; }

            /// <summary>Content version applicable to ranges below.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contentVersion")]
            public virtual string ContentVersion { get; set; }

            /// <summary>Range in GB image format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbImageRange")]
            public virtual BooksAnnotationsRange GbImageRange { get; set; }

            /// <summary>Range in GB text format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbTextRange")]
            public virtual BooksAnnotationsRange GbTextRange { get; set; }

            /// <summary>Range in image CFI format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("imageCfiRange")]
            public virtual BooksAnnotationsRange ImageCfiRange { get; set; }
        }

        public class LayerSummaryData
        {
            /// <summary>Maximum allowed characters on this layer, especially for the "copy" layer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("allowedCharacterCount")]
            public virtual System.Nullable<int> AllowedCharacterCount { get; set; }

            /// <summary>Type of limitation on this layer. "limited" or "unlimited" for the "copy" layer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("limitType")]
            public virtual string LimitType { get; set; }

            /// <summary>Remaining allowed characters on this layer, especially for the "copy" layer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("remainingCharacterCount")]
            public virtual System.Nullable<int> RemainingCharacterCount { get; set; }
        }
    }

    public class Annotations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Annotation> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token to pass in for pagination for the next page. This will not be present if this request does not have
        /// more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Total number of annotations found. This may be greater than the number of notes returned in this response if
        /// results have been paginated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AnnotationsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("layers")]
        public virtual System.Collections.Generic.IList<LayersData> Layers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class LayersData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("allowedCharacterCount")]
            public virtual System.Nullable<int> AllowedCharacterCount { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
            public virtual string LayerId { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("limitType")]
            public virtual string LimitType { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("remainingCharacterCount")]
            public virtual System.Nullable<int> RemainingCharacterCount { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("updated")]
            public virtual string Updated { get; set; }
        }
    }

    public class Annotationsdata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Annotation Data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GeoAnnotationdata> Items { get; set; }

        /// <summary>Resource type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token to pass in for pagination for the next page. This will not be present if this request does not have
        /// more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of volume annotations found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BooksAnnotationsRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The offset from the ending position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual string EndOffset { get; set; }

        /// <summary>The ending position for the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endPosition")]
        public virtual string EndPosition { get; set; }

        /// <summary>The offset from the starting position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual string StartOffset { get; set; }

        /// <summary>The starting position for the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startPosition")]
        public virtual string StartPosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BooksCloudloadingResource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("processingState")]
        public virtual string ProcessingState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BooksVolumesRecommendedRateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("consistency_token")]
        public virtual string ConsistencyToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Bookshelf : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this bookshelf is PUBLIC or PRIVATE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; }

        /// <summary>Created time for this bookshelf (formatted UTC timestamp with millisecond resolution).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created { get; set; }

        /// <summary>Description of this bookshelf.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Id of this bookshelf, only unique by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>Resource type for bookshelf metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>URL to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Title of this bookshelf.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Last modified time of this bookshelf (formatted UTC timestamp with millisecond resolution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>Number of volumes in this bookshelf.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeCount")]
        public virtual System.Nullable<int> VolumeCount { get; set; }

        /// <summary>
        /// Last time a volume was added or removed from this bookshelf (formatted UTC timestamp with millisecond
        /// resolution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumesLastUpdated")]
        public virtual string VolumesLastUpdated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Bookshelves : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of bookshelves.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Bookshelf> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Category : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of onboarding categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ItemsData> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>A list of onboarding categories.</summary>
        public class ItemsData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("badgeUrl")]
            public virtual string BadgeUrl { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("categoryId")]
            public virtual string CategoryId { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }
    }

    public class ConcurrentAccessRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether access is granted for this (user, device, volume).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAllowed")]
        public virtual System.Nullable<bool> DeviceAllowed { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The maximum number of concurrent access licenses for this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentDevices")]
        public virtual System.Nullable<int> MaxConcurrentDevices { get; set; }

        /// <summary>Error/warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Client nonce for verification. Download access and client-validation only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonce")]
        public virtual string Nonce { get; set; }

        /// <summary>Error/warning reason code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonCode")]
        public virtual string ReasonCode { get; set; }

        /// <summary>Whether this volume has any concurrent access restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restricted")]
        public virtual System.Nullable<bool> Restricted { get; set; }

        /// <summary>Response signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>Client app identifier for verification. Download access and client-validation only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Time in seconds for license auto-expiration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeWindowSeconds")]
        public virtual System.Nullable<int> TimeWindowSeconds { get; set; }

        /// <summary>Identifies the volume for which this entry applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DictionaryAnnotationdata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of annotation this data is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>
        /// JSON encoded data for this dictionary annotation data. Emitted with name 'data' in JSON output. Either this
        /// or geo_data will be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual Dictlayerdata Data { get; set; }

        /// <summary>Base64 encoded data for this annotation data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>Unique id for this annotation data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource Type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The Layer id for this data. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
        public virtual string LayerId { get; set; }

        /// <summary>URL for this resource. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Timestamp for the last time this data was updated. (RFC 3339 UTC date-time format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The volume id for this data. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Dictlayerdata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual CommonData Common { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dict")]
        public virtual DictData Dict { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class CommonData
        {
            /// <summary>
            /// The display title and localized canonical name to use when searching for this entity on Google search.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }
        }

        public class DictData
        {
            /// <summary>The source, url and attribution for this dictionary data.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("source")]
            public virtual SourceData Source { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("words")]
            public virtual System.Collections.Generic.IList<WordsData> Words { get; set; }

            /// <summary>The source, url and attribution for this dictionary data.</summary>
            public class SourceData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                public virtual string Attribution { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }

            public class WordsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("derivatives")]
                public virtual System.Collections.Generic.IList<DerivativesData> Derivatives { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("examples")]
                public virtual System.Collections.Generic.IList<ExamplesData> Examples { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("senses")]
                public virtual System.Collections.Generic.IList<SensesData> Senses { get; set; }

                /// <summary>
                /// The words with different meanings but not related words, e.g. "go" (game) and "go" (verb).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("source")]
                public virtual SourceData Source { get; set; }

                public class DerivativesData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("source")]
                    public virtual SourceData Source { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("text")]
                    public virtual string Text { get; set; }

                    public class SourceData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                        public virtual string Attribution { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("url")]
                        public virtual string Url { get; set; }
                    }
                }

                public class ExamplesData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("source")]
                    public virtual SourceData Source { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("text")]
                    public virtual string Text { get; set; }

                    public class SourceData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                        public virtual string Attribution { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("url")]
                        public virtual string Url { get; set; }
                    }
                }

                public class SensesData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("conjugations")]
                    public virtual System.Collections.Generic.IList<ConjugationsData> Conjugations { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("definitions")]
                    public virtual System.Collections.Generic.IList<DefinitionsData> Definitions { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("partOfSpeech")]
                    public virtual string PartOfSpeech { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("pronunciation")]
                    public virtual string Pronunciation { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("pronunciationUrl")]
                    public virtual string PronunciationUrl { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("source")]
                    public virtual SourceData Source { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("syllabification")]
                    public virtual string Syllabification { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
                    public virtual System.Collections.Generic.IList<SynonymsData> Synonyms { get; set; }

                    public class ConjugationsData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("type")]
                        public virtual string Type { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("value")]
                        public virtual string Value { get; set; }
                    }

                    public class DefinitionsData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
                        public virtual string Definition { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
                        public virtual System.Collections.Generic.IList<ExamplesData> Examples { get; set; }

                        public class ExamplesData
                        {
                            [Newtonsoft.Json.JsonPropertyAttribute("source")]
                            public virtual SourceData Source { get; set; }

                            [Newtonsoft.Json.JsonPropertyAttribute("text")]
                            public virtual string Text { get; set; }

                            public class SourceData
                            {
                                [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                                public virtual string Attribution { get; set; }

                                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                                public virtual string Url { get; set; }
                            }
                        }
                    }

                    public class SourceData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                        public virtual string Attribution { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("url")]
                        public virtual string Url { get; set; }
                    }

                    public class SynonymsData
                    {
                        [Newtonsoft.Json.JsonPropertyAttribute("source")]
                        public virtual SourceData Source { get; set; }

                        [Newtonsoft.Json.JsonPropertyAttribute("text")]
                        public virtual string Text { get; set; }

                        public class SourceData
                        {
                            [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                            public virtual string Attribution { get; set; }

                            [Newtonsoft.Json.JsonPropertyAttribute("url")]
                            public virtual string Url { get; set; }
                        }
                    }
                }

                /// <summary>
                /// The words with different meanings but not related words, e.g. "go" (game) and "go" (verb).
                /// </summary>
                public class SourceData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("attribution")]
                    public virtual string Attribution { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("url")]
                    public virtual string Url { get; set; }
                }
            }
        }
    }

    public class Discoveryclusters : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<ClustersData> Clusters { get; set; }

        /// <summary>Resorce type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("totalClusters")]
        public virtual System.Nullable<int> TotalClusters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class ClustersData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("banner_with_content_container")]
            public virtual BannerWithContentContainerData BannerWithContentContainer { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("subTitle")]
            public virtual string SubTitle { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("totalVolumes")]
            public virtual System.Nullable<int> TotalVolumes { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("uid")]
            public virtual string Uid { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
            public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

            public class BannerWithContentContainerData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("fillColorArgb")]
                public virtual string FillColorArgb { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
                public virtual string ImageUrl { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("maskColorArgb")]
                public virtual string MaskColorArgb { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("moreButtonText")]
                public virtual string MoreButtonText { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("moreButtonUrl")]
                public virtual string MoreButtonUrl { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("textColorArgb")]
                public virtual string TextColorArgb { get; set; }
            }
        }
    }

    public class DownloadAccessRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If restricted, whether access is granted for this (user, device, volume).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAllowed")]
        public virtual System.Nullable<bool> DeviceAllowed { get; set; }

        /// <summary>
        /// If restricted, the number of content download licenses already acquired (including the requesting client, if
        /// licensed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadsAcquired")]
        public virtual System.Nullable<int> DownloadsAcquired { get; set; }

        /// <summary>If deviceAllowed, whether access was just acquired with this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justAcquired")]
        public virtual System.Nullable<bool> JustAcquired { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>If restricted, the maximum number of content download licenses for this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDownloadDevices")]
        public virtual System.Nullable<int> MaxDownloadDevices { get; set; }

        /// <summary>Error/warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Client nonce for verification. Download access and client-validation only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonce")]
        public virtual string Nonce { get; set; }

        /// <summary>
        /// Error/warning reason code. Additional codes may be added in the future. 0 OK 100
        /// ACCESS_DENIED_PUBLISHER_LIMIT 101 ACCESS_DENIED_LIMIT 200 WARNING_USED_LAST_ACCESS
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonCode")]
        public virtual string ReasonCode { get; set; }

        /// <summary>Whether this volume has any download access restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restricted")]
        public virtual System.Nullable<bool> Restricted { get; set; }

        /// <summary>Response signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>Client app identifier for verification. Download access and client-validation only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Identifies the volume for which this entry applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DownloadAccesses : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of download access responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadAccessList")]
        public virtual System.Collections.Generic.IList<DownloadAccessRestriction> DownloadAccessList { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

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

    public class FamilyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Family membership info of the user that made the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual MembershipData Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Family membership info of the user that made the request.</summary>
        public class MembershipData
        {
            /// <summary>Restrictions on user buying and acquiring content.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("acquirePermission")]
            public virtual string AcquirePermission { get; set; }

            /// <summary>The age group of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ageGroup")]
            public virtual string AgeGroup { get; set; }

            /// <summary>The maximum allowed maturity rating for the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("allowedMaturityRating")]
            public virtual string AllowedMaturityRating { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("isInFamily")]
            public virtual System.Nullable<bool> IsInFamily { get; set; }

            /// <summary>The role of the user in the family.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("role")]
            public virtual string Role { get; set; }
        }
    }

    public class GeoAnnotationdata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of annotation this data is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>
        /// JSON encoded data for this geo annotation data. Emitted with name 'data' in JSON output. Either this or
        /// dict_data will be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual Geolayerdata Data { get; set; }

        /// <summary>Base64 encoded data for this annotation data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>Unique id for this annotation data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource Type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The Layer id for this data. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
        public virtual string LayerId { get; set; }

        /// <summary>URL for this resource. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Timestamp for the last time this data was updated. (RFC 3339 UTC date-time format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The volume id for this data. *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Geolayerdata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual CommonData Common { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("geo")]
        public virtual GeoData Geo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class CommonData
        {
            /// <summary>The language of the information url and description.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("lang")]
            public virtual string Lang { get; set; }

            /// <summary>The URL for the preview image information.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("previewImageUrl")]
            public virtual string PreviewImageUrl { get; set; }

            /// <summary>The description for this location.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
            public virtual string Snippet { get; set; }

            /// <summary>The URL for information for this location. Ex: wikipedia link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("snippetUrl")]
            public virtual string SnippetUrl { get; set; }

            /// <summary>
            /// The display title and localized canonical name to use when searching for this entity on Google search.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }
        }

        public class GeoData
        {
            /// <summary>
            /// The boundary of the location as a set of loops containing pairs of latitude, longitude coordinates.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("boundary")]
            public virtual System.Collections.Generic.IList<string> Boundary { get; set; }

            /// <summary>The cache policy active for this data. EX: UNRESTRICTED, RESTRICTED, NEVER</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cachePolicy")]
            public virtual string CachePolicy { get; set; }

            /// <summary>The country code of the location.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
            public virtual string CountryCode { get; set; }

            /// <summary>The latitude of the location.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
            public virtual System.Nullable<double> Latitude { get; set; }

            /// <summary>The longitude of the location.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
            public virtual System.Nullable<double> Longitude { get; set; }

            /// <summary>
            /// The type of map that should be used for this location. EX: HYBRID, ROADMAP, SATELLITE, TERRAIN
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mapType")]
            public virtual string MapType { get; set; }

            /// <summary>The viewport for showing this location. This is a latitude, longitude rectangle.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("viewport")]
            public virtual ViewportData Viewport { get; set; }

            /// <summary>
            /// The Zoom level to use for the map. Zoom levels between 0 (the lowest zoom level, in which the entire
            /// world can be seen on one map) to 21+ (down to individual buildings). See: https:
            /// //developers.google.com/maps/documentation/staticmaps/#Zoomlevels
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("zoom")]
            public virtual System.Nullable<int> Zoom { get; set; }

            /// <summary>The viewport for showing this location. This is a latitude, longitude rectangle.</summary>
            public class ViewportData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("hi")]
                public virtual HiData Hi { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("lo")]
                public virtual LoData Lo { get; set; }

                public class HiData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
                    public virtual System.Nullable<double> Latitude { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
                    public virtual System.Nullable<double> Longitude { get; set; }
                }

                public class LoData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
                    public virtual System.Nullable<double> Latitude { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
                    public virtual System.Nullable<double> Longitude { get; set; }
                }
            }
        }
    }

    public class Layersummaries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of layer summary items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Layersummary> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The total number of layer summaries found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Layersummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of annotations for this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationCount")]
        public virtual System.Nullable<int> AnnotationCount { get; set; }

        /// <summary>The list of annotation types contained for this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationTypes")]
        public virtual System.Collections.Generic.IList<string> AnnotationTypes { get; set; }

        /// <summary>Link to get data for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationsDataLink")]
        public virtual string AnnotationsDataLink { get; set; }

        /// <summary>The link to get the annotations for this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationsLink")]
        public virtual string AnnotationsLink { get; set; }

        /// <summary>The content version this resource is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentVersion")]
        public virtual string ContentVersion { get; set; }

        /// <summary>The number of data items for this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCount")]
        public virtual System.Nullable<int> DataCount { get; set; }

        /// <summary>Unique id of this layer summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource Type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The layer id for this summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
        public virtual string LayerId { get; set; }

        /// <summary>URL to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Timestamp for the last time an item in this layer was updated. (RFC 3339 UTC date-time format).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>
        /// The current version of this layer's volume annotations. Note that this version applies only to the data in
        /// the books.layers.volumeAnnotations.* responses. The actual annotation data is versioned separately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeAnnotationsVersion")]
        public virtual string VolumeAnnotationsVersion { get; set; }

        /// <summary>The volume id this resource is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of offline dictionary metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ItemsData> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>A list of offline dictionary metadata.</summary>
        public class ItemsData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("download_url")]
            public virtual string DownloadUrl { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("encrypted_key")]
            public virtual string EncryptedKey { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual System.Nullable<long> Size { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("version")]
            public virtual System.Nullable<long> Version { get; set; }
        }
    }

    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>The list of crm experiment ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crmExperimentIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CrmExperimentIds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doc_id")]
        public virtual string DocId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doc_type")]
        public virtual string DocType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dont_show_notification")]
        public virtual System.Nullable<bool> DontShowNotification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("is_document_mature")]
        public virtual System.Nullable<bool> IsDocumentMature { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notificationGroup")]
        public virtual string NotificationGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notification_type")]
        public virtual string NotificationType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pcampaign_id")]
        public virtual string PcampaignId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("show_notification_settings_action")]
        public virtual System.Nullable<bool> ShowNotificationSettingsAction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetUrl")]
        public virtual string TargetUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeToExpireMs")]
        public virtual System.Nullable<long> TimeToExpireMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Offers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ItemsData> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>A list of offers.</summary>
        public class ItemsData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("artUrl")]
            public virtual string ArtUrl { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("gservicesKey")]
            public virtual string GservicesKey { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("items")]
            public virtual System.Collections.Generic.IList<ItemsDataSchema> Items { get; set; }

            public class ItemsDataSchema
            {
                [Newtonsoft.Json.JsonPropertyAttribute("author")]
                public virtual string Author { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("canonicalVolumeLink")]
                public virtual string CanonicalVolumeLink { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("coverUrl")]
                public virtual string CoverUrl { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("description")]
                public virtual string Description { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("title")]
                public virtual string Title { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
                public virtual string VolumeId { get; set; }
            }
        }
    }

    public class ReadingPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Position in an EPUB as a CFI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epubCfiPosition")]
        public virtual string EpubCfiPosition { get; set; }

        /// <summary>Position in a volume for image-based content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gbImagePosition")]
        public virtual string GbImagePosition { get; set; }

        /// <summary>Position in a volume for text-based content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gbTextPosition")]
        public virtual string GbTextPosition { get; set; }

        /// <summary>Resource type for a reading position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Position in a PDF file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdfPosition")]
        public virtual string PdfPosition { get; set; }

        /// <summary>
        /// Timestamp when this reading position was last updated (formatted UTC timestamp with millisecond resolution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>Volume id associated with this reading position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RequestAccessData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A concurrent access response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentAccess")]
        public virtual ConcurrentAccessRestriction ConcurrentAccess { get; set; }

        /// <summary>A download access response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadAccess")]
        public virtual DownloadAccessRestriction DownloadAccess { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Author of this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual AuthorData Author { get; set; }

        /// <summary>Review text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Date of this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; }

        /// <summary>URL for the full review text, for reviews gathered from the web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTextUrl")]
        public virtual string FullTextUrl { get; set; }

        /// <summary>Resource type for a review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Star rating for this review. Possible values are ONE, TWO, THREE, FOUR, FIVE or NOT_RATED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual string Rating { get; set; }

        /// <summary>
        /// Information regarding the source of this review, when the review is not from a Google Books user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual SourceData Source { get; set; }

        /// <summary>Title for this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Source type for this review. Possible values are EDITORIAL, WEB_USER or GOOGLE_USER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Volume that this review is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Author of this review.</summary>
        public class AuthorData
        {
            /// <summary>Name of this person.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }
        }

        /// <summary>
        /// Information regarding the source of this review, when the review is not from a Google Books user.
        /// </summary>
        public class SourceData
        {
            /// <summary>Name of the source.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; }

            /// <summary>Extra text about the source of the review.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("extraDescription")]
            public virtual string ExtraDescription { get; set; }

            /// <summary>URL of the source of the review.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }
    }

    public class Series : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual System.Collections.Generic.IList<SeriesData> SeriesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class SeriesData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("bannerImageUrl")]
            public virtual string BannerImageUrl { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("eligibleForSubscription")]
            public virtual System.Nullable<bool> EligibleForSubscription { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
            public virtual string ImageUrl { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("isComplete")]
            public virtual System.Nullable<bool> IsComplete { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("seriesFormatType")]
            public virtual string SeriesFormatType { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("seriesId")]
            public virtual string SeriesId { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("seriesSubscriptionReleaseInfo")]
            public virtual SeriesSubscriptionReleaseInfoData SeriesSubscriptionReleaseInfo { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("seriesType")]
            public virtual string SeriesType { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("subscriptionId")]
            public virtual string SubscriptionId { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }

            public class SeriesSubscriptionReleaseInfoData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
                public virtual string CancelTime { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("currentReleaseInfo")]
                public virtual CurrentReleaseInfoData CurrentReleaseInfo { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("nextReleaseInfo")]
                public virtual NextReleaseInfoData NextReleaseInfo { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("seriesSubscriptionType")]
                public virtual string SeriesSubscriptionType { get; set; }

                public class CurrentReleaseInfoData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("amountInMicros")]
                    public virtual System.Nullable<double> AmountInMicros { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                    public virtual string CurrencyCode { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("releaseNumber")]
                    public virtual string ReleaseNumber { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("releaseTime")]
                    public virtual string ReleaseTime { get; set; }
                }

                public class NextReleaseInfoData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("amountInMicros")]
                    public virtual System.Nullable<double> AmountInMicros { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                    public virtual string CurrencyCode { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("releaseNumber")]
                    public virtual string ReleaseNumber { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("releaseTime")]
                    public virtual string ReleaseTime { get; set; }
                }
            }
        }
    }

    public class Seriesmembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resorce type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual System.Collections.Generic.IList<Volume> Member { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Usersettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>User settings in sub-objects, each for different purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notesExport")]
        public virtual NotesExportData NotesExport { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual NotificationData Notification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>User settings in sub-objects, each for different purposes.</summary>
        public class NotesExportData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("folderName")]
            public virtual string FolderName { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("isEnabled")]
            public virtual System.Nullable<bool> IsEnabled { get; set; }
        }

        public class NotificationData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("matchMyInterests")]
            public virtual MatchMyInterestsData MatchMyInterests { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("moreFromAuthors")]
            public virtual MoreFromAuthorsData MoreFromAuthors { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("moreFromSeries")]
            public virtual MoreFromSeriesData MoreFromSeries { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("priceDrop")]
            public virtual PriceDropData PriceDrop { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("rewardExpirations")]
            public virtual RewardExpirationsData RewardExpirations { get; set; }

            public class MatchMyInterestsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("opted_state")]
                public virtual string OptedState { get; set; }
            }

            public class MoreFromAuthorsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("opted_state")]
                public virtual string OptedState { get; set; }
            }

            public class MoreFromSeriesData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("opted_state")]
                public virtual string OptedState { get; set; }
            }

            public class PriceDropData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("opted_state")]
                public virtual string OptedState { get; set; }
            }

            public class RewardExpirationsData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("opted_state")]
                public virtual string OptedState { get; set; }
            }
        }
    }

    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Any information about a volume related to reading or obtaining that volume text. This information can depend
        /// on country (books may be public domain in one country but not in another, e.g.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessInfo")]
        public virtual AccessInfoData AccessInfo { get; set; }

        /// <summary>Opaque identifier for a specific version of a volume resource. (In LITE projection)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Unique identifier for a volume. (In LITE projection.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource type for a volume. (In LITE projection.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>What layers exist in this volume and high level information about them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerInfo")]
        public virtual LayerInfoData LayerInfo { get; set; }

        /// <summary>Recommendation related information for this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedInfo")]
        public virtual RecommendedInfoData RecommendedInfo { get; set; }

        /// <summary>
        /// Any information about a volume related to the eBookstore and/or purchaseability. This information can depend
        /// on the country where the request originates from (i.e. books may not be for sale in certain countries).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saleInfo")]
        public virtual SaleInfoData SaleInfo { get; set; }

        /// <summary>Search result information related to this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchInfo")]
        public virtual SearchInfoData SearchInfo { get; set; }

        /// <summary>URL to this resource. (In LITE projection.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// User specific information related to this volume. (e.g. page this user last read or whether they purchased
        /// this book)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual UserInfoData UserInfo { get; set; }

        /// <summary>General volume information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeInfo")]
        public virtual VolumeInfoData VolumeInfo { get; set; }

        /// <summary>
        /// Any information about a volume related to reading or obtaining that volume text. This information can depend
        /// on country (books may be public domain in one country but not in another, e.g.).
        /// </summary>
        public class AccessInfoData
        {
            /// <summary>
            /// Combines the access and viewability of this volume into a single status field for this user. Values can
            /// be FULL_PURCHASED, FULL_PUBLIC_DOMAIN, SAMPLE or NONE. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("accessViewStatus")]
            public virtual string AccessViewStatus { get; set; }

            /// <summary>
            /// The two-letter ISO_3166-1 country code for which this access information is valid. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("country")]
            public virtual string Country { get; set; }

            /// <summary>Information about a volume's download license access restrictions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("downloadAccess")]
            public virtual DownloadAccessRestriction DownloadAccess { get; set; }

            /// <summary>
            /// URL to the Google Drive viewer if this volume is uploaded by the user by selecting the file from Google
            /// Drive.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("driveImportedContentLink")]
            public virtual string DriveImportedContentLink { get; set; }

            /// <summary>Whether this volume can be embedded in a viewport using the Embedded Viewer API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("embeddable")]
            public virtual System.Nullable<bool> Embeddable { get; set; }

            /// <summary>Information about epub content. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("epub")]
            public virtual EpubData Epub { get; set; }

            /// <summary>
            /// Whether this volume requires that the client explicitly request offline download license rather than
            /// have it done automatically when loading the content, if the client supports it.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("explicitOfflineLicenseManagement")]
            public virtual System.Nullable<bool> ExplicitOfflineLicenseManagement { get; set; }

            /// <summary>Information about pdf content. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("pdf")]
            public virtual PdfData Pdf { get; set; }

            /// <summary>Whether or not this book is public domain in the country listed above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("publicDomain")]
            public virtual System.Nullable<bool> PublicDomain { get; set; }

            /// <summary>Whether quote sharing is allowed for this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("quoteSharingAllowed")]
            public virtual System.Nullable<bool> QuoteSharingAllowed { get; set; }

            /// <summary>
            /// Whether text-to-speech is permitted for this volume. Values can be ALLOWED, ALLOWED_FOR_ACCESSIBILITY,
            /// or NOT_ALLOWED.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("textToSpeechPermission")]
            public virtual string TextToSpeechPermission { get; set; }

            /// <summary>
            /// For ordered but not yet processed orders, we give a URL that can be used to go to the appropriate Google
            /// Wallet page.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("viewOrderUrl")]
            public virtual string ViewOrderUrl { get; set; }

            /// <summary>
            /// The read access of a volume. Possible values are PARTIAL, ALL_PAGES, NO_PAGES or UNKNOWN. This value
            /// depends on the country listed above. A value of PARTIAL means that the publisher has allowed some
            /// portion of the volume to be viewed publicly, without purchase. This can apply to eBooks as well as
            /// non-eBooks. Public domain books will always have a value of ALL_PAGES.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("viewability")]
            public virtual string Viewability { get; set; }

            /// <summary>
            /// URL to read this volume on the Google Books site. Link will not allow users to read non-viewable
            /// volumes.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webReaderLink")]
            public virtual string WebReaderLink { get; set; }

            /// <summary>Information about epub content. (In LITE projection.)</summary>
            public class EpubData
            {
                /// <summary>URL to retrieve ACS token for epub download. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("acsTokenLink")]
                public virtual string AcsTokenLink { get; set; }

                /// <summary>URL to download epub. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("downloadLink")]
                public virtual string DownloadLink { get; set; }

                /// <summary>
                /// Is a flowing text epub available either as public domain or for purchase. (In LITE projection.)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("isAvailable")]
                public virtual System.Nullable<bool> IsAvailable { get; set; }
            }

            /// <summary>Information about pdf content. (In LITE projection.)</summary>
            public class PdfData
            {
                /// <summary>URL to retrieve ACS token for pdf download. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("acsTokenLink")]
                public virtual string AcsTokenLink { get; set; }

                /// <summary>URL to download pdf. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("downloadLink")]
                public virtual string DownloadLink { get; set; }

                /// <summary>
                /// Is a scanned image pdf available either as public domain or for purchase. (In LITE projection.)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("isAvailable")]
                public virtual System.Nullable<bool> IsAvailable { get; set; }
            }
        }

        /// <summary>What layers exist in this volume and high level information about them.</summary>
        public class LayerInfoData
        {
            /// <summary>A layer should appear here if and only if the layer exists for this book.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("layers")]
            public virtual System.Collections.Generic.IList<LayersData> Layers { get; set; }

            /// <summary>A layer should appear here if and only if the layer exists for this book.</summary>
            public class LayersData
            {
                /// <summary>The layer id of this layer (e.g. "geo").</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
                public virtual string LayerId { get; set; }

                /// <summary>
                /// The current version of this layer's volume annotations. Note that this version applies only to the
                /// data in the books.layers.volumeAnnotations.* responses. The actual annotation data is versioned
                /// separately.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("volumeAnnotationsVersion")]
                public virtual string VolumeAnnotationsVersion { get; set; }
            }
        }

        /// <summary>Recommendation related information for this volume.</summary>
        public class RecommendedInfoData
        {
            /// <summary>A text explaining why this volume is recommended.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
            public virtual string Explanation { get; set; }
        }

        /// <summary>
        /// Any information about a volume related to the eBookstore and/or purchaseability. This information can depend
        /// on the country where the request originates from (i.e. books may not be for sale in certain countries).
        /// </summary>
        public class SaleInfoData
        {
            /// <summary>URL to purchase this volume on the Google Books site. (In LITE projection)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("buyLink")]
            public virtual string BuyLink { get; set; }

            /// <summary>
            /// The two-letter ISO_3166-1 country code for which this sale information is valid. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("country")]
            public virtual string Country { get; set; }

            /// <summary>Whether or not this volume is an eBook (can be added to the My eBooks shelf).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isEbook")]
            public virtual System.Nullable<bool> IsEbook { get; set; }

            /// <summary>Suggested retail price. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("listPrice")]
            public virtual ListPriceData ListPrice { get; set; }

            /// <summary>Offers available for this volume (sales and rentals).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("offers")]
            public virtual System.Collections.Generic.IList<OffersData> Offers { get; set; }

            /// <summary>The date on which this book is available for sale.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("onSaleDate")]
            public virtual string OnSaleDate { get; set; }

            /// <summary>
            /// The actual selling price of the book. This is the same as the suggested retail or list price unless
            /// there are offers or discounts on this volume. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("retailPrice")]
            public virtual RetailPriceData RetailPrice { get; set; }

            /// <summary>
            /// Whether or not this book is available for sale or offered for free in the Google eBookstore for the
            /// country listed above. Possible values are FOR_SALE, FOR_RENTAL_ONLY, FOR_SALE_AND_RENTAL, FREE,
            /// NOT_FOR_SALE, or FOR_PREORDER.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("saleability")]
            public virtual string Saleability { get; set; }

            /// <summary>Suggested retail price. (In LITE projection.)</summary>
            public class ListPriceData
            {
                /// <summary>Amount in the currency listed below. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("amount")]
                public virtual System.Nullable<double> Amount { get; set; }

                /// <summary>An ISO 4217, three-letter currency code. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                public virtual string CurrencyCode { get; set; }
            }

            /// <summary>Offers available for this volume (sales and rentals).</summary>
            public class OffersData
            {
                /// <summary>The finsky offer type (e.g., PURCHASE=0 RENTAL=3)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("finskyOfferType")]
                public virtual System.Nullable<int> FinskyOfferType { get; set; }

                /// <summary>Indicates whether the offer is giftable.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("giftable")]
                public virtual System.Nullable<bool> Giftable { get; set; }

                /// <summary>Offer list (=undiscounted) price in Micros.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("listPrice")]
                public virtual ListPriceData ListPrice { get; set; }

                /// <summary>The rental duration (for rental offers only).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("rentalDuration")]
                public virtual RentalDurationData RentalDuration { get; set; }

                /// <summary>Offer retail (=discounted) price in Micros</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("retailPrice")]
                public virtual RetailPriceData RetailPrice { get; set; }

                /// <summary>Offer list (=undiscounted) price in Micros.</summary>
                public class ListPriceData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("amountInMicros")]
                    public virtual System.Nullable<double> AmountInMicros { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                    public virtual string CurrencyCode { get; set; }
                }

                /// <summary>The rental duration (for rental offers only).</summary>
                public class RentalDurationData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("count")]
                    public virtual System.Nullable<double> Count { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("unit")]
                    public virtual string Unit { get; set; }
                }

                /// <summary>Offer retail (=discounted) price in Micros</summary>
                public class RetailPriceData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("amountInMicros")]
                    public virtual System.Nullable<double> AmountInMicros { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                    public virtual string CurrencyCode { get; set; }
                }
            }

            /// <summary>
            /// The actual selling price of the book. This is the same as the suggested retail or list price unless
            /// there are offers or discounts on this volume. (In LITE projection.)
            /// </summary>
            public class RetailPriceData
            {
                /// <summary>Amount in the currency listed below. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("amount")]
                public virtual System.Nullable<double> Amount { get; set; }

                /// <summary>An ISO 4217, three-letter currency code. (In LITE projection.)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
                public virtual string CurrencyCode { get; set; }
            }
        }

        /// <summary>Search result information related to this volume.</summary>
        public class SearchInfoData
        {
            /// <summary>A text snippet containing the search query.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("textSnippet")]
            public virtual string TextSnippet { get; set; }
        }

        /// <summary>
        /// User specific information related to this volume. (e.g. page this user last read or whether they purchased
        /// this book)
        /// </summary>
        public class UserInfoData
        {
            /// <summary>
            /// Timestamp when this volume was acquired by the user. (RFC 3339 UTC date-time format) Acquiring includes
            /// purchase, user upload, receiving family sharing, etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("acquiredTime")]
            public virtual string AcquiredTime { get; set; }

            /// <summary>How this volume was acquired.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("acquisitionType")]
            public virtual System.Nullable<int> AcquisitionType { get; set; }

            /// <summary>Copy/Paste accounting information.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("copy")]
            public virtual CopyData Copy { get; set; }

            /// <summary>Whether this volume is purchased, sample, pd download etc.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entitlementType")]
            public virtual System.Nullable<int> EntitlementType { get; set; }

            /// <summary>Information on the ability to share with the family.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("familySharing")]
            public virtual FamilySharingData FamilySharing { get; set; }

            /// <summary>Whether or not the user shared this volume with the family.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isFamilySharedFromUser")]
            public virtual System.Nullable<bool> IsFamilySharedFromUser { get; set; }

            /// <summary>Whether or not the user received this volume through family sharing.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isFamilySharedToUser")]
            public virtual System.Nullable<bool> IsFamilySharedToUser { get; set; }

            /// <summary>Deprecated: Replaced by familySharing.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isFamilySharingAllowed")]
            public virtual System.Nullable<bool> IsFamilySharingAllowed { get; set; }

            /// <summary>Deprecated: Replaced by familySharing.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isFamilySharingDisabledByFop")]
            public virtual System.Nullable<bool> IsFamilySharingDisabledByFop { get; set; }

            /// <summary>Whether or not this volume is currently in "my books."</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isInMyBooks")]
            public virtual System.Nullable<bool> IsInMyBooks { get; set; }

            /// <summary>
            /// Whether or not this volume was pre-ordered by the authenticated user making the request. (In LITE
            /// projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isPreordered")]
            public virtual System.Nullable<bool> IsPreordered { get; set; }

            /// <summary>
            /// Whether or not this volume was purchased by the authenticated user making the request. (In LITE
            /// projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isPurchased")]
            public virtual System.Nullable<bool> IsPurchased { get; set; }

            /// <summary>Whether or not this volume was user uploaded.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isUploaded")]
            public virtual System.Nullable<bool> IsUploaded { get; set; }

            /// <summary>
            /// The user's current reading position in the volume, if one is available. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("readingPosition")]
            public virtual ReadingPosition ReadingPosition { get; set; }

            /// <summary>Period during this book is/was a valid rental.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rentalPeriod")]
            public virtual RentalPeriodData RentalPeriod { get; set; }

            /// <summary>Whether this book is an active or an expired rental.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rentalState")]
            public virtual string RentalState { get; set; }

            /// <summary>This user's review of this volume, if one exists.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("review")]
            public virtual Review Review { get; set; }

            /// <summary>
            /// Timestamp when this volume was last modified by a user action, such as a reading position update, volume
            /// purchase or writing a review. (RFC 3339 UTC date-time format).
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("updated")]
            public virtual string Updated { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("userUploadedVolumeInfo")]
            public virtual UserUploadedVolumeInfoData UserUploadedVolumeInfo { get; set; }

            /// <summary>Copy/Paste accounting information.</summary>
            public class CopyData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("allowedCharacterCount")]
                public virtual System.Nullable<int> AllowedCharacterCount { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("limitType")]
                public virtual string LimitType { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("remainingCharacterCount")]
                public virtual System.Nullable<int> RemainingCharacterCount { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("updated")]
                public virtual string Updated { get; set; }
            }

            /// <summary>Information on the ability to share with the family.</summary>
            public class FamilySharingData
            {
                /// <summary>The role of the user in the family.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("familyRole")]
                public virtual string FamilyRole { get; set; }

                /// <summary>
                /// Whether or not this volume can be shared with the family by the user. This includes sharing
                /// eligibility of both the volume and the user. If the value is true, the user can initiate a family
                /// sharing action.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("isSharingAllowed")]
                public virtual System.Nullable<bool> IsSharingAllowed { get; set; }

                /// <summary>
                /// Whether or not sharing this volume is temporarily disabled due to issues with the Family Wallet.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("isSharingDisabledByFop")]
                public virtual System.Nullable<bool> IsSharingDisabledByFop { get; set; }
            }

            /// <summary>Period during this book is/was a valid rental.</summary>
            public class RentalPeriodData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("endUtcSec")]
                public virtual System.Nullable<long> EndUtcSec { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("startUtcSec")]
                public virtual System.Nullable<long> StartUtcSec { get; set; }
            }

            public class UserUploadedVolumeInfoData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("processingState")]
                public virtual string ProcessingState { get; set; }
            }
        }

        /// <summary>General volume information.</summary>
        public class VolumeInfoData
        {
            /// <summary>Whether anonymous logging should be allowed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("allowAnonLogging")]
            public virtual System.Nullable<bool> AllowAnonLogging { get; set; }

            /// <summary>The names of the authors and/or editors for this volume. (In LITE projection)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("authors")]
            public virtual System.Collections.Generic.IList<string> Authors { get; set; }

            /// <summary>The mean review rating for this volume. (min = 1.0, max = 5.0)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("averageRating")]
            public virtual System.Nullable<double> AverageRating { get; set; }

            /// <summary>Canonical URL for a volume. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("canonicalVolumeLink")]
            public virtual string CanonicalVolumeLink { get; set; }

            /// <summary>A list of subject categories, such as "Fiction", "Suspense", etc.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("categories")]
            public virtual System.Collections.Generic.IList<string> Categories { get; set; }

            /// <summary>Whether the volume has comics content.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comicsContent")]
            public virtual System.Nullable<bool> ComicsContent { get; set; }

            /// <summary>
            /// An identifier for the version of the volume content (text &amp;amp; images). (In LITE projection)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contentVersion")]
            public virtual string ContentVersion { get; set; }

            /// <summary>
            /// A synopsis of the volume. The text of the description is formatted in HTML and includes simple
            /// formatting elements, such as b, i, and br tags. (In LITE projection.)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; }

            /// <summary>Physical dimensions of this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
            public virtual DimensionsData Dimensions { get; set; }

            /// <summary>A list of image links for all the sizes that are available. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("imageLinks")]
            public virtual ImageLinksData ImageLinks { get; set; }

            /// <summary>Industry standard identifiers for this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("industryIdentifiers")]
            public virtual System.Collections.Generic.IList<IndustryIdentifiersData> IndustryIdentifiers { get; set; }

            /// <summary>
            /// URL to view information about this volume on the Google Books site. (In LITE projection)
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("infoLink")]
            public virtual string InfoLink { get; set; }

            /// <summary>
            /// Best language for this volume (based on content). It is the two-letter ISO 639-1 code such as 'fr',
            /// 'en', etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language { get; set; }

            /// <summary>
            /// The main category to which this volume belongs. It will be the category from the categories list
            /// returned below that has the highest weight.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mainCategory")]
            public virtual string MainCategory { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("maturityRating")]
            public virtual string MaturityRating { get; set; }

            /// <summary>Total number of pages as per publisher metadata.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("pageCount")]
            public virtual System.Nullable<int> PageCount { get; set; }

            /// <summary>A top-level summary of the panelization info in this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("panelizationSummary")]
            public virtual PanelizationSummaryData PanelizationSummary { get; set; }

            /// <summary>URL to preview this volume on the Google Books site.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("previewLink")]
            public virtual string PreviewLink { get; set; }

            /// <summary>Type of publication of this volume. Possible values are BOOK or MAGAZINE.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("printType")]
            public virtual string PrintType { get; set; }

            /// <summary>Total number of printed pages in generated pdf representation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("printedPageCount")]
            public virtual System.Nullable<int> PrintedPageCount { get; set; }

            /// <summary>Date of publication. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("publishedDate")]
            public virtual string PublishedDate { get; set; }

            /// <summary>Publisher of this volume. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
            public virtual string Publisher { get; set; }

            /// <summary>The number of review ratings for this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ratingsCount")]
            public virtual System.Nullable<int> RatingsCount { get; set; }

            /// <summary>The reading modes available for this volume.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("readingModes")]
            public virtual ReadingModesData ReadingModes { get; set; }

            /// <summary>Total number of sample pages as per publisher metadata.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("samplePageCount")]
            public virtual System.Nullable<int> SamplePageCount { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("seriesInfo")]
            public virtual Volumeseriesinfo SeriesInfo { get; set; }

            /// <summary>Volume subtitle. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
            public virtual string Subtitle { get; set; }

            /// <summary>Volume title. (In LITE projection.)</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }

            /// <summary>Physical dimensions of this volume.</summary>
            public class DimensionsData
            {
                /// <summary>Height or length of this volume (in cm).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual string Height { get; set; }

                /// <summary>Thickness of this volume (in cm).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("thickness")]
                public virtual string Thickness { get; set; }

                /// <summary>Width of this volume (in cm).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual string Width { get; set; }
            }

            /// <summary>A list of image links for all the sizes that are available. (In LITE projection.)</summary>
            public class ImageLinksData
            {
                /// <summary>Image link for extra large size (width of ~1280 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("extraLarge")]
                public virtual string ExtraLarge { get; set; }

                /// <summary>Image link for large size (width of ~800 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("large")]
                public virtual string Large { get; set; }

                /// <summary>Image link for medium size (width of ~575 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("medium")]
                public virtual string Medium { get; set; }

                /// <summary>Image link for small size (width of ~300 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("small")]
                public virtual string Small { get; set; }

                /// <summary>Image link for small thumbnail size (width of ~80 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("smallThumbnail")]
                public virtual string SmallThumbnail { get; set; }

                /// <summary>Image link for thumbnail size (width of ~128 pixels). (In LITE projection)</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
                public virtual string Thumbnail { get; set; }
            }

            /// <summary>Industry standard identifiers for this volume.</summary>
            public class IndustryIdentifiersData
            {
                /// <summary>Industry specific volume identifier.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
                public virtual string Identifier { get; set; }

                /// <summary>Identifier type. Possible values are ISBN_10, ISBN_13, ISSN and OTHER.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                public virtual string Type { get; set; }
            }

            /// <summary>A top-level summary of the panelization info in this volume.</summary>
            public class PanelizationSummaryData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("containsEpubBubbles")]
                public virtual System.Nullable<bool> ContainsEpubBubbles { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("containsImageBubbles")]
                public virtual System.Nullable<bool> ContainsImageBubbles { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("epubBubbleVersion")]
                public virtual string EpubBubbleVersion { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("imageBubbleVersion")]
                public virtual string ImageBubbleVersion { get; set; }
            }

            /// <summary>The reading modes available for this volume.</summary>
            public class ReadingModesData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("image")]
                public virtual System.Nullable<bool> Image { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("text")]
                public virtual System.Nullable<bool> Text { get; set; }
            }
        }
    }

    public class Volume2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Volume> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Volumeannotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The annotation data id for this volume annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationDataId")]
        public virtual string AnnotationDataId { get; set; }

        /// <summary>Link to get data for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationDataLink")]
        public virtual string AnnotationDataLink { get; set; }

        /// <summary>The type of annotation this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationType")]
        public virtual string AnnotationType { get; set; }

        /// <summary>The content ranges to identify the selected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRanges")]
        public virtual ContentRangesData ContentRanges { get; set; }

        /// <summary>Data for this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Indicates that this annotation is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Unique id of this volume annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Resource Type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The Layer this annotation is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerId")]
        public virtual string LayerId { get; set; }

        /// <summary>Pages the annotation spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageIds")]
        public virtual System.Collections.Generic.IList<string> PageIds { get; set; }

        /// <summary>Excerpt from the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedText")]
        public virtual string SelectedText { get; set; }

        /// <summary>URL to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Timestamp for the last time this anntoation was updated. (RFC 3339 UTC date-time format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The Volume this annotation is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The content ranges to identify the selected text.</summary>
        public class ContentRangesData
        {
            /// <summary>Range in CFI format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cfiRange")]
            public virtual BooksAnnotationsRange CfiRange { get; set; }

            /// <summary>Content version applicable to ranges below.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contentVersion")]
            public virtual string ContentVersion { get; set; }

            /// <summary>Range in GB image format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbImageRange")]
            public virtual BooksAnnotationsRange GbImageRange { get; set; }

            /// <summary>Range in GB text format for this annotation for version above.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("gbTextRange")]
            public virtual BooksAnnotationsRange GbTextRange { get; set; }
        }
    }

    public class Volumeannotations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of volume annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Volumeannotation> Items { get; set; }

        /// <summary>Resource type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token to pass in for pagination for the next page. This will not be present if this request does not have
        /// more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of volume annotations found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>
        /// The version string for all of the volume annotations in this layer (not just the ones in this response).
        /// Note: the version string doesn't apply to the annotation data, just the information in this response (e.g.
        /// the location of annotations in the book).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Volumes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Volume> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Total number of volumes found. This might be greater than the number of volumes returned in this response if
        /// results have been paginated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Volumeseriesinfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display number string. This should be used only for display purposes and the actual sequence should be
        /// inferred from the below orderNumber.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bookDisplayNumber")]
        public virtual string BookDisplayNumber { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Short book title in the context of the series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortSeriesBookTitle")]
        public virtual string ShortSeriesBookTitle { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeSeries")]
        public virtual System.Collections.Generic.IList<VolumeSeriesData> VolumeSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class VolumeSeriesData
        {
            /// <summary>List of issues. Applicable only for Collection Edition and Omnibus.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("issue")]
            public virtual System.Collections.Generic.IList<IssueData> Issue { get; set; }

            /// <summary>The book order number in the series.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("orderNumber")]
            public virtual System.Nullable<int> OrderNumber { get; set; }

            /// <summary>
            /// The book type in the context of series. Examples - Single Issue, Collection Edition, etc.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("seriesBookType")]
            public virtual string SeriesBookType { get; set; }

            /// <summary>The series id.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("seriesId")]
            public virtual string SeriesId { get; set; }

            /// <summary>List of issues. Applicable only for Collection Edition and Omnibus.</summary>
            public class IssueData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("issueDisplayNumber")]
                public virtual string IssueDisplayNumber { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("issueOrderNumber")]
                public virtual System.Nullable<int> IssueOrderNumber { get; set; }
            }
        }
    }
}
