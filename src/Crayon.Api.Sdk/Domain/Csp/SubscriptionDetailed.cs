using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionDetailed : Subscription
    {
        public DateTimeOffset EffectiveStartDate { get; set; }
        public DateTimeOffset CommitmentEndDate { get; set; }
        public string SuspensionReasons { get; set; }
    }
}