namespace Crayon.Api.Sdk.Domain
{
    public class ResellerSalesPriceToggle
    {
        public bool Toggle { get; set; }
        public int ObjectId { get; set; }
        public ResellerSalesPriceObjectType ObjectType { get; set; }
    }
}
