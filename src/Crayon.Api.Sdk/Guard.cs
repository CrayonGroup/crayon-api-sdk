using System;

namespace Crayon.Api.Sdk
{
    internal static class Guard
    {
        internal static void NotNull(object o, string paramName, string message = "")
        {
            if (o == null)
            {
                throw new ArgumentNullException(paramName, message);
            }
        }
    }
}