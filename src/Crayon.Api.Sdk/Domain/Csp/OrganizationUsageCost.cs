namespace Crayon.Api.Sdk.Domain.Csp
{
    public class OrganizationUsageCost
    {
        public string Supplier { get; set; }

        public int AccountId { get; set; }

        public string AccountName { get; set; }

        public string SubscriptionName { get; set; }

        public string SubscriptionId { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}
