using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class BillingRecord
    {
        public int Id { get; set; }

        public int BillingStatementId { get; set; }

        public DateTime Created { get; set; }

        public BillingRecordCustomerTenant CustomerTenant { get; set; }

        public Price ItemUnitPrice { get; set; }

        public BillingRecordSubscription Subscription { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public BillingRecordProduct Product { get; set; }

        public decimal Quantity { get; set; }

        public decimal IncludedQuantity { get; set; }

        public string InvoicePartNumber { get; set; }

        public string Unit { get; set; }
    }
}