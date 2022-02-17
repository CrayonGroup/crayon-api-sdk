using System;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Filtering
{
    public class SubscriptionFilter : IHttpFilter
    {
        public SubscriptionFilter()
        {
            Page = 1;
            PageSize = 50;
            Refresh = false;
            Statuses = SubscriptionStatus.All;
            RegisteredForReservedInstance = null;
        }

        public int OrganizationId { get; set; }
        public int CustomerTenantId { get; set; }
        public int PublisherId { get; set; }
        [Obsolete("This property is no longer in use")]
        public bool Refresh { get; set; }
        public SubscriptionStatus Statuses { get; set; }
        public bool? IsTrial { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public bool? RegisteredForReservedInstance { get; set; }
        public SubscriptionSortBy? SortBy { get; set; }
        public SortOrder SortOrder { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}