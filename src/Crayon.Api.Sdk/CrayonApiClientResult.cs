using Crayon.Api.Sdk.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace Crayon.Api.Sdk
{
    public class CrayonApiClientResult<T> : CrayonApiClientResult
    {
        public CrayonApiClientResult(T data, HttpStatusCode statusCode, string content, Uri uri)
            : base(statusCode, content, uri)
        {
            if (IsSuccessStatusCode)
            {
                Data = data;
            }
        }

        internal CrayonApiClientResult(
            HttpStatusCode statusCode,
            string content,
            Uri url,
            Error error)
            : base(statusCode, content, url)
        {
            Error = error;
        }

        internal CrayonApiClientResult(T data, HttpStatusCode statusCode)
            : base(statusCode, string.Empty, null)
        {
            if (IsSuccessStatusCode)
            {
                Data = data;
            }
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

            var message = $"{Error.ErrorCode}: {Error.Message}";
            var innerException = new Exception(Error.Message);

            throw new ApiHttpException(StatusCode, message, innerException) {
                InnerStackTrace = string.Empty
            };
        }
    }

    public class CrayonApiClientResult
    {
        public CrayonApiClientResult(HttpStatusCode statusCode, string content, Uri uri)
        {
            Content = content;
            ResponseUri = uri;            
            StatusCode = statusCode;
            IsSuccessStatusCode = (int)statusCode >= 200 && (int)statusCode <= 299;

            if (!IsSuccessStatusCode)
            {
                Error = HandleFailureStatusCode();
            }
        }

        internal CrayonApiClientResult(
            HttpStatusCode statusCode,
            string content,
            Uri url,
            Error error)
            : this(statusCode, content, url)
        {
            Error = error;
        }


        public string Content { get; }
        public Error Error { get; internal set; }
        public Uri ResponseUri { get; }
        public HttpStatusCode StatusCode { get; }
        public bool IsSuccessStatusCode { get; }

        private Error HandleFailureStatusCode()
        {
            if (string.IsNullOrEmpty(Content))
            {
                return new Error {
                    Message = StatusCode == HttpStatusCode.NotFound ? "Not found" : string.Empty,
                    ErrorCode = "NO_CONTENT"
                };
            }

            try
            {
                return JsonConvert.DeserializeObject<Error>(Content);
            }
            catch (Exception ex)
            {
                return new Error {
                    Message = ex.Message,
                    ErrorCode = "UNABLE_TO_FORMAT_JSON"
                };
            }
        }

        public static CrayonApiClientResult<T> NotFound<T>()
        {
            return new CrayonApiClientResult<T>(default(T), HttpStatusCode.NotFound, string.Empty, null);
        }
    }
}