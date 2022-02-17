using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ManagementLinkResource
    {
        private readonly CrayonApiClient _client;

        public ManagementLinkResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<ManagementLink>> Get(string token, ManagementLinkFilter filter = null)
        {
            var uri = "/api/v1/managementlinks/".Append(filter);
            return _client.Get<ApiCollection<ManagementLink>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<ManagementLink>>> GetAsync(string token, ManagementLinkFilter filter = null)
        {
            var uri = "/api/v1/managementlinks/".Append(filter);
            return await _client.GetAsync<ApiCollection<ManagementLink>>(token, uri);
        }

        public CrayonApiClientResult<ApiCollection<ManagementLinkGrouped>> GetAsGrouped(string token, ManagementLinkFilter filter = null)
        {
            var uri = "/api/v1/managementlinks/grouped/".Append(filter);
            return _client.Get<ApiCollection<ManagementLinkGrouped>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<ManagementLinkGrouped>>> GetAsGroupedAsync(string token, ManagementLinkFilter filter = null)
        {
            var uri = "/api/v1/managementlinks/grouped/".Append(filter);
            return await _client.GetAsync<ApiCollection<ManagementLinkGrouped>>(token, uri);
        }
    }
}
