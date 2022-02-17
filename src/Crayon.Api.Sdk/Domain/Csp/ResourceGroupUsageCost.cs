namespace Crayon.Api.Sdk.Domain.Csp
{
    public class ResourceGroupUsageCost
    {
        public string Category { get; set; }

        public string Subcategory { get; set; }

        public string Meter { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}