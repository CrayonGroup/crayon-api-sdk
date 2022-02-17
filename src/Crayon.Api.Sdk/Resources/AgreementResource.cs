using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class AgreementResource
    {
        private readonly CrayonApiClient _client;

        public AgreementResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<AgreementCollection> Get(string token, AgreementFilter filter = null)
        {
            var uri = "/api/v1/agreements/".Append(filter);
            return _client.Get<AgreementCollection>(token, uri);
        }

        public async Task<CrayonApiClientResult<AgreementCollection>> GetAsync(string token, AgreementFilter filter = null)
        {
            var uri = "/api/v1/agreements/".Append(filter);
            return await _client.GetAsync<AgreementCollection>(token, uri);
        }
    }
}