using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AssetOrderLineError
    {
        public string ReasonCode { get; set; }

        public string Description { get; set; }

        public Dictionary<string, string> Properties { get; set; }
    }
}
