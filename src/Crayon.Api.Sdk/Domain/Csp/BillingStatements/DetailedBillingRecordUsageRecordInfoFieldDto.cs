namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class DetailedBillingRecordUsageRecordInfoFieldDto
    {
        public int Id { get; set; }

        public int UsageRecordId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}