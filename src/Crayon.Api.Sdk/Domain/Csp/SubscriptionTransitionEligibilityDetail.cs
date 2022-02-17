using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionTransitionEligibilityDetail
    {
        public SubscriptionTransitionEligibilityDetail()
        {
            Errors = new List<SubscriptionTransitionError>();
        }

        public List<SubscriptionTransitionError> Errors { get; set; }

        public bool IsEligible { get; set; }

        public string TransitionType { get; set; }
    }
}
