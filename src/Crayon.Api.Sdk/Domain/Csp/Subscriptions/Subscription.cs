using Crayon.Api.Sdk.Domain.CloudProvisioning.CustomerTenants;
using Crayon.Api.Sdk.Domain.Common;
using System;
using System.Collections.Generic;
using Crayon.Api.Sdk.Domain.Products;

namespace Crayon.Api.Sdk.Domain.CloudProvisioning.Subscriptions
{
    public class Subscription
    {
        public int Id { get; set; }

        public string PublisherSubscriptionId { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Organization { get; set; }

        public CustomerTenantReference CustomerTenant { get; set; }

        public ProductReference Product { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public SubscriptionStatus Status { get; set; }

        public int AvailableAddonsCount { get; set; }

        public List<SubscriptionAddOn> Subscriptions { get; set; }

        public string OrderId { get; set; }

        public DateTimeOffset CreationDate { get; set; }
    }
}