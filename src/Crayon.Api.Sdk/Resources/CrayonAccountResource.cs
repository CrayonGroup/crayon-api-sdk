using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class CrayonAccountResource
    {
        private readonly CrayonApiClient _client;

        public CrayonAccountResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<CrayonAccount>> Get(string token, CrayonAccountFilter filter = null)
        {
            var uri = "api/v1/crayonaccounts/".Append(filter);
            return _client.Get<ApiCollection<CrayonAccount>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<CrayonAccount>>> GetAsync(string token, CrayonAccountFilter filter = null)
        {
            var uri = "api/v1/crayonaccounts/".Append(filter);
            return await _client.GetAsync<ApiCollection<CrayonAccount>>(token, uri);
        }
        
        public CrayonApiClientResult<CrayonAccount> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<CrayonAccount>();
            }

            var uri = $"/api/v1/crayonaccounts/{id}";
            return _client.Get<CrayonAccount>(token, uri);
        }

        public async Task<CrayonApiClientResult<CrayonAccount>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<CrayonAccount>();
            }

            var uri = $"/api/v1/crayonaccounts/{id}";
            return await _client.GetAsync<CrayonAccount>(token, uri);
        }

        public CrayonApiClientResult<CrayonAccount> Update(string token, CrayonAccount CrayonAccount)
        {
            Guard.NotNull(CrayonAccount, nameof(CrayonAccount));

            var uri = $"/api/v1/crayonaccounts/{CrayonAccount.Id}";
            return _client.Put<CrayonAccount>(token, uri, CrayonAccount);
        }

        public async Task<CrayonApiClientResult<CrayonAccount>> UpdateAsync(string token, CrayonAccount CrayonAccount)
        {
            Guard.NotNull(CrayonAccount, nameof(CrayonAccount));

            var uri = $"/api/v1/crayonaccounts/{CrayonAccount.Id}";
            return await _client.PutAsync<CrayonAccount>(token, uri, CrayonAccount);
        }

        public CrayonApiClientResult<CrayonAccount> Create(string token, CrayonAccount CrayonAccount)
        {
            Guard.NotNull(CrayonAccount, nameof(CrayonAccount));

            var uri = "/api/v1/crayonaccounts/";
            return _client.Post<CrayonAccount>(token, uri, CrayonAccount);
        }

        public async Task<CrayonApiClientResult<CrayonAccount>> CreateAsync(string token, CrayonAccount CrayonAccount)
        {
            Guard.NotNull(CrayonAccount, nameof(CrayonAccount));

            var uri = "/api/v1/crayonaccounts/";
            return await _client.PostAsync<CrayonAccount>(token, uri, CrayonAccount);
        }
    }
}