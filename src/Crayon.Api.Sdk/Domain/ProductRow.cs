using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class ProductRow
    {
        public int Id { get; set; }

        public int ProductContainerId { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; } = string.Empty;

        public string UsageCountryCode { get; set; } = string.Empty;

        /// <summary>
        /// Price with margin and discount
        /// </summary>
        public Price SalesUnitPrice { get; set; }

        /// <summary>
        /// Alternative Sales Price
        /// </summary>
        public Price AlternativeSalesUnitPrice { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Program { get; set; }

        public AgreementIdentityReference Agreement { get; set; }

        public ProductReference Product { get; set; }

        public ProductRowUser User { get; set; }

        public ObjectReference ProductVariant { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public Grouping Grouping { get; set; }

        public List<ProductContainerIssue> Issues { get; set; } = new List<ProductContainerIssue>();

        public string OfferingType { get; set; }

        public PriceCalculationType PriceCalculation { get; set; }

        public string InvoiceReference { get; set; }

        public string CustomerReference { get; set; }

        public decimal SalesPricePerAlternativeUnit { get; set; }

        public decimal LevelValue { get; set; }
    }
}