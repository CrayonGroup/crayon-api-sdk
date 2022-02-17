using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Resources
{
    public class AddressResource
    {
        private readonly CrayonApiClient _client;

        public AddressResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Address>> Get(string token, int organizationId, AddressType type = AddressType.None)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/?type={type}";
            return _client.Get<ApiCollection<Address>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Address>>> GetAsync(string token, int organizationId, AddressType type = AddressType.None)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/?type={type}";
            return await _client.GetAsync<ApiCollection<Address>>(token, uri);
        }

        public CrayonApiClientResult<Address> GetById(string token, int organizationId, long addressId)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/{addressId}/";
            return _client.Get<Address>(token, uri);
        }

        public async Task<CrayonApiClientResult<Address>> GetByIdAsync(string token, int organizationId, long addressId)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/{addressId}/";
            return await _client.GetAsync<Address>(token, uri);
        }
    }
}