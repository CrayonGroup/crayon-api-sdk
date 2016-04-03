namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class BillingStatementFile
    {
        public BillingStatement BillingStatement { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }
}