using System;

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
        public int UnitCount { get; set; }
        public string Version { get; set; }
        public string PurchaseUnit { get; set; }
        public DateTimeOffset AddDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
    }
}