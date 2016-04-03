using System;
using System.Net;

namespace Crayon.Api.Sdk.Exceptions
{
    public class ApiHttpException : Exception
    {
        public ApiHttpException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
            InnerStackTrace = string.Empty;
        }

        public ApiHttpException(HttpStatusCode statusCode, string message, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        public ApiHttpException(string message)
            : base(message)
        {
            StatusCode = HttpStatusCode.InternalServerError;
        }

        public HttpStatusCode StatusCode { get; set; }
        public string InnerStackTrace { get; set; }
        public Uri ResponseUri { get; set; }
    }
}