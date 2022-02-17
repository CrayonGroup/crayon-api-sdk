using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ProgramResource
    {
        private readonly CrayonApiClient _client;

        public ProgramResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Program>> Get(string token, ProgramFilter filter = null)
        {
            var uri = "/api/v1/programs/".Append(filter);
            return _client.Get<ApiCollection<Program>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Program>>> GetAsync(string token, ProgramFilter filter = null)
        {
            var uri = "/api/v1/programs/".Append(filter);
            return await _client.GetAsync<ApiCollection<Program>>(token, uri);
        }

        public CrayonApiClientResult<Program> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Program>();
            }

            var uri = $"/api/v1/programs/{id}/";
            return _client.Get<Program>(token, uri);
        }

        public async Task<CrayonApiClientResult<Program>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Program>();
            }

            var uri = $"/api/v1/programs/{id}/";
            return await _client.GetAsync<Program>(token, uri);
        }
    }
}