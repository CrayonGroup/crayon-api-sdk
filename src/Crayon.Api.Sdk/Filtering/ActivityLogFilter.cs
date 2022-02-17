using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class ActivityLogFilter : IHttpFilter
    {
        public string Entity { get; set; }
        public int Id { get; set; }
        public List<int> Ids { get; set; }

        public DateTimeOffset? SearchDate { get; set; } = new DateTimeOffset(DateTime.UtcNow.Date, new TimeSpan());
        public DateTimeOffset? From { get; set; }
        public DateTimeOffset? To { get; set; }

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
