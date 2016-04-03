using System.Collections.Generic;
using Crayon.Api.Sdk.Domain.Common;

namespace Crayon.Api.Sdk.Domain.Products
{
    public class PublisherAggregationItem
    {
        public string Key { get; set; }

        public long DocCount { get; set; }

        public List<AggregationItem> Programs { get; set; }
    }
}