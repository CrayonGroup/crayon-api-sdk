namespace Crayon.Api.Sdk.Domain.Csp
{
    public class BillingStatementFile
    {
        public BillingStatement BillingStatement { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }
}