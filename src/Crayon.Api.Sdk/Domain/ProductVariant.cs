using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public ProductReference Product { get; set; }
        public string PartNumber { get; set; }
        public string ProductName { get; set; }
        public ObjectReference Publisher { get; set; }
        public ObjectReference Program { get; set; }
        public ObjectReference ProductFamily { get; set; }
        public ObjectReference Language { get; set; }
        public ObjectReference Level { get; set; }
        public ObjectReference ProductType { get; set; }
        public ObjectReference Pool { get; set; }
        public ObjectReference LicenseType { get; set; }
        public ObjectReference LicenseAgreementType { get; set; }
        public ObjectReference OperatingSystem { get; set; }
        public ObjectReference Offering { get; set; }
        public MinimumCommitmentLight MinimumCommitment { get; set; }
        public int UnitCount { get; set; }
        public string Version { get; set; }
        public string PurchaseUnit { get; set; }
        public string PurchasePeriod { get; set; }
        public DateTimeOffset AddDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public string ProductCategory { get; set; }
        public string Region { get; set; }
        public bool IsTrial { get; set; }
        public int DefaultBillingCycleId { get; set; }
        public int[] AvailableBillingCycleIds { get; set; }
        public IDictionary<string, object> Attributes { get; set; }
        public decimal MinimumQuantity { get; set; }
    }
}