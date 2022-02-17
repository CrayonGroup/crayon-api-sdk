using System.Threading.Tasks;
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

        public async Task<CrayonApiClientResult<ApiCollection<InvoiceProfile>>> GetAsync(string token, InvoiceProfileFilter filter = null)
        {
            var uri = "/api/v1/invoiceprofiles/".Append(filter);
            return await _client.GetAsync<ApiCollection<InvoiceProfile>>(token, uri);
        }

        public CrayonApiClientResult<InvoiceProfile> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<InvoiceProfile>();
            }

            var uri = $"/api/v1/invoiceprofiles/{id}";
            return _client.Get<InvoiceProfile>(token, uri);
        }

        public async Task<CrayonApiClientResult<InvoiceProfile>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<InvoiceProfile>();
            }

            var uri = $"/api/v1/invoiceprofiles/{id}";
            return await _client.GetAsync<InvoiceProfile>(token, uri);
        }
        
        public CrayonApiClientResult<InvoiceProfile> Create(string token, InvoiceProfile invoiceProfile)
        {
            var uri = "/api/v1/invoiceprofiles/";
            return _client.Post<InvoiceProfile>(token, uri, invoiceProfile);
        }

        public async Task<CrayonApiClientResult<InvoiceProfile>> CreateAsync(string token, InvoiceProfile invoiceProfile)
        {
            var uri = "/api/v1/invoiceprofiles/";
            return await _client.PostAsync<InvoiceProfile>(token, uri, invoiceProfile);
        }

        public CrayonApiClientResult<InvoiceProfile> Update(string token, InvoiceProfile invoiceProfile)
        {
            Guard.NotNull(invoiceProfile, nameof(invoiceProfile));

            var uri = $"/api/v1/invoiceprofiles/{invoiceProfile.Id}";
            return _client.Put<InvoiceProfile>(token, uri, invoiceProfile);
        }

        public async Task<CrayonApiClientResult<InvoiceProfile>> UpdateAsync(string token, InvoiceProfile invoiceProfile)
        {
            Guard.NotNull(invoiceProfile, nameof(invoiceProfile));

            var uri = $"/api/v1/invoiceprofiles/{invoiceProfile.Id}";
            return await _client.PutAsync<InvoiceProfile>(token, uri, invoiceProfile);
        }

        public CrayonApiClientResult Delete(string token, int id)
        {
            var uri = $"/api/v1/invoiceprofiles/{id}/";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, int id)
        {
            var uri = $"/api/v1/invoiceprofiles/{id}/";
            return await _client.DeleteAsync(token, uri);
        }
    }
}