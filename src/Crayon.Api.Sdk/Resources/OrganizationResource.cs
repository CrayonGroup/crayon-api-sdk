using Crayon.Api.Sdk.Domain.Organizations;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Resources
{
    public class OrganizationResource
    {
        private readonly CrayonApiClient _client;

        public OrganizationResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<OrganizationCollection> Get(string token, OrganizationFilter filter = null)
        {
            var uri = "/api/v1/organizations/".Append(filter);
            return _client.Get<OrganizationCollection>(token, uri);
        }

        public CrayonApiClientDataResult<Organization> GetById(string token, int id)
        {
            var uri = $"/api/v1/organizations/{id}";
            return _client.Get<Organization>(token, uri);
        }
    }
}