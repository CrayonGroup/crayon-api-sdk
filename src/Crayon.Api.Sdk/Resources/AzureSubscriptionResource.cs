using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class AzureSubscriptionResource
    {
        private readonly CrayonApiClient _client;

        public AzureSubscriptionResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<AzureSubscription>> Get(string token, int azurePlanId, AzureSubscriptionFilter filter = null)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions".Append(filter);
            return _client.Get<ApiCollection<AzureSubscription>>(token, uri);
        }
        
        public async Task<CrayonApiClientResult<ApiCollection<AzureSubscription>>> GetAsync(string token, int azurePlanId, AzureSubscriptionFilter filter = null)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions".Append(filter);
            return await _client.GetAsync<ApiCollection<AzureSubscription>>(token, uri).ConfigureAwait(false);
        }
        
        public CrayonApiClientResult<AzureSubscription> GetById(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}";
            return _client.Get<AzureSubscription>(token, uri);
        }
        public async Task<CrayonApiClientResult<AzureSubscription>> GetByIdAsync(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}";
            return await _client.GetAsync<AzureSubscription>(token, uri).ConfigureAwait(false);
        }

        public CrayonApiClientResult Create(string token, int azurePlanId, CreateAzureSubscriptionRequest request)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/";
            return _client.Post(token, uri, request);
        }
        
        public async Task<CrayonApiClientResult> CreateAsync(string token, int azurePlanId, CreateAzureSubscriptionRequest request)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/";
            return await _client.PostAsync(token, uri, request).ConfigureAwait(false);
        }
        
        public CrayonApiClientResult<AzureSubscription> Update(string token,
            int azurePlanId, int id, AzureSubscription azureSubscription)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}";
            return _client.Put<AzureSubscription>(token, uri, azureSubscription);
        }

        public async Task<CrayonApiClientResult<AzureSubscription>> UpdateAsync(string token,
            int azurePlanId, int id, AzureSubscription azureSubscription)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}";
            return await _client.PutAsync<AzureSubscription>(token, uri, azureSubscription).ConfigureAwait(false);
        }

        public async Task<CrayonApiClientResult<bool>> AssignUniqueAdminAsync(string token, int azurePlanId, int id, AzureSubscriptionAssignAdmin body)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/assign-unique-admin";

            return await _client.PutAsync<bool>(token, uri, body).ConfigureAwait(false);
        }

        public CrayonApiClientResult<AzureSubscriptionUpdated> Cancel(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/cancel/";
            return _client.Post<AzureSubscriptionUpdated>(token, uri, null);
        }

        public async Task<CrayonApiClientResult<AzureSubscriptionUpdated>> CancelAsync(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/cancel/";
            return await _client.PostAsync<AzureSubscriptionUpdated>(token, uri, null);
        }

        public CrayonApiClientResult<AzureSubscriptionUpdated> Enable(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/enable/";
            return _client.Post<AzureSubscriptionUpdated>(token, uri, null);
        }

        public async Task<CrayonApiClientResult<AzureSubscriptionUpdated>> EnableAsync(string token, int azurePlanId, int id)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/enable/";
            return await _client.PostAsync<AzureSubscriptionUpdated>(token, uri, null);
        }

        public CrayonApiClientResult<AzureSubscriptionUpdated> Rename(string token, int azurePlanId, int id, AzureSubscriptionRename body)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/rename/";
            return _client.Patch<AzureSubscriptionUpdated>(token, uri, body);
        }

        public async Task<CrayonApiClientResult<AzureSubscriptionUpdated>> RenameAsync(string token, int azurePlanId, int id, AzureSubscriptionRename body)
        {
            var uri = $"api/v1/azureplans/{azurePlanId}/azureSubscriptions/{id}/rename/";
            return await _client.PatchAsync<AzureSubscriptionUpdated>(token, uri, body);
        }
    }
}