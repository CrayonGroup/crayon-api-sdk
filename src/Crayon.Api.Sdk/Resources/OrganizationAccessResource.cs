using Crayon.Api.Sdk.Domain.Access;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Resources
{
    public class OrganizationAccessResource
    {
        private readonly CrayonApiClient _client;

        public OrganizationAccessResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<OrganizationAccessCollection> GetGrant(string token, int organizationId, string userId)
        {
            var uri = $"/api/v1/organizationaccess/grant/?organizationId={organizationId}&userId={userId}";
            return _client.Get<OrganizationAccessCollection>(token, uri);
        }

        public CrayonApiClientDataResult<List<OrganizationAccess>> Update(string token, List<OrganizationAccess> list)
        {
            var uri = "/api/v1/organizationaccess/";
            return _client.Put<List<OrganizationAccess>>(token, uri, list);
        }
    }
}