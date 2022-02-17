using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Internal;
using System.Threading;
using System.IO;

namespace Crayon.Api.Sdk
{
    public class CrayonApiOptions
    {
        public TimeSpan? DefaultRequestTimeout { get; set; }
    }

    public class CrayonApiClient
    {
        public static Urls ApiUrls = new Urls { Production = "https://apiv1.crayon.com/", Demo = "https://demoapi.crayon.com/" };
        public static Urls AuthorityUrls = new Urls { Production = "https://signin.crayon.com/auth/", Demo = "https://demosignin.crayon.com/auth/" };

        private readonly string _assemblyVersion;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSerializerSettings;
        private readonly IHttpSerializer _httpSerializer;
        private readonly TimeSpan? _defaultRequestTimeout;

        public CrayonApiClient()
            : this(ApiUrls.Production)
        {
        }

        public CrayonApiClient(string baseUrl)
            : this(new HttpClient { BaseAddress = new Uri(baseUrl) }, new CrayonApiOptions())
        {
        }

        public CrayonApiClient(HttpClient httpClient, CrayonApiOptions options)
        {
            _httpClient = httpClient;
            _jsonSerializerSettings = new JsonSerializerSettings {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                Formatting = Formatting.Indented
            };

            _httpSerializer = new JsonHttpSerializer(_jsonSerializerSettings);
            _assemblyVersion = typeof(CrayonApiClient).GetTypeInfo().Assembly.GetName().Version.ToString();
            _defaultRequestTimeout = options.DefaultRequestTimeout;

            ActivityLog = new ActivityLogResource(this);
            Addresses = new AddressResource(this);
            AgreementProducts = new AgreementProductResource(this);
            AgreementReports = new AgreementReportResource(this);
            Agreements = new AgreementResource(this);
            Assets = new AssetResource(this);
            AwsAccounts = new AwsAccountResource(this);
            AzurePlans = new AzurePlanResource(this);
            AzureSubscriptions = new AzureSubscriptionResource(this);
            BillingCycles = new BillingCycleResource(this);
            BillingStatements = new BillingStatementResource(this);
            BlogItems = new BlogItemResource(this);
            Clients = new ClientResource(this);
            Consumers = new ConsumerResource(this);
            CustomerTenants = new CustomerTenantResource(this);
            CrayonAccounts = new CrayonAccountResource(this);
            FacebookOrders = new FacebookOrderResource(this);
            GoogleOrders = new GoogleOrderResource(this);
            Groupings = new GroupingResource(this);
            InvoiceProfiles = new InvoiceProfileResource(this);
            ManagementLinkResource = new ManagementLinkResource(this);
            Me = new MeResource(this);
            OrganizationAccess = new OrganizationAccessResource(this);
            Organizations = new OrganizationResource(this);
            Publishers = new PublisherResource(this);
            ProductContainers = new ProductContainerResource(this);
            Programs = new ProgramResource(this);
            Regions = new RegionResource(this);
            ResellerSalesPrices = new ResellerSalesPriceResource(this);
            Secrets = new SecretResource(this);
            Subscriptions = new SubscriptionResource(this);
            Tokens = new TokenResource(this);
            UsageCost = new UsageCostResource(this);
            Users = new UserResource(this);
        }

        public ActivityLogResource ActivityLog { get; }
        public AddressResource Addresses { get; }
        public AgreementProductResource AgreementProducts { get; }
        public AgreementReportResource AgreementReports { get; }
        public AgreementResource Agreements { get; }
        public AssetResource Assets { get; }
        public AwsAccountResource AwsAccounts { get; }
        public AzurePlanResource AzurePlans { get; }
        public AzureSubscriptionResource AzureSubscriptions { get; }
        public BillingCycleResource BillingCycles { get; }
        public BillingStatementResource BillingStatements { get; }
        public BlogItemResource BlogItems { get; }
        public ClientResource Clients { get; }
        public ConsumerResource Consumers { get; }
        public CustomerTenantResource CustomerTenants { get; }
        public CrayonAccountResource CrayonAccounts { get; }
        public FacebookOrderResource FacebookOrders { get; }
        public GoogleOrderResource GoogleOrders { get; }
        public GroupingResource Groupings { get; }
        public InvoiceProfileResource InvoiceProfiles { get; }
        public ManagementLinkResource ManagementLinkResource { get; }
        public MeResource Me { get; }
        public OrganizationAccessResource OrganizationAccess { get; }
        public OrganizationResource Organizations { get; }
        public PublisherResource Publishers { get; }
        public ProductContainerResource ProductContainers { get; }
        public ProgramResource Programs { get; }
        public RegionResource Regions { get; }
        public ResellerSalesPriceResource ResellerSalesPrices { get; }
        public SecretResource Secrets { get; }
        public SubscriptionResource Subscriptions { get; }
        public TokenResource Tokens { get; }
        public UsageCostResource UsageCost { get; }
        public UserResource Users { get; }

