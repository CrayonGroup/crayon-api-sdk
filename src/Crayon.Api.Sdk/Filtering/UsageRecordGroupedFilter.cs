using Crayon.Api.Sdk.Filtering.Extensions;
using System;

namespace Crayon.Api.Sdk.Filtering
{
    public class UsageRecordGroupedFilter : IFilter
    {
        public int OrganizationId { get; set; }
        public int BillingStatementId { get; set; }
        public int SubscriptionId { get; set; }
        public int ProductFamilyId { get; set; }
        public int PublisherId { get; set; }
        public int CustomerTenantId { get; set; }
        public DateTimeOffset? From { get; set; }
        public DateTimeOffset? To { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToUrlQuery();
        }
    }
}