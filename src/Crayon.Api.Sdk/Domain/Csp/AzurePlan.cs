namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AzurePlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublisherSubscriptionId { get; set; }
        public SubscriptionStatus Status { get; set; }
        public bool RegisteredForReservedInstance { get; set; }

        public ObjectReference Organization { get; set; }
        public CustomerTenantReference CustomerTenant { get; set; }
    }
}