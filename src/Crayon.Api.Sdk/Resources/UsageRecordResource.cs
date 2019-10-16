using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;
using System;

namespace Crayon.Api.Sdk.Resources
{
    public class UsageRecordResource
    {
        private readonly CrayonApiClient _client;

        public UsageRecordResource(CrayonApiClient client)
        {
            _client = client;
        }

        [Obsolete("This endpoint is depricated")]
        public CrayonApiClientResult<ApiCollection<UsageRecordGrouped>> GetAsGrouped(string token, UsageRecordGroupedFilter filter = null)
        {
            var uri = "/api/v1/usagerecords/grouped/".Append(filter);
            return _client.Get<ApiCollection<UsageRecordGrouped>>(token, uri);
        }
    }
}