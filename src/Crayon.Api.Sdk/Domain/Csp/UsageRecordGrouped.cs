using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class UsageRecordGrouped
    {
        public string PartNumber { get; set; }
        public string MeterName { get; set; }
        public string MeterCategory { get; set; }
        public string MeterSubCategory { get; set; }
        public Price SalesUnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal IncludedQuantity { get; set; }
        public string Unit { get; set; }
        public string PublisherCustomerTenantId { get; set; }
        public string CustomerTenantDomainPrefix { get; set; }
        public string CustomerTenantName { get; set; }
        public string PublisherSubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public DateTimeOffset UsageStartTime { get; set; }
        public DateTimeOffset UsageEndTime { get; set; }
        public ProductReference Product { get; set; }
        public ObjectReference Publisher { get; set; }
        public ObjectReference Agreement { get; set; }
    }
}