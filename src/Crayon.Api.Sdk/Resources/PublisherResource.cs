using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class PublisherResource
    {
        private readonly CrayonApiClient _client;

        public PublisherResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Publisher>> Get(string token, PublisherFilter filter = null)
        {
            var uri = "/api/v1/publishers/".Append(filter);
            return _client.Get<ApiCollection<Publisher>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Publisher>>> GetAsync(string token, PublisherFilter filter = null)
        {
            var uri = "/api/v1/publishers/".Append(filter);
            return await _client.GetAsync<ApiCollection<Publisher>>(token, uri);
        }

        public CrayonApiClientResult<Publisher> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Publisher>();
            }

            var uri = $"/api/v1/publishers/{id}/";
            return _client.Get<Publisher>(token, uri);
        }

        public async Task<CrayonApiClientResult<Publisher>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Publisher>();
            }

            var uri = $"/api/v1/publishers/{id}/";
            return await _client.GetAsync<Publisher>(token, uri);
        }
    }
}