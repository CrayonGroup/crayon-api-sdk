using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionTransitionEligibility
    {
        public string CatalogItemId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public List<SubscriptionTransitionEligibilityDetail> Eligibilities { get; set; }
    }
}
