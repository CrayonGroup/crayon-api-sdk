using Newtonsoft.Json;
using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionDetailed : Subscription
    {
        public DateTimeOffset EffectiveStartDate { get; set; }

        public DateTimeOffset CommitmentEndDate { get; set; }

        public string SuspensionReasons { get; set; }

        public int? OriginalAgreementId { get; set; }

        [JsonProperty(nameof(Pricing), NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionPricing Pricing { get; set; }

        public bool? AttestationAccepted { get; set; }
    }
}