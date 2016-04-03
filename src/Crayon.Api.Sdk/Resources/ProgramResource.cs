using Crayon.Api.Sdk.Domain.MasterData.Programs;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class ProgramResource
    {
        private readonly CrayonApiClient _client;

        public ProgramResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<ProgramCollection> Get(string token, ProgramFilter filter = null)
        {
            var uri = "/api/v1/programs/".Append(filter);
            return _client.Get<ProgramCollection>(token, uri);
        }

        public CrayonApiClientDataResult<Program> GetById(string token, int id)
        {
            var uri = $"/api/v1/programs/{id}/";
            return _client.Get<Program>(token, uri);
        }
    }
}