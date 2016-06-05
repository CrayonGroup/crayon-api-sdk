using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Resources
{
    public class SecretResource
    {
        private readonly CrayonApiClient _client;

        public SecretResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<Secret> Create(string token, Secret secret)
        {
            var uri = "/api/v1/secrets/";
            return _client.Post<Secret>(token, uri, secret);
        }

        public CrayonApiClientResult Delete(string token, int secretId, string clientId)
        {
            var uri = $"/api/v1/secrets/?secretId={secretId}&clientId={clientId}";
            return _client.Delete(token, uri);
        }
    }
}