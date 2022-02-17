using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ClientResource
    {
        private readonly CrayonApiClient _client;

        public ClientResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Client>> Get(string token, ClientFilter filter = null)
        {
            var uri = "/api/v1/clients/".Append(filter);
            return _client.Get<ApiCollection<Client>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Client>>> GetAsync(string token, ClientFilter filter = null)
        {
            var uri = "/api/v1/clients/".Append(filter);
            return await _client.GetAsync<ApiCollection<Client>>(token, uri);
        }

        public CrayonApiClientResult<Client> GetByClientId(string token, string clientId)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                return CrayonApiClientResult.NotFound<Client>();
            }

            var uri = $"/api/v1/clients/{clientId}/";
            return _client.Get<Client>(token, uri);
        }

        public async Task<CrayonApiClientResult<Client>> GetByClientIdAsync(string token, string clientId)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                return CrayonApiClientResult.NotFound<Client>();
            }

            var uri = $"/api/v1/clients/{clientId}/";
            return await _client.GetAsync<Client>(token, uri);
        }

        public CrayonApiClientResult<Client> Create(string token, Client client)
        {
            var uri = "/api/v1/clients/";
            return _client.Post<Client>(token, uri, client);
        }

        public async Task<CrayonApiClientResult<Client>> CreateAsync(string token, Client client)
        {
            var uri = "/api/v1/clients/";
            return await _client.PostAsync<Client>(token, uri, client);
        }

        public CrayonApiClientResult<Client> Update(string token, Client client)
        {
            Guard.NotNull(client, nameof(client));

            var uri = $"/api/v1/clients/{client.ClientId}/";
            return _client.Put<Client>(token, uri, client);
        }

        public async Task<CrayonApiClientResult<Client>> UpdateAsync(string token, Client client)
        {
            Guard.NotNull(client, nameof(client));

            var uri = $"/api/v1/clients/{client.ClientId}/";
            return await _client.PutAsync<Client>(token, uri, client);
        }

        public CrayonApiClientResult Delete(string token, string clientId)
        {
            var uri = $"/api/v1/clients/{clientId}/";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, string clientId)
        {
            var uri = $"/api/v1/clients/{clientId}/";
            return await _client.DeleteAsync(token, uri);
        }
    }
}