        internal CrayonApiClientResult<T> Get<T>(string token, string uri, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            return SynchronousHttpClient.SendRequest<T>(HttpMethod.Get, _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options);
#else
            var response = SendRequest(token, uri, HttpMethod.Get, options);
            return DeserializeResponseToResultOf<T>(response);
#endif
        }

        internal CrayonApiClientResult Post(string token, string uri, object value, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            string content = value != null ? _httpSerializer.Serialize(value) : null;
            return SynchronousHttpClient.SendRequest(HttpMethod.Post, _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options, content);
#else
            var response = SendRequest(token, uri, HttpMethod.Post, options, value);
            return ResponseToSimpleResult(response);
#endif
        }
        
        internal CrayonApiClientResult<T> Post<T>(string token, string uri, object value, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            string content = value != null ? _httpSerializer.Serialize(value) : null;
            return SynchronousHttpClient.SendRequest<T>(HttpMethod.Post, _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options, content);
#else
            var response = SendRequest(token, uri, HttpMethod.Post, options, value);
            return DeserializeResponseToResultOf<T>(response);
#endif
        }

        internal CrayonApiClientResult<T> Put<T>(string token, string uri, object value, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            string content = value != null ? _httpSerializer.Serialize(value) : null;
            return SynchronousHttpClient.SendRequest<T>(HttpMethod.Put, _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options, content);
#else
            var response = SendRequest(token, uri, HttpMethod.Put, options, value);
            return DeserializeResponseToResultOf<T>(response);
#endif
        }

        internal CrayonApiClientResult<T> Patch<T>(string token, string uri, object value, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            string content = value != null ? _httpSerializer.Serialize(value) : null;
            return SynchronousHttpClient.SendRequest<T>(new HttpMethod("PATCH"), _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options, content);
#else
            var response = SendRequest(token, uri, new HttpMethod("Patch"), options, value);
            return DeserializeResponseToResultOf<T>(response);
#endif
        }

        internal CrayonApiClientResult Delete(string token, string uri, RequestOptions options = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

#if NET451 || NET461            
            return SynchronousHttpClient.SendRequest(HttpMethod.Delete, _httpClient.BaseAddress, uri, token, _httpSerializer, _assemblyVersion, PreSend, options);
#else
            var response = SendRequest(token, uri, HttpMethod.Delete, options);

            string content = string.Empty;
            if (response.Content != null)
            {
                content = SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsStringAsync());
            }

            return new CrayonApiClientResult(response.StatusCode, content, response.RequestMessage?.RequestUri);
#endif
        }


