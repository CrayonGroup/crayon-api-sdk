using System;

namespace Crayon.Api.Sdk.Domain
{
    [Flags]
    public enum UserRole
    {
        None = 0,
        User = 1,
        TenantAdmin = 2
    }
}