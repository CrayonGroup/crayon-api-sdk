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

        public CrayonApiClientResult<Organization> GetById(string token, int id)
        {
            var uri = $"/api/v1/organizations/{id}";
            return _client.Get<Organization>(token, uri);
        }
    }
}