namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class DetailedBillingRecordExternalProductDto
    {
        public int Id { get; set; }

        public string PartNumber { get; set; }

        public string ItemLegalName { get; set; }

        public string ItemName { get; set; }

        public string SearchableName { get; set; }

        public int ProductFamilyId { get; set; }

        public string ProductFamilyName { get; set; }
    }
}