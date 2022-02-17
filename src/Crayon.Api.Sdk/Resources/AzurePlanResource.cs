using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Resources
{
    public class AzurePlanResource
    {
        private readonly CrayonApiClient _client;

        public AzurePlanResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<AzurePlan> GetById(string token, int id)
        {
            var uri = $"api/v1/azureplans/{id}/";
            return _client.Get<AzurePlan>(token, uri);
        }
        
        public Task<CrayonApiClientResult<AzurePlan>> GetByIdAsync(string token, int id)
        {
            var uri = $"api/v1/azureplans/{id}/";
            return _client.GetAsync<AzurePlan>(token, uri);
        }
    }
}