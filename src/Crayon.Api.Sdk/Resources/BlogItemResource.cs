using Crayon.Api.Sdk.Domain.Blog;
using Crayon.Api.Sdk.Filtering.Extensions;
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

        public CrayonApiClientDataResult<BlogItemCollection> Get(int count)
        {
            var uri = "/api/v1/blogitems/".Append("count", count);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = _client.SendRequest(request);

            return _client.DeserializeResponseToResultOf<BlogItemCollection>(response);
        }
    }
}