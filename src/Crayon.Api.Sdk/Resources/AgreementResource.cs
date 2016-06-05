using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class AgreementResource
    {
        private readonly CrayonApiClient _client;

        public AgreementResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<AgreementCollection> Get(string token, AgreementFilter filter = null)
        {
            var uri = "/api/v1/agreements/".Append(filter);
            return _client.Get<AgreementCollection>(token, uri);
        }
    }
}