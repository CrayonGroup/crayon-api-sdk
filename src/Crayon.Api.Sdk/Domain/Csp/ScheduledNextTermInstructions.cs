
namespace Crayon.Api.Sdk.Domain.Csp
{
    public class ScheduledNextTermInstructions
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }

    public class Product
    {
        public string ProductId { get; set; }

        public string SkuId { get; set; }

        public string AvailabilityId { get; set; }

        public string BillingCycle { get; set; }

        public string TermDuration { get; set; }
    }
}
