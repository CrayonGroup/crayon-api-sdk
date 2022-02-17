using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class Subscription
    {
        public int Id { get; set; }

        public string PublisherSubscriptionId { get; set; }

        public string EntitlementId { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Organization { get; set; }

        public CustomerTenantReference CustomerTenant { get; set; }

        public ProductReference Product { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public SubscriptionStatus Status { get; set; }

        public ProvisionType ProvisionType { get; set; }

        public int AvailableAddonsCount { get; set; }

        public List<SubscriptionAddOn> Subscriptions { get; set; }

        public string OrderId { get; set; }

        public DateTimeOffset CreationDate { get; set; }

        public BillingCycleEnum BillingCycle { get; set; }

        public decimal Markup { get; set; }

        public bool IsTrial { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public SubscriptionPriceType PriceType { get; set; }

        public decimal SalesPrice { get; set; }

        public bool RegisteredForReservedInstance { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public SubscriptionTags SubscriptionTags { get; set; }

        public bool? AcceptAutoSuspension { get; set; }

        public DateTimeOffset? AutoSuspensionDate { get; set; }

        public string PartNumber { get; set; }

        public string TermDuration { get; set; }

        public bool? AutoRenewEnabled { get; set; }

        public DateTimeOffset? CancellationAllowedUntilDate { get; set; }

        public ScheduledNextTermInstructions ScheduledNextTermInstructions { get; set; }
    }
}