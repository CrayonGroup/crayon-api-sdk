using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionTransition
    {
        public string ToCatalogItemId { get; set; }

        public int Quantity { get; set; }

        public string TransitionType { get; set; }

        public BillingCycleEnum BillingCycle { get; set; }

        public string Term { get; set; }
    }

    public class SubscriptionTransitionResponse : SubscriptionTransition
    {
        public string FromCatalogItemId { get; set; }

        public List<Event> Events { get; set; }
    }
}
