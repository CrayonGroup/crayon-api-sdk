using Crayon.Api.Sdk.Domain.Addresses;

namespace Crayon.Api.Sdk.Resources
{
    public class AddressResource
    {
        private readonly CrayonApiClient _client;

        public AddressResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<AddressCollection> Get(string token, int organizationId, AddressType type = AddressType.None)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/?type={type}";
            return _client.Get<AddressCollection>(token, uri);
        }

        public CrayonApiClientDataResult<Address> GetById(string token, int organizationId, long addressId)
        {
            var uri = $"api/v1/organizations/{organizationId}/addresses/{addressId}/";
            return _client.Get<Address>(token, uri);
        }
    }
}