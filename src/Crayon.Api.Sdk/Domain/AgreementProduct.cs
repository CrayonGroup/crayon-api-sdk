namespace Crayon.Api.Sdk.Domain
{
    public class AgreementProduct
    {
        public string UniqueId { get; set; }
        
        public ProductTypeDto ProductType { get; set; }

        public ProductVariant ProductVariant { get; set; }

        public ObjectReference Agreement { get; set; }

        public string Name { get; set; }

        public int PriceId { get; set; }

        public Price RecommendedRetailPrice { get; set; }

        public Price SalesPrice { get; set; }

        public Price AlternativeSalesPrice { get; set; }
        
        public string PriceListName { get; set; }

        public int MonthMultiplier { get; set; }

        public PriceCalculationType PriceCalculationType { get; set; }

        public AgreementType AgreementType { get; set; }

        public ProductInformation ProductInformation { get; set; }

        public int MinimumQuantity { get; set; }

        public int? MaximumQuantity { get; set; }

        public ObjectReference Catalog { get; set; }
    }
}