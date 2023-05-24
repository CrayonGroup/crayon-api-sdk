using Crayon.Api.Sdk.Domain.Csp;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class PurchaseRequestResource
    {
        private readonly CrayonApiClient _client;

        public PurchaseRequestResource(CrayonApiClient client)
        {
            _client = client;
        }

        public async Task<CrayonApiClientResult<PurchaseRequestOrder>> VerifyAsync(string token, PurchaseRequestOrder order)
        {
            const string uri = "api/v1/purchaserequest/verify";
            return await _client.PostAsync<PurchaseRequestOrder>(token, uri, order);
        }

        public async Task<CrayonApiClientResult<PurchaseRequestOrder>> CheckoutAsync(string token, PurchaseRequestOrder order)
        {
            const string uri = "api/v1/purchaserequest/checkout";
            return await _client.PostAsync<PurchaseRequestOrder>(token, uri, order);
        }
    }
}
