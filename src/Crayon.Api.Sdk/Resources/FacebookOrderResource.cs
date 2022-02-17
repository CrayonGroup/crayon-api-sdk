using Crayon.Api.Sdk.Domain;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class FacebookOrderResource
    {
        private readonly CrayonApiClient _client;

        public FacebookOrderResource(CrayonApiClient client)
        {
            _client = client;
        }

        public async Task<CrayonApiClientResult> CheckoutAsync(string token, FacebookOrder order)
        {
            const string uri = "api/v1/facebookorders/checkout";
            return await _client.PostAsync<FacebookOrder>(token, uri, order);
        }
    }
}
