using System.Collections.Generic;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class BillingCycleResource
    {
        private readonly CrayonApiClient _client;

        public BillingCycleResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<BillingCycle>> Get(string token, bool includeUnknown = false)
        {
            var uri = $"/api/v1/billingcycles/?includeUnknown={includeUnknown.ToString()}";
            return _client.Get<ApiCollection<BillingCycle>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<BillingCycle>>> GetAsync(string token, bool includeUnknown = false)
        {
            var uri = $"/api/v1/billingcycles/?includeUnknown={includeUnknown.ToString()}";
            return await _client.GetAsync<ApiCollection<BillingCycle>>(token, uri);
        }
        public CrayonApiClientResult<ApiCollection<BillingCycle>> GetByProductVariantId(string token, int productVariantId)
        {
            var uri = $"/api/v1/billingcycles/productVariant/{productVariantId}";
            return _client.Get<ApiCollection<BillingCycle>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<BillingCycle>>> GetByProductVariantIdAsync(string token, int productVariantId)
        {
            var uri = $"/api/v1/billingcycles/productVariant/{productVariantId}";
            return await _client.GetAsync<ApiCollection<BillingCycle>>(token, uri);
        }

        public async Task<CrayonApiClientResult<Dictionary<int, string>>> GetCspNameDictionaryAsync(string token)
        {
            var uri = $"/api/v1/billingcycles/cspNameDictionary/";
            return await _client.GetAsync<Dictionary<int, string>>(token, uri);
        }
    }
}
