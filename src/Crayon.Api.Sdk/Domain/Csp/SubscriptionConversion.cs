namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionConversion
    {
        public BillingCycleEnum BillingCycle { get; set; }
        public string OfferId { get; set; }
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public string TargetOfferId { get; set; }
        public string ProductName { get; set; }
    }
}
