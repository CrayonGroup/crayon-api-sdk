using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Filtering
{
    public class ScheduledPurchaseRequestFilter : IHttpFilter
    {
        public ScheduledPurchaseRequestFilter()
        {
            Page = 1;
            PageSize = 20;
            SortOrder = SortOrder.Ascending;
        }

        public int ResellerCustomerId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public SortOrder SortOrder { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
