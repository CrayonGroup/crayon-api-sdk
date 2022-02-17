namespace Crayon.Api.Sdk.Domain.Csp
{
    public sealed class BillingRecordsFile
    {
        public BillingStatement BillingStatement { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }
}