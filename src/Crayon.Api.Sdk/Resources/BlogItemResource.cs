using Crayon.Api.Sdk.Domain;
using System.Net.Http;

namespace Crayon.Api.Sdk.Resources
{
    public class BlogItemResource
    {
        private readonly CrayonApiClient _client;

        public BlogItemResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<BlogItem>> Get(int count)
        {
            var uri = $"/api/v1/blogitems/?count={count}";
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = _client.SendRequest(request);

            return _client.DeserializeResponseToResultOf<ApiCollection<BlogItem>>(response);
        }
    }
}