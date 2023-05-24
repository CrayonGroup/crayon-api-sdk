namespace Crayon.Api.Sdk.Filtering
{
    public class SubscriptionCoterminosityFilter : IHttpFilter
    {
        public int OrganizationId { get; set; }
        public int CustomerTenantId { get; set; }
        public int? SubscriptionId { get; set; }
        public string TermDuration { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
