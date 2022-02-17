using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class RegionResource
    {
        private readonly CrayonApiClient _client;

        public RegionResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Region>> Get(string token, RegionFilter filter = null)
        {
            var uri = "/api/v1/regions/".Append(filter);
            return _client.Get<ApiCollection<Region>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Region>>> GetAsync(string token, RegionFilter filter = null)
        {
            var uri = "/api/v1/regions/".Append(filter);
            return await _client.GetAsync<ApiCollection<Region>>(token, uri);
        }

        public CrayonApiClientResult<Region> GetByCode(string token, string regionCode, RegionList regionList)
        {
            var uri = $"/api/v1/regions/bycode?regionCode={regionCode}&regionList={(int)regionList}";
            return _client.Get<Region>(token, uri);
        }

        public async Task<CrayonApiClientResult<Region>> GetByCodeAsync(string token, string regionCode, RegionList regionList)
        {
            var uri = $"/api/v1/regions/bycode?regionCode={regionCode}&regionList={(int)regionList}";
            return await _client.GetAsync<Region>(token, uri);
        }
    }
}