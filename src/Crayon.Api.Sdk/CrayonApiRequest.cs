using System;
using System.Threading;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk
{
    public class CrayonApiRequest<T>
    {
        private readonly Func<RequestOptions, Task<CrayonApiClientResult<T>>> _func;
        private readonly Func<RequestOptions, CrayonApiClientResult<T>> _funcSynchronous;
        private RequestOptions _options;

        public CrayonApiRequest(
            Func<RequestOptions, Task<CrayonApiClientResult<T>>> func,
            Func<RequestOptions, CrayonApiClientResult<T>> funcSynchronous)
        {
            _func = func;
            _funcSynchronous = funcSynchronous;
        }

        public async Task<CrayonApiClientResult<T>> ResultAsync()
        {
            var result = await _func(_options ?? new RequestOptions());
            return result;
        }

        public CrayonApiClientResult<T> ResultSynchronous()
        {
            var result = _funcSynchronous(_options ?? new RequestOptions());
            return result;
        }

        public async Task<T> TryAsync()
        {
            return (await ResultAsync()).Data;
        }

        public async Task<T> ExecAsync()
        {
            return (await ResultAsync()).GetData();
        }

        public T ExecSynchronous()
        {
            return _funcSynchronous(_options ?? new RequestOptions()).GetData();
        }

        public CrayonApiRequest<T> SetCancellationToken(CancellationToken timeout)
        {
            _options = _options ?? new RequestOptions();
            _options.RequestTimeout = null;
            _options.CancellationToken = timeout;
            return this;
        }

        public CrayonApiRequest<T> SetCancellationToken(TimeSpan? timeout)
        {
            _options = _options ?? new RequestOptions();
            _options.CancellationToken = null;
            _options.RequestTimeout = timeout;
            return this;
        }
    }
}