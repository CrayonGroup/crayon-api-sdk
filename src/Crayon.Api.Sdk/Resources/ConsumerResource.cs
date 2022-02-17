using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ConsumerResource
    {
        private readonly CrayonApiClient _client;

        public ConsumerResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Consumer>> Get(string token, ConsumerFilter filter = null)
        {
            var uri = "api/v1/consumers/".Append(filter);
            return _client.Get<ApiCollection<Consumer>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Consumer>>> GetAsync(string token, ConsumerFilter filter = null)
        {
            var uri = "api/v1/consumers/".Append(filter);
            return await _client.GetAsync<ApiCollection<Consumer>>(token, uri);
        }

        public CrayonApiClientResult<Consumer> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Consumer>();
            }

            var uri = $"api/v1/consumers/{id}/";
            return _client.Get<Consumer>(token, uri);
        }

        public async Task<CrayonApiClientResult<Consumer>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Consumer>();
            }

            var uri = $"api/v1/consumers/{id}/";
            return await _client.GetAsync<Consumer>(token, uri);
        }

        public CrayonApiClientResult<Consumer> Create(string token, Consumer consumer)
        {
            var uri = "api/v1/consumers/";
            return _client.Post<Consumer>(token, uri, consumer);
        }

        public async Task<CrayonApiClientResult<Consumer>> CreateAsync(string token, Consumer consumer)
        {
            var uri = "api/v1/consumers/";
            return await _client.PostAsync<Consumer>(token, uri, consumer);
        }

        public CrayonApiClientResult<Consumer> Update(string token, Consumer consumer)
        {
            Guard.NotNull(consumer, nameof(consumer));

            var uri = $"api/v1/consumers/{consumer.Id}/";
            return _client.Put<Consumer>(token, uri, consumer);
        }

        public async Task<CrayonApiClientResult<Consumer>> UpdateAsync(string token, Consumer consumer)
        {
            Guard.NotNull(consumer, nameof(consumer));

            var uri = $"api/v1/consumers/{consumer.Id}/";
            return await _client.PutAsync<Consumer>(token, uri, consumer);
        }

        public CrayonApiClientResult Delete(string token, int id)
        {
            var uri = $"/api/v1/consumers/{id}";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, int id)
        {
            var uri = $"/api/v1/consumers/{id}";
            return await _client.DeleteAsync(token, uri);
        }
    }
}
