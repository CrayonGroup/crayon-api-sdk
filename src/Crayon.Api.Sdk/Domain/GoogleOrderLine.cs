namespace Crayon.Api.Sdk.Domain
{
    public class GoogleOrderLine
    {
        public int PublisherId { get; set; }
        public int AgreementId { get; set; }
        public int ProductVariantId { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}
