using System;
using System.Threading;

namespace Crayon.Api.Sdk.Domain
{
    public class RequestOptions
    {
        public CancellationToken? CancellationToken { get; set; }
        public TimeSpan? RequestTimeout { get; set; }

        internal void SetInternalProperties(TimeSpan? defaultTimeout)
        {
            RequestTimeout = RequestTimeout ?? defaultTimeout;
        }
    }
}
