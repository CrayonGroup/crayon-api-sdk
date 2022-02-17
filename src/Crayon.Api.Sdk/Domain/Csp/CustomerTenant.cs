namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CustomerTenant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Program { get; set; }

        public string PublisherCustomerId { get; set; }

        public string ExternalPublisherCustomerId { get; set; }

        public string Domain { get; set; }

        public string DomainPrefix { get; set; }

        public string Reference { get; set; }

        public CustomerTenantType CustomerTenantType { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public Organization Organization { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public ObjectReference Consumer { get; set; }

        public decimal ResellerMarkup { get; set; }

        public SubscriptionPriceType DefaultSubscriptionPriceType { get; set; }

        public CustomerTenantAgreement agreement { get; set; }
    }
}