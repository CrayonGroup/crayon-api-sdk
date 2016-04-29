using System;

namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class DetailedBillingRecordDto
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string CustomerTenantName { get; set; }

        public string CustomerTenantReference { get; set; }

        public string PublisherCustomerTenantId { get; set; }

        public string CustomerTenantId { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; }

        public decimal TotalLinePrice { get; set; }

        public string TenantName { get; set; }

        public int SubscriptionId { get; set; }

        public string SubscriptionName { get; set; }

        public string ProductName { get; set; }

        public object PriceData { get; set; }

        public DetailedBillingRecordExternalProductDto ExternalProduct { get; set; }
    }
}