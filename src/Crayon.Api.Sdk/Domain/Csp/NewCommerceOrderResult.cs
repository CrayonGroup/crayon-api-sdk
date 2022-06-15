namespace Crayon.Api.Sdk.Domain.Csp
{
    public class NewCommerceOrderResult
    {
        public bool IsSuccessful { get; set; }
        public string ErrorReasonCode { get; set; }
        public string ErrorDescription { get; set; }
        public System.Guid? NewCommerceOrderId { get; set; }

    }
}
