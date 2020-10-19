namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CustomerTenantDetailed
    {
        public CustomerTenant Tenant { get; set; }

        public CustomerTenantUser User { get; set; }

        public CustomerTenantProfile Profile { get; set; }

        public CustomerTenantCompany Company { get; set; }
    }
}