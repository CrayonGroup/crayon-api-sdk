using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ActivityLogResource
    {
        private readonly CrayonApiClient _client;

        public ActivityLogResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ActivityLog> Get(string token, ActivityLogFilter filter = null)
        {
            if (filter.Id <= 0)
                return CrayonApiClientResult.NotFound<ActivityLog>();

            var uri = "api/v1/activitylogs/".Append(filter);
            return _client.Get<ActivityLog>(token, uri);
        }

        public async Task<CrayonApiClientResult<ActivityLog>> GetAsync(string token, ActivityLogFilter filter = null)
        {
            if (filter.Id <= 0)
                return CrayonApiClientResult.NotFound<ActivityLog>();

            var uri = "api/v1/activitylogs/".Append(filter);
            return await _client.GetAsync<ActivityLog>(token, uri);
        }
    }
}
