using System;

namespace Crayon.Api.Sdk.Domain.Users
{
    [Flags]
    public enum UserRole
    {
        None = 0,
        User = 1,
        TenantAdmin = 2
    }
}