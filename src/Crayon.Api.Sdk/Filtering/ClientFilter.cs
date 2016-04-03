using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Filtering
{
    public class ClientFilter : IFilter
    {
        public ClientFilter()
        {
            Page = 1;
            PageSize = 50;
        }

        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToUrlQuery();
        }
    }
}