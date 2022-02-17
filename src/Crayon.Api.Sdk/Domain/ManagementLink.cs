
namespace Crayon.Api.Sdk.Domain
{
    public class ManagementLink
    {
        public string Link { get; set; }
        public ObjectReference ResellerCustomer { get; set; }
        public ObjectReference Subscription { get; set; }
        public string Text { get; set; }
    }
}
