using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Internal
{
    internal class ResultFormatter
    {
        private readonly IHttpSerializer _formatter;

        public ResultFormatter(IHttpSerializer formatter)
        {
            _formatter = formatter;
        }

        public CrayonApiClientResult<T> HandleException<T>(bool successfull, Exception ex, string responseBody, HttpStatusCode? responseStatusCode, string baseAddress, Uri uri)
        {
            //Handle service not responding att all
            var requestException = ex as HttpRequestException;
            if (requestException != null)
            {
                Error error = ToError(ex.InnerException ?? ex, $"Unable to connect to {baseAddress + uri}");
                return new CrayonApiClientResult<T>(
                    HttpStatusCode.ServiceUnavailable,
                    responseBody,
                    uri,
                    error);
            }

#if NET451 || NET461
            var webException = ex as WebException;
            if (webException != null)
            {
                Error error = ToError(ex.InnerException ?? ex, $"Unable to connect to {baseAddress + uri}");
                return new CrayonApiClientResult<T>(
                    HttpStatusCode.ServiceUnavailable,
                    responseBody,
                    uri,
                    error);
            }
#endif

            //Handle error message if it was returned            
            try
            {
                var error = _formatter.DeserializeString<Error>(responseBody);
                return new CrayonApiClientResult<T>(
                    responseStatusCode ?? HttpStatusCode.InternalServerError,
                    responseBody,
                    uri,
                    error);
            }
            catch (FormattingException e)
            {
                string message = $"Attempted to format: '{responseBody}'";
                var error = ToError(e, message);
                return new CrayonApiClientResult<T>(
                    responseStatusCode ?? HttpStatusCode.InternalServerError,
                    responseBody,
                    uri,
                    error);
            }
        }

        public CrayonApiClientResult HandleException(bool successfull, Exception ex, string responseBody, HttpStatusCode? responseStatusCode, string baseAddress, Uri uri)
        {
            //Handle service not responding att all
            var requestException = ex as HttpRequestException;
            if (requestException != null)
            {
                Error error = ToError(ex.InnerException ?? ex, $"Unable to connect to {baseAddress + uri}");
                return new CrayonApiClientResult(
                    HttpStatusCode.ServiceUnavailable,
                    responseBody,
                    uri,
                    error);
            }

#if NET451 || NET461
            var webException = ex as WebException;
            if (webException != null)
            {
                Error error = ToError(ex.InnerException ?? ex, $"Unable to connect to {baseAddress + uri}");
                return new CrayonApiClientResult(
                    HttpStatusCode.ServiceUnavailable,
                    responseBody,
                    uri,
                    error);
            }
#endif

            //Handle error message if it was returned            
            try
            {
                var error = _formatter.DeserializeString<Error>(responseBody);
                return new CrayonApiClientResult(
                    responseStatusCode ?? HttpStatusCode.InternalServerError,
                    responseBody,
                    uri,
                    error);
            }
            catch (FormattingException e)
            {
                string message = $"Attempted to format: '{responseBody}'";
                var error = ToError(e, message);
                return new CrayonApiClientResult(
                    responseStatusCode ?? HttpStatusCode.InternalServerError,
                    responseBody,
                    uri,
                    error);
            }
        }

        private static Error ToError(Exception e, string message)
        {
            var error = new Error
            {
                Message = e.Message,
                ObjectErrors = new List<InternalError> {
                    new InternalError {
                        Message = e.InnerException?.Message ?? string.Empty
                    },
                    new InternalError {
                        Message = message
                    }
                }
            };

            return error;
        }
    }
}
