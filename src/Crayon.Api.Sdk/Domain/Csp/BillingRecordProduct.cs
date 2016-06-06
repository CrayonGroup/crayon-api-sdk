namespace Crayon.Api.Sdk.Domain.Csp
{
    public class BillingRecordProduct
    {
        public int Id { get; set; }

        public string PartNumber { get; set; }

        public string InvoicePartNumber { get; set; }

        public string ItemLegalName { get; set; }

        public string ItemName { get; set; }

        public string ProductFamilyName { get; set; }

        public string ProductCategoryName { get; set; }
    }
}