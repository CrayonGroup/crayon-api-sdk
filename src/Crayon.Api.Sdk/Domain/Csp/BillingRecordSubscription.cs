using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class BillingRecordSubscription
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PublisherSubscriptionId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}