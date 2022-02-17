using System.Linq;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionUsageCostClientModel
    {
        public SubscriptionUsageCostClientModel(SubscriptionUsageCost subscriptionUsageCost)
        {

            Category = subscriptionUsageCost.Category;
            Amount = subscriptionUsageCost.Amount;
            CurrencyCode = subscriptionUsageCost.CurrencyCode;
            ClientName = Category != null ? new string(Category.Where(c => char.IsLetterOrDigit(c) || c == '_').ToArray()) : string.Empty;
        }

        public string ClientName { get; set; }

        public string Category { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }

    public class SubscriptionUsageCost
    {
        public string Category { get; set; }

        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}