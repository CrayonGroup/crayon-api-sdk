using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class InternalError
    {
        public InternalError()
        {
            Parameters = new Dictionary<string, string>();
        }

        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public Dictionary<string, string> Parameters { get; set; }
    }
}