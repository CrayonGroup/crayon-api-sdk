using Crayon.Api.Sdk.Resources;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace Crayon.Api.Sdk
{
    public class CrayonApiClient
    {
        public static Urls ApiUrls = new Urls { Production = "https://apiv1.crayon.com/", Demo = "https://demoapi.crayon.com/" };
        public static Urls AuthorityUrls = new Urls { Production = "https://signin.crayon.com/auth/", Demo = "https://demosignin.crayon.com/auth/" };

        private readonly string _assemblyVersion;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        public CrayonApiClient()
            : this(ApiUrls.Production)
        {
        }

        public CrayonApiClient(string baseUrl)
            : this(new HttpClient { BaseAddress = new Uri(baseUrl) })
        {
        }

        public CrayonApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonSerializerSettings = new JsonSerializerSettings {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                Formatting = Formatting.Indented
            };

            _assemblyVersion = typeof(CrayonApiClient).GetTypeInfo().Assembly.GetName().Version.ToString();

            Addresses = new AddressResource(this);
            AgreementProducts = new AgreementProductResource(this);
            Agreements = new AgreementResource(this);
            BillingStatements = new BillingStatementResource(this);
            BlogItems = new BlogItemResource(this);
            Clients = new ClientResource(this);
            CustomerTenants = new CustomerTenantResource(this);
            InvoiceProfiles = new InvoiceProfileResource(this);
            Me = new MeResource(this);
            OrganizationAccess = new OrganizationAccessResource(this);
            Organizations = new OrganizationResource(this);
            Publishers = new PublisherResource(this);
            Programs = new ProgramResource(this);
            Regions = new RegionResource(this);
            Secrets = new SecretResource(this);
            Subscriptions = new SubscriptionResource(this);
            Tokens = new TokenResource(this);
            UsageRecords = new UsageRecordResource(this);
            Users = new UserResource(this);
        }

        public AddressResource Addresses { get; }
        public AgreementProductResource AgreementProducts { get; }
        public AgreementResource Agreements { get; }
        public BillingStatementResource BillingStatements { get; }
        public BlogItemResource BlogItems { get; }
        public ClientResource Clients { get; }
        public CustomerTenantResource CustomerTenants { get; }
        public InvoiceProfileResource InvoiceProfiles { get; }
        public MeResource Me { get; }
        public OrganizationAccessResource OrganizationAccess { get; }
        public OrganizationResource Organizations { get; }
        public PublisherResource Publishers { get; }
        public ProgramResource Programs { get; }
        public RegionResource Regions { get; }
        public SecretResource Secrets { get; }
        public SubscriptionResource Subscriptions { get; }
        public TokenResource Tokens { get; }
        public UsageRecordResource UsageRecords { get; }
        public UserResource Users { get; }

        internal CrayonApiClientDataResult<T> Get<T>(string token, string uri)
        {
            var response = SendRequest(token, uri, HttpMethod.Get);
            return DeserializeResponseToResultOf<T>(response);
        }

        internal CrayonApiClientDataResult<T> Post<T>(string token, string uri, object value)
        {
            var response = SendRequest(token, uri, HttpMethod.Post, value);
            return DeserializeResponseToResultOf<T>(response);
        }

        internal CrayonApiClientDataResult<T> Put<T>(string token, string uri, object value)
        {
            var response = SendRequest(token, uri, HttpMethod.Put, value);
            return DeserializeResponseToResultOf<T>(response);
        }

        internal CrayonApiClientResult Delete(string token, string uri)
        {
            var response = SendRequest(token, uri, HttpMethod.Delete);
            return new CrayonApiClientResult(response);
        }

        internal CrayonApiClientDataResult<T> DeserializeResponseToResultOf<T>(HttpResponseMessage response)
        {
            var result = DeserializeResponseTo<T>(response);
            return new CrayonApiClientDataResult<T>(result, response);
        }

        protected T DeserializeResponseTo<T>(HttpResponseMessage response)
        {
            var content = response.Content.ReadAsStringAsync().Result;

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

        internal HttpResponseMessage SendRequest(HttpRequestMessage request)
        {
            request.Headers.Add("sdk-version", _assemblyVersion);

            return _httpClient.SendAsync(request).Result;
        }

        protected HttpResponseMessage SendRequest(string token, string uri, HttpMethod method, object content = null)
        {
            var request = new HttpRequestMessage(method, uri.TrimEnd('?', '&'));

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            if (content != null)
            {
                var serializedContent = JsonConvert.SerializeObject(content, _jsonSerializerSettings);
                var jsonContent = new StringContent(serializedContent, Encoding.UTF8, "application/json");
                request.Content = jsonContent;
            }

            return SendRequest(request);
        }
    }
}