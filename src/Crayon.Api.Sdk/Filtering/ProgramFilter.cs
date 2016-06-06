using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Filtering
{
    public class ProgramFilter : IHttpFilter
    {
        public ProgramFilter()
        {
            Search = string.Empty;
            Page = 1;
            PageSize = 1000;
        }

        public int PublisherId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}