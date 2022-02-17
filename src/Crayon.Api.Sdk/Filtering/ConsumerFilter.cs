using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class ConsumerFilter : IHttpFilter
    {
        public int OrganizationId { get; set; }
        public string Search { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 1000;

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
