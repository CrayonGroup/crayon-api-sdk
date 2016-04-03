using Crayon.Api.Sdk.Domain.MasterData.Regions;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Filtering
{
    public class RegionFilter : IFilter
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
            return this.ToUrlQuery();
        }
    }
}