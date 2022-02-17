namespace Crayon.Api.Sdk.Domain.Csp
{
    public class PutAzureSubscription
    {
        public int Id { get; set; }
        
        public ObjectReference InvoiceProfile { get; set; }

        public AzureSubscriptionTags Tags { get; set; }
    }
}