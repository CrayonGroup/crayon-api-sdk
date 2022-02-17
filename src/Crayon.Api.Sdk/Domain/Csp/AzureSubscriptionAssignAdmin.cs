namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AzureSubscriptionAssignAdmin
    {
        public int? AzurePlanId { get; set; }

        public int? AzureSubscriptionId { get; set; }

        public string AdminEmail { get; set; }
    }
}
