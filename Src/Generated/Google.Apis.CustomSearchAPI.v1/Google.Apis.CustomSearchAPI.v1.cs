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

namespace Google.Apis.CustomSearchAPI.v1
{
    /// <summary>The CustomSearchAPI Service.</summary>
    public class CustomSearchAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CustomSearchAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CustomSearchAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Cse = new CseResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://customsearch.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://customsearch.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "customsearch";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Cse resource.</summary>
        public virtual CseResource Cse { get; }
    }

    /// <summary>A base abstract class for CustomSearchAPI requests.</summary>
    public abstract class CustomSearchAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CustomSearchAPIBaseServiceRequest instance.</summary>
        protected CustomSearchAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CustomSearchAPI parameter list.</summary>
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

    /// <summary>The "cse" collection of methods.</summary>
    public class CseResource
    {
        private const string Resource = "cse";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CseResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Siterestrict = new SiterestrictResource(service);
        }

        /// <summary>Gets the Siterestrict resource.</summary>
        public virtual SiterestrictResource Siterestrict { get; }

        /// <summary>The "siterestrict" collection of methods.</summary>
        public class SiterestrictResource
        {
            private const string Resource = "siterestrict";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SiterestrictResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns metadata about the search performed, metadata about the engine used for the search, and the
            /// search results. Uses a small set of url patterns.
            /// </summary>
            public virtual ListRequest List()
            {
                return new ListRequest(this.service);
            }

            /// <summary>
            /// Returns metadata about the search performed, metadata about the engine used for the search, and the
            /// search results. Uses a small set of url patterns.
            /// </summary>
            public class ListRequest : CustomSearchAPIBaseServiceRequest<Google.Apis.CustomSearchAPI.v1.Data.Search>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service) : base(service)
                {
                    InitParameters();
                }

                /// <summary>
                /// Enables or disables [Simplified and Traditional Chinese
                /// Search](https://developers.google.com/custom-search/docs/json_api_reference#chineseSearch). The
                /// default value for this parameter is 0 (zero), meaning that the feature is enabled. Supported values
                /// are: * `1`: Disabled * `0`: Enabled (default)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("c2coff", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string C2coff { get; set; }

                /// <summary>
                /// Restricts search results to documents originating in a particular country. You may use [Boolean
                /// operators](https://developers.google.com/custom-search/docs/json_api_reference#booleanOperators) in
                /// the cr parameter's value. Google Search determines the country of a document by analyzing: * the
                /// top-level domain (TLD) of the document's URL * the geographic location of the Web server's IP
                /// address See the [Country Parameter
                /// Values](https://developers.google.com/custom-search/docs/json_api_reference#countryCollections) page
                /// for a list of valid values for this parameter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("cr", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Cr { get; set; }

                /// <summary>The Programmable Search Engine ID to use for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("cx", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Cx { get; set; }

                /// <summary>
                /// Restricts results to URLs based on date. Supported values include: * `d[number]`: requests results
                /// from the specified number of past days. * `w[number]`: requests results from the specified number of
                /// past weeks. * `m[number]`: requests results from the specified number of past months. * `y[number]`:
                /// requests results from the specified number of past years.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dateRestrict", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DateRestrict { get; set; }

                /// <summary>
                /// Optional. Enables routing of Programmable Search Engine requests to an alternate search handler.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("enableAlternateSearchHandler", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> EnableAlternateSearchHandler { get; set; }

                /// <summary>Identifies a phrase that all documents in the search results must contain.</summary>
                [Google.Apis.Util.RequestParameterAttribute("exactTerms", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ExactTerms { get; set; }

                /// <summary>
                /// Identifies a word or phrase that should not appear in any documents in the search results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("excludeTerms", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ExcludeTerms { get; set; }

                /// <summary>
                /// Restricts results to files of a specified extension. A list of file types indexable by Google can be
                /// found in Search Console [Help Center](https://support.google.com/webmasters/answer/35287).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fileType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FileType { get; set; }

                /// <summary>
                /// Controls turning on or off the duplicate content filter. * See [Automatic
                /// Filtering](https://developers.google.com/custom-search/docs/json_api_reference#automaticFiltering)
                /// for more information about Google's search results filters. Note that host crowding filtering
                /// applies only to multi-site searches. * By default, Google applies filtering to all search results to
                /// improve the quality of those results. Acceptable values are: * `0`: Turns off duplicate content
                /// filter. * `1`: Turns on duplicate content filter.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Geolocation of end user. * The `gl` parameter value is a two-letter country code. The `gl` parameter
                /// boosts search results whose country of origin matches the parameter value. See the [Country
                /// Codes](https://developers.google.com/custom-search/docs/json_api_reference#countryCodes) page for a
                /// list of valid values. * Specifying a `gl` parameter value should lead to more relevant results. This
                /// is particularly true for international customers and, even more specifically, for customers in
                /// English- speaking countries other than the United States.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("gl", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Gl { get; set; }

                /// <summary>
                /// **Deprecated**. Use the `gl` parameter for a similar effect. The local Google domain (for example,
                /// google.com, google.de, or google.fr) to use to perform the search.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("googlehost", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Googlehost { get; set; }

                /// <summary>
                /// Specifies the ending value for a search range. * Use `lowRange` and `highRange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("highRange", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string HighRange { get; set; }

                /// <summary>
                /// Sets the user interface language. * Explicitly setting this parameter improves the performance and
                /// the quality of your search results. * See the [Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#wsInterfaceLanguages)
                /// section of [Internationalizing Queries and Results
                /// Presentation](https://developers.google.com/custom-search/docs/json_api_reference#wsInternationalizing)
                /// for more information, and [Supported Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#interfaceLanguages)
                /// for a list of supported languages.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Hl { get; set; }

                /// <summary>
                /// Appends the specified query terms to the query, as if they were combined with a logical AND
                /// operator.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("hq", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Hq { get; set; }

                /// <summary>
                /// Returns black and white, grayscale, transparent, or color images. Acceptable values are: * `"color"`
                /// * `"gray"` * `"mono"`: black and white * `"trans"`: transparent background
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imgColorType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ImgColorTypeEnum> ImgColorType { get; set; }

                /// <summary>
                /// Returns black and white, grayscale, transparent, or color images. Acceptable values are: * `"color"`
                /// * `"gray"` * `"mono"`: black and white * `"trans"`: transparent background
                /// </summary>
                public enum ImgColorTypeEnum
                {
                    /// <summary>No image color type specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("imgColorTypeUndefined")]
                    ImgColorTypeUndefined = 0,

                    /// <summary>Black and white images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("mono")]
                    Mono = 1,

                    /// <summary>Grayscale images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("gray")]
                    Gray = 2,

                    /// <summary>Color images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("color")]
                    Color = 3,

                    /// <summary>Images with transparent background</summary>
                    [Google.Apis.Util.StringValueAttribute("trans")]
                    Trans = 4,
                }

                /// <summary>
                /// Returns images of a specific dominant color. Acceptable values are: * `"black"` * `"blue"` *
                /// `"brown"` * `"gray"` * `"green"` * `"orange"` * `"pink"` * `"purple"` * `"red"` * `"teal"` *
                /// `"white"` * `"yellow"`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imgDominantColor", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ImgDominantColorEnum> ImgDominantColor { get; set; }

                /// <summary>
                /// Returns images of a specific dominant color. Acceptable values are: * `"black"` * `"blue"` *
                /// `"brown"` * `"gray"` * `"green"` * `"orange"` * `"pink"` * `"purple"` * `"red"` * `"teal"` *
                /// `"white"` * `"yellow"`
                /// </summary>
                public enum ImgDominantColorEnum
                {
                    /// <summary>No dominant color specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("imgDominantColorUndefined")]
                    ImgDominantColorUndefined = 0,

                    /// <summary>Predominantly black images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("black")]
                    Black = 1,

                    /// <summary>Predominantly blue images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("blue")]
                    Blue = 2,

                    /// <summary>Predominantly brown images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("brown")]
                    Brown = 3,

                    /// <summary>Predominantly gray images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("gray")]
                    Gray = 4,

                    /// <summary>Predominantly green images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("green")]
                    Green = 5,

                    /// <summary>Predominantly orange images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("orange")]
                    Orange = 6,

                    /// <summary>Predominantly pink images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("pink")]
                    Pink = 7,

                    /// <summary>Predominantly purple images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("purple")]
                    Purple = 8,

                    /// <summary>Predominantly red images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("red")]
                    Red = 9,

                    /// <summary>Predominantly teal images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("teal")]
                    Teal = 10,

                    /// <summary>Predominantly white images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("white")]
                    White = 11,

                    /// <summary>Predominantly yellow images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("yellow")]
                    Yellow = 12,
                }

                /// <summary>
                /// Returns images of a specified size. Acceptable values are: * `"huge"` * `"icon"` * `"large"` *
                /// `"medium"` * `"small"` * `"xlarge"` * `"xxlarge"`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imgSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ImgSizeEnum> ImgSize { get; set; }

                /// <summary>
                /// Returns images of a specified size. Acceptable values are: * `"huge"` * `"icon"` * `"large"` *
                /// `"medium"` * `"small"` * `"xlarge"` * `"xxlarge"`
                /// </summary>
                public enum ImgSizeEnum
                {
                    /// <summary>No image size specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("imgSizeUndefined")]
                    ImgSizeUndefined = 0,

                    /// <summary>Only the largest possible images.</summary>
                    [Google.Apis.Util.StringValueAttribute("HUGE")]
                    HUGE = 1,

                    /// <summary>Only very small icon-sized images.</summary>
                    [Google.Apis.Util.StringValueAttribute("ICON")]
                    ICON = 2,

                    /// <summary>Only large images.</summary>
                    [Google.Apis.Util.StringValueAttribute("LARGE")]
                    LARGE = 3,

                    /// <summary>Only medium images.</summary>
                    [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                    MEDIUM = 4,

                    /// <summary>Only small images.</summary>
                    [Google.Apis.Util.StringValueAttribute("SMALL")]
                    SMALL = 5,

                    /// <summary>Only very large images.</summary>
                    [Google.Apis.Util.StringValueAttribute("XLARGE")]
                    XLARGE = 6,

                    /// <summary>Only extremely large images.</summary>
                    [Google.Apis.Util.StringValueAttribute("XXLARGE")]
                    XXLARGE = 7,
                }

                /// <summary>
                /// Returns images of a type. Acceptable values are: * `"clipart"` * `"face"` * `"lineart"` * `"stock"`
                /// * `"photo"` * `"animated"`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imgType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ImgTypeEnum> ImgType { get; set; }

                /// <summary>
                /// Returns images of a type. Acceptable values are: * `"clipart"` * `"face"` * `"lineart"` * `"stock"`
                /// * `"photo"` * `"animated"`
                /// </summary>
                public enum ImgTypeEnum
                {
                    /// <summary>No image type specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("imgTypeUndefined")]
                    ImgTypeUndefined = 0,

                    /// <summary>Clipart-style images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("clipart")]
                    Clipart = 1,

                    /// <summary>Images of faces only.</summary>
                    [Google.Apis.Util.StringValueAttribute("face")]
                    Face = 2,

                    /// <summary>Line art images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("lineart")]
                    Lineart = 3,

                    /// <summary>Stock images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("stock")]
                    Stock = 4,

                    /// <summary>Photo images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("photo")]
                    Photo = 5,

                    /// <summary>Animated images only.</summary>
                    [Google.Apis.Util.StringValueAttribute("animated")]
                    Animated = 6,
                }

                /// <summary>Specifies that all search results should contain a link to a particular URL.</summary>
                [Google.Apis.Util.RequestParameterAttribute("linkSite", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LinkSite { get; set; }

                /// <summary>
                /// Specifies the starting value for a search range. Use `lowRange` and `highRange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("lowRange", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LowRange { get; set; }

                /// <summary>
                /// Restricts the search to documents written in a particular language (e.g., `lr=lang_ja`). Acceptable
                /// values are: * `"lang_ar"`: Arabic * `"lang_bg"`: Bulgarian * `"lang_ca"`: Catalan * `"lang_cs"`:
                /// Czech * `"lang_da"`: Danish * `"lang_de"`: German * `"lang_el"`: Greek * `"lang_en"`: English *
                /// `"lang_es"`: Spanish * `"lang_et"`: Estonian * `"lang_fi"`: Finnish * `"lang_fr"`: French *
                /// `"lang_hr"`: Croatian * `"lang_hu"`: Hungarian * `"lang_id"`: Indonesian * `"lang_is"`: Icelandic *
                /// `"lang_it"`: Italian * `"lang_iw"`: Hebrew * `"lang_ja"`: Japanese * `"lang_ko"`: Korean *
                /// `"lang_lt"`: Lithuanian * `"lang_lv"`: Latvian * `"lang_nl"`: Dutch * `"lang_no"`: Norwegian *
                /// `"lang_pl"`: Polish * `"lang_pt"`: Portuguese * `"lang_ro"`: Romanian * `"lang_ru"`: Russian *
                /// `"lang_sk"`: Slovak * `"lang_sl"`: Slovenian * `"lang_sr"`: Serbian * `"lang_sv"`: Swedish *
                /// `"lang_tr"`: Turkish * `"lang_zh-CN"`: Chinese (Simplified) * `"lang_zh-TW"`: Chinese (Traditional)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("lr", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Lr { get; set; }

                /// <summary>
                /// Number of search results to return. * Valid values are integers between 1 and 10, inclusive.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("num", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Num { get; set; }

                /// <summary>
                /// Provides additional search terms to check for in a document, where each document in the search
                /// results must contain at least one of the additional search terms.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orTerms", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrTerms { get; set; }

                /// <summary>Query</summary>
                [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Q { get; set; }

                /// <summary>Deprecated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("relatedSite", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RelatedSite { get; set; }

                /// <summary>
                /// Filters based on licensing. Supported values include: `cc_publicdomain`, `cc_attribute`,
                /// `cc_sharealike`, `cc_noncommercial`, `cc_nonderived` and combinations of these. See [typical
                /// combinations](https://wiki.creativecommons.org/wiki/CC_Search_integration).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("rights", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Rights { get; set; }

                /// <summary>
                /// Search safety level. Acceptable values are: * `"active"`: Enables SafeSearch filtering. * `"off"`:
                /// Disables SafeSearch filtering. (default)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("safe", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SafeEnum> Safe { get; set; }

                /// <summary>
                /// Search safety level. Acceptable values are: * `"active"`: Enables SafeSearch filtering. * `"off"`:
                /// Disables SafeSearch filtering. (default)
                /// </summary>
                public enum SafeEnum
                {
                    /// <summary>SafeSearch mode unspecified. (Falls back to engine's configuration.)</summary>
                    [Google.Apis.Util.StringValueAttribute("safeUndefined")]
                    SafeUndefined = 0,

                    /// <summary>Turn SafeSearch on.</summary>
                    [Google.Apis.Util.StringValueAttribute("active")]
                    Active = 1,

                    /// <summary>Deprecated, equivalent to "active".</summary>
                    [Google.Apis.Util.StringValueAttribute("high")]
                    High = 2,

                    /// <summary>Deprecated, equivalent to "active".</summary>
                    [Google.Apis.Util.StringValueAttribute("medium")]
                    Medium = 3,

                    /// <summary>Turn SafeSearch off.</summary>
                    [Google.Apis.Util.StringValueAttribute("off")]
                    Off = 4,
                }

                /// <summary>
                /// Specifies the search type: `image`. If unspecified, results are limited to webpages. Acceptable
                /// values are: * `"image"`: custom image search.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("searchType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SearchTypeEnum> SearchType { get; set; }

                /// <summary>
                /// Specifies the search type: `image`. If unspecified, results are limited to webpages. Acceptable
                /// values are: * `"image"`: custom image search.
                /// </summary>
                public enum SearchTypeEnum
                {
                    /// <summary>Search type unspecified (defaults to web search).</summary>
                    [Google.Apis.Util.StringValueAttribute("searchTypeUndefined")]
                    SearchTypeUndefined = 0,

                    /// <summary>Image search.</summary>
                    [Google.Apis.Util.StringValueAttribute("image")]
                    Image = 1,
                }

                /// <summary>
                /// Specifies a given site which should always be included or excluded from results (see
                /// `siteSearchFilter` parameter, below).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("siteSearch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SiteSearch { get; set; }

                /// <summary>
                /// Controls whether to include or exclude results from the site named in the `siteSearch` parameter.
                /// Acceptable values are: * `"e"`: exclude * `"i"`: include
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("siteSearchFilter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SiteSearchFilterEnum> SiteSearchFilter { get; set; }

                /// <summary>
                /// Controls whether to include or exclude results from the site named in the `siteSearch` parameter.
                /// Acceptable values are: * `"e"`: exclude * `"i"`: include
                /// </summary>
                public enum SiteSearchFilterEnum
                {
                    /// <summary>Filter mode unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("siteSearchFilterUndefined")]
                    SiteSearchFilterUndefined = 0,

                    /// <summary>Exclude results from the listed sites.</summary>
                    [Google.Apis.Util.StringValueAttribute("e")]
                    E = 1,

                    /// <summary>Include only results from the listed sites.</summary>
                    [Google.Apis.Util.StringValueAttribute("i")]
                    I = 2,
                }

                /// <summary>
                /// Optional. Maximum length of snippet text, in characters, to be returned with results. Note: this
                /// feature is limited to specific engines. * Valid values are integers between 161 and 1000, inclusive.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("snippetLength", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> SnippetLength { get; set; }

                /// <summary>
                /// The sort expression to apply to the results. The sort parameter specifies that the results be sorted
                /// according to the specified expression i.e. sort by date. [Example:
                /// sort=date](https://developers.google.com/custom-search/docs/structured_search#sort-by-attribute).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort { get; set; }

                /// <summary>
                /// The index of the first result to return. The default number of results per page is 10, so
                /// `&amp;amp;start=11` would start at the top of the second page of results. **Note**: The JSON API
                /// will never return more than 100 results, even if more than 100 documents match the query, so setting
                /// the sum of `start + num` to a number greater than 100 will produce an error. Also note that the
                /// maximum value for `num` is 10.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("start", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> Start { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "customsearch/v1/siterestrict";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("c2coff", new Google.Apis.Discovery.Parameter
                    {
                        Name = "c2coff",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("cr", new Google.Apis.Discovery.Parameter
                    {
                        Name = "cr",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("cx", new Google.Apis.Discovery.Parameter
                    {
                        Name = "cx",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dateRestrict", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dateRestrict",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("enableAlternateSearchHandler", new Google.Apis.Discovery.Parameter
                    {
                        Name = "enableAlternateSearchHandler",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("exactTerms", new Google.Apis.Discovery.Parameter
                    {
                        Name = "exactTerms",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("excludeTerms", new Google.Apis.Discovery.Parameter
                    {
                        Name = "excludeTerms",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fileType",
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
                    RequestParameters.Add("gl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "gl",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("googlehost", new Google.Apis.Discovery.Parameter
                    {
                        Name = "googlehost",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("highRange", new Google.Apis.Discovery.Parameter
                    {
                        Name = "highRange",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "hl",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("hq", new Google.Apis.Discovery.Parameter
                    {
                        Name = "hq",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imgColorType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imgColorType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imgDominantColor", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imgDominantColor",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imgSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imgSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imgType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imgType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("linkSite", new Google.Apis.Discovery.Parameter
                    {
                        Name = "linkSite",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("lowRange", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lowRange",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("lr", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lr",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("num", new Google.Apis.Discovery.Parameter
                    {
                        Name = "num",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orTerms", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orTerms",
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
                    RequestParameters.Add("relatedSite", new Google.Apis.Discovery.Parameter
                    {
                        Name = "relatedSite",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("rights", new Google.Apis.Discovery.Parameter
                    {
                        Name = "rights",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("safe", new Google.Apis.Discovery.Parameter
                    {
                        Name = "safe",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("searchType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "searchType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("siteSearch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteSearch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("siteSearchFilter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteSearchFilter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("snippetLength", new Google.Apis.Discovery.Parameter
                    {
                        Name = "snippetLength",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sort",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("start", new Google.Apis.Discovery.Parameter
                    {
                        Name = "start",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Returns metadata about the search performed, metadata about the engine used for the search, and the search
        /// results.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Returns metadata about the search performed, metadata about the engine used for the search, and the search
        /// results.
        /// </summary>
        public class ListRequest : CustomSearchAPIBaseServiceRequest<Google.Apis.CustomSearchAPI.v1.Data.Search>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Enables or disables [Simplified and Traditional Chinese
            /// Search](https://developers.google.com/custom-search/docs/json_api_reference#chineseSearch). The default
            /// value for this parameter is 0 (zero), meaning that the feature is enabled. Supported values are: * `1`:
            /// Disabled * `0`: Enabled (default)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("c2coff", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string C2coff { get; set; }

            /// <summary>
            /// Restricts search results to documents originating in a particular country. You may use [Boolean
            /// operators](https://developers.google.com/custom-search/docs/json_api_reference#booleanOperators) in the
            /// cr parameter's value. Google Search determines the country of a document by analyzing: * the top-level
            /// domain (TLD) of the document's URL * the geographic location of the Web server's IP address See the
            /// [Country Parameter
            /// Values](https://developers.google.com/custom-search/docs/json_api_reference#countryCollections) page for
            /// a list of valid values for this parameter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("cr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cr { get; set; }

            /// <summary>The Programmable Search Engine ID to use for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("cx", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Cx { get; set; }

            /// <summary>
            /// Restricts results to URLs based on date. Supported values include: * `d[number]`: requests results from
            /// the specified number of past days. * `w[number]`: requests results from the specified number of past
            /// weeks. * `m[number]`: requests results from the specified number of past months. * `y[number]`: requests
            /// results from the specified number of past years.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dateRestrict", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DateRestrict { get; set; }

            /// <summary>
            /// Optional. Enables routing of Programmable Search Engine requests to an alternate search handler.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enableAlternateSearchHandler", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableAlternateSearchHandler { get; set; }

            /// <summary>Identifies a phrase that all documents in the search results must contain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("exactTerms", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ExactTerms { get; set; }

            /// <summary>
            /// Identifies a word or phrase that should not appear in any documents in the search results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("excludeTerms", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ExcludeTerms { get; set; }

            /// <summary>
            /// Restricts results to files of a specified extension. A list of file types indexable by Google can be
            /// found in Search Console [Help Center](https://support.google.com/webmasters/answer/35287).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("fileType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FileType { get; set; }

            /// <summary>
            /// Controls turning on or off the duplicate content filter. * See [Automatic
            /// Filtering](https://developers.google.com/custom-search/docs/json_api_reference#automaticFiltering) for
            /// more information about Google's search results filters. Note that host crowding filtering applies only
            /// to multi-site searches. * By default, Google applies filtering to all search results to improve the
            /// quality of those results. Acceptable values are: * `0`: Turns off duplicate content filter. * `1`: Turns
            /// on duplicate content filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Geolocation of end user. * The `gl` parameter value is a two-letter country code. The `gl` parameter
            /// boosts search results whose country of origin matches the parameter value. See the [Country
            /// Codes](https://developers.google.com/custom-search/docs/json_api_reference#countryCodes) page for a list
            /// of valid values. * Specifying a `gl` parameter value should lead to more relevant results. This is
            /// particularly true for international customers and, even more specifically, for customers in English-
            /// speaking countries other than the United States.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("gl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Gl { get; set; }

            /// <summary>
            /// **Deprecated**. Use the `gl` parameter for a similar effect. The local Google domain (for example,
            /// google.com, google.de, or google.fr) to use to perform the search.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("googlehost", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Googlehost { get; set; }

            /// <summary>
            /// Specifies the ending value for a search range. * Use `lowRange` and `highRange` to append an inclusive
            /// search range of `lowRange...highRange` to the query.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("highRange", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string HighRange { get; set; }

            /// <summary>
            /// Sets the user interface language. * Explicitly setting this parameter improves the performance and the
            /// quality of your search results. * See the [Interface
            /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#wsInterfaceLanguages)
            /// section of [Internationalizing Queries and Results
            /// Presentation](https://developers.google.com/custom-search/docs/json_api_reference#wsInternationalizing)
            /// for more information, and [Supported Interface
            /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#interfaceLanguages) for a
            /// list of supported languages.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>
            /// Appends the specified query terms to the query, as if they were combined with a logical AND operator.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hq", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hq { get; set; }

            /// <summary>
            /// Returns black and white, grayscale, transparent, or color images. Acceptable values are: * `"color"` *
            /// `"gray"` * `"mono"`: black and white * `"trans"`: transparent background
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("imgColorType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ImgColorTypeEnum> ImgColorType { get; set; }

            /// <summary>
            /// Returns black and white, grayscale, transparent, or color images. Acceptable values are: * `"color"` *
            /// `"gray"` * `"mono"`: black and white * `"trans"`: transparent background
            /// </summary>
            public enum ImgColorTypeEnum
            {
                /// <summary>No image color type specified.</summary>
                [Google.Apis.Util.StringValueAttribute("imgColorTypeUndefined")]
                ImgColorTypeUndefined = 0,

                /// <summary>Black and white images only.</summary>
                [Google.Apis.Util.StringValueAttribute("mono")]
                Mono = 1,

                /// <summary>Grayscale images only.</summary>
                [Google.Apis.Util.StringValueAttribute("gray")]
                Gray = 2,

                /// <summary>Color images only.</summary>
                [Google.Apis.Util.StringValueAttribute("color")]
                Color = 3,

                /// <summary>Images with transparent background</summary>
                [Google.Apis.Util.StringValueAttribute("trans")]
                Trans = 4,
            }

            /// <summary>
            /// Returns images of a specific dominant color. Acceptable values are: * `"black"` * `"blue"` * `"brown"` *
            /// `"gray"` * `"green"` * `"orange"` * `"pink"` * `"purple"` * `"red"` * `"teal"` * `"white"` * `"yellow"`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("imgDominantColor", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ImgDominantColorEnum> ImgDominantColor { get; set; }

            /// <summary>
            /// Returns images of a specific dominant color. Acceptable values are: * `"black"` * `"blue"` * `"brown"` *
            /// `"gray"` * `"green"` * `"orange"` * `"pink"` * `"purple"` * `"red"` * `"teal"` * `"white"` * `"yellow"`
            /// </summary>
            public enum ImgDominantColorEnum
            {
                /// <summary>No dominant color specified.</summary>
                [Google.Apis.Util.StringValueAttribute("imgDominantColorUndefined")]
                ImgDominantColorUndefined = 0,

                /// <summary>Predominantly black images only.</summary>
                [Google.Apis.Util.StringValueAttribute("black")]
                Black = 1,

                /// <summary>Predominantly blue images only.</summary>
                [Google.Apis.Util.StringValueAttribute("blue")]
                Blue = 2,

                /// <summary>Predominantly brown images only.</summary>
                [Google.Apis.Util.StringValueAttribute("brown")]
                Brown = 3,

                /// <summary>Predominantly gray images only.</summary>
                [Google.Apis.Util.StringValueAttribute("gray")]
                Gray = 4,

                /// <summary>Predominantly green images only.</summary>
                [Google.Apis.Util.StringValueAttribute("green")]
                Green = 5,

                /// <summary>Predominantly orange images only.</summary>
                [Google.Apis.Util.StringValueAttribute("orange")]
                Orange = 6,

                /// <summary>Predominantly pink images only.</summary>
                [Google.Apis.Util.StringValueAttribute("pink")]
                Pink = 7,

                /// <summary>Predominantly purple images only.</summary>
                [Google.Apis.Util.StringValueAttribute("purple")]
                Purple = 8,

                /// <summary>Predominantly red images only.</summary>
                [Google.Apis.Util.StringValueAttribute("red")]
                Red = 9,

                /// <summary>Predominantly teal images only.</summary>
                [Google.Apis.Util.StringValueAttribute("teal")]
                Teal = 10,

                /// <summary>Predominantly white images only.</summary>
                [Google.Apis.Util.StringValueAttribute("white")]
                White = 11,

                /// <summary>Predominantly yellow images only.</summary>
                [Google.Apis.Util.StringValueAttribute("yellow")]
                Yellow = 12,
            }

            /// <summary>
            /// Returns images of a specified size. Acceptable values are: * `"huge"` * `"icon"` * `"large"` *
            /// `"medium"` * `"small"` * `"xlarge"` * `"xxlarge"`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("imgSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ImgSizeEnum> ImgSize { get; set; }

            /// <summary>
            /// Returns images of a specified size. Acceptable values are: * `"huge"` * `"icon"` * `"large"` *
            /// `"medium"` * `"small"` * `"xlarge"` * `"xxlarge"`
            /// </summary>
            public enum ImgSizeEnum
            {
                /// <summary>No image size specified.</summary>
                [Google.Apis.Util.StringValueAttribute("imgSizeUndefined")]
                ImgSizeUndefined = 0,

                /// <summary>Only the largest possible images.</summary>
                [Google.Apis.Util.StringValueAttribute("HUGE")]
                HUGE = 1,

                /// <summary>Only very small icon-sized images.</summary>
                [Google.Apis.Util.StringValueAttribute("ICON")]
                ICON = 2,

                /// <summary>Only large images.</summary>
                [Google.Apis.Util.StringValueAttribute("LARGE")]
                LARGE = 3,

                /// <summary>Only medium images.</summary>
                [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                MEDIUM = 4,

                /// <summary>Only small images.</summary>
                [Google.Apis.Util.StringValueAttribute("SMALL")]
                SMALL = 5,

                /// <summary>Only very large images.</summary>
                [Google.Apis.Util.StringValueAttribute("XLARGE")]
                XLARGE = 6,

                /// <summary>Only extremely large images.</summary>
                [Google.Apis.Util.StringValueAttribute("XXLARGE")]
                XXLARGE = 7,
            }

            /// <summary>
            /// Returns images of a type. Acceptable values are: * `"clipart"` * `"face"` * `"lineart"` * `"stock"` *
            /// `"photo"` * `"animated"`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("imgType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ImgTypeEnum> ImgType { get; set; }

            /// <summary>
            /// Returns images of a type. Acceptable values are: * `"clipart"` * `"face"` * `"lineart"` * `"stock"` *
            /// `"photo"` * `"animated"`
            /// </summary>
            public enum ImgTypeEnum
            {
                /// <summary>No image type specified.</summary>
                [Google.Apis.Util.StringValueAttribute("imgTypeUndefined")]
                ImgTypeUndefined = 0,

                /// <summary>Clipart-style images only.</summary>
                [Google.Apis.Util.StringValueAttribute("clipart")]
                Clipart = 1,

                /// <summary>Images of faces only.</summary>
                [Google.Apis.Util.StringValueAttribute("face")]
                Face = 2,

                /// <summary>Line art images only.</summary>
                [Google.Apis.Util.StringValueAttribute("lineart")]
                Lineart = 3,

                /// <summary>Stock images only.</summary>
                [Google.Apis.Util.StringValueAttribute("stock")]
                Stock = 4,

                /// <summary>Photo images only.</summary>
                [Google.Apis.Util.StringValueAttribute("photo")]
                Photo = 5,

                /// <summary>Animated images only.</summary>
                [Google.Apis.Util.StringValueAttribute("animated")]
                Animated = 6,
            }

            /// <summary>Specifies that all search results should contain a link to a particular URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("linkSite", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LinkSite { get; set; }

            /// <summary>
            /// Specifies the starting value for a search range. Use `lowRange` and `highRange` to append an inclusive
            /// search range of `lowRange...highRange` to the query.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("lowRange", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LowRange { get; set; }

            /// <summary>
            /// Restricts the search to documents written in a particular language (e.g., `lr=lang_ja`). Acceptable
            /// values are: * `"lang_ar"`: Arabic * `"lang_bg"`: Bulgarian * `"lang_ca"`: Catalan * `"lang_cs"`: Czech *
            /// `"lang_da"`: Danish * `"lang_de"`: German * `"lang_el"`: Greek * `"lang_en"`: English * `"lang_es"`:
            /// Spanish * `"lang_et"`: Estonian * `"lang_fi"`: Finnish * `"lang_fr"`: French * `"lang_hr"`: Croatian *
            /// `"lang_hu"`: Hungarian * `"lang_id"`: Indonesian * `"lang_is"`: Icelandic * `"lang_it"`: Italian *
            /// `"lang_iw"`: Hebrew * `"lang_ja"`: Japanese * `"lang_ko"`: Korean * `"lang_lt"`: Lithuanian *
            /// `"lang_lv"`: Latvian * `"lang_nl"`: Dutch * `"lang_no"`: Norwegian * `"lang_pl"`: Polish * `"lang_pt"`:
            /// Portuguese * `"lang_ro"`: Romanian * `"lang_ru"`: Russian * `"lang_sk"`: Slovak * `"lang_sl"`: Slovenian
            /// * `"lang_sr"`: Serbian * `"lang_sv"`: Swedish * `"lang_tr"`: Turkish * `"lang_zh-CN"`: Chinese
            /// (Simplified) * `"lang_zh-TW"`: Chinese (Traditional)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("lr", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Lr { get; set; }

            /// <summary>
            /// Number of search results to return. * Valid values are integers between 1 and 10, inclusive.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("num", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> Num { get; set; }

            /// <summary>
            /// Provides additional search terms to check for in a document, where each document in the search results
            /// must contain at least one of the additional search terms.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orTerms", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrTerms { get; set; }

            /// <summary>Query</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>Deprecated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("relatedSite", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RelatedSite { get; set; }

            /// <summary>
            /// Filters based on licensing. Supported values include: `cc_publicdomain`, `cc_attribute`,
            /// `cc_sharealike`, `cc_noncommercial`, `cc_nonderived` and combinations of these. See [typical
            /// combinations](https://wiki.creativecommons.org/wiki/CC_Search_integration).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("rights", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Rights { get; set; }

            /// <summary>
            /// Search safety level. Acceptable values are: * `"active"`: Enables SafeSearch filtering. * `"off"`:
            /// Disables SafeSearch filtering. (default)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("safe", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SafeEnum> Safe { get; set; }

            /// <summary>
            /// Search safety level. Acceptable values are: * `"active"`: Enables SafeSearch filtering. * `"off"`:
            /// Disables SafeSearch filtering. (default)
            /// </summary>
            public enum SafeEnum
            {
                /// <summary>SafeSearch mode unspecified. (Falls back to engine's configuration.)</summary>
                [Google.Apis.Util.StringValueAttribute("safeUndefined")]
                SafeUndefined = 0,

                /// <summary>Turn SafeSearch on.</summary>
                [Google.Apis.Util.StringValueAttribute("active")]
                Active = 1,

                /// <summary>Deprecated, equivalent to "active".</summary>
                [Google.Apis.Util.StringValueAttribute("high")]
                High = 2,

                /// <summary>Deprecated, equivalent to "active".</summary>
                [Google.Apis.Util.StringValueAttribute("medium")]
                Medium = 3,

                /// <summary>Turn SafeSearch off.</summary>
                [Google.Apis.Util.StringValueAttribute("off")]
                Off = 4,
            }

            /// <summary>
            /// Specifies the search type: `image`. If unspecified, results are limited to webpages. Acceptable values
            /// are: * `"image"`: custom image search.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("searchType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SearchTypeEnum> SearchType { get; set; }

            /// <summary>
            /// Specifies the search type: `image`. If unspecified, results are limited to webpages. Acceptable values
            /// are: * `"image"`: custom image search.
            /// </summary>
            public enum SearchTypeEnum
            {
                /// <summary>Search type unspecified (defaults to web search).</summary>
                [Google.Apis.Util.StringValueAttribute("searchTypeUndefined")]
                SearchTypeUndefined = 0,

                /// <summary>Image search.</summary>
                [Google.Apis.Util.StringValueAttribute("image")]
                Image = 1,
            }

            /// <summary>
            /// Specifies a given site which should always be included or excluded from results (see `siteSearchFilter`
            /// parameter, below).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("siteSearch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SiteSearch { get; set; }

            /// <summary>
            /// Controls whether to include or exclude results from the site named in the `siteSearch` parameter.
            /// Acceptable values are: * `"e"`: exclude * `"i"`: include
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("siteSearchFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SiteSearchFilterEnum> SiteSearchFilter { get; set; }

            /// <summary>
            /// Controls whether to include or exclude results from the site named in the `siteSearch` parameter.
            /// Acceptable values are: * `"e"`: exclude * `"i"`: include
            /// </summary>
            public enum SiteSearchFilterEnum
            {
                /// <summary>Filter mode unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("siteSearchFilterUndefined")]
                SiteSearchFilterUndefined = 0,

                /// <summary>Exclude results from the listed sites.</summary>
                [Google.Apis.Util.StringValueAttribute("e")]
                E = 1,

                /// <summary>Include only results from the listed sites.</summary>
                [Google.Apis.Util.StringValueAttribute("i")]
                I = 2,
            }

            /// <summary>
            /// Optional. Maximum length of snippet text, in characters, to be returned with results. Note: this feature
            /// is limited to specific engines. * Valid values are integers between 161 and 1000, inclusive.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("snippetLength", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> SnippetLength { get; set; }

            /// <summary>
            /// The sort expression to apply to the results. The sort parameter specifies that the results be sorted
            /// according to the specified expression i.e. sort by date. [Example:
            /// sort=date](https://developers.google.com/custom-search/docs/structured_search#sort-by-attribute).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Sort { get; set; }

            /// <summary>
            /// The index of the first result to return. The default number of results per page is 10, so
            /// `&amp;amp;start=11` would start at the top of the second page of results. **Note**: The JSON API will
            /// never return more than 100 results, even if more than 100 documents match the query, so setting the sum
            /// of `start + num` to a number greater than 100 will produce an error. Also note that the maximum value
            /// for `num` is 10.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("start", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Start { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "customsearch/v1";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("c2coff", new Google.Apis.Discovery.Parameter
                {
                    Name = "c2coff",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("cr", new Google.Apis.Discovery.Parameter
                {
                    Name = "cr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("cx", new Google.Apis.Discovery.Parameter
                {
                    Name = "cx",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dateRestrict", new Google.Apis.Discovery.Parameter
                {
                    Name = "dateRestrict",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableAlternateSearchHandler", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableAlternateSearchHandler",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("exactTerms", new Google.Apis.Discovery.Parameter
                {
                    Name = "exactTerms",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("excludeTerms", new Google.Apis.Discovery.Parameter
                {
                    Name = "excludeTerms",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fileType", new Google.Apis.Discovery.Parameter
                {
                    Name = "fileType",
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
                RequestParameters.Add("gl", new Google.Apis.Discovery.Parameter
                {
                    Name = "gl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("googlehost", new Google.Apis.Discovery.Parameter
                {
                    Name = "googlehost",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("highRange", new Google.Apis.Discovery.Parameter
                {
                    Name = "highRange",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hq", new Google.Apis.Discovery.Parameter
                {
                    Name = "hq",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("imgColorType", new Google.Apis.Discovery.Parameter
                {
                    Name = "imgColorType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("imgDominantColor", new Google.Apis.Discovery.Parameter
                {
                    Name = "imgDominantColor",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("imgSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "imgSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("imgType", new Google.Apis.Discovery.Parameter
                {
                    Name = "imgType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("linkSite", new Google.Apis.Discovery.Parameter
                {
                    Name = "linkSite",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("lowRange", new Google.Apis.Discovery.Parameter
                {
                    Name = "lowRange",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("lr", new Google.Apis.Discovery.Parameter
                {
                    Name = "lr",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("num", new Google.Apis.Discovery.Parameter
                {
                    Name = "num",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orTerms", new Google.Apis.Discovery.Parameter
                {
                    Name = "orTerms",
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
                RequestParameters.Add("relatedSite", new Google.Apis.Discovery.Parameter
                {
                    Name = "relatedSite",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("rights", new Google.Apis.Discovery.Parameter
                {
                    Name = "rights",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("safe", new Google.Apis.Discovery.Parameter
                {
                    Name = "safe",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("searchType", new Google.Apis.Discovery.Parameter
                {
                    Name = "searchType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("siteSearch", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteSearch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("siteSearchFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteSearchFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("snippetLength", new Google.Apis.Discovery.Parameter
                {
                    Name = "snippetLength",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                {
                    Name = "sort",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("start", new Google.Apis.Discovery.Parameter
                {
                    Name = "start",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CustomSearchAPI.v1.Data
{
    /// <summary>Promotion result.</summary>
    public class Promotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of block objects for this promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLines")]
        public virtual System.Collections.Generic.IList<BodyLinesData> BodyLines { get; set; }

        /// <summary>An abridged version of this search's result URL, e.g. www.example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLink")]
        public virtual string DisplayLink { get; set; }

        /// <summary>The title of the promotion, in HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlTitle")]
        public virtual string HtmlTitle { get; set; }

        /// <summary>Image belonging to a promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageData Image { get; set; }

        /// <summary>The URL of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>The title of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>An array of block objects for this promotion.</summary>
        public class BodyLinesData
        {
            /// <summary>The block object's text in HTML, if it has text.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("htmlTitle")]
            public virtual string HtmlTitle { get; set; }

            /// <summary>The anchor text of the block object's link, if it has a link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("link")]
            public virtual string Link { get; set; }

            /// <summary>The block object's text, if it has text.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }

            /// <summary>The URL of the block object's link, if it has one.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }

        /// <summary>Image belonging to a promotion.</summary>
        public class ImageData
        {
            /// <summary>Image height in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<int> Height { get; set; }

            /// <summary>URL of the image for this promotion link.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("source")]
            public virtual string Source { get; set; }

            /// <summary>Image width in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<int> Width { get; set; }
        }
    }

    /// <summary>A custom search result.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the ID of Google's cached version of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheId")]
        public virtual string CacheId { get; set; }

        /// <summary>An abridged version of this search result’s URL, e.g. www.example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLink")]
        public virtual string DisplayLink { get; set; }

        /// <summary>The file format of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>The URL displayed after the snippet for each search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedUrl")]
        public virtual string FormattedUrl { get; set; }

        /// <summary>The HTML-formatted URL displayed after the snippet for each search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlFormattedUrl")]
        public virtual string HtmlFormattedUrl { get; set; }

        /// <summary>The snippet of the search result, in HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlSnippet")]
        public virtual string HtmlSnippet { get; set; }

        /// <summary>The title of the search result, in HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlTitle")]
        public virtual string HtmlTitle { get; set; }

        /// <summary>Image belonging to a custom search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageData Image { get; set; }

        /// <summary>
        /// A unique identifier for the type of current object. For this API, it is `customsearch#result.`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Encapsulates all information about refinement labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelsData> Labels { get; set; }

        /// <summary>The full URL to which the search result is pointing, e.g. http://www.example.com/foo/bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>The MIME type of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mime")]
        public virtual string Mime { get; set; }

        /// <summary>
        /// Contains [PageMap](https://developers.google.com/custom-search/docs/structured_data#pagemaps) information
        /// for this search result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagemap")]
        public virtual System.Collections.Generic.IDictionary<string, object> Pagemap { get; set; }

        /// <summary>The snippet of the search result, in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>The title of the search result, in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Image belonging to a custom search result.</summary>
        public class ImageData
        {
            /// <summary>The size of the image, in bytes.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("byteSize")]
            public virtual System.Nullable<int> ByteSize { get; set; }

            /// <summary>A URL pointing to the webpage hosting the image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contextLink")]
            public virtual string ContextLink { get; set; }

            /// <summary>The height of the image, in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<int> Height { get; set; }

            /// <summary>The height of the thumbnail image, in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("thumbnailHeight")]
            public virtual System.Nullable<int> ThumbnailHeight { get; set; }

            /// <summary>A URL to the thumbnail image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("thumbnailLink")]
            public virtual string ThumbnailLink { get; set; }

            /// <summary>The width of the thumbnail image, in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("thumbnailWidth")]
            public virtual System.Nullable<int> ThumbnailWidth { get; set; }

            /// <summary>The width of the image, in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<int> Width { get; set; }
        }

        /// <summary>Encapsulates all information about refinement labels.</summary>
        public class LabelsData
        {
            /// <summary>
            /// The display name of a refinement label. This is the name you should display in your user interface.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }

            /// <summary>Refinement label and the associated refinement operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("label_with_op")]
            public virtual string LabelWithOp { get; set; }

            /// <summary>
            /// The name of a refinement label, which you can use to refine searches. Don't display this in your user
            /// interface; instead, use displayName.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }
    }

    /// <summary>Response to a custom search request.</summary>
    public class Search : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metadata and refinements associated with the given search engine, including: * The name of the search engine
        /// that was used for the query. * A set of [facet
        /// objects](https://developers.google.com/custom-search/docs/refinements#create) (refinements) you can use for
        /// refining a search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual System.Collections.Generic.IDictionary<string, object> Context { get; set; }

        /// <summary>The current set of custom search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Result> Items { get; set; }

        /// <summary>
        /// Unique identifier for the type of current object. For this API, it is customsearch#search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The set of [promotions](https://developers.google.com/custom-search/docs/promotions). Present only if the
        /// custom search engine's configuration files define any promotions for the given query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<Promotion> Promotions { get; set; }

        /// <summary>Query metadata for the previous, current, and next pages of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual QueriesData Queries { get; set; }

        /// <summary>Metadata about a search operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchInformation")]
        public virtual SearchInformationData SearchInformation { get; set; }

        /// <summary>Spell correction information for a query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spelling")]
        public virtual SpellingData Spelling { get; set; }

        /// <summary>OpenSearch template and URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual UrlData Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Query metadata for the previous, current, and next pages of results.</summary>
        public class QueriesData
        {
            /// <summary>Metadata representing the next page of results, if applicable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("nextPage")]
            public virtual System.Collections.Generic.IList<NextPageData> NextPage { get; set; }

            /// <summary>Metadata representing the previous page of results, if applicable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("previousPage")]
            public virtual System.Collections.Generic.IList<PreviousPageData> PreviousPage { get; set; }

            /// <summary>Metadata representing the current request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("request")]
            public virtual System.Collections.Generic.IList<RequestData> Request { get; set; }

            /// <summary>Metadata representing the next page of results, if applicable.</summary>
            public class NextPageData
            {
                /// <summary>Number of search results returned in this set.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("count")]
                public virtual System.Nullable<int> Count { get; set; }

                /// <summary>
                /// Restricts search results to documents originating in a particular country. You may use [Boolean
                /// operators](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) in
                /// the `cr` parameter's value. Google WebSearch determines the country of a document by analyzing the
                /// following: * The top-level domain (TLD) of the document's URL. * The geographic location of the web
                /// server's IP address. See [Country (cr) Parameter
                /// Values](https://developers.google.com/custom-search/docs/json_api_reference#countryCollections) for
                /// a list of valid values for this parameter.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cr")]
                public virtual string Cr { get; set; }

                /// <summary>
                /// The identifier of an engine created using the Programmable Search Engine [Control
                /// Panel](https://programmablesearchengine.google.com/). This is a custom property not defined in the
                /// OpenSearch spec. This parameter is **required**.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cx")]
                public virtual string Cx { get; set; }

                /// <summary>
                /// Restricts results to URLs based on date. Supported values include: * `d[number]`: requests results
                /// from the specified number of past days. * `w[number]`: requests results from the specified number of
                /// past weeks. * `m[number]`: requests results from the specified number of past months. * `y[number]`:
                /// requests results from the specified number of past years.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("dateRestrict")]
                public virtual string DateRestrict { get; set; }

                /// <summary>
                /// Enables or disables the [Simplified and Traditional Chinese
                /// Search](https://developers.google.com/custom-search/docs/json_api_reference#chineseSearch) feature.
                /// Supported values are: * `0`: enabled (default) * `1`: disabled
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("disableCnTwTranslation")]
                public virtual string DisableCnTwTranslation { get; set; }

                /// <summary>Identifies a phrase that all documents in the search results must contain.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("exactTerms")]
                public virtual string ExactTerms { get; set; }

                /// <summary>
                /// Identifies a word or phrase that should not appear in any documents in the search results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("excludeTerms")]
                public virtual string ExcludeTerms { get; set; }

                /// <summary>
                /// Restricts results to files of a specified extension. Filetypes supported by Google include: * Adobe
                /// Portable Document Format (`pdf`) * Adobe PostScript (`ps`) * Lotus 1-2-3 (`wk1`, `wk2`, `wk3`,
                /// `wk4`, `wk5`, `wki`, `wks`, `wku`) * Lotus WordPro (`lwp`) * Macwrite (`mw`) * Microsoft Excel
                /// (`xls`) * Microsoft PowerPoint (`ppt`) * Microsoft Word (`doc`) * Microsoft Works (`wks`, `wps`,
                /// `wdb`) * Microsoft Write (`wri`) * Rich Text Format (`rtf`) * Shockwave Flash (`swf`) * Text (`ans`,
                /// `txt`). Additional filetypes may be added in the future. An up-to-date list can always be found in
                /// Google's [file type FAQ](https://support.google.com/webmasters/answer/35287).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
                public virtual string FileType { get; set; }

                /// <summary>
                /// Activates or deactivates the automatic filtering of Google search results. See [Automatic
                /// Filtering](https://developers.google.com/custom-search/docs/json_api_reference#automaticFiltering)
                /// for more information about Google's search results filters. Valid values for this parameter are: *
                /// `0`: Disabled * `1`: Enabled (default) **Note**: By default, Google applies filtering to all search
                /// results to improve the quality of those results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filter")]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Boosts search results whose country of origin matches the parameter value. See [Country
                /// Codes](https://developers.google.com/custom-search/docs/json_api_reference#countryCodes) for a list
                /// of valid values. Specifying a `gl` parameter value in WebSearch requests should improve the
                /// relevance of results. This is particularly true for international customers and, even more
                /// specifically, for customers in English-speaking countries other than the United States.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("gl")]
                public virtual string Gl { get; set; }

                /// <summary>
                /// Specifies the Google domain (for example, google.com, google.de, or google.fr) to which the search
                /// should be limited.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("googleHost")]
                public virtual string GoogleHost { get; set; }

                /// <summary>
                /// Specifies the ending value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("highRange")]
                public virtual string HighRange { get; set; }

                /// <summary>
                /// Specifies the interface language (host language) of your user interface. Explicitly setting this
                /// parameter improves the performance and the quality of your search results. See the [Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#wsInterfaceLanguages)
                /// section of [Internationalizing Queries and Results
                /// Presentation](https://developers.google.com/custom-search/docs/json_api_reference#wsInternationalizing)
                /// for more information, and [Supported Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#interfaceLanguages)
                /// for a list of supported languages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hl")]
                public virtual string Hl { get; set; }

                /// <summary>
                /// Appends the specified query terms to the query, as if they were combined with a logical `AND`
                /// operator.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hq")]
                public virtual string Hq { get; set; }

                /// <summary>
                /// Restricts results to images of a specified color type. Supported values are: * `mono` (black and
                /// white) * `gray` (grayscale) * `color` (color)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgColorType")]
                public virtual string ImgColorType { get; set; }

                /// <summary>
                /// Restricts results to images with a specific dominant color. Supported values are: * `red` * `orange`
                /// * `yellow` * `green` * `teal` * `blue` * `purple` * `pink` * `white` * `gray` * `black` * `brown`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgDominantColor")]
                public virtual string ImgDominantColor { get; set; }

                /// <summary>
                /// Restricts results to images of a specified size. Supported values are: * `icon` (small) * `small |
                /// medium | large | xlarge` (medium) * `xxlarge` (large) * `huge` (extra-large)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgSize")]
                public virtual string ImgSize { get; set; }

                /// <summary>
                /// Restricts results to images of a specified type. Supported values are: * `clipart` (Clip art) *
                /// `face` (Face) * `lineart` (Line drawing) * `photo` (Photo) * `animated` (Animated) * `stock` (Stock)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgType")]
                public virtual string ImgType { get; set; }

                /// <summary>The character encoding supported for search requests.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("inputEncoding")]
                public virtual string InputEncoding { get; set; }

                /// <summary>The language of the search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("language")]
                public virtual string Language { get; set; }

                /// <summary>Specifies that all results should contain a link to a specific URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("linkSite")]
                public virtual string LinkSite { get; set; }

                /// <summary>
                /// Specifies the starting value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lowRange")]
                public virtual string LowRange { get; set; }

                /// <summary>
                /// Provides additional search terms to check for in a document, where each document in the search
                /// results must contain at least one of the additional search terms. You can also use the [Boolean
                /// OR](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) query term
                /// for this type of query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("orTerms")]
                public virtual string OrTerms { get; set; }

                /// <summary>The character encoding supported for search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("outputEncoding")]
                public virtual string OutputEncoding { get; set; }

                /// <summary>
                /// Specifies that all search results should be pages that are related to the specified URL. The
                /// parameter value should be a URL.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("relatedSite")]
                public virtual string RelatedSite { get; set; }

                /// <summary>
                /// Filters based on licensing. Supported values include: * `cc_publicdomain` * `cc_attribute` *
                /// `cc_sharealike` * `cc_noncommercial` * `cc_nonderived`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("rights")]
                public virtual string Rights { get; set; }

                /// <summary>
                /// Specifies the [SafeSearch
                /// level](https://developers.google.com/custom-search/docs/json_api_reference#safeSearchLevels) used
                /// for filtering out adult results. This is a custom property not defined in the OpenSearch spec. Valid
                /// parameter values are: * `"off"`: Disable SafeSearch * `"active"`: Enable SafeSearch
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("safe")]
                public virtual string Safe { get; set; }

                /// <summary>The search terms entered by the user.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchTerms")]
                public virtual string SearchTerms { get; set; }

                /// <summary>
                /// Allowed values are `web` or `image`. If unspecified, results are limited to webpages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
                public virtual string SearchType { get; set; }

                /// <summary>Restricts results to URLs from a specified site.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearch")]
                public virtual string SiteSearch { get; set; }

                /// <summary>
                /// Specifies whether to include or exclude results from the site named in the `sitesearch` parameter.
                /// Supported values are: * `i`: include content from site * `e`: exclude content from site
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearchFilter")]
                public virtual string SiteSearchFilter { get; set; }

                /// <summary>
                /// Specifies that results should be sorted according to the specified expression. For example, sort by
                /// date.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("sort")]
                public virtual string Sort { get; set; }

                /// <summary>
                /// The index of the current set of search results into the total set of results, where the index of the
                /// first result is 1.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>
                /// The page number of this set of results, where the page length is set by the `count` property.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startPage")]
                public virtual System.Nullable<int> StartPage { get; set; }

                /// <summary>A description of the query.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("title")]
                public virtual string Title { get; set; }

                /// <summary>Estimated number of total search results. May not be accurate.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
                public virtual System.Nullable<long> TotalResults { get; set; }
            }

            /// <summary>Metadata representing the previous page of results, if applicable.</summary>
            public class PreviousPageData
            {
                /// <summary>Number of search results returned in this set.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("count")]
                public virtual System.Nullable<int> Count { get; set; }

                /// <summary>
                /// Restricts search results to documents originating in a particular country. You may use [Boolean
                /// operators](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) in
                /// the `cr` parameter's value. Google WebSearch determines the country of a document by analyzing the
                /// following: * The top-level domain (TLD) of the document's URL. * The geographic location of the web
                /// server's IP address. See [Country (cr) Parameter
                /// Values](https://developers.google.com/custom-search/docs/json_api_reference#countryCollections) for
                /// a list of valid values for this parameter.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cr")]
                public virtual string Cr { get; set; }

                /// <summary>
                /// The identifier of an engine created using the Programmable Search Engine [Control
                /// Panel](https://programmablesearchengine.google.com/). This is a custom property not defined in the
                /// OpenSearch spec. This parameter is **required**.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cx")]
                public virtual string Cx { get; set; }

                /// <summary>
                /// Restricts results to URLs based on date. Supported values include: * `d[number]`: requests results
                /// from the specified number of past days. * `w[number]`: requests results from the specified number of
                /// past weeks. * `m[number]`: requests results from the specified number of past months. * `y[number]`:
                /// requests results from the specified number of past years.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("dateRestrict")]
                public virtual string DateRestrict { get; set; }

                /// <summary>
                /// Enables or disables the [Simplified and Traditional Chinese
                /// Search](https://developers.google.com/custom-search/docs/json_api_reference#chineseSearch) feature.
                /// Supported values are: * `0`: enabled (default) * `1`: disabled
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("disableCnTwTranslation")]
                public virtual string DisableCnTwTranslation { get; set; }

                /// <summary>Identifies a phrase that all documents in the search results must contain.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("exactTerms")]
                public virtual string ExactTerms { get; set; }

                /// <summary>
                /// Identifies a word or phrase that should not appear in any documents in the search results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("excludeTerms")]
                public virtual string ExcludeTerms { get; set; }

                /// <summary>
                /// Restricts results to files of a specified extension. Filetypes supported by Google include: * Adobe
                /// Portable Document Format (`pdf`) * Adobe PostScript (`ps`) * Lotus 1-2-3 (`wk1`, `wk2`, `wk3`,
                /// `wk4`, `wk5`, `wki`, `wks`, `wku`) * Lotus WordPro (`lwp`) * Macwrite (`mw`) * Microsoft Excel
                /// (`xls`) * Microsoft PowerPoint (`ppt`) * Microsoft Word (`doc`) * Microsoft Works (`wks`, `wps`,
                /// `wdb`) * Microsoft Write (`wri`) * Rich Text Format (`rtf`) * Shockwave Flash (`swf`) * Text (`ans`,
                /// `txt`). Additional filetypes may be added in the future. An up-to-date list can always be found in
                /// Google's [file type FAQ](https://support.google.com/webmasters/answer/35287).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
                public virtual string FileType { get; set; }

                /// <summary>
                /// Activates or deactivates the automatic filtering of Google search results. See [Automatic
                /// Filtering](https://developers.google.com/custom-search/docs/json_api_reference#automaticFiltering)
                /// for more information about Google's search results filters. Valid values for this parameter are: *
                /// `0`: Disabled * `1`: Enabled (default) **Note**: By default, Google applies filtering to all search
                /// results to improve the quality of those results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filter")]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Boosts search results whose country of origin matches the parameter value. See [Country
                /// Codes](https://developers.google.com/custom-search/docs/json_api_reference#countryCodes) for a list
                /// of valid values. Specifying a `gl` parameter value in WebSearch requests should improve the
                /// relevance of results. This is particularly true for international customers and, even more
                /// specifically, for customers in English-speaking countries other than the United States.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("gl")]
                public virtual string Gl { get; set; }

                /// <summary>
                /// Specifies the Google domain (for example, google.com, google.de, or google.fr) to which the search
                /// should be limited.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("googleHost")]
                public virtual string GoogleHost { get; set; }

                /// <summary>
                /// Specifies the ending value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("highRange")]
                public virtual string HighRange { get; set; }

                /// <summary>
                /// Specifies the interface language (host language) of your user interface. Explicitly setting this
                /// parameter improves the performance and the quality of your search results. See the [Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#wsInterfaceLanguages)
                /// section of [Internationalizing Queries and Results
                /// Presentation](https://developers.google.com/custom-search/docs/json_api_reference#wsInternationalizing)
                /// for more information, and [Supported Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#interfaceLanguages)
                /// for a list of supported languages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hl")]
                public virtual string Hl { get; set; }

                /// <summary>
                /// Appends the specified query terms to the query, as if they were combined with a logical `AND`
                /// operator.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hq")]
                public virtual string Hq { get; set; }

                /// <summary>
                /// Restricts results to images of a specified color type. Supported values are: * `mono` (black and
                /// white) * `gray` (grayscale) * `color` (color)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgColorType")]
                public virtual string ImgColorType { get; set; }

                /// <summary>
                /// Restricts results to images with a specific dominant color. Supported values are: * `red` * `orange`
                /// * `yellow` * `green` * `teal` * `blue` * `purple` * `pink` * `white` * `gray` * `black` * `brown`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgDominantColor")]
                public virtual string ImgDominantColor { get; set; }

                /// <summary>
                /// Restricts results to images of a specified size. Supported values are: * `icon` (small) * `small |
                /// medium | large | xlarge` (medium) * `xxlarge` (large) * `huge` (extra-large)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgSize")]
                public virtual string ImgSize { get; set; }

                /// <summary>
                /// Restricts results to images of a specified type. Supported values are: * `clipart` (Clip art) *
                /// `face` (Face) * `lineart` (Line drawing) * `photo` (Photo) * `animated` (Animated) * `stock` (Stock)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgType")]
                public virtual string ImgType { get; set; }

                /// <summary>The character encoding supported for search requests.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("inputEncoding")]
                public virtual string InputEncoding { get; set; }

                /// <summary>The language of the search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("language")]
                public virtual string Language { get; set; }

                /// <summary>Specifies that all results should contain a link to a specific URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("linkSite")]
                public virtual string LinkSite { get; set; }

                /// <summary>
                /// Specifies the starting value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lowRange")]
                public virtual string LowRange { get; set; }

                /// <summary>
                /// Provides additional search terms to check for in a document, where each document in the search
                /// results must contain at least one of the additional search terms. You can also use the [Boolean
                /// OR](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) query term
                /// for this type of query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("orTerms")]
                public virtual string OrTerms { get; set; }

                /// <summary>The character encoding supported for search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("outputEncoding")]
                public virtual string OutputEncoding { get; set; }

                /// <summary>
                /// Specifies that all search results should be pages that are related to the specified URL. The
                /// parameter value should be a URL.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("relatedSite")]
                public virtual string RelatedSite { get; set; }

                /// <summary>
                /// Filters based on licensing. Supported values include: * `cc_publicdomain` * `cc_attribute` *
                /// `cc_sharealike` * `cc_noncommercial` * `cc_nonderived`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("rights")]
                public virtual string Rights { get; set; }

                /// <summary>
                /// Specifies the [SafeSearch
                /// level](https://developers.google.com/custom-search/docs/json_api_reference#safeSearchLevels) used
                /// for filtering out adult results. This is a custom property not defined in the OpenSearch spec. Valid
                /// parameter values are: * `"off"`: Disable SafeSearch * `"active"`: Enable SafeSearch
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("safe")]
                public virtual string Safe { get; set; }

                /// <summary>The search terms entered by the user.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchTerms")]
                public virtual string SearchTerms { get; set; }

                /// <summary>
                /// Allowed values are `web` or `image`. If unspecified, results are limited to webpages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
                public virtual string SearchType { get; set; }

                /// <summary>Restricts results to URLs from a specified site.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearch")]
                public virtual string SiteSearch { get; set; }

                /// <summary>
                /// Specifies whether to include or exclude results from the site named in the `sitesearch` parameter.
                /// Supported values are: * `i`: include content from site * `e`: exclude content from site
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearchFilter")]
                public virtual string SiteSearchFilter { get; set; }

                /// <summary>
                /// Specifies that results should be sorted according to the specified expression. For example, sort by
                /// date.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("sort")]
                public virtual string Sort { get; set; }

                /// <summary>
                /// The index of the current set of search results into the total set of results, where the index of the
                /// first result is 1.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>
                /// The page number of this set of results, where the page length is set by the `count` property.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startPage")]
                public virtual System.Nullable<int> StartPage { get; set; }

                /// <summary>A description of the query.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("title")]
                public virtual string Title { get; set; }

                /// <summary>Estimated number of total search results. May not be accurate.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
                public virtual System.Nullable<long> TotalResults { get; set; }
            }

            /// <summary>Metadata representing the current request.</summary>
            public class RequestData
            {
                /// <summary>Number of search results returned in this set.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("count")]
                public virtual System.Nullable<int> Count { get; set; }

                /// <summary>
                /// Restricts search results to documents originating in a particular country. You may use [Boolean
                /// operators](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) in
                /// the `cr` parameter's value. Google WebSearch determines the country of a document by analyzing the
                /// following: * The top-level domain (TLD) of the document's URL. * The geographic location of the web
                /// server's IP address. See [Country (cr) Parameter
                /// Values](https://developers.google.com/custom-search/docs/json_api_reference#countryCollections) for
                /// a list of valid values for this parameter.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cr")]
                public virtual string Cr { get; set; }

                /// <summary>
                /// The identifier of an engine created using the Programmable Search Engine [Control
                /// Panel](https://programmablesearchengine.google.com/). This is a custom property not defined in the
                /// OpenSearch spec. This parameter is **required**.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("cx")]
                public virtual string Cx { get; set; }

                /// <summary>
                /// Restricts results to URLs based on date. Supported values include: * `d[number]`: requests results
                /// from the specified number of past days. * `w[number]`: requests results from the specified number of
                /// past weeks. * `m[number]`: requests results from the specified number of past months. * `y[number]`:
                /// requests results from the specified number of past years.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("dateRestrict")]
                public virtual string DateRestrict { get; set; }

                /// <summary>
                /// Enables or disables the [Simplified and Traditional Chinese
                /// Search](https://developers.google.com/custom-search/docs/json_api_reference#chineseSearch) feature.
                /// Supported values are: * `0`: enabled (default) * `1`: disabled
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("disableCnTwTranslation")]
                public virtual string DisableCnTwTranslation { get; set; }

                /// <summary>Identifies a phrase that all documents in the search results must contain.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("exactTerms")]
                public virtual string ExactTerms { get; set; }

                /// <summary>
                /// Identifies a word or phrase that should not appear in any documents in the search results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("excludeTerms")]
                public virtual string ExcludeTerms { get; set; }

                /// <summary>
                /// Restricts results to files of a specified extension. Filetypes supported by Google include: * Adobe
                /// Portable Document Format (`pdf`) * Adobe PostScript (`ps`) * Lotus 1-2-3 (`wk1`, `wk2`, `wk3`,
                /// `wk4`, `wk5`, `wki`, `wks`, `wku`) * Lotus WordPro (`lwp`) * Macwrite (`mw`) * Microsoft Excel
                /// (`xls`) * Microsoft PowerPoint (`ppt`) * Microsoft Word (`doc`) * Microsoft Works (`wks`, `wps`,
                /// `wdb`) * Microsoft Write (`wri`) * Rich Text Format (`rtf`) * Shockwave Flash (`swf`) * Text (`ans`,
                /// `txt`). Additional filetypes may be added in the future. An up-to-date list can always be found in
                /// Google's [file type FAQ](https://support.google.com/webmasters/answer/35287).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
                public virtual string FileType { get; set; }

                /// <summary>
                /// Activates or deactivates the automatic filtering of Google search results. See [Automatic
                /// Filtering](https://developers.google.com/custom-search/docs/json_api_reference#automaticFiltering)
                /// for more information about Google's search results filters. Valid values for this parameter are: *
                /// `0`: Disabled * `1`: Enabled (default) **Note**: By default, Google applies filtering to all search
                /// results to improve the quality of those results.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filter")]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Boosts search results whose country of origin matches the parameter value. See [Country
                /// Codes](https://developers.google.com/custom-search/docs/json_api_reference#countryCodes) for a list
                /// of valid values. Specifying a `gl` parameter value in WebSearch requests should improve the
                /// relevance of results. This is particularly true for international customers and, even more
                /// specifically, for customers in English-speaking countries other than the United States.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("gl")]
                public virtual string Gl { get; set; }

                /// <summary>
                /// Specifies the Google domain (for example, google.com, google.de, or google.fr) to which the search
                /// should be limited.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("googleHost")]
                public virtual string GoogleHost { get; set; }

                /// <summary>
                /// Specifies the ending value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("highRange")]
                public virtual string HighRange { get; set; }

                /// <summary>
                /// Specifies the interface language (host language) of your user interface. Explicitly setting this
                /// parameter improves the performance and the quality of your search results. See the [Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#wsInterfaceLanguages)
                /// section of [Internationalizing Queries and Results
                /// Presentation](https://developers.google.com/custom-search/docs/json_api_reference#wsInternationalizing)
                /// for more information, and [Supported Interface
                /// Languages](https://developers.google.com/custom-search/docs/json_api_reference#interfaceLanguages)
                /// for a list of supported languages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hl")]
                public virtual string Hl { get; set; }

                /// <summary>
                /// Appends the specified query terms to the query, as if they were combined with a logical `AND`
                /// operator.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("hq")]
                public virtual string Hq { get; set; }

                /// <summary>
                /// Restricts results to images of a specified color type. Supported values are: * `mono` (black and
                /// white) * `gray` (grayscale) * `color` (color)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgColorType")]
                public virtual string ImgColorType { get; set; }

                /// <summary>
                /// Restricts results to images with a specific dominant color. Supported values are: * `red` * `orange`
                /// * `yellow` * `green` * `teal` * `blue` * `purple` * `pink` * `white` * `gray` * `black` * `brown`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgDominantColor")]
                public virtual string ImgDominantColor { get; set; }

                /// <summary>
                /// Restricts results to images of a specified size. Supported values are: * `icon` (small) * `small |
                /// medium | large | xlarge` (medium) * `xxlarge` (large) * `huge` (extra-large)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgSize")]
                public virtual string ImgSize { get; set; }

                /// <summary>
                /// Restricts results to images of a specified type. Supported values are: * `clipart` (Clip art) *
                /// `face` (Face) * `lineart` (Line drawing) * `photo` (Photo) * `animated` (Animated) * `stock` (Stock)
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("imgType")]
                public virtual string ImgType { get; set; }

                /// <summary>The character encoding supported for search requests.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("inputEncoding")]
                public virtual string InputEncoding { get; set; }

                /// <summary>The language of the search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("language")]
                public virtual string Language { get; set; }

                /// <summary>Specifies that all results should contain a link to a specific URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("linkSite")]
                public virtual string LinkSite { get; set; }

                /// <summary>
                /// Specifies the starting value for a search range. Use `cse:lowRange` and `cse:highrange` to append an
                /// inclusive search range of `lowRange...highRange` to the query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lowRange")]
                public virtual string LowRange { get; set; }

                /// <summary>
                /// Provides additional search terms to check for in a document, where each document in the search
                /// results must contain at least one of the additional search terms. You can also use the [Boolean
                /// OR](https://developers.google.com/custom-search/docs/json_api_reference#BooleanOrSearch) query term
                /// for this type of query.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("orTerms")]
                public virtual string OrTerms { get; set; }

                /// <summary>The character encoding supported for search results.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("outputEncoding")]
                public virtual string OutputEncoding { get; set; }

                /// <summary>
                /// Specifies that all search results should be pages that are related to the specified URL. The
                /// parameter value should be a URL.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("relatedSite")]
                public virtual string RelatedSite { get; set; }

                /// <summary>
                /// Filters based on licensing. Supported values include: * `cc_publicdomain` * `cc_attribute` *
                /// `cc_sharealike` * `cc_noncommercial` * `cc_nonderived`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("rights")]
                public virtual string Rights { get; set; }

                /// <summary>
                /// Specifies the [SafeSearch
                /// level](https://developers.google.com/custom-search/docs/json_api_reference#safeSearchLevels) used
                /// for filtering out adult results. This is a custom property not defined in the OpenSearch spec. Valid
                /// parameter values are: * `"off"`: Disable SafeSearch * `"active"`: Enable SafeSearch
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("safe")]
                public virtual string Safe { get; set; }

                /// <summary>The search terms entered by the user.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchTerms")]
                public virtual string SearchTerms { get; set; }

                /// <summary>
                /// Allowed values are `web` or `image`. If unspecified, results are limited to webpages.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
                public virtual string SearchType { get; set; }

                /// <summary>Restricts results to URLs from a specified site.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearch")]
                public virtual string SiteSearch { get; set; }

                /// <summary>
                /// Specifies whether to include or exclude results from the site named in the `sitesearch` parameter.
                /// Supported values are: * `i`: include content from site * `e`: exclude content from site
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("siteSearchFilter")]
                public virtual string SiteSearchFilter { get; set; }

                /// <summary>
                /// Specifies that results should be sorted according to the specified expression. For example, sort by
                /// date.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("sort")]
                public virtual string Sort { get; set; }

                /// <summary>
                /// The index of the current set of search results into the total set of results, where the index of the
                /// first result is 1.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
                public virtual System.Nullable<int> StartIndex { get; set; }

                /// <summary>
                /// The page number of this set of results, where the page length is set by the `count` property.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startPage")]
                public virtual System.Nullable<int> StartPage { get; set; }

                /// <summary>A description of the query.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("title")]
                public virtual string Title { get; set; }

                /// <summary>Estimated number of total search results. May not be accurate.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
                public virtual System.Nullable<long> TotalResults { get; set; }
            }
        }

        /// <summary>Metadata about a search operation.</summary>
        public class SearchInformationData
        {
            /// <summary>
            /// The time taken for the server to return search results, formatted according to locale style.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("formattedSearchTime")]
            public virtual string FormattedSearchTime { get; set; }

            /// <summary>The total number of search results, formatted according to locale style.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("formattedTotalResults")]
            public virtual string FormattedTotalResults { get; set; }

            /// <summary>The time taken for the server to return search results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("searchTime")]
            public virtual System.Nullable<double> SearchTime { get; set; }

            /// <summary>The total number of search results returned by the query.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
            public virtual string TotalResults { get; set; }
        }

        /// <summary>Spell correction information for a query.</summary>
        public class SpellingData
        {
            /// <summary>The corrected query.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("correctedQuery")]
            public virtual string CorrectedQuery { get; set; }

            /// <summary>The corrected query, formatted in HTML.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("htmlCorrectedQuery")]
            public virtual string HtmlCorrectedQuery { get; set; }
        }

        /// <summary>OpenSearch template and URL.</summary>
        public class UrlData
        {
            /// <summary>
            /// The actual [OpenSearch
            /// template](http://www.opensearch.org/specifications/opensearch/1.1#opensearch_url_template_syntax) for
            /// this API.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("template")]
            public virtual string Template { get; set; }

            /// <summary>The MIME type of the OpenSearch URL template for the Custom Search JSON API.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }
}
