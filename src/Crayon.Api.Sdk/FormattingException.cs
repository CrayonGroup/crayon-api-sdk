using System;

namespace Crayon.Api.Sdk
{
    internal class FormattingException : Exception
    {
        public FormattingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
