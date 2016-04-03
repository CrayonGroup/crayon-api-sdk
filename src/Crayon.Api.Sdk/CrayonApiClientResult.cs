using Crayon.Api.Sdk.Domain.Common;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace Crayon.Api.Sdk
{
    public class CrayonApiClientResult
    {
        public CrayonApiClientResult(HttpResponseMessage response)
        {
            Content = response.Content.ReadAsStringAsync().Result;
            ResponseUri = response.RequestMessage.RequestUri;
            StatusCode = response.StatusCode;
            IsSuccessStatusCode = response.IsSuccessStatusCode;

            if (!IsSuccessStatusCode)
            {
                Error = HandleFailureStatusCode(response);
            }
        }

        public string Content { get; }
        public Error Error { get; }
        public Uri ResponseUri { get; }
        public HttpStatusCode StatusCode { get; }
        protected bool IsSuccessStatusCode { get; }

        private Error HandleFailureStatusCode(HttpResponseMessage response)
        {
            try
            {
                return JsonConvert.DeserializeObject<Error>(Content);
            }
            catch (JsonException ex)
            {
                return new Error {
                    Message = ex.Message,
                    ErrorCode = response.StatusCode.ToString()
                };
            }
        }
    }
}