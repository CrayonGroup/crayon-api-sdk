using System;

namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class DetailedBillingRecordCspStatementLineDto
    {
        public string OperatingUnit { get; set; }

        public string CustomerNumber { get; set; }

        public string OrderId { get; set; }

        public string SubscriptionId { get; set; }

        public string SyndicationPartnerSubscriptionNumber { get; set; }

        public string OfferId { get; set; }

        public string DurableOfferId { get; set; }

        public string OfferName { get; set; }

        public DateTime SubscriptionStartDate { get; set; }

        public DateTime SubscriptionEndDate { get; set; }

        public DateTime ChargeStartDate { get; set; }

        public DateTime ChargeEndDate { get; set; }

        public string ChargeType { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public decimal TotalCalDiscount { get; set; }

        public decimal TotalOtherDiscount { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal TotalForCustomer { get; set; }

        public string Currency { get; set; }

        public string CustomerName { get; set; }

        public string MpnIdT1 { get; set; }

        public string MpnIdT2 { get; set; }
    }
}