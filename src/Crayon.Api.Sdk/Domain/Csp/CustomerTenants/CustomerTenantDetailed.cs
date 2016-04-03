namespace Crayon.Api.Sdk.Domain.CloudProvisioning.CustomerTenants
{
    public class CustomerTenantDetailed
    {
        public CustomerTenant Tenant { get; set; }

        public CustomerTenantUser User { get; set; }

        public CustomerTenantProfile Profile { get; set; }
    }
}