using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class DetailedBillingRecordUsageRecordDto
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        public int ResellerCustomerId { get; set; }

        public string EntitlementId { get; set; }

        public DateTime UsageStartDateTime { get; set; }

        public DateTime UsageEndDateTime { get; set; }

        public string ObjectType { get; set; }

        public string MeterName { get; set; }

        public string MeterCategory { get; set; }

        public string MeterSubCategory { get; set; }

        public string Unit { get; set; }

        public string MeterId { get; set; }

        public decimal Quantity { get; set; }

        public decimal IncludedQuantity { get; set; }

        public List<DetailedBillingRecordUsageRecordInfoFieldDto> UsageRecordInfoFieldsDtos { get; set; }

        public string InstanceData { get; set; }

        public string AxDataAreaId { get; set; }

        public string OperatingUnit { get; set; }

        public string PublisherCustomerId { get; set; }

        public DateTime ReportStartDate { get; set; }

        public DateTime ReportEndDate { get; set; }

        public int? AgreementId { get; set; }

        public int? SubscriptionId { get; set; }

        public decimal? PurchaseUnitPrice { get; set; }

        public string PurchaseUnitPriceCurrencyCode { get; set; }

        public decimal? SalesUnitPrice { get; set; }

        public string SalesUnitPriceCurrencyCode { get; set; }

        public decimal? UnitPrice { get; set; }

        public string UnitPriceCurrencyCode { get; set; }

        public int? PriceId { get; set; }

        public int? ExternalProductId { get; set; }

        public DateTime Created { get; set; }

        public decimal Margin { get; set; }
    }
}