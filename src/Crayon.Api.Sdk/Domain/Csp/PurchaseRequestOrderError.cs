namespace Crayon.Api.Sdk.Domain.Csp
{
    public class PurchaseRequestOrderError
    {
        public string OrderGroupId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
