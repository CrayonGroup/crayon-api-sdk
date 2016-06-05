using System;

namespace Crayon.Api.Sdk.Domain
{
    public class DateRange
    {
        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }
    }
}