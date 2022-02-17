using System.Net;
using System.Net.Http;

namespace Crayon.Api.Sdk
{
    public interface IPreSendWrapper
    {
        bool AddHeader(string name, string value);
    }

#if NET451 || NET461 
    internal class HttpWebRequestWrapper : IPreSendWrapper
    {
        private readonly HttpWebRequest _request;

        public HttpWebRequestWrapper(HttpWebRequest request)
        {
            _request = request;
        }

        public bool AddHeader(string name, string value)
        {
            _request.Headers.Add(name, value);
            return true;
        }
    }
#endif

    internal class HttpRequestMessageWrapper : IPreSendWrapper
    {
        private readonly HttpRequestMessage _request;

        public HttpRequestMessageWrapper(HttpRequestMessage request)
        {
            _request = request;
        }

        public bool AddHeader(string name, string value)
        {
            return _request.Headers.TryAddWithoutValidation(name, value);
        }
    }
}
