using Crayon.Api.Sdk.Domain.CloudProvisioning.Subscriptions;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Filtering
{
    public class SubscriptionFilter : IFilter
    {
        public SubscriptionFilter()
        {
            Page = 1;
            PageSize = 50;
            Refresh = false;
            Statuses = SubscriptionStatus.All;
        }

        public int OrganizationId { get; set; }
        public int CustomerTenantId { get; set; }
        public string PublisherCustomerId { get; set; }
        public bool Refresh { get; set; }
        public SubscriptionStatus Statuses { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToUrlQuery();
        }
    }
}