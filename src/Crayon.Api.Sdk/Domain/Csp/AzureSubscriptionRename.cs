namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AzureSubscriptionRename
    {
        public int? AzurePlanId { get; set; }

        public int? AzureSubscriptionId { get; set; }

        public string Name { get; set; }
    }
}
