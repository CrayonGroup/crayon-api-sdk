namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubcategoryUsageCost
    {
        public string Meter { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}