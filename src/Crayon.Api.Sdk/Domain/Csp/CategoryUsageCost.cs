using System.Linq;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CategoryUsageCostClientModel
    {
        public CategoryUsageCostClientModel(CategoryUsageCost categoryUsageCost)
        {
            Subcategory = categoryUsageCost.Subcategory;
            Amount = categoryUsageCost.Amount;
            CurrencyCode = categoryUsageCost.CurrencyCode;
            ClientName = Subcategory != null ? new string(Subcategory.Where(c => char.IsLetterOrDigit(c) || c == '_').ToArray()) : string.Empty;
        }

        public string ClientName { get; set; }

        public string Subcategory { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }

    public class CategoryUsageCost
    {
        public string Subcategory { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}