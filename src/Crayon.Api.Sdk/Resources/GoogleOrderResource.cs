using Crayon.Api.Sdk.Domain;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class GoogleOrderResource
    {
        private readonly CrayonApiClient _client;

        public GoogleOrderResource(CrayonApiClient client)
        {
            _client = client;
        }

        public async Task<CrayonApiClientResult> CheckoutAsync(string token, GoogleOrder order)
        {
            const string uri = "api/v1/googleorders/checkout";
            return await _client.PostAsync<GoogleOrder>(token, uri, order);
        }
    }
}
