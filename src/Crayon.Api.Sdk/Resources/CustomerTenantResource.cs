using System.Collections.Generic;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class CustomerTenantResource
    {
        private readonly CrayonApiClient _client;

        public CustomerTenantResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<CustomerTenant>> Get(string token, CustomerTenantFilter filter = null)
        {
            var uri = "api/v1/customertenants/".Append(filter);
            return _client.Get<ApiCollection<CustomerTenant>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<CustomerTenant>>> GetAsync(string token, CustomerTenantFilter filter = null)
        {
            var uri = "api/v1/customertenants/".Append(filter);
            return await _client.GetAsync<ApiCollection<CustomerTenant>>(token, uri);
        }

        public CrayonApiClientResult<CustomerTenant> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<CustomerTenant>();
            }

            var uri = $"api/v1/customertenants/{id}/";
            return _client.Get<CustomerTenant>(token, uri);
        }

        public async Task<CrayonApiClientResult<CustomerTenant>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<CustomerTenant>();
            }

            var uri = $"api/v1/customertenants/{id}/";
            return await _client.GetAsync<CustomerTenant>(token, uri);
        }

        public CrayonApiClientResult<CustomerTenantDetailed> GetDetailedById(string token, int id)
        {
            var uri = $"api/v1/customertenants/{id}/detailed/";
            return _client.Get<CustomerTenantDetailed>(token, uri);
        }

        public async Task<CrayonApiClientResult<CustomerTenantDetailed>> GetDetailedByIdAsync(string token, int id)
        {
            var uri = $"api/v1/customertenants/{id}/detailed/";
            return await _client.GetAsync<CustomerTenantDetailed>(token, uri);
        }
        
        public CrayonApiClientResult<AzurePlan> GetAzurePlan(string token, int customerTenantId)
        {
            var uri = $"api/v1/customertenants/{customerTenantId}/azurePlan/";
            return _client.Get<AzurePlan>(token, uri);
        }
        
        public async Task<CrayonApiClientResult<AzurePlan>> GetAzurePlanAsync(string token, int customerTenantId)
        {
            var uri = $"api/v1/customertenants/{customerTenantId}/azurePlan/";
            return await _client.GetAsync<AzurePlan>(token, uri);
        }

        public CrayonApiClientResult<CustomerTenantDetailed> Create(string token, CustomerTenantDetailed customerTenant)
        {
            var uri = "api/v1/customertenants/";
            return _client.Post<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public async Task<CrayonApiClientResult<CustomerTenantDetailed>> CreateAsync(string token, CustomerTenantDetailed customerTenant)
        {
            var uri = "api/v1/customertenants/";
            return await _client.PostAsync<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public CrayonApiClientResult<CustomerTenantDetailed> CreateExisting(string token, CustomerTenantDetailed customerTenant)
        {
            var uri = $"api/v1/customertenants/existing/";
            return _client.Post<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public async Task<CrayonApiClientResult<CustomerTenantDetailed>> CreateExistingAsync(string token, CustomerTenantDetailed customerTenant)
        {
            var uri = $"api/v1/customertenants/existing/";
            return await _client.PostAsync<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public CrayonApiClientResult<CustomerTenantDetailed> Update(string token, CustomerTenantDetailed customerTenant)
        {
            Guard.NotNull(customerTenant, nameof(customerTenant));

            var uri = $"api/v1/customertenants/{customerTenant.Tenant.Id}/";
            return _client.Put<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public async Task<CrayonApiClientResult<CustomerTenantDetailed>> UpdateAsync(string token, CustomerTenantDetailed customerTenant)
        {
            Guard.NotNull(customerTenant, nameof(customerTenant));

            var uri = $"api/v1/customertenants/{customerTenant.Tenant.Id}/";
            return await _client.PutAsync<CustomerTenantDetailed>(token, uri, customerTenant);
        }

        public CrayonApiClientResult Delete(string token, int id)
        {
            var uri = $"/api/v1/customertenants/{id}/";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, int id)
        {
            var uri = $"/api/v1/customertenants/{id}/";
            return await _client.DeleteAsync(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<ServiceAccountAgreement>>> GetAgreementsAsync(string token, int customerTenantId, CustomerTenantAgreementFilter filter)
        {
            var uri = $"api/v1/customertenants/{customerTenantId}/agreements/?" + filter.ToQueryString();
            return await _client.GetAsync<ApiCollection<ServiceAccountAgreement>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ServiceAccountAgreement>> AddAgreementAsync(string token, int customerTenantId, ServiceAccountAgreement agreement)
        {            
            var uri = $"api/v1/customertenants/{customerTenantId}/agreements/";
            return await _client.PostAsync<ServiceAccountAgreement>(token, uri, agreement);
        }
    }
}