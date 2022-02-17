namespace Crayon.Api.Sdk.Domain.Csp
{
    public sealed class ReconciliationFile
    {
        public BillingStatement BillingStatement { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }
}