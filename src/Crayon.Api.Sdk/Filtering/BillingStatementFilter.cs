using System;

namespace Crayon.Api.Sdk.Filtering
{
    public class BillingStatementFilter : IHttpFilter
    {
        public BillingStatementFilter()
        {
            From = DateTimeOffset.MinValue;
            To = DateTimeOffset.MaxValue;
            Page = 1;
            PageSize = 50;
        }

        public int InvoiceProfileId { get; set; }
        public int OrganizationId { get; set; }
        public DateTimeOffset? From { get; set; }
        public DateTimeOffset? To { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}