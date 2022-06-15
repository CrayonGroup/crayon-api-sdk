namespace Crayon.Api.Sdk.Domain.Csp
{
    public class NewCommerceOrder
    {
        public int CustomerTenantId { get; set; }

        public string PartNumber { get; set; }

        public BillingCycleType BillingCycle { get; set; }
        public string TermDuration { get; set; }

        public int Quantity { get; set; }

    }
}
