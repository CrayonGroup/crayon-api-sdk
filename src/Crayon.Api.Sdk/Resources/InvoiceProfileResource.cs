using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class InvoiceProfileResource
    {
        private readonly CrayonApiClient _client;

        public InvoiceProfileResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<InvoiceProfile>> Get(string token, InvoiceProfileFilter filter = null)
        {
            var uri = "/api/v1/invoiceprofiles/".Append(filter);
            return _client.Get<ApiCollection<InvoiceProfile>>(token, uri);
        }

        public CrayonApiClientResult<InvoiceProfile> GetById(string token, int id)
        {
            var uri = $"/api/v1/invoiceprofiles/{id}";
            return _client.Get<InvoiceProfile>(token, uri);
        }

        public CrayonApiClientResult<InvoiceProfile> Create(string token, InvoiceProfile invoiceProfile)
        {
            var uri = "/api/v1/invoiceprofiles/";
            return _client.Post<InvoiceProfile>(token, uri, invoiceProfile);
        }

        public CrayonApiClientResult<InvoiceProfile> Update(string token, InvoiceProfile invoiceProfile)
        {
            Guard.NotNull(invoiceProfile, nameof(invoiceProfile));

            var uri = $"/api/v1/invoiceprofiles/{invoiceProfile.Id}";
            return _client.Put<InvoiceProfile>(token, uri, invoiceProfile);
        }
    }
}