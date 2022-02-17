using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class OrganizationResource
    {
        private readonly CrayonApiClient _client;

        public OrganizationResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Organization>> Get(string token, OrganizationFilter filter = null)
        {
            var uri = "/api/v1/organizations/".Append(filter);
            return _client.Get<ApiCollection<Organization>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Organization>>> GetAsync(string token, OrganizationFilter filter = null)
        {
            var uri = "/api/v1/organizations/".Append(filter);
            return await _client.GetAsync<ApiCollection<Organization>>(token, uri);
        }

        public CrayonApiClientResult<Organization> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Organization>();
            }

            var uri = $"/api/v1/organizations/{id}";
            return _client.Get<Organization>(token, uri);
        }

        public async Task<CrayonApiClientResult<Organization>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Organization>();
            }

            var uri = $"/api/v1/organizations/{id}";
            return await _client.GetAsync<Organization>(token, uri);
        }

        public CrayonApiClientResult<OrganizationSalesContact> GetOrganizationSalesContact(string token, int organizationId)
        {
            if (organizationId <= 0)
            {
                return CrayonApiClientResult.NotFound<OrganizationSalesContact>();
            }

            var uri = $"/api/v1/organizations/{organizationId}/salescontact/";
            return _client.Get<OrganizationSalesContact>(token, uri);
        }

        public async Task<CrayonApiClientResult<OrganizationSalesContact>> GetOrganizationSalesContactAsync(string token, int organizationId)
        {
            if (organizationId <= 0)
            {
                return CrayonApiClientResult.NotFound<OrganizationSalesContact>();
            }

            var uri = $"/api/v1/organizations/{organizationId}/salescontact/";
            return await _client.GetAsync<OrganizationSalesContact>(token, uri);
        }

        public async Task<CrayonApiClientResult<bool>> HasAccessAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<bool>();
            }

            var uri = $"/api/v1/organizations/HasAccess/{id}";
            return await _client.GetAsync<bool>(token, uri);
        }
    }
}