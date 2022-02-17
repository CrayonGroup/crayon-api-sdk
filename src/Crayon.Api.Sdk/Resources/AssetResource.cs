using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class AssetResource
    {
        private readonly CrayonApiClient _client;

        public AssetResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Asset>> Get(string token, AssetFilter filter = null)
        {
            var uri = "/api/v1/assets/".Append(filter);
            return _client.Get<ApiCollection<Asset>>(token, uri);
        }

        public async Task<CrayonApiClientResult<Asset>> GetByIdAsync(string token, int id)
        {
            var uri = $"/api/v1/assets/{id}";
            return await _client.GetAsync<Asset>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Asset>>> GetAsync(string token, AssetFilter filter = null)
        {
            var uri = "/api/v1/assets/".Append(filter);
            return await _client.GetAsync<ApiCollection<Asset>>(token, uri);
        }

        public async Task<CrayonApiClientResult<AssetOrder>> VerifyAsync(string token, AssetOrder order)
        {
            const string uri = "api/v1/assets/verify";
            return await _client.PostAsync<AssetOrder>(token, uri, order);
        }

        public async Task<CrayonApiClientResult> CheckoutAsync(string token, AssetOrder order)
        {
            const string uri = "api/v1/assets/checkout";
            return await _client.PostAsync<AssetOrder>(token, uri, order);
        }

        public async Task<CrayonApiClientResult<ApiCollection<AssetOrder>>> GetOrdersAsync(string token, AssetFilter filter = null)
        {
            var uri = "api/v1/assets/orders/".Append(filter);
            return await _client.GetAsync<ApiCollection<AssetOrder>>(token, uri);
        }

        public async Task<CrayonApiClientResult<Asset>> UpdateAssetAsync(string token, int assetId, Asset asset)
        {
            string uri = $"api/v1/assets/{assetId}";
            return await _client.PutAsync<Asset>(token, uri, asset);
        }

        public async Task<CrayonApiClientResult<AssetTags>> AddAssetTagsAsync(string token, AssetTags assetTags)
        {
            string uri = $"api/v1/assets/{assetTags.AssetId}/tags";
            return await _client.PostAsync<AssetTags>(token, uri, assetTags);
        }

        public async Task<CrayonApiClientResult<AssetTags>> UpdateAssetTagsAsync(string token, int assetId, AssetTags assetTags)
        {
            string uri = $"api/v1/assets/{assetId}/tags";
            return await _client.PutAsync<AssetTags>(token, uri, assetTags);
        }

        public async Task<CrayonApiClientResult> DeleteAssetTagsAsync(string token, int assetId)
        {
            string uri = $"api/v1/assets/{assetId}/tags";
            return await _client.DeleteAsync(token, uri);
        }
    }
}
