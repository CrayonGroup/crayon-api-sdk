using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class RegionResource
    {
        private readonly CrayonApiClient _client;

        public RegionResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<RegionCollection> Get(string token, RegionFilter filter = null)
        {
            var uri = "/api/v1/regions/".Append(filter);
            return _client.Get<RegionCollection>(token, uri);
        }
    }
}