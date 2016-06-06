using System;
using System.Net.Http;

namespace Crayon.Api.Sdk
{
    public class CrayonApiClientDataResult<T> : CrayonApiClientResult
    {
        public CrayonApiClientDataResult(T data, HttpResponseMessage response)
            : base(response)
        {
            Data = data;
        }

        public T Data { get; }

        public T GetData()
        {
            if (IsSuccessStatusCode)
            {
                return Data;
            }

            if (Error == null)
            {
                throw new ApiHttpException(StatusCode, Content);
            }

            var message = Error.ErrorCode + ": " + Error.Message;
            var innerException = new Exception(Error.Message);

            throw new ApiHttpException(StatusCode, message, innerException) {
                InnerStackTrace = string.Empty
            };
        }
    }
}