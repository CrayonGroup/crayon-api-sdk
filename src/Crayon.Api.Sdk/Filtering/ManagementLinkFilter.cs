using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class ManagementLinkFilter : IHttpFilter
    {
        public List<int> SubscriptionIds { get; set; }
        public List<int> ResellerCustomerIds { get; set; } = new List<int>();
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
