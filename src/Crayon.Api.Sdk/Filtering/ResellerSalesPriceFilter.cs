using Crayon.Api.Sdk.Domain;
using System;

namespace Crayon.Api.Sdk.Filtering
{
    public class ResellerSalesPriceFilter : IHttpFilter
    {
        public ResellerSalesPriceType? Type { get; set; }
        public int ObjectId { get; set; }
        public ResellerSalesPriceObjectType ObjectType { get; set; }
        public DateTimeOffset? FromDate { get; set; }
        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
