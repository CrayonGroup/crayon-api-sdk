﻿using Crayon.Api.Sdk.Domain.Clients;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class ClientResource
    {
        private readonly CrayonApiClient _client;

        public ClientResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<ClientCollection> Get(string token, ClientFilter filter = null)
        {
            var uri = "/api/v1/clients/".Append(filter);
            return _client.Get<ClientCollection>(token, uri);
        }

        public CrayonApiClientDataResult<Client> GetByClientId(string token, string clientId)
        {
            var uri = $"/api/v1/clients/{clientId}/";
            return _client.Get<Client>(token, uri);
        }

        public CrayonApiClientDataResult<Client> Create(string token, Client client)
        {
            var uri = "/api/v1/clients/";
            return _client.Post<Client>(token, uri, client);
        }

        public CrayonApiClientDataResult<Client> Update(string token, Client client)
        {
            Guard.NotNull(client, nameof(client));

            var uri = $"/api/v1/clients/{client.ClientId}/";
            return _client.Put<Client>(token, uri, client);
        }

        public CrayonApiClientResult Delete(string token, string clientId)
        {
            var uri = $"/api/v1/clients/{clientId}/";
            return _client.Delete(token, uri);
        }
    }
}