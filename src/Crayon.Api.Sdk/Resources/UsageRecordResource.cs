using Crayon.Api.Sdk.Domain.CloudProvisioning.Usage;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class UsageRecordResource
    {
        private readonly CrayonApiClient _client;

        public UsageRecordResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<UsageRecordGroupedCollection> GetAsGrouped(string token, UsageRecordGroupedFilter filter = null)
        {
            var uri = "/api/v1/usagerecords/grouped/".Append(filter);
            return _client.Get<UsageRecordGroupedCollection>(token, uri);
        }
    }
}