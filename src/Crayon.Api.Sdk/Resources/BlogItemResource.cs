using Crayon.Api.Sdk.Domain;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class BlogItemResource
    {
        private readonly CrayonApiClient _client;

        public BlogItemResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<BlogItem>> Get(string token, int count, int? organizationId = 0)
        {
            var uri = $"/api/v1/blogitems/?count={count}&organizationId={organizationId}";

            return _client.Get<ApiCollection<BlogItem>>(token, uri);
        }
        public async Task<CrayonApiClientResult<ApiCollection<BlogItem>>> GetAsync(string token, int count, int organizationId = 0)
        {
            var uri = $"/api/v1/blogitems/?count={count}&organizationId={organizationId}";

            return await _client.GetAsync<ApiCollection<BlogItem>>(token, uri);
        }
    }
}