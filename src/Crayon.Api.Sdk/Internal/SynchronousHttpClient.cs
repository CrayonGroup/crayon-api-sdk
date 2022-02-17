using Crayon.Api.Sdk.Domain;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

#if NET451 || NET461 
namespace Crayon.Api.Sdk.Internal
{
    internal class SynchronousHttpClient
    {
        internal static CrayonApiClientResult<T> SendRequest<T>(
            HttpMethod method,
            Uri baseAddress,
            string uri,
            string bearerToken,
            IHttpSerializer serializer,
            string sdkVersion,
            Action<IPreSendWrapper> preSend,
            RequestOptions options,
            string content = null
            )
        {            
            var requestUri = FormatRequestUri(baseAddress, uri);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);            
            request.Method = method.ToString();

            if (!string.IsNullOrWhiteSpace(bearerToken))
            {
                request.Headers.Add("Authorization", "Bearer " + bearerToken);
            }

            request.Headers.Add("sdk-version", sdkVersion);
            request.ContentType = "application/json";
            if (options.RequestTimeout.HasValue)
            {
                request.Timeout = (int)options.RequestTimeout.Value.TotalMilliseconds;
            }
            
            if (content != null)
            {
                var bytes = Encoding.UTF8.GetBytes(content);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            else
            {
                request.ContentLength = 0;
            }

            preSend(new HttpWebRequestWrapper(request));

            string contentAsString = string.Empty;
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            try
            {
                try
                {
                    using (var webResponse = (HttpWebResponse)request.GetResponse())
                    {
                        statusCode = webResponse.StatusCode;

                        using (Stream responseStream = webResponse.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    contentAsString = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                catch (WebException webException)
                {
                    if (webException.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = (HttpWebResponse)webException.Response;
                        statusCode = response.StatusCode;
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    contentAsString = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }

                var data = serializer.DeserializeString<T>(contentAsString);

                return new CrayonApiClientResult<T>(data, statusCode, contentAsString, request.RequestUri);
            }
            catch (Exception ex)
            {
                bool successfull = (int)statusCode >= 200 || (int)statusCode <= 299;

                return new ResultFormatter(serializer).HandleException<T>(
                    successfull,
                    ex,
                    contentAsString,
                    statusCode,
                    baseAddress.ToString(),
                    requestUri);
            }
        }

        internal static CrayonApiClientResult SendRequest(
            HttpMethod method,
            Uri baseAddress,
            string uri,
            string bearerToken,
            IHttpSerializer serializer,
            string sdkVersion,
            Action<IPreSendWrapper> preSend,
            RequestOptions options,
            string content = null
            )
        {
            var requestUri = FormatRequestUri(baseAddress, uri);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Method = method.ToString();

            if (!string.IsNullOrWhiteSpace(bearerToken))
            {
                request.Headers.Add("Authorization", "Bearer " + bearerToken);
            }

            request.Headers.Add("sdk-version", sdkVersion);
            request.ContentType = "application/json";
            
            if (options.RequestTimeout.HasValue)
            {
                request.Timeout = (int)options.RequestTimeout.Value.TotalMilliseconds;
            }

            if (content != null)
            {
                //28591 = iso-8859-1 = Western European (ISO)
                var bytes = Encoding.GetEncoding(28591).GetBytes(content);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            else
            {
                request.ContentLength = 0;
            }

            preSend(new HttpWebRequestWrapper(request));

            string contentAsString = string.Empty;
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            try
            {
                try
                {
                    using (var webResponse = (HttpWebResponse)request.GetResponse())
                    {
                        statusCode = webResponse.StatusCode;

                        using (Stream responseStream = webResponse.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    contentAsString = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                catch (WebException webException)
                {
                    if (webException.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = (HttpWebResponse)webException.Response;
                        statusCode = response.StatusCode;
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    contentAsString = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }

                return new CrayonApiClientResult(statusCode, contentAsString, request.RequestUri);
            }
            catch (Exception ex)
            {
                bool successfull = (int)statusCode >= 200 || (int)statusCode <= 299;

                return new ResultFormatter(serializer).HandleException(
                    successfull,
                    ex,
                    contentAsString,
                    statusCode,
                    baseAddress.ToString(),
                    requestUri);
            }
        }

        private static Uri FormatRequestUri(Uri baseAddress, string uri)
        {
            var requestUri = new Uri(baseAddress + uri.TrimStart('/').TrimEnd('?', '&'));
            return requestUri;
        }
    }
}
#endif