using System;

namespace Crayon.Api.Sdk.Internal
{
    internal class FormattingException : Exception
    {
        public FormattingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
