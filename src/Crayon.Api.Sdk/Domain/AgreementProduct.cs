namespace Crayon.Api.Sdk.Domain
{
    public class AgreementProduct
    {
        public string UniqueId { get; set; }

        public ProductVariant ProductVariant { get; set; }

        public ObjectReference Agreement { get; set; }

        public string Name { get; set; }

        public int PriceId { get; set; }

        public Price SalesPrice { get; set; }

        public string PriceListName { get; set; }

        public int MonthMultiplier { get; set; }

        public PriceCalculationType PriceCalculationType { get; set; }
    }
}