namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AzureSubscription
    {
        public int Id { get; set; }
        
        public int AzurePlanId { get; set; }
        
        public string PublisherSubscriptionId { get; set; }
        
        public string FriendlyName { get; set; }
        
        public string Status { get; set; }
        
        public ObjectReference InvoiceProfile { get; set; }

        public AzureSubscriptionTags Tags { get; set; }
    }
}