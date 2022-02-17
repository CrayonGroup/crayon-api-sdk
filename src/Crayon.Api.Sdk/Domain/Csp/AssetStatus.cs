using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    [Flags]
    public enum AssetStatus
    {
        None = 0,
        Fulfilling = 1,
        Succeeded = 2,
        Cancelled = 4,
        Expired = 8,
        All = Fulfilling | Succeeded | Cancelled | Expired
    }
}
