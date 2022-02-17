using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Domain
{
    public class AwsAccount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ObjectReference Publisher { get; set; }

        public string ExternalPublisherCustomerId { get; set; }
        
        public string Reference { get; set; }

        public CustomerTenantType CustomerTenantType { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public Organization Organization { get; set; }

        public ObjectReference InvoiceProfile { get; set; }
        
        public bool IsActivated { get; set; }

        public SubscriptionTags Tags { get; set; }

        public string PayerAccountId { get; set; }

        public string AwsAccountName { get; set; }

        public AwsMasterAccountStatus MasterAccountStatus { get; set; }
    }
}