using System;

namespace Crayon.Api.Sdk.Domain.Secrets
{
    public class Secret
    {
        public int Id { get; set; }

        public string ClientId { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public DateTimeOffset? Expiration { get; set; }

        public DateTimeOffset TimeStamp { get; set; }
    }
}