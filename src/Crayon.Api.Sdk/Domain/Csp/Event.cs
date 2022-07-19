using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class Event
    {
        public string Name { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string Status { get; set; }

        public Attributes Attributes { get; set; }
    }
}