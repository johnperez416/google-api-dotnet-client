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

namespace Google.Apis.StreetViewPublish.v1
{
    /// <summary>The StreetViewPublish Service.</summary>
    public class StreetViewPublishService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public StreetViewPublishService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public StreetViewPublishService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Photo = new PhotoResource(this);
            PhotoSequence = new PhotoSequenceResource(this);
            PhotoSequences = new PhotoSequencesResource(this);
            Photos = new PhotosResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://streetviewpublish.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://streetviewpublish.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "streetviewpublish";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Street View Publish API.</summary>
        public class Scope
        {
            /// <summary>Publish and manage your 360 photos on Google Street View</summary>
            public static string Streetviewpublish = "https://www.googleapis.com/auth/streetviewpublish";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Street View Publish API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Publish and manage your 360 photos on Google Street View</summary>
            public const string Streetviewpublish = "https://www.googleapis.com/auth/streetviewpublish";
        }

        /// <summary>Gets the Photo resource.</summary>
        public virtual PhotoResource Photo { get; }

        /// <summary>Gets the PhotoSequence resource.</summary>
        public virtual PhotoSequenceResource PhotoSequence { get; }

        /// <summary>Gets the PhotoSequences resource.</summary>
        public virtual PhotoSequencesResource PhotoSequences { get; }

