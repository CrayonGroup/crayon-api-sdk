using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionAddOn
    {
        public int Id { get; set; }
        public string PublisherSubscriptionId { get; set; }
        public string PublisherCustomerId { get; set; }
        public string Name { get; set; }
        public SubscriptionStatus Status { get; set; }
        public int Quantity { get; set; }
        public ObjectReference Organization { get; set; }
        public string OrderId { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public ProductReference Product { get; set; }
        public ObjectReference Publisher { get; set; }
    }
}