using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    [Flags]
    public enum SubscriptionStatus
    {
        None = 0,
        Active = 1,
        Suspended = 2,
        Deleted = 4,
        CustomerCancellation = 8,
        Converted = 16,
        Expired = 32,
        Pending = 64,
        Cancelled = 128,
        Disabled = 256,
        Inactive = Suspended | Deleted | CustomerCancellation | Converted | Expired | Cancelled | Disabled,
        All = Inactive | Active | Pending
    }
}