using System;

namespace Crayon.Api.Sdk.Domain.Common
{
    public class DateRange
    {
        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }
    }
}