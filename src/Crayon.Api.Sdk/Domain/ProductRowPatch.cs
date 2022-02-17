namespace Crayon.Api.Sdk.Domain
{
    public class ProductRowPatch
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public string Comment { get; set; }

        public string UsageCountryCode { get; set; }

        public string UserId { get; set; }

        public ObjectReference Agreement { get; set; }

        public ObjectReference ProductVariant { get; set; }

        public ObjectReference Grouping { get; set; }
    }
}
