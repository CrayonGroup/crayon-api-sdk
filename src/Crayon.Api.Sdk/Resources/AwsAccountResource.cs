using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class AwsAccountResource
    {
        private readonly CrayonApiClient _client;

        public AwsAccountResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<AwsAccount>> Get(string token, AwsAccountFilter filter = null)
        {
            var uri = "api/v1/awsaccounts/".Append(filter);
            return _client.Get<ApiCollection<AwsAccount>>(token, uri);
        }

        public Task<CrayonApiClientResult<ApiCollection<AwsAccount>>> GetAsync(string token, AwsAccountFilter filter = null)
        {
            var uri = "api/v1/awsaccounts/".Append(filter);
            return _client.GetAsync<ApiCollection<AwsAccount>>(token, uri);
        }
        
        public CrayonApiClientResult<AwsAccount> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<AwsAccount>();
            }

            var uri = $"/api/v1/awsaccounts/{id}";
            return _client.Get<AwsAccount>(token, uri);
        }

        public Task<CrayonApiClientResult<AwsAccount>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return Task.FromResult(CrayonApiClientResult.NotFound<AwsAccount>());
            }

            var uri = $"/api/v1/awsaccounts/{id}";
            return _client.GetAsync<AwsAccount>(token, uri);
        }

        public CrayonApiClientResult<AwsAccount> Update(string token, AwsAccount awsAccount)
        {
            Guard.NotNull(awsAccount, nameof(awsAccount));

            var uri = $"/api/v1/awsaccounts/{awsAccount.Id}";
            return _client.Put<AwsAccount>(token, uri, awsAccount);
        }

        public Task<CrayonApiClientResult<AwsAccount>> UpdateAsync(string token, AwsAccount awsAccount)
        {
            Guard.NotNull(awsAccount, nameof(awsAccount));

            var uri = $"/api/v1/awsaccounts/{awsAccount.Id}";
            return _client.PutAsync<AwsAccount>(token, uri, awsAccount);
        }
    }
}