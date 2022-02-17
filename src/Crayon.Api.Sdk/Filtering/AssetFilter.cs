using System.Collections.Generic;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Filtering
{
    public class AssetFilter : IHttpFilter
    {
        public AssetFilter()
        {
            Page = 1;
            PageSize = 20;
            ExternalOrderIds = new List<string>();
        }

        public int ResellerCustomerId { get; set; }
        public int PublisherId { get; set; }
        public string ExternalOrderId { get; set; }
        public List<string> ExternalOrderIds { get; set; }
        public string ReservationId { get; set; }
        public AssetType? AssetType { get; set; }
        public AssetStatus Status { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public AssetSortBy? SortBy { get; set; }
        public SortOrder SortOrder { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
