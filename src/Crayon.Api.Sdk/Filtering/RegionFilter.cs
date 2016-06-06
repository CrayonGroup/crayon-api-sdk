using Crayon.Api.Sdk.Domain.MasterData;

namespace Crayon.Api.Sdk.Filtering
{
    public class RegionFilter : IHttpFilter
    {
        public RegionFilter()
        {
            Page = 1;
            PageSize = 1000;
        }

        public RegionList RegionList { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}