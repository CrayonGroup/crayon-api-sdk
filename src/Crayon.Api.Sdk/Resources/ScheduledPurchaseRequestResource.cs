using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class ScheduledPurchaseRequestResource
    {
        private readonly CrayonApiClient _client;

        public ScheduledPurchaseRequestResource(CrayonApiClient client)
        {
            _client = client;
        }

        public async Task<CrayonApiClientResult<ApiCollection<ScheduledPurchaseRequestItem>>> GetScheduledPurchaseRequestsAsync(string token, ScheduledPurchaseRequestFilter filter = null)
        {
            var uri = "api/v1/scheduledpurchaserequest/".Append(filter);
            return await _client.GetAsync<ApiCollection<ScheduledPurchaseRequestItem>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ScheduledPurchaseRequestItem>> CancelOrderLineItemAsync(string token, int id, int orderNumber)
        {
            string uri = $"api/v1/scheduledpurchaserequest/cancel-order/{id}/{orderNumber}";
            return await _client.PutAsync<ScheduledPurchaseRequestItem>(token, uri, null);
        }
    }
}
