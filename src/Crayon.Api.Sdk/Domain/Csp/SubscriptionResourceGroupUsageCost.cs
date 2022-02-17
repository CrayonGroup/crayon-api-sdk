namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionResourceGroupUsageCost
    {
        public string ResourceGroup { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}