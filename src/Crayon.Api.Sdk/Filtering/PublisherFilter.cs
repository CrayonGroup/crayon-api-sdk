using Crayon.Api.Sdk.Filtering.Extensions;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class PublisherFilter : IHttpFilter
    {
        public PublisherFilter()
        {
            Page = 1;
            PageSize = 1000;
            Names = new List<string>();
        }

        public List<string> Names { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}