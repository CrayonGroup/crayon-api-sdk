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
        Inactive = Suspended | Deleted | CustomerCancellation | Converted,
        All = Active | Inactive
    }
}