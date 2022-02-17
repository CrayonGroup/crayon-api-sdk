using Crayon.Api.Sdk.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class OrganizationAccessResource
    {
        private readonly CrayonApiClient _client;

        public OrganizationAccessResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<OrganizationAccess>> GetGrant(string token, int organizationId, string userId)
        {
            var uri = $"/api/v1/organizationaccess/grant/?organizationId={organizationId}&userId={userId}";
            return _client.Get<ApiCollection<OrganizationAccess>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<OrganizationAccess>>> GetGrantAsync(string token, int organizationId, string userId)
        {
            var uri = $"/api/v1/organizationaccess/grant/?organizationId={organizationId}&userId={userId}";
            return await _client.GetAsync<ApiCollection<OrganizationAccess>>(token, uri);
        }

        public CrayonApiClientResult<ApiCollection<OrganizationAccess>> Get(string token, int organizationId, string userId)
        {
            var uri = $"/api/v1/organizationaccess/?organizationId={organizationId}&userId={userId}";
            return _client.Get<ApiCollection<OrganizationAccess>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<OrganizationAccess>>> GetAsync(string token, int organizationId, string userId)
        {
            var uri = $"/api/v1/organizationaccess/?organizationId={organizationId}&userId={userId}";
            return await _client.GetAsync<ApiCollection<OrganizationAccess>>(token, uri);
        }

        public CrayonApiClientResult<List<OrganizationAccess>> Update(string token, List<OrganizationAccess> list)
        {
            var uri = "/api/v1/organizationaccess/";
            return _client.Put<List<OrganizationAccess>>(token, uri, list);
        }

        public async Task<CrayonApiClientResult<List<OrganizationAccess>>> UpdateAsync(string token, List<OrganizationAccess> list)
        {
            var uri = "/api/v1/organizationaccess/";
            return await _client.PutAsync<List<OrganizationAccess>>(token, uri, list);
        }

        public CrayonApiClientResult<ApiCollection<OrganizationAccess>> GetGrantForUser(string token, string userId)
        {
            return GetGrant(token, 0, userId);
        }

        public async Task<CrayonApiClientResult<ApiCollection<OrganizationAccess>>> GetGrantForUserAsync(string token, string userId)
        {
            return await GetGrantAsync(token, 0, userId);
        }

        public CrayonApiClientResult<ApiCollection<OrganizationAccess>> GetGrantForOrganization(string token, int organizationId)
        {
            return GetGrant(token, organizationId, null);
        }

        public async Task<CrayonApiClientResult<ApiCollection<OrganizationAccess>>> GetGrantForOrganizationAsync(string token, int organizationId)
        {
            return await GetGrantAsync(token, organizationId, null);
        }
    }
}