        internal async Task<CrayonApiClientResult<T>> GetAsync<T>(string token, string uri, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, HttpMethod.Get, options);
            return await DeserializeResponseToResultOfAsync<T>(response);
        }

        internal async Task<CrayonApiClientResult> PostAsync(string token, string uri, object value, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, HttpMethod.Post, options, value);
            return await ResponseToSimpleResultAsync(response);
        }
        
        internal async Task<CrayonApiClientResult<T>> PostAsync<T>(string token, string uri, object value, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, HttpMethod.Post, options, value);
            return await DeserializeResponseToResultOfAsync<T>(response);
        }


        internal async Task<CrayonApiClientResult<T>> PutAsync<T>(string token, string uri, object value, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, HttpMethod.Put, options, value);
            return await DeserializeResponseToResultOfAsync<T>(response);
        }

        internal async Task<CrayonApiClientResult<T>> PatchAsync<T>(string token, string uri, object value, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, new HttpMethod("PATCH"), options, value);
            return await DeserializeResponseToResultOfAsync<T>(response);
        }

        internal async Task<CrayonApiClientResult> DeleteAsync(string token, string uri, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, HttpMethod.Delete, options);

            string content = string.Empty;
            if (response.Content != null)
            {
                content = await response.Content.ReadAsStringAsync();
            }            

            return new CrayonApiClientResult(response.StatusCode, content, response.RequestMessage?.RequestUri);
        }

        internal CrayonApiClientResult<FileResponse> GetFile(HttpMethod method, string token, string uri, object payload, RequestOptions options = null)
        {
            var response = SendRequest(token, uri, method, options, payload);

            if (response.IsSuccessStatusCode)
            {
                var fileContent = SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsByteArrayAsync());
                var fileName = response.Content.Headers.ContentDisposition.FileName;
                var fileContentType = response.Content.Headers.ContentType.MediaType;

                var file = new FileResponse(fileContent, fileName, fileContentType);

                return new CrayonApiClientResult<FileResponse>(file, response.StatusCode,
                    string.Empty, 
                    response.RequestMessage?.RequestUri);
            }

            var content = response.Content != null ? SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsStringAsync()) : string.Empty;
            return new CrayonApiClientResult<FileResponse>(null, response.StatusCode,
                content,
                response.RequestMessage?.RequestUri);
        }

        internal async Task<CrayonApiClientResult<FileResponse>> GetFileAsync(HttpMethod method, string token, string uri, object payload, RequestOptions options = null)
        {
            var response = await SendRequestAsync(token, uri, method, options, payload);

            if (response.IsSuccessStatusCode)
            {
                var fileContent = await response.Content.ReadAsByteArrayAsync();
                var fileName = response.Content.Headers.ContentDisposition.FileName;
                var fileContentType = response.Content.Headers.ContentType.MediaType;

                var file = new FileResponse(fileContent, fileName, fileContentType);

                return new CrayonApiClientResult<FileResponse>(file, response.StatusCode,
                    string.Empty,
                    response.RequestMessage?.RequestUri);
            }

            var content = response.Content != null ? await response.Content.ReadAsStringAsync() : string.Empty;
            return new CrayonApiClientResult<FileResponse>(null, response.StatusCode,
                content,
                response.RequestMessage?.RequestUri);
        }