        /// <summary>Gets the Photos resource.</summary>
        public virtual PhotosResource Photos { get; }
    }

    /// <summary>A base abstract class for StreetViewPublish requests.</summary>
    public abstract class StreetViewPublishBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new StreetViewPublishBaseServiceRequest instance.</summary>
        protected StreetViewPublishBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes StreetViewPublish parameter list.</summary>
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

    /// <summary>The "photo" collection of methods.</summary>
    public class PhotoResource
    {
        private const string Resource = "photo";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PhotoResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// After the client finishes uploading the photo with the returned UploadRef, CreatePhoto publishes the
        /// uploaded Photo to Street View on Google Maps. Currently, the only way to set heading, pitch, and roll in
        /// CreatePhoto is through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in the photo bytes. CreatePhoto
        /// ignores the `pose.heading`, `pose.pitch`, `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// This method returns the following error codes: * google.rpc.Code.INVALID_ARGUMENT if the request is
        /// malformed or if the uploaded photo is not a 360 photo. * google.rpc.Code.NOT_FOUND if the upload reference
        /// does not exist. * google.rpc.Code.RESOURCE_EXHAUSTED if the account has reached the storage limit.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.StreetViewPublish.v1.Data.Photo body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// After the client finishes uploading the photo with the returned UploadRef, CreatePhoto publishes the
        /// uploaded Photo to Street View on Google Maps. Currently, the only way to set heading, pitch, and roll in
        /// CreatePhoto is through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in the photo bytes. CreatePhoto
        /// ignores the `pose.heading`, `pose.pitch`, `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// This method returns the following error codes: * google.rpc.Code.INVALID_ARGUMENT if the request is
        /// malformed or if the uploaded photo is not a 360 photo. * google.rpc.Code.NOT_FOUND if the upload reference
        /// does not exist. * google.rpc.Code.RESOURCE_EXHAUSTED if the account has reached the storage limit.
        /// </summary>
        public class CreateRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Photo>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.Photo body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.Photo Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photo";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes a Photo and its metadata. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo. *
        /// google.rpc.Code.NOT_FOUND if the photo ID does not exist.
        /// </summary>
        /// <param name="photoId">Required. ID of the Photo.</param>
        public virtual DeleteRequest Delete(string photoId)
        {
            return new DeleteRequest(this.service, photoId);
        }

        /// <summary>
        /// Deletes a Photo and its metadata. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo. *
        /// google.rpc.Code.NOT_FOUND if the photo ID does not exist.
        /// </summary>
        public class DeleteRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string photoId) : base(service)
            {
                PhotoId = photoId;
                InitParameters();
            }

            /// <summary>Required. ID of the Photo.</summary>
            [Google.Apis.Util.RequestParameterAttribute("photoId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PhotoId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photo/{photoId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("photoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "photoId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the metadata of the specified Photo. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested Photo. *
        /// google.rpc.Code.NOT_FOUND if the requested Photo does not exist. * google.rpc.Code.UNAVAILABLE if the
        /// requested Photo is still being indexed.
        /// </summary>
        /// <param name="photoId">Required. ID of the Photo.</param>
        public virtual GetRequest Get(string photoId)
        {
            return new GetRequest(this.service, photoId);
        }

        /// <summary>
        /// Gets the metadata of the specified Photo. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested Photo. *
        /// google.rpc.Code.NOT_FOUND if the requested Photo does not exist. * google.rpc.Code.UNAVAILABLE if the
        /// requested Photo is still being indexed.
        /// </summary>
        public class GetRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Photo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string photoId) : base(service)
            {
                PhotoId = photoId;
                InitParameters();
            }

            /// <summary>Required. ID of the Photo.</summary>
            [Google.Apis.Util.RequestParameterAttribute("photoId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PhotoId { get; private set; }

            /// <summary>
            /// The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
            /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. If language_code is unspecified, the
            /// user's language preference for Google services is used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photo bytes should be returned in the Photo response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photo bytes should be returned in the Photo response.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>
                /// Server responses do not include the download URL for the photo bytes. The default value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Server responses include the download URL for the photo bytes.</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_DOWNLOAD_URL")]
                INCLUDEDOWNLOADURL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photo/{photoId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("photoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "photoId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses the upload URL of the returned
        /// UploadRef to upload the bytes for the Photo. In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?ref_topic=6275604, the photo must meet the following
        /// requirements: * Photo Sphere XMP metadata must be included in the photo metadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the required fields. * The pixel size of the
        /// photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?ref_topic=6275604, and the photo must be a full 360
        /// horizontally. After the upload completes, the method uses UploadRef with CreatePhoto to create the Photo
        /// object entry.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual StartUploadRequest StartUpload(Google.Apis.StreetViewPublish.v1.Data.Empty body)
        {
            return new StartUploadRequest(this.service, body);
        }

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses the upload URL of the returned
        /// UploadRef to upload the bytes for the Photo. In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?ref_topic=6275604, the photo must meet the following
        /// requirements: * Photo Sphere XMP metadata must be included in the photo metadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the required fields. * The pixel size of the
        /// photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?ref_topic=6275604, and the photo must be a full 360
        /// horizontally. After the upload completes, the method uses UploadRef with CreatePhoto to create the Photo
        /// object entry.
        /// </summary>
        public class StartUploadRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.UploadRef>
        {
            /// <summary>Constructs a new StartUpload request.</summary>
            public StartUploadRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.Empty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.Empty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "startUpload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photo:startUpload";

            /// <summary>Initializes StartUpload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Updates the metadata of a Photo, such as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported. Only the fields specified in the updateMask field are used. If `updateMask` is not
        /// present, the update applies to all fields. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo. *
        /// google.rpc.Code.INVALID_ARGUMENT if the request is malformed. * google.rpc.Code.NOT_FOUND if the requested
        /// photo does not exist. * google.rpc.Code.UNAVAILABLE if the requested Photo is still being indexed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">A unique identifier for a photo.</param>
        public virtual UpdateRequest Update(Google.Apis.StreetViewPublish.v1.Data.Photo body, string id)
        {
            return new UpdateRequest(this.service, body, id);
        }

        /// <summary>
        /// Updates the metadata of a Photo, such as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported. Only the fields specified in the updateMask field are used. If `updateMask` is not
        /// present, the update applies to all fields. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo. *
        /// google.rpc.Code.INVALID_ARGUMENT if the request is malformed. * google.rpc.Code.NOT_FOUND if the requested
        /// photo does not exist. * google.rpc.Code.UNAVAILABLE if the requested Photo is still being indexed.
        /// </summary>
        public class UpdateRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Photo>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.Photo body, string id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>A unique identifier for a photo.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// Required. Mask that identifies fields on the photo metadata to update. If not present, the old Photo
            /// metadata is entirely replaced with the new Photo metadata in this request. The update fails if invalid
            /// fields are specified. Multiple fields can be specified in a comma-delimited list. The following fields
            /// are valid: * `pose.heading` * `pose.lat_lng_pair` * `pose.pitch` * `pose.roll` * `pose.level` *
            /// `pose.altitude` * `connections` * `places` &amp;gt; Note: When updateMask contains repeated fields, the
            /// entire set of repeated values get replaced with the new contents. For example, if updateMask contains
            /// `connections` and `UpdatePhotoRequest.photo.connections` is empty, all connections are removed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.Photo Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photo/{id}";

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
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "photoSequence" collection of methods.</summary>
    public class PhotoSequenceResource
    {
        private const string Resource = "photoSequence";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PhotoSequenceResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// After the client finishes uploading the PhotoSequence with the returned UploadRef, CreatePhotoSequence
        /// extracts a sequence of 360 photos from a video or Extensible Device Metadata (XDM, http://www.xdm.org/) to
        /// be published to Street View on Google Maps. `CreatePhotoSequence` returns an Operation, with the
        /// PhotoSequence Id set in the `Operation.name` field. This method returns the following error codes: *
        /// google.rpc.Code.INVALID_ARGUMENT if the request is malformed. * google.rpc.Code.NOT_FOUND if the upload
        /// reference does not exist.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.StreetViewPublish.v1.Data.PhotoSequence body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// After the client finishes uploading the PhotoSequence with the returned UploadRef, CreatePhotoSequence
        /// extracts a sequence of 360 photos from a video or Extensible Device Metadata (XDM, http://www.xdm.org/) to
        /// be published to Street View on Google Maps. `CreatePhotoSequence` returns an Operation, with the
        /// PhotoSequence Id set in the `Operation.name` field. This method returns the following error codes: *
        /// google.rpc.Code.INVALID_ARGUMENT if the request is malformed. * google.rpc.Code.NOT_FOUND if the upload
        /// reference does not exist.
        /// </summary>
        public class CreateRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.PhotoSequence body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The input form of PhotoSequence.</summary>
            [Google.Apis.Util.RequestParameterAttribute("inputType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<InputTypeEnum> InputType { get; set; }

            /// <summary>Required. The input form of PhotoSequence.</summary>
            public enum InputTypeEnum
            {
                /// <summary>Not specified. Server will return google.rpc.Code.INVALID_ARGUMENT.</summary>
                [Google.Apis.Util.StringValueAttribute("INPUT_TYPE_UNSPECIFIED")]
                INPUTTYPEUNSPECIFIED = 0,

                /// <summary>360 Video.</summary>
                [Google.Apis.Util.StringValueAttribute("VIDEO")]
                VIDEO = 1,

                /// <summary>Extensible Device Metadata, http://www.xdm.org</summary>
                [Google.Apis.Util.StringValueAttribute("XDM")]
                XDM = 2,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.PhotoSequence Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photoSequence";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("inputType", new Google.Apis.Discovery.Parameter
                {
                    Name = "inputType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a PhotoSequence and its metadata. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo sequence. *
        /// google.rpc.Code.NOT_FOUND if the photo sequence ID does not exist. * google.rpc.Code.FAILED_PRECONDITION if
        /// the photo sequence ID is not yet finished processing.
        /// </summary>
        /// <param name="sequenceId">Required. ID of the PhotoSequence.</param>
        public virtual DeleteRequest Delete(string sequenceId)
        {
            return new DeleteRequest(this.service, sequenceId);
        }

        /// <summary>
        /// Deletes a PhotoSequence and its metadata. This method returns the following error codes: *
        /// google.rpc.Code.PERMISSION_DENIED if the requesting user did not create the requested photo sequence. *
        /// google.rpc.Code.NOT_FOUND if the photo sequence ID does not exist. * google.rpc.Code.FAILED_PRECONDITION if
        /// the photo sequence ID is not yet finished processing.
        /// </summary>
        public class DeleteRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string sequenceId) : base(service)
            {
                SequenceId = sequenceId;
                InitParameters();
            }

            /// <summary>Required. ID of the PhotoSequence.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sequenceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SequenceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photoSequence/{sequenceId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sequenceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "sequenceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the metadata of the specified PhotoSequence via the Operation interface. This method returns the
        /// following three types of responses: * `Operation.done` = false, if the processing of PhotoSequence is not
        /// finished yet. * `Operation.done` = true and `Operation.error` is populated, if there was an error in
        /// processing. * `Operation.done` = true and `Operation.response` is poulated, which contains a PhotoSequence
        /// message. This method returns the following error codes: * google.rpc.Code.PERMISSION_DENIED if the
        /// requesting user did not create the requested PhotoSequence. * google.rpc.Code.NOT_FOUND if the requested
        /// PhotoSequence does not exist.
        /// </summary>
        /// <param name="sequenceId">Required. ID of the photo sequence.</param>
        public virtual GetRequest Get(string sequenceId)
        {
            return new GetRequest(this.service, sequenceId);
        }

        /// <summary>
        /// Gets the metadata of the specified PhotoSequence via the Operation interface. This method returns the
        /// following three types of responses: * `Operation.done` = false, if the processing of PhotoSequence is not
        /// finished yet. * `Operation.done` = true and `Operation.error` is populated, if there was an error in
        /// processing. * `Operation.done` = true and `Operation.response` is poulated, which contains a PhotoSequence
        /// message. This method returns the following error codes: * google.rpc.Code.PERMISSION_DENIED if the
        /// requesting user did not create the requested PhotoSequence. * google.rpc.Code.NOT_FOUND if the requested
        /// PhotoSequence does not exist.
        /// </summary>
        public class GetRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string sequenceId) : base(service)
            {
                SequenceId = sequenceId;
                InitParameters();
            }

            /// <summary>Required. ID of the photo sequence.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sequenceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SequenceId { get; private set; }

            /// <summary>
            /// Optional. The filter expression. For example: `published_status=PUBLISHED`. The filters supported are:
            /// `published_status`. See https://google.aip.dev/160 for more information.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Specifies if a download URL for the photo sequence should be returned in `download_url` of individual
            /// photos in the PhotoSequence response. &amp;gt; Note: Currently not implemented.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Specifies if a download URL for the photo sequence should be returned in `download_url` of individual
            /// photos in the PhotoSequence response. &amp;gt; Note: Currently not implemented.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>
                /// Server responses do not include the download URL for the photo bytes. The default value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Server responses include the download URL for the photo bytes.</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_DOWNLOAD_URL")]
                INCLUDEDOWNLOADURL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photoSequence/{sequenceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sequenceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "sequenceId",
                    IsRequired = true,
                    ParameterType = "path",
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
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates an upload session to start uploading photo sequence data. The upload URL of the returned UploadRef
        /// is used to upload the data for the `photoSequence`. After the upload is complete, the UploadRef is used with
        /// CreatePhotoSequence to create the PhotoSequence object entry.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual StartUploadRequest StartUpload(Google.Apis.StreetViewPublish.v1.Data.Empty body)
        {
            return new StartUploadRequest(this.service, body);
        }

        /// <summary>
        /// Creates an upload session to start uploading photo sequence data. The upload URL of the returned UploadRef
        /// is used to upload the data for the `photoSequence`. After the upload is complete, the UploadRef is used with
        /// CreatePhotoSequence to create the PhotoSequence object entry.
        /// </summary>
        public class StartUploadRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.UploadRef>
        {
            /// <summary>Constructs a new StartUpload request.</summary>
            public StartUploadRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.Empty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.Empty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "startUpload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photoSequence:startUpload";

            /// <summary>Initializes StartUpload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "photoSequences" collection of methods.</summary>
    public class PhotoSequencesResource
    {
        private const string Resource = "photoSequences";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PhotoSequencesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists all the PhotoSequences that belong to the user, in descending CreatePhotoSequence timestamp order.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists all the PhotoSequences that belong to the user, in descending CreatePhotoSequence timestamp order.
        /// </summary>
        public class ListRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.ListPhotoSequencesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The filter expression. For example: `imagery_type=SPHERICAL`. The filters supported are:
            /// `imagery_type`, `processing_state`, `min_latitude`, `max_latitude`, `min_longitude`, `max_longitude`,
            /// `filename_query`, `min_capture_time_seconds`, `max_capture_time_seconds. See https://google.aip.dev/160
            /// for more information. Filename queries should sent as a Phrase in order to support multiple words and
            /// special characters by adding escaped quotes. Ex: filename_query="example of a phrase.mp4"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of photo sequences to return. `pageSize` must be non-negative. If
            /// `pageSize` is zero or is not provided, the default page size of 100 is used. The number of photo
            /// sequences returned in the response may be less than `pageSize` if the number of matches is less than
            /// `pageSize`. This is currently unimplemented but is in process.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. The nextPageToken value returned from a previous ListPhotoSequences request, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photoSequences";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "photos" collection of methods.</summary>
    public class PhotosResource
    {
        private const string Resource = "photos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PhotosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes a list of Photos and their metadata. Note that if BatchDeletePhotos fails, either critical fields
        /// are missing or there is an authentication error. Even if BatchDeletePhotos succeeds, individual photos in
        /// the batch may have failures. These failures are specified in each PhotoResponse.status in
        /// BatchDeletePhotosResponse.results. See DeletePhoto for specific failures that can occur per photo.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchDeleteRequest BatchDelete(Google.Apis.StreetViewPublish.v1.Data.BatchDeletePhotosRequest body)
        {
            return new BatchDeleteRequest(this.service, body);
        }

        /// <summary>
        /// Deletes a list of Photos and their metadata. Note that if BatchDeletePhotos fails, either critical fields
        /// are missing or there is an authentication error. Even if BatchDeletePhotos succeeds, individual photos in
        /// the batch may have failures. These failures are specified in each PhotoResponse.status in
        /// BatchDeletePhotosResponse.results. See DeletePhoto for specific failures that can occur per photo.
        /// </summary>
        public class BatchDeleteRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.BatchDeletePhotosResponse>
        {
            /// <summary>Constructs a new BatchDelete request.</summary>
            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.BatchDeletePhotosRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.BatchDeletePhotosRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchDelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photos:batchDelete";

            /// <summary>Initializes BatchDelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Gets the metadata of the specified Photo batch. Note that if BatchGetPhotos fails, either critical fields
        /// are missing or there is an authentication error. Even if BatchGetPhotos succeeds, individual photos in the
        /// batch may have failures. These failures are specified in each PhotoResponse.status in
        /// BatchGetPhotosResponse.results. See GetPhoto for specific failures that can occur per photo.
        /// </summary>
        public virtual BatchGetRequest BatchGet()
        {
            return new BatchGetRequest(this.service);
        }

        /// <summary>
        /// Gets the metadata of the specified Photo batch. Note that if BatchGetPhotos fails, either critical fields
        /// are missing or there is an authentication error. Even if BatchGetPhotos succeeds, individual photos in the
        /// batch may have failures. These failures are specified in each PhotoResponse.status in
        /// BatchGetPhotosResponse.results. See GetPhoto for specific failures that can occur per photo.
        /// </summary>
        public class BatchGetRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.BatchGetPhotosResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
            /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. If language_code is unspecified, the
            /// user's language preference for Google services is used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Required. IDs of the Photos. For HTTP GET requests, the URL query parameter should be
            /// `photoIds=&amp;amp;photoIds=&amp;amp;...`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("photoIds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> PhotoIds { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photo bytes should be returned in the Photo response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photo bytes should be returned in the Photo response.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>
                /// Server responses do not include the download URL for the photo bytes. The default value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Server responses include the download URL for the photo bytes.</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_DOWNLOAD_URL")]
                INCLUDEDOWNLOADURL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photos:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("photoIds", new Google.Apis.Discovery.Parameter
                {
                    Name = "photoIds",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the metadata of Photos, such as pose, place association, connections, etc. Changing the pixels of
        /// photos is not supported. Note that if BatchUpdatePhotos fails, either critical fields are missing or there
        /// is an authentication error. Even if BatchUpdatePhotos succeeds, individual photos in the batch may have
        /// failures. These failures are specified in each PhotoResponse.status in BatchUpdatePhotosResponse.results.
        /// See UpdatePhoto for specific failures that can occur per photo. Only the fields specified in updateMask
        /// field are used. If `updateMask` is not present, the update applies to all fields. The number of
        /// UpdatePhotoRequest messages in a BatchUpdatePhotosRequest must not exceed 20. &amp;gt; Note: To update
        /// Pose.altitude, Pose.latLngPair has to be filled as well. Otherwise, the request will fail.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.StreetViewPublish.v1.Data.BatchUpdatePhotosRequest body)
        {
            return new BatchUpdateRequest(this.service, body);
        }

        /// <summary>
        /// Updates the metadata of Photos, such as pose, place association, connections, etc. Changing the pixels of
        /// photos is not supported. Note that if BatchUpdatePhotos fails, either critical fields are missing or there
        /// is an authentication error. Even if BatchUpdatePhotos succeeds, individual photos in the batch may have
        /// failures. These failures are specified in each PhotoResponse.status in BatchUpdatePhotosResponse.results.
        /// See UpdatePhoto for specific failures that can occur per photo. Only the fields specified in updateMask
        /// field are used. If `updateMask` is not present, the update applies to all fields. The number of
        /// UpdatePhotoRequest messages in a BatchUpdatePhotosRequest must not exceed 20. &amp;gt; Note: To update
        /// Pose.altitude, Pose.latLngPair has to be filled as well. Otherwise, the request will fail.
        /// </summary>
        public class BatchUpdateRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.BatchUpdatePhotosResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.StreetViewPublish.v1.Data.BatchUpdatePhotosRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.StreetViewPublish.v1.Data.BatchUpdatePhotosRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photos:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Lists all the Photos that belong to the user. &amp;gt; Note: Recently created photos that are still being
        /// indexed are not returned in the response.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists all the Photos that belong to the user. &amp;gt; Note: Recently created photos that are still being
        /// indexed are not returned in the response.
        /// </summary>
        public class ListRequest : StreetViewPublishBaseServiceRequest<Google.Apis.StreetViewPublish.v1.Data.ListPhotosResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`. The filters
            /// supported are: `placeId`, `min_latitude`, `max_latitude`, `min_longitude`, `max_longitude`. See
            /// https://google.aip.dev/160 for more information.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
            /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. If language_code is unspecified, the
            /// user's language preference for Google services is used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. The maximum number of photos to return. `pageSize` must be non-negative. If `pageSize` is zero
            /// or is not provided, the default page size of 100 is used. The number of photos returned in the response
            /// may be less than `pageSize` if the number of photos that belong to the user is less than `pageSize`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. The nextPageToken value returned from a previous ListPhotos request, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photos bytes should be returned in the Photos response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Required. Specifies if a download URL for the photos bytes should be returned in the Photos response.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>
                /// Server responses do not include the download URL for the photo bytes. The default value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Server responses include the download URL for the photo bytes.</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_DOWNLOAD_URL")]
                INCLUDEDOWNLOADURL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/photos";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.StreetViewPublish.v1.Data
{
    /// <summary>Request to delete multiple Photos.</summary>
    public class BatchDeletePhotosRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. IDs of the Photos. HTTP GET requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;amp;photoIds=&amp;amp;...`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoIds")]
        public virtual System.Collections.Generic.IList<string> PhotoIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to batch delete of one or more Photos.</summary>
    public class BatchDeletePhotosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status for the operation to delete a single Photo in the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Collections.Generic.IList<Status> Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to batch get of Photos.</summary>
    public class BatchGetPhotosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of results for each individual Photo requested, in the same order as the requests in BatchGetPhotos.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<PhotoResponse> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update the metadata of photos. Updating the pixels of photos is not supported.</summary>
    public class BatchUpdatePhotosRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of UpdatePhotoRequests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePhotoRequests")]
        public virtual System.Collections.Generic.IList<UpdatePhotoRequest> UpdatePhotoRequests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to batch update of metadata of one or more Photos.</summary>
    public class BatchUpdatePhotosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of results for each individual Photo updated, in the same order as the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<PhotoResponse> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A connection is the link from a source photo to a destination photo.</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The destination of the connection from the containing photo to another photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual PhotoId Target { get; set; }

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
    /// Details related to ProcessingFailureReason#GPS_DATA_GAP. If there are multiple GPS data gaps, only the one with
    /// the largest duration is reported here.
    /// </summary>
    public class GpsDataGapFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of the gap in GPS data that was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gapDuration")]
        public virtual object GapDuration { get; set; }

        /// <summary>Relative time (from the start of the video stream) when the gap started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gapStartTime")]
        public virtual object GapStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IMU data from the device sensors.</summary>
    public class Imu : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accelerometer measurements in meters/sec^2 with increasing timestamps from devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelMpsps")]
        public virtual System.Collections.Generic.IList<Measurement3d> AccelMpsps { get; set; }

        /// <summary>The gyroscope measurements in radians/sec with increasing timestamps from devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gyroRps")]
        public virtual System.Collections.Generic.IList<Measurement3d> GyroRps { get; set; }

        /// <summary>
        /// The magnetometer measurements of the magnetic field in microtesla (uT) with increasing timestamps from
        /// devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magUt")]
        public virtual System.Collections.Generic.IList<Measurement3d> MagUt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details related to ProcessingFailureReason#IMU_DATA_GAP. If there are multiple IMU data gaps, only the one with
    /// the largest duration is reported here.
    /// </summary>
    public class ImuDataGapFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of the gap in IMU data that was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gapDuration")]
        public virtual object GapDuration { get; set; }

        /// <summary>Relative time (from the start of the video stream) when the gap started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gapStartTime")]
        public virtual object GapStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details related to ProcessingFailureReason#INSUFFICIENT_GPS.</summary>
    public class InsufficientGpsFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of GPS points that were found in the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsPointsFound")]
        public virtual System.Nullable<int> GpsPointsFound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rectangle in geographical coordinates.</summary>
    public class LatLngBounds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The northeast corner of these bounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("northeast")]
        public virtual LatLng Northeast { get; set; }

        /// <summary>The southwest corner of these bounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("southwest")]
        public virtual LatLng Southwest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Level information containing level number and its corresponding name.</summary>
    public class Level : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A name assigned to this Level, restricted to 3 characters. Consider how the elevator buttons would
        /// be labeled for this level if there was an elevator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Floor number, used for ordering. 0 indicates the ground level, 1 indicates the first level above
        /// ground level, -1 indicates the first level under ground level. Non-integer values are OK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<double> Number { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list all photo sequences that belong to a user.</summary>
    public class ListPhotoSequencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of photo sequences via Operation interface. The maximum number of items returned is based on the
        /// pageSize field in the request. Each item in the list can have three possible states, * `Operation.done` =
        /// false, if the processing of PhotoSequence is not finished yet. * `Operation.done` = true and
        /// `Operation.error` is populated, if there was an error in processing. * `Operation.done` = true and
        /// `Operation.response` contains a PhotoSequence message, In each sequence, only Id is populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoSequences")]
        public virtual System.Collections.Generic.IList<Operation> PhotoSequences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list all photos that belong to a user.</summary>
    public class ListPhotosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of photos. The pageSize field in the request determines the number of items returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photos")]
        public virtual System.Collections.Generic.IList<Photo> Photos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Generic 3d measurement sample.</summary>
    public class Measurement3d : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _captureTimeRaw;

        private object _captureTime;

        /// <summary>The timestamp of the IMU measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captureTime")]
        public virtual string CaptureTimeRaw
        {
            get => _captureTimeRaw;
            set
            {
                _captureTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _captureTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaptureTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaptureTimeDateTimeOffset instead.")]
        public virtual object CaptureTime
        {
            get => _captureTime;
            set
            {
                _captureTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _captureTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaptureTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaptureTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaptureTimeRaw);
            set => CaptureTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The sensor measurement in the x axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>The sensor measurement in the y axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The sensor measurement in the z axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("z")]
        public virtual System.Nullable<float> Z { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details related to PhotoSequenceProcessingFailureReason#NO_OVERLAP_GPS.</summary>
    public class NoOverlapGpsFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _gpsEndTimeRaw;

        private object _gpsEndTime;

        /// <summary>Time of last recorded GPS point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsEndTime")]
        public virtual string GpsEndTimeRaw
        {
            get => _gpsEndTimeRaw;
            set
            {
                _gpsEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _gpsEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GpsEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GpsEndTimeDateTimeOffset instead.")]
        public virtual object GpsEndTime
        {
            get => _gpsEndTime;
            set
            {
                _gpsEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _gpsEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="GpsEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GpsEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GpsEndTimeRaw);
            set => GpsEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _gpsStartTimeRaw;

        private object _gpsStartTime;

        /// <summary>Time of first recorded GPS point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsStartTime")]
        public virtual string GpsStartTimeRaw
        {
            get => _gpsStartTimeRaw;
            set
            {
                _gpsStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _gpsStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GpsStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GpsStartTimeDateTimeOffset instead.")]
        public virtual object GpsStartTime
        {
            get => _gpsStartTime;
            set
            {
                _gpsStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _gpsStartTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="GpsStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GpsStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GpsStartTimeRaw);
            set => GpsStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _videoEndTimeRaw;

        private object _videoEndTime;

        /// <summary>End time of video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEndTime")]
        public virtual string VideoEndTimeRaw
        {
            get => _videoEndTimeRaw;
            set
            {
                _videoEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _videoEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VideoEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VideoEndTimeDateTimeOffset instead.")]
        public virtual object VideoEndTime
        {
            get => _videoEndTime;
            set
            {
                _videoEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _videoEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VideoEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VideoEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VideoEndTimeRaw);
            set => VideoEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _videoStartTimeRaw;

        private object _videoStartTime;

        /// <summary>Start time of video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoStartTime")]
        public virtual string VideoStartTimeRaw
        {
            get => _videoStartTimeRaw;
            set
            {
                _videoStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _videoStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VideoStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VideoStartTimeDateTimeOffset instead.")]
        public virtual object VideoStartTime
        {
            get => _videoStartTime;
            set
            {
                _videoStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _videoStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="VideoStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VideoStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VideoStartTimeRaw);
            set => VideoStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details related to ProcessingFailureReason#NOT_OUTDOORS. If there are multiple indoor frames found, the first
    /// frame is recorded here.
    /// </summary>
    public class NotOutdoorsFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Relative time (from the start of the video stream) when an indoor frame was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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

    /// <summary>Photo is used to store 360 photos along with photo metadata.</summary>
    public class Photo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _captureTimeRaw;

        private object _captureTime;

        /// <summary>
        /// Optional. Absolute time when the photo was captured. When the photo has no exif timestamp, this is used to
        /// set a timestamp in the photo metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captureTime")]
        public virtual string CaptureTimeRaw
        {
            get => _captureTimeRaw;
            set
            {
                _captureTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _captureTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaptureTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaptureTimeDateTimeOffset instead.")]
        public virtual object CaptureTime
        {
            get => _captureTime;
            set
            {
                _captureTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _captureTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaptureTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaptureTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaptureTimeRaw);
            set => CaptureTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Connections to other photos. A connection represents the link from this photo to another photo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>
        /// Output only. The download URL for the photo bytes. This field is set only when GetPhotoRequest.view is set
        /// to PhotoView.INCLUDE_DOWNLOAD_URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>Output only. Status in Google Maps, whether this photo was published or rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapsPublishStatus")]
        public virtual string MapsPublishStatus { get; set; }

        /// <summary>
        /// Required. Output only. Required when updating a photo. Output only when creating a photo. Identifier for the
        /// photo, which is unique among all photos in Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoId")]
        public virtual PhotoId PhotoId { get; set; }

        /// <summary>Optional. Places where this photo belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("places")]
        public virtual System.Collections.Generic.IList<Place> Places { get; set; }

        /// <summary>Optional. Pose of the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pose")]
        public virtual Pose Pose { get; set; }

        /// <summary>Output only. The share link for the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareLink")]
        public virtual string ShareLink { get; set; }

        /// <summary>Output only. The thumbnail URL for showing a preview of the given photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Output only. Status of rights transfer on this photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferStatus")]
        public virtual string TransferStatus { get; set; }

        /// <summary>
        /// Input only. Required when creating a photo. Input only. The resource URL where the photo bytes are uploaded
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadReference")]
        public virtual UploadRef UploadReference { get; set; }

        private string _uploadTimeRaw;

        private object _uploadTime;

        /// <summary>Output only. Time when the image was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTime")]
        public virtual string UploadTimeRaw
        {
            get => _uploadTimeRaw;
            set
            {
                _uploadTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _uploadTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UploadTimeDateTimeOffset instead.")]
        public virtual object UploadTime
        {
            get => _uploadTime;
            set
            {
                _uploadTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _uploadTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UploadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. View count of the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewCount")]
        public virtual System.Nullable<long> ViewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifier for a Photo.</summary>
    public class PhotoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique identifier for a photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response payload for a single Photo in batch operations including BatchGetPhotos and BatchUpdatePhotos.
    /// </summary>
    public class PhotoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Photo resource, if the request was successful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photo")]
        public virtual Photo Photo { get; set; }

        /// <summary>The status for the operation to get or update a single photo in the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sequence of 360 photos along with metadata.</summary>
    public class PhotoSequence : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _captureTimeOverrideRaw;

        private object _captureTimeOverride;

        /// <summary>
        /// Optional. Absolute time when the photo sequence starts to be captured. If the photo sequence is a video,
        /// this is the start time of the video. If this field is populated in input, it overrides the capture time in
        /// the video or XDM file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captureTimeOverride")]
        public virtual string CaptureTimeOverrideRaw
        {
            get => _captureTimeOverrideRaw;
            set
            {
                _captureTimeOverride = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _captureTimeOverrideRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaptureTimeOverrideRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaptureTimeOverrideDateTimeOffset instead.")]
        public virtual object CaptureTimeOverride
        {
            get => _captureTimeOverride;
            set
            {
                _captureTimeOverrideRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _captureTimeOverride = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CaptureTimeOverrideRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaptureTimeOverrideDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaptureTimeOverrideRaw);
            set => CaptureTimeOverrideRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The computed distance of the photo sequence in meters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceMeters")]
        public virtual System.Nullable<double> DistanceMeters { get; set; }

        /// <summary>
        /// Output only. If this sequence has `failure_reason` set, this may contain additional details about the
        /// failure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureDetails")]
        public virtual ProcessingFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Output only. If this sequence has processing_state = FAILED, this will contain the reason why it failed. If
        /// the processing_state is any other value, this field will be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Output only. The filename of the upload. Does not include the directory path. Only available if the sequence
        /// was uploaded on a platform that provides the filename.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Input only. If both raw_gps_timeline and the Camera Motion Metadata Track (CAMM) contain GPS measurements,
        /// indicate which takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsSource")]
        public virtual string GpsSource { get; set; }

        /// <summary>
        /// Output only. Unique identifier for the photo sequence. This also acts as a long running operation ID if
        /// uploading is performed asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Input only. Three axis IMU data for the collection. If this data is too large to put in the request, then it
        /// should be put in the CAMM track for the video. This data always takes precedence over the equivalent CAMM
        /// data, if it exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imu")]
        public virtual Imu Imu { get; set; }

        /// <summary>Output only. Photos with increasing timestamps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photos")]
        public virtual System.Collections.Generic.IList<Photo> Photos { get; set; }

        /// <summary>Output only. The processing state of this sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingState")]
        public virtual string ProcessingState { get; set; }

        /// <summary>
        /// Input only. Raw GPS measurements with increasing timestamps from the device that aren't time synced with
        /// each photo. These raw measurements will be used to infer the pose of each frame. Required in input when
        /// InputType is VIDEO and raw GPS measurements are not in Camera Motion Metadata Track (CAMM). User can
        /// indicate which takes precedence using gps_source if raw GPS measurements are provided in both
        /// raw_gps_timeline and Camera Motion Metadata Track (CAMM).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawGpsTimeline")]
        public virtual System.Collections.Generic.IList<Pose> RawGpsTimeline { get; set; }

        /// <summary>Output only. A rectangular box that encapsulates every image in this photo sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceBounds")]
        public virtual LatLngBounds SequenceBounds { get; set; }

        /// <summary>
        /// Input only. Required when creating photo sequence. The resource name where the bytes of the photo sequence
        /// (in the form of video) are uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadReference")]
        public virtual UploadRef UploadReference { get; set; }

        private string _uploadTimeRaw;

        private object _uploadTime;

        /// <summary>Output only. The time this photo sequence was created in uSV Store service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTime")]
        public virtual string UploadTimeRaw
        {
            get => _uploadTimeRaw;
            set
            {
                _uploadTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _uploadTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UploadTimeDateTimeOffset instead.")]
        public virtual object UploadTime
        {
            get => _uploadTime;
            set
            {
                _uploadTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _uploadTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UploadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The total number of views that all the published images in this PhotoSequence have received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewCount")]
        public virtual System.Nullable<long> ViewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Place metadata for an entity.</summary>
    public class Place : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The language_code that the name is localized with. This should be the language_code specified
        /// in the request, but may be a fallback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. The name of the place, localized to the language_code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Place identifier, as described in https://developers.google.com/places/place-id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Raw pose measurement for an entity.</summary>
    public class Pose : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The estimated horizontal accuracy of this pose in meters with 68% confidence (one standard deviation). For
        /// example, on Android, this value is available from this method:
        /// https://developer.android.com/reference/android/location/Location#getAccuracy(). Other platforms have
        /// different methods of obtaining similar accuracy estimations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accuracyMeters")]
        public virtual System.Nullable<float> AccuracyMeters { get; set; }

        /// <summary>
        /// Altitude of the pose in meters above WGS84 ellipsoid. NaN indicates an unmeasured quantity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual System.Nullable<double> Altitude { get; set; }

        private string _gpsRecordTimestampUnixEpochRaw;

        private object _gpsRecordTimestampUnixEpoch;

        /// <summary>Time of the GPS record since UTC epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsRecordTimestampUnixEpoch")]
        public virtual string GpsRecordTimestampUnixEpochRaw
        {
            get => _gpsRecordTimestampUnixEpochRaw;
            set
            {
                _gpsRecordTimestampUnixEpoch = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _gpsRecordTimestampUnixEpochRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GpsRecordTimestampUnixEpochRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GpsRecordTimestampUnixEpochDateTimeOffset instead.")]
        public virtual object GpsRecordTimestampUnixEpoch
        {
            get => _gpsRecordTimestampUnixEpoch;
            set
            {
                _gpsRecordTimestampUnixEpochRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _gpsRecordTimestampUnixEpoch = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="GpsRecordTimestampUnixEpochRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GpsRecordTimestampUnixEpochDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GpsRecordTimestampUnixEpochRaw);
            set => GpsRecordTimestampUnixEpochRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The following pose parameters pertain to the center of the photo. They match
        /// https://developers.google.com/streetview/spherical-metadata. Compass heading, measured at the center of the
        /// photo in degrees clockwise from North. Value must be &amp;gt;=0 and &amp;lt;360. NaN indicates an unmeasured
        /// quantity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heading")]
        public virtual System.Nullable<double> Heading { get; set; }

        /// <summary>
        /// Latitude and longitude pair of the pose, as explained here:
        /// https://cloud.google.com/datastore/docs/reference/rest/Shared.Types/LatLng When creating a Photo, if the
        /// latitude and longitude pair are not provided, the geolocation from the exif header is used. A latitude and
        /// longitude pair not provided in the photo or exif header causes the photo process to fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLngPair")]
        public virtual LatLng LatLngPair { get; set; }

        /// <summary>Level (the floor in a building) used to configure vertical navigation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual Level Level { get; set; }

        /// <summary>
        /// Pitch, measured at the center of the photo in degrees. Value must be &amp;gt;=-90 and &amp;lt;= 90. A value
        /// of -90 means looking directly down, and a value of 90 means looking directly up. NaN indicates an unmeasured
        /// quantity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitch")]
        public virtual System.Nullable<double> Pitch { get; set; }

        /// <summary>
        /// Roll, measured in degrees. Value must be &amp;gt;= 0 and &amp;lt;360. A value of 0 means level with the
        /// horizon. NaN indicates an unmeasured quantity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roll")]
        public virtual System.Nullable<double> Roll { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional details to accompany the ProcessingFailureReason enum. This message is always expected to be used in
    /// conjunction with ProcessingFailureReason, and the oneof value set in this message should match the
    /// FailureReason.
    /// </summary>
    public class ProcessingFailureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>See GpsDataGapFailureDetails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpsDataGapDetails")]
        public virtual GpsDataGapFailureDetails GpsDataGapDetails { get; set; }

        /// <summary>See ImuDataGapFailureDetails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imuDataGapDetails")]
        public virtual ImuDataGapFailureDetails ImuDataGapDetails { get; set; }

        /// <summary>See InsufficientGpsFailureDetails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insufficientGpsDetails")]
        public virtual InsufficientGpsFailureDetails InsufficientGpsDetails { get; set; }

        /// <summary>See NoOverlapGpsFailureDetails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noOverlapGpsDetails")]
        public virtual NoOverlapGpsFailureDetails NoOverlapGpsDetails { get; set; }

        /// <summary>See NotOutdoorsFailureDetails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notOutdoorsDetails")]
        public virtual NotOutdoorsFailureDetails NotOutdoorsDetails { get; set; }

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

    /// <summary>Request to update the metadata of a Photo. Updating the pixels of a photo is not supported.</summary>
    public class UpdatePhotoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Photo object containing the new metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photo")]
        public virtual Photo Photo { get; set; }

        /// <summary>
        /// Required. Mask that identifies fields on the photo metadata to update. If not present, the old Photo
        /// metadata is entirely replaced with the new Photo metadata in this request. The update fails if invalid
        /// fields are specified. Multiple fields can be specified in a comma-delimited list. The following fields are
        /// valid: * `pose.heading` * `pose.lat_lng_pair` * `pose.pitch` * `pose.roll` * `pose.level` * `pose.altitude`
        /// * `connections` * `places` &amp;gt; Note: When updateMask contains repeated fields, the entire set of
        /// repeated values get replaced with the new contents. For example, if updateMask contains `connections` and
        /// `UpdatePhotoRequest.photo.connections` is empty, all connections are removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Upload reference for media files.</summary>
    public class UploadRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An upload reference should be unique for each user. It follows the form:
        /// "https://streetviewpublish.googleapis.com/media/user/{account_id}/photo/{upload_reference}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadUrl")]
        public virtual string UploadUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
