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

namespace Google.Apis.Cloudbilling.v1
{
    /// <summary>The Cloudbilling Service.</summary>
    public class CloudbillingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudbillingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudbillingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BillingAccounts = new BillingAccountsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            Services = new ServicesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudbilling.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudbilling.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudbilling";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Billing API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public static string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>View your Google Cloud Platform billing accounts</summary>
            public static string CloudBillingReadonly = "https://www.googleapis.com/auth/cloud-billing.readonly";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Billing API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public const string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>View your Google Cloud Platform billing accounts</summary>
            public const string CloudBillingReadonly = "https://www.googleapis.com/auth/cloud-billing.readonly";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }
    }

    /// <summary>A base abstract class for Cloudbilling requests.</summary>
    public abstract class CloudbillingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudbillingBaseServiceRequest instance.</summary>
        protected CloudbillingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Cloudbilling parameter list.</summary>
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

    /// <summary>The "billingAccounts" collection of methods.</summary>
    public class BillingAccountsResource
    {
        private const string Resource = "billingAccounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingAccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Projects = new ProjectsResource(service);
            SubAccounts = new SubAccountsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
            }

            /// <summary>
            /// Lists the projects associated with a billing account. The current authenticated user must have the
            /// `billing.resourceAssociations.list` IAM permission, which is often given to billing account
            /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the billing account associated with the projects that you want to list.
            /// For example, `billingAccounts/012345-567890-ABCDEF`.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists the projects associated with a billing account. The current authenticated user must have the
            /// `billing.resourceAssociations.list` IAM permission, which is often given to billing account
            /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListProjectBillingInfoResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the billing account associated with the projects that you want to
                /// list. For example, `billingAccounts/012345-567890-ABCDEF`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Requested page size. The maximum page size is 100; this is also the default.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results to be returned. This should be a `next_page_token` value
                /// returned from a previous `ListProjectBillingInfo` call. If unspecified, the first page of results is
                /// returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/projects";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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

        /// <summary>Gets the SubAccounts resource.</summary>
        public virtual SubAccountsResource SubAccounts { get; }

        /// <summary>The "subAccounts" collection of methods.</summary>
        public class SubAccountsResource
        {
            private const string Resource = "subAccounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubAccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
            /// Google Cloud resellers should use the Channel Services APIs,
            /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
            /// and
            /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
            /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
            /// permission on the parent account, which is typically given to billing account
            /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return
            /// an error if the parent account has not been provisioned for subaccounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. The parent to create a billing account from. Format: - `billingAccounts/{billing_account_id}`,
            /// for example, `billingAccounts/012345-567890-ABCDEF`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
            /// Google Cloud resellers should use the Channel Services APIs,
            /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
            /// and
            /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
            /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
            /// permission on the parent account, which is typically given to billing account
            /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return
            /// an error if the parent account has not been provisioned for subaccounts.
            /// </summary>
            public class CreateRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. The parent to create a billing account from. Format: -
                /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudbilling.v1.Data.BillingAccount Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/subAccounts";

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
                        Pattern = @"^billingAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the billing accounts that the current authenticated user has permission to
            /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            /// <param name="parent">
            /// Optional. The parent resource to list billing accounts from. Format: -
            /// `organizations/{organization_id}`, for example, `organizations/12345678` -
            /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the billing accounts that the current authenticated user has permission to
            /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListBillingAccountsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Optional. The parent resource to list billing accounts from. Format: -
                /// `organizations/{organization_id}`, for example, `organizations/12345678` -
                /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Options for how to filter the returned billing accounts. This only supports filtering for
                /// [subaccounts](https://cloud.google.com/billing/docs/concepts) under a single provided parent billing
                /// account. (for example, `master_billing_account=billingAccounts/012345-678901-ABCDEF`). Boolean
                /// algebra and other fields are not currently supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size. The maximum page size is 100; this is also the default.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results to return. This should be a `next_page_token` value returned
                /// from a previous `ListBillingAccounts` call. If unspecified, the first page of results is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/subAccounts";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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
        /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// Google Cloud resellers should use the Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
        /// permission on the parent account, which is typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return an
        /// error if the parent account has not been provisioned for subaccounts.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Cloudbilling.v1.Data.BillingAccount body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// Google Cloud resellers should use the Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
        /// permission on the parent account, which is typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return an
        /// error if the parent account has not been provisioned for subaccounts.
        /// </summary>
        public class CreateRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.BillingAccount body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. The parent to create a billing account from. Format: - `billingAccounts/{billing_account_id}`,
            /// for example, `billingAccounts/012345-567890-ABCDEF`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.BillingAccount Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/billingAccounts";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets information about a billing account. The current authenticated user must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets information about a billing account. The current authenticated user must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the billing account to retrieve. For example,
            /// `billingAccounts/012345-567890-ABCDEF`.
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
                    Pattern = @"^billingAccounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a billing account. The caller must have the
        /// `billing.accounts.getIamPolicy` permission on the account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
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
        /// Gets the access control policy for a billing account. The caller must have the
        /// `billing.accounts.getIamPolicy` permission on the account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public class GetIamPolicyRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
            {
                Resource = resource;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>
            /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and
            /// 3. Requests specifying an invalid value will be rejected. Requests for policies with any conditional
            /// role bindings must specify version 3. Policies with no conditional role bindings may specify any valid
            /// value or leave the field unset. The policy in the response might use the policy version that you
            /// specified, or it might use a lower policy version. For example, if you specify version 3, but the policy
            /// has no conditional role bindings, the response uses version 1. To learn which resources support
            /// conditions in their IAM policies, see the [IAM
            /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                    Pattern = @"^billingAccounts/[^/]+$",
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

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListBillingAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Options for how to filter the returned billing accounts. This only supports filtering for
            /// [subaccounts](https://cloud.google.com/billing/docs/concepts) under a single provided parent billing
            /// account. (for example, `master_billing_account=billingAccounts/012345-678901-ABCDEF`). Boolean algebra
            /// and other fields are not currently supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Requested page size. The maximum page size is 100; this is also the default.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying a page of results to return. This should be a `next_page_token` value returned from
            /// a previous `ListBillingAccounts` call. If unspecified, the first page of results is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The parent resource to list billing accounts from. Format: -
            /// `organizations/{organization_id}`, for example, `organizations/12345678` -
            /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/billingAccounts";

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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Changes which parent organization a billing account belongs to.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the billing account to move. Must be of the form
        /// `billingAccounts/{billing_account_id}`. The specified billing account cannot be a subaccount, since a
        /// subaccount always belongs to the same organization as its parent account.
        /// </param>
        public virtual MoveRequest Move(Google.Apis.Cloudbilling.v1.Data.MoveBillingAccountRequest body, string name)
        {
            return new MoveRequest(this.service, body, name);
        }

        /// <summary>Changes which parent organization a billing account belongs to.</summary>
        public class MoveRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
        {
            /// <summary>Constructs a new Move request.</summary>
            public MoveRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.MoveBillingAccountRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the billing account to move. Must be of the form
            /// `billingAccounts/{billing_account_id}`. The specified billing account cannot be a subaccount, since a
            /// subaccount always belongs to the same organization as its parent account.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.MoveBillingAccountRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "move";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:move";

            /// <summary>Initializes Move parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^billingAccounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates a billing account's fields. Currently the only field that can be edited is `display_name`. The
        /// current authenticated user must have the `billing.accounts.update` IAM permission, which is typically given
        /// to the [administrator](https://cloud.google.com/billing/docs/how-to/billing-access) of the billing account.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the billing account resource to be updated.</param>
        public virtual PatchRequest Patch(Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates a billing account's fields. Currently the only field that can be edited is `display_name`. The
        /// current authenticated user must have the `billing.accounts.update` IAM permission, which is typically given
        /// to the [administrator](https://cloud.google.com/billing/docs/how-to/billing-access) of the billing account.
        /// </summary>
        public class PatchRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the billing account resource to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The update mask applied to the resource. Only "display_name" is currently supported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.BillingAccount Body { get; set; }

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
                    Pattern = @"^billingAccounts/[^/]+$",
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

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing policy. The caller must have the
        /// `billing.accounts.setIamPolicy` permission on the account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Cloudbilling.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing policy. The caller must have the
        /// `billing.accounts.setIamPolicy` permission on the account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public class SetIamPolicyRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                    Pattern = @"^billingAccounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes the resource and a set of
        /// permissions as input and returns the subset of the input permissions that the caller is allowed for that
        /// resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Cloudbilling.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, resource);
        }

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes the resource and a set of
        /// permissions as input and returns the subset of the input permissions that the caller is allowed for that
        /// resource.
        /// </summary>
        public class TestIamPermissionsRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                    Pattern = @"^billingAccounts/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            BillingAccounts = new BillingAccountsResource(service);
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }

        /// <summary>The "billingAccounts" collection of methods.</summary>
        public class BillingAccountsResource
        {
            private const string Resource = "billingAccounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BillingAccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
            /// Google Cloud resellers should use the Channel Services APIs,
            /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
            /// and
            /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
            /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
            /// permission on the parent account, which is typically given to billing account
            /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return
            /// an error if the parent account has not been provisioned for subaccounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Optional. The parent to create a billing account from. Format: - `billingAccounts/{billing_account_id}`,
            /// for example, `billingAccounts/012345-567890-ABCDEF`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// This method creates [billing subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
            /// Google Cloud resellers should use the Channel Services APIs,
            /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
            /// and
            /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
            /// When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM
            /// permission on the parent account, which is typically given to billing account
            /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return
            /// an error if the parent account has not been provisioned for subaccounts.
            /// </summary>
            public class CreateRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.BillingAccount body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Optional. The parent to create a billing account from. Format: -
                /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudbilling.v1.Data.BillingAccount Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/billingAccounts";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the billing accounts that the current authenticated user has permission to
            /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            /// <param name="parent">
            /// Optional. The parent resource to list billing accounts from. Format: -
            /// `organizations/{organization_id}`, for example, `organizations/12345678` -
            /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the billing accounts that the current authenticated user has permission to
            /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
            /// </summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListBillingAccountsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Optional. The parent resource to list billing accounts from. Format: -
                /// `organizations/{organization_id}`, for example, `organizations/12345678` -
                /// `billingAccounts/{billing_account_id}`, for example, `billingAccounts/012345-567890-ABCDEF`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Options for how to filter the returned billing accounts. This only supports filtering for
                /// [subaccounts](https://cloud.google.com/billing/docs/concepts) under a single provided parent billing
                /// account. (for example, `master_billing_account=billingAccounts/012345-678901-ABCDEF`). Boolean
                /// algebra and other fields are not currently supported.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size. The maximum page size is 100; this is also the default.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results to return. This should be a `next_page_token` value returned
                /// from a previous `ListBillingAccounts` call. If unspecified, the first page of results is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/billingAccounts";

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
                        Pattern = @"^organizations/[^/]+$",
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

            /// <summary>Changes which parent organization a billing account belongs to.</summary>
            /// <param name="destinationParent">
            /// Required. The resource name of the Organization to move the billing account under. Must be of the form
            /// `organizations/{organization_id}`.
            /// </param>
            /// <param name="name">
            /// Required. The resource name of the billing account to move. Must be of the form
            /// `billingAccounts/{billing_account_id}`. The specified billing account cannot be a subaccount, since a
            /// subaccount always belongs to the same organization as its parent account.
            /// </param>
            public virtual MoveRequest Move(string destinationParent, string name)
            {
                return new MoveRequest(this.service, destinationParent, name);
            }

            /// <summary>Changes which parent organization a billing account belongs to.</summary>
            public class MoveRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.BillingAccount>
            {
                /// <summary>Constructs a new Move request.</summary>
                public MoveRequest(Google.Apis.Services.IClientService service, string destinationParent, string name) : base(service)
                {
                    DestinationParent = destinationParent;
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Organization to move the billing account under. Must be of the
                /// form `organizations/{organization_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("destinationParent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DestinationParent { get; private set; }

                /// <summary>
                /// Required. The resource name of the billing account to move. Must be of the form
                /// `billingAccounts/{billing_account_id}`. The specified billing account cannot be a subaccount, since
                /// a subaccount always belongs to the same organization as its parent account.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "move";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+destinationParent}/{+name}:move";

                /// <summary>Initializes Move parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("destinationParent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "destinationParent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^billingAccounts/[^/]+$",
                    });
                }
            }
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
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user must have the
        /// `resourcemanager.projects.get` permission for the project, which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is retrieved. For example,
        /// `projects/tokyo-rain-123`.
        /// </param>
        public virtual GetBillingInfoRequest GetBillingInfo(string name)
        {
            return new GetBillingInfoRequest(this.service, name);
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user must have the
        /// `resourcemanager.projects.get` permission for the project, which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) role.
        /// </summary>
        public class GetBillingInfoRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ProjectBillingInfo>
        {
            /// <summary>Constructs a new GetBillingInfo request.</summary>
            public GetBillingInfoRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the project for which billing information is retrieved. For example,
            /// `projects/tokyo-rain-123`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getBillingInfo";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}/billingInfo";

            /// <summary>Initializes GetBillingInfo parameter list.</summary>
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
        /// Sets or updates the billing account associated with a project. You specify the new billing account by
        /// setting the `billing_account_name` in the `ProjectBillingInfo` resource to the resource name of a billing
        /// account. Associating a project with an open billing account enables billing on the project and allows
        /// charges for resource usage. If the project already had a billing account, this method changes the billing
        /// account used for resource usage charges. *Note:* Incurred charges that have not yet been reported in the
        /// transaction history of the Google Cloud Console might be billed to the new billing account, even if the
        /// charge occurred before the new billing account was assigned to the project. The current authenticated user
        /// must have ownership privileges for both the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access). You can disable billing on the
        /// project by setting the `billing_account_name` field to empty. This action disassociates the current billing
        /// account from the project. Any billable activity of your in-use services will stop, and your application
        /// could stop functioning as expected. Any unbilled charges to date will be billed to the previously associated
        /// account. The current authenticated user must be either an owner of the project or an owner of the billing
        /// account for the project. Note that associating a project with a *closed* billing account will have much the
        /// same effect as disabling billing on the project: any paid resources used by the project will be shut down.
        /// Thus, unless you wish to disable billing, you should always call this method with the name of an *open*
        /// billing account.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the project associated with the billing information that you want to update.
        /// For example, `projects/tokyo-rain-123`.
        /// </param>
        public virtual UpdateBillingInfoRequest UpdateBillingInfo(Google.Apis.Cloudbilling.v1.Data.ProjectBillingInfo body, string name)
        {
            return new UpdateBillingInfoRequest(this.service, body, name);
        }

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify the new billing account by
        /// setting the `billing_account_name` in the `ProjectBillingInfo` resource to the resource name of a billing
        /// account. Associating a project with an open billing account enables billing on the project and allows
        /// charges for resource usage. If the project already had a billing account, this method changes the billing
        /// account used for resource usage charges. *Note:* Incurred charges that have not yet been reported in the
        /// transaction history of the Google Cloud Console might be billed to the new billing account, even if the
        /// charge occurred before the new billing account was assigned to the project. The current authenticated user
        /// must have ownership privileges for both the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access). You can disable billing on the
        /// project by setting the `billing_account_name` field to empty. This action disassociates the current billing
        /// account from the project. Any billable activity of your in-use services will stop, and your application
        /// could stop functioning as expected. Any unbilled charges to date will be billed to the previously associated
        /// account. The current authenticated user must be either an owner of the project or an owner of the billing
        /// account for the project. Note that associating a project with a *closed* billing account will have much the
        /// same effect as disabling billing on the project: any paid resources used by the project will be shut down.
        /// Thus, unless you wish to disable billing, you should always call this method with the name of an *open*
        /// billing account.
        /// </summary>
        public class UpdateBillingInfoRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ProjectBillingInfo>
        {
            /// <summary>Constructs a new UpdateBillingInfo request.</summary>
            public UpdateBillingInfoRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1.Data.ProjectBillingInfo body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the project associated with the billing information that you want to
            /// update. For example, `projects/tokyo-rain-123`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1.Data.ProjectBillingInfo Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateBillingInfo";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}/billingInfo";

            /// <summary>Initializes UpdateBillingInfo parameter list.</summary>
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
    }

    /// <summary>The "services" collection of methods.</summary>
    public class ServicesResource
    {
        private const string Resource = "services";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ServicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Skus = new SkusResource(service);
        }

        /// <summary>Gets the Skus resource.</summary>
        public virtual SkusResource Skus { get; }

        /// <summary>The "skus" collection of methods.</summary>
        public class SkusResource
        {
            private const string Resource = "skus";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SkusResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all publicly available SKUs for a given cloud service.</summary>
            /// <param name="parent">Required. The name of the service. Example: "services/6F81-5844-456A"</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all publicly available SKUs for a given cloud service.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListSkusResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the service. Example: "services/6F81-5844-456A"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The ISO 4217 currency code for the pricing info in the response proto. Will use the conversion rate
                /// as of start_time. Optional. If not specified USD will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CurrencyCode { get; set; }

                private object _endTime;

                /// <summary>
                /// String representation of <see cref="EndTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
                public virtual object EndTime
                {
                    get => _endTime;
                    set
                    {
                        EndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _endTime = value;
                    }
                }

                public virtual System.DateTimeOffset? EndTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
                    set
                    {
                        EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _endTime = value;
                    }
                }

                /// <summary>Requested page size. Defaults to 5000.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results to return. This should be a `next_page_token` value returned
                /// from a previous `ListSkus` call. If unspecified, the first page of results is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                private object _startTime;

                /// <summary>
                /// String representation of <see cref="StartTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
                public virtual object StartTime
                {
                    get => _startTime;
                    set
                    {
                        StartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _startTime = value;
                    }
                }

                public virtual System.DateTimeOffset? StartTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
                    set
                    {
                        StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _startTime = value;
                    }
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/skus";

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
                        Pattern = @"^services/[^/]+$",
                    });
                    RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currencyCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endTime",
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
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Lists all public cloud services.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all public cloud services.</summary>
        public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1.Data.ListServicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Requested page size. Defaults to 5000.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying a page of results to return. This should be a `next_page_token` value returned from
            /// a previous `ListServices` call. If unspecified, the first page of results is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
}
namespace Google.Apis.Cloudbilling.v1.Data
{
    /// <summary>Represents the aggregation level and interval for pricing of a single SKU.</summary>
    public class AggregationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of intervals to aggregate over. Example: If aggregation_level is "DAILY" and aggregation_count is
        /// 14, aggregation will be over 14 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationCount")]
        public virtual System.Nullable<int> AggregationCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("aggregationInterval")]
        public virtual string AggregationInterval { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("aggregationLevel")]
        public virtual string AggregationLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A billing account in the [Google Cloud Console](https://console.cloud.google.com/). You can assign a billing
    /// account to one or more projects.
    /// </summary>
    public class BillingAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The currency in which the billing account is billed and charged, represented as an ISO 4217 code
        /// such as `USD`. Billing account currency is determined at the time of billing account creation and cannot be
        /// updated subsequently, so this field should not be set on update requests. In addition, a subaccount always
        /// matches the currency of its parent billing account, so this field should not be set on subaccount creation
        /// requests. Clients can read this field to determine the currency of an existing billing account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// The display name given to the billing account, such as `My Billing Account`. This name is displayed in the
        /// Google Cloud Console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// If this account is a [subaccount](https://cloud.google.com/billing/docs/concepts), then this will be the
        /// resource name of the parent billing account that it is being resold through. Otherwise this will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterBillingAccount")]
        public virtual string MasterBillingAccount { get; set; }

        /// <summary>
        /// Output only. The resource name of the billing account. The resource name has the form
        /// `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF` would be the
        /// resource name for billing account `012345-567890-ABCDEF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. True if the billing account is open, and will therefore be charged for any usage on associated
        /// projects. False if the billing account is closed, and therefore projects associated with it are unable to
        /// use paid services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("open")]
        public virtual System.Nullable<bool> Open { get; set; }

        /// <summary>
        /// Output only. The billing account's parent resource identifier. Use the `MoveBillingAccount` method to update
        /// the account's parent resource if it is a organization. Format: - `organizations/{organization_id}`, for
        /// example, `organizations/12345678` - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Represents the category hierarchy of a SKU.</summary>
    public class Category : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of product the SKU refers to. Example: "Compute", "Storage", "Network", "ApplicationServices" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFamily")]
        public virtual string ResourceFamily { get; set; }

        /// <summary>
        /// A group classification for related SKUs. Example: "RAM", "GPU", "Prediction", "Ops", "GoogleEgress" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual string ResourceGroup { get; set; }

        /// <summary>The display name of the service this SKU belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDisplayName")]
        public virtual string ServiceDisplayName { get; set; }

        /// <summary>
        /// Represents how the SKU is consumed. Example: "OnDemand", "Preemptible", "Commit1Mo", "Commit1Yr" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageType")]
        public virtual string UsageType { get; set; }

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

    /// <summary>Encapsulates the geographic taxonomy data for a sku.</summary>
    public class GeoTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of regions associated with a sku. Empty for Global skus, which are associated with all Google Cloud
        /// regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The type of Geo Taxonomy: GLOBAL, REGIONAL, or MULTI_REGIONAL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListBillingAccounts`.</summary>
    public class ListBillingAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of billing accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccounts")]
        public virtual System.Collections.Generic.IList<BillingAccount> BillingAccounts { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. To retrieve the next page, call `ListBillingAccounts` again
        /// with the `page_token` field set to this value. This field is empty if there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `ListProjectBillingInfoResponse`.</summary>
    public class ListProjectBillingInfoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. To retrieve the next page, call `ListProjectBillingInfo` again
        /// with the `page_token` field set to this value. This field is empty if there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A list of `ProjectBillingInfo` resources representing the projects associated with the billing account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectBillingInfo")]
        public virtual System.Collections.Generic.IList<ProjectBillingInfo> ProjectBillingInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListServices`.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. To retrieve the next page, call `ListServices` again with the
        /// `page_token` field set to this value. This field is empty if there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListSkus`.</summary>
    public class ListSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. To retrieve the next page, call `ListSkus` again with the
        /// `page_token` field set to this value. This field is empty if there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of public SKUs of the given service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skus")]
        public virtual System.Collections.Generic.IList<Sku> Skus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for `MoveBillingAccount` RPC.</summary>
    public class MoveBillingAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the Organization to move the billing account under. Must be of the form
        /// `organizations/{organization_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

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
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

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
    /// Expresses a mathematical pricing formula. For Example:- `usage_unit: GBy` `tiered_rates:` `[start_usage_amount:
    /// 20, unit_price: $10]` `[start_usage_amount: 100, unit_price: $5]` The above expresses a pricing formula where
    /// the first 20GB is free, the next 80GB is priced at $10 per GB followed by $5 per GB for additional usage.
    /// </summary>
    public class PricingExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base unit for the SKU which is the unit used in usage exports. Example: "By"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUnit")]
        public virtual string BaseUnit { get; set; }

        /// <summary>
        /// Conversion factor for converting from price per usage_unit to price per base_unit, and start_usage_amount to
        /// start_usage_amount in base_unit. unit_price / base_unit_conversion_factor = price per base_unit.
        /// start_usage_amount * base_unit_conversion_factor = start_usage_amount in base_unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUnitConversionFactor")]
        public virtual System.Nullable<double> BaseUnitConversionFactor { get; set; }

        /// <summary>The base unit in human readable form. Example: "byte".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUnitDescription")]
        public virtual string BaseUnitDescription { get; set; }

        /// <summary>
        /// The recommended quantity of units for displaying pricing info. When displaying pricing info it is
        /// recommended to display: (unit_price * display_quantity) per display_quantity usage_unit. This field does not
        /// affect the pricing formula and is for display purposes only. Example: If the unit_price is "0.0001 USD", the
        /// usage_unit is "GB" and the display_quantity is "1000" then the recommended way of displaying the pricing
        /// info is "0.10 USD per 1000 GB"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayQuantity")]
        public virtual System.Nullable<double> DisplayQuantity { get; set; }

        /// <summary>
        /// The list of tiered rates for this pricing. The total cost is computed by applying each of the tiered rates
        /// on usage. This repeated list is sorted by ascending order of start_usage_amount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tieredRates")]
        public virtual System.Collections.Generic.IList<TierRate> TieredRates { get; set; }

        /// <summary>
        /// The short hand for unit of usage this pricing is specified in. Example: usage_unit of "GiBy" means that
        /// usage is specified in "Gibi Byte".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageUnit")]
        public virtual string UsageUnit { get; set; }

        /// <summary>The unit of usage in human readable form. Example: "gibi byte".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageUnitDescription")]
        public virtual string UsageUnitDescription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the pricing information for a SKU at a single point of time.</summary>
    public class PricingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aggregation Info. This can be left unspecified if the pricing expression doesn't require aggregation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationInfo")]
        public virtual AggregationInfo AggregationInfo { get; set; }

        /// <summary>
        /// Conversion rate used for currency conversion, from USD to the currency specified in the request. This
        /// includes any surcharge collected for billing in non USD currency. If a currency is not specified in the
        /// request this defaults to 1.0. Example: USD * currency_conversion_rate = JPY
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyConversionRate")]
        public virtual System.Nullable<double> CurrencyConversionRate { get; set; }

        private string _effectiveTimeRaw;

        private object _effectiveTime;

        /// <summary>
        /// The timestamp from which this pricing was effective within the requested time range. This is guaranteed to
        /// be greater than or equal to the start_time field in the request and less than the end_time field in the
        /// request. If a time range was not specified in the request this field will be equivalent to a time within the
        /// last 12 hours, indicating the latest pricing info.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
        public virtual string EffectiveTimeRaw
        {
            get => _effectiveTimeRaw;
            set
            {
                _effectiveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _effectiveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
        public virtual object EffectiveTime
        {
            get => _effectiveTime;
            set
            {
                _effectiveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _effectiveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EffectiveTimeRaw);
            set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Expresses the pricing formula. See `PricingExpression` for an example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingExpression")]
        public virtual PricingExpression PricingExpression { get; set; }

        /// <summary>
        /// An optional human readable summary of the pricing information, has a maximum length of 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulation of billing information for a Google Cloud Console project. A project has at most one associated
    /// billing account at a time (but a billing account can be assigned to multiple projects).
    /// </summary>
    public class ProjectBillingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the billing account associated with the project, if any. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountName")]
        public virtual string BillingAccountName { get; set; }

        /// <summary>
        /// Output only. True if the project is associated with an open billing account, to which usage on the project
        /// is charged. False if the project is associated with a closed billing account, or no billing account at all,
        /// and therefore cannot use paid services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingEnabled")]
        public virtual System.Nullable<bool> BillingEnabled { get; set; }

        /// <summary>
        /// Output only. The resource name for the `ProjectBillingInfo`; has the form
        /// `projects/{project_id}/billingInfo`. For example, the resource name for the billing information for project
        /// `tokyo-rain-123` would be `projects/tokyo-rain-123/billingInfo`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The ID of the project that this `ProjectBillingInfo` represents, such as `tokyo-rain-123`. This
        /// is a convenience field so that you don't need to parse the `name` field to obtain a project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a single service in Google Cloud Platform.</summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The business under which the service is offered. Ex. "businessEntities/GCP", "businessEntities/Maps"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessEntityName")]
        public virtual string BusinessEntityName { get; set; }

        /// <summary>A human readable display name for this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name for the service. Example: "services/6F81-5844-456A"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The identifier for the service. Example: "6F81-5844-456A"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; }

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

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a single SKU in Google Cloud</summary>
    public class Sku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category hierarchy of this SKU, purely for organizational purpose.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual Category Category { get; set; }

        /// <summary>A human readable description of the SKU, has a maximum length of 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The geographic taxonomy for this sku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTaxonomy")]
        public virtual GeoTaxonomy GeoTaxonomy { get; set; }

        /// <summary>The resource name for the SKU. Example: "services/6F81-5844-456A/skus/D041-B8A1-6E0B"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A timeline of pricing info for this SKU in chronological order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingInfo")]
        public virtual System.Collections.Generic.IList<PricingInfo> PricingInfo { get; set; }

        /// <summary>
        /// Identifies the service provider. This is 'Google' for first party services in Google Cloud Platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceProviderName")]
        public virtual string ServiceProviderName { get; set; }

        /// <summary>
        /// List of service regions this SKU is offered at. Example: "asia-east1" Service regions can be found at
        /// https://cloud.google.com/about/locations/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRegions")]
        public virtual System.Collections.Generic.IList<string> ServiceRegions { get; set; }

        /// <summary>The identifier for the SKU. Example: "D041-B8A1-6E0B"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

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

    /// <summary>The price rate indicating starting usage and its corresponding price.</summary>
    public class TierRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Usage is priced at this rate only after this amount. Example: start_usage_amount of 10 indicates that the
        /// usage will be priced at the unit_price after the first 10 usage_units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUsageAmount")]
        public virtual System.Nullable<double> StartUsageAmount { get; set; }

        /// <summary>
        /// The price per unit of usage. Example: unit_price of amount $10 indicates that each unit will cost $10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPrice")]
        public virtual Money UnitPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
