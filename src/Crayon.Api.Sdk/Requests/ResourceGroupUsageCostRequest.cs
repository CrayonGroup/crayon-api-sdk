using System;

namespace Crayon.Api.Sdk.Requests
{
    public class ResourceGroupUsageCostRequest
    {
        public int ResellerCustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}