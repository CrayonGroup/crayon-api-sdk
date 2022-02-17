using System;

namespace Crayon.Api.Sdk.Domain
{
    [Flags]
    public enum ProgramType
    {
        None = 0,
        License = 1,
        Report = 2,
        Cloud = 4
    }
}
