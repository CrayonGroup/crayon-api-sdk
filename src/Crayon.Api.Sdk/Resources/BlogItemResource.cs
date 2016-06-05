using Crayon.Api.Sdk.Domain;
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

        public CrayonApiClientDataResult<ApiCollection<BlogItem>> Get(int count)
        {
            var uri = "/api/v1/blogitems/".Append("count", count);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = _client.SendRequest(request);

            return _client.DeserializeResponseToResultOf<ApiCollection<BlogItem>>(response);
        }
    }
}