#region Internal implementation


        internal CrayonApiClientResult ResponseToSimpleResult(HttpResponseMessage response)
        {
            var content = response.Content != null ? SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsStringAsync()) : string.Empty;

            return new CrayonApiClientResult(response.StatusCode, content, response.RequestMessage?.RequestUri);
        }

        internal CrayonApiClientResult<T> DeserializeResponseToResultOf<T>(HttpResponseMessage response)
        {
            var result = DeserializeResponseTo<T>(response);
            var content = response.Content != null ? SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsStringAsync()) : string.Empty;

            return new CrayonApiClientResult<T>(result, response.StatusCode, content, response.RequestMessage?.RequestUri);
        }

        internal async Task<CrayonApiClientResult> ResponseToSimpleResultAsync(HttpResponseMessage response)
        {
            var content = response.Content != null ? await response.Content.ReadAsStringAsync() : string.Empty;

            return new CrayonApiClientResult(response.StatusCode, content, response.RequestMessage?.RequestUri);
        }
        
        internal async Task<CrayonApiClientResult<T>> DeserializeResponseToResultOfAsync<T>(HttpResponseMessage response)
        {
            var result = await DeserializeResponseToAsync<T>(response);
            var content = response.Content != null ? await response.Content.ReadAsStringAsync() : string.Empty;

            return new CrayonApiClientResult<T>(result, response.StatusCode, content, response.RequestMessage?.RequestUri);
        }

        protected T DeserializeResponseTo<T>(HttpResponseMessage response)
        {
            var content = response.Content != null ? SynchronousExecutor.SynchronousExecute(() => response.Content.ReadAsStringAsync()) : string.Empty;
            return DeserializeString<T>(content);
        }
        protected async Task<T> DeserializeResponseToAsync<T>(HttpResponseMessage response)
        {
            var content = response.Content != null ? await response.Content.ReadAsStreamAsync() : null;
            return _httpSerializer.DeserializeStream<T>(content);
        }

        private T DeserializeString<T>(string content)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(content, _jsonSerializerSettings);
            }
            catch (JsonSerializationException)
            {
                //This exception can occure if we expect a list of objects but the error object is returned
                return default(T);
            }
            catch (JsonReaderException)
            {
                //This exception can occure if we expect a primarytype but the error object is returned
                return default(T);
            }
        }

        internal HttpResponseMessage SendRequest(HttpRequestMessage request, RequestOptions options)
        {
            request.Headers.Add("sdk-version", _assemblyVersion);
            return SynchronousExecutor.SynchronousExecute(() =>
            {
                try
                {
                    //Use cancellationToken specified in this request
                    if (options.CancellationToken.HasValue)
                    {
                        return _httpClient.SendAsync(request, options.CancellationToken.Value);
                    }

                    //Set cancellation token with request timeout or default request timeout
                    if (options.RequestTimeout.HasValue)
                    {
                        using (CancellationTokenSource source = new CancellationTokenSource(options.RequestTimeout.Value))
                        {
                            return _httpClient.SendAsync(request, source.Token);
                        }
                    }

                    //Make request with max timeout specified in HttpClient.Timeout
                    return _httpClient.SendAsync(request);
                }
                catch (HttpRequestException ex)
                {
                    var error = ToError(ex.InnerException ?? ex, "Unable to connect to API");
                    var serializedContent = JsonConvert.SerializeObject(error, _jsonSerializerSettings);
                    var jsonContent = new StringContent(serializedContent, Encoding.UTF8, "application/json");

                    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable) {
                        Content = jsonContent
                    });
                }
            });
        }
        internal async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request, RequestOptions options)
        {
            request.Headers.Add("sdk-version", _assemblyVersion);

            try
            {
                //Use cancellationToken specified in this request
                if (options.CancellationToken.HasValue)
                {
                    return await _httpClient.SendAsync(request, options.CancellationToken.Value);
                }

                //Set cancellation token with request timeout or default request timeout
                if (options.RequestTimeout.HasValue)
                {
                    using (CancellationTokenSource source = new CancellationTokenSource(options.RequestTimeout.Value))
                    {
                        return await _httpClient.SendAsync(request, source.Token);
                    }
                }

                //Make request with max timeout specified in HttpClient.Timeout
                return await _httpClient.SendAsync(request);
            }
            catch (HttpRequestException ex)
            {
                var error = ToError(ex.InnerException ?? ex, "Unable to connect to API");
                var serializedContent = JsonConvert.SerializeObject(error, _jsonSerializerSettings);
                var jsonContent = new StringContent(serializedContent, Encoding.UTF8, "application/json");

                return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable) {
                    Content = jsonContent
                };
            }
        }

        protected HttpResponseMessage SendRequest(string token, string uri, HttpMethod method, RequestOptions options, object content = null)
        {
            var request = new HttpRequestMessage(method, uri.TrimEnd('?', '&'));

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (content != null)
            {
                var serializedContent = JsonConvert.SerializeObject(content, _jsonSerializerSettings);
                var jsonContent = new StringContent(serializedContent, Encoding.UTF8, "application/json");
                request.Content = jsonContent;
            }

            PreSend(new HttpRequestMessageWrapper(request));
            return SendRequest(request, options);
        }

        protected async Task<HttpResponseMessage> SendRequestAsync(
            string token, 
            string uri, 
            HttpMethod method,
            RequestOptions options,
            object content = null)
        {
            options = options ?? new RequestOptions();
            options.SetInternalProperties(_defaultRequestTimeout);

            var request = new HttpRequestMessage(method, uri.TrimEnd('?', '&'));

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (content != null)
            {
                var serializedContent = JsonConvert.SerializeObject(content, _jsonSerializerSettings);
                var jsonContent = new StringContent(serializedContent, Encoding.UTF8, "application/json");
                request.Content = jsonContent;
            }

            PreSend(new HttpRequestMessageWrapper(request));
            return await SendRequestAsync(request, options);
        }


        protected virtual void PreSend(IPreSendWrapper preSendWrapper)
        {
            //This is empty on purpose
            //This method can be overriden externally because it is virtual
        }

        private static Error ToError(Exception e, string message)
        {
            var error = new Error
            {
                Message = e.Message,
                ObjectErrors = new List<InternalError> {
                    new InternalError {
                        Message = e.InnerException?.Message ?? string.Empty
                    },
                    new InternalError {
                        Message = message
                    }
                }
            };

            return error;
        }
#endregion
    }
}