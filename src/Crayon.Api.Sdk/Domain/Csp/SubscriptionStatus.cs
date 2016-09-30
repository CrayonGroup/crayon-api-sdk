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
        Inactive = Suspended | Deleted | CustomerCancellation,
        All = Active | Inactive
    }
}