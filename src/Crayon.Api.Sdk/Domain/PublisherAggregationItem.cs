using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class PublisherAggregationItem
    {
        public string Key { get; set; }

        public long DocCount { get; set; }

        public List<AggregationItem> Programs { get; set; }
    }
}