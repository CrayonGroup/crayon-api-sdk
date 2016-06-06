using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Resources
{
    public class MeResource
    {
        private readonly CrayonApiClient _client;

        public MeResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<Me> Get(string token)
        {
            var uri = "/api/v1/me/";
            return _client.Get<Me>(token, uri);
        }
    }
}