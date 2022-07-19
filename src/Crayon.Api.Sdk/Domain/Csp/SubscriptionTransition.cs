using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionTransition
    {
        public string FromCatalogItemId { get; set; }

        public string FromSubscriptionId { get; set; }

        public string ToCatalogItemId { get; set; }

        public string ToSubscriptionId { get; set; }

        public string TransitionType { get; set; }

        public int Quantity { get; set; }

        public BillingCycleType BillingCycle { get; set; }

        public string Term { get; set; }
    }

    public class SubscriptionTransitionResponse : SubscriptionTransition
    {
        public List<Event> Events { get; set; }

        public Attributes Attributes { get; set; }
    }

    public class Attributes
    {
        public string ObjectType { get; set; }
    }
}
