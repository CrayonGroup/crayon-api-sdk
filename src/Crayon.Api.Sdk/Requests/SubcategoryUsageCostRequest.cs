using System;

namespace Crayon.Api.Sdk.Requests
{
    public class SubcategoryUsageCostRequest
    {
        public int ResellerCustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}