using Crayon.Api.Sdk.Domain.MasterData;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class PublisherResource
    {
        private readonly CrayonApiClient _client;

        public PublisherResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<PublisherCollection> Get(string token, PublisherFilter filter = null)
        {
            var uri = "/api/v1/publishers/".Append(filter);
            return _client.Get<PublisherCollection>(token, uri);
        }

        public CrayonApiClientDataResult<Publisher> GetById(string token, int id)
        {
            var uri = $"/api/v1/publishers/{id}/";
            return _client.Get<Publisher>(token, uri);
        }
    }
}