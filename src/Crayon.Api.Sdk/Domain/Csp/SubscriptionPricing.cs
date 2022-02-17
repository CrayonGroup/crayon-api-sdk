using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionPricing
    {
        public string CurrencyCode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RecommendedRetailPrice { get; set; }
    }
}
