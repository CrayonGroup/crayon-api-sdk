using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class GroupingResource
    {
        private readonly CrayonApiClient _client;

        public GroupingResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<Grouping>> Get(string token, GroupingFilter filter = null)
        {
            var uri = "/api/v1/groupings/".Append(filter);
            return _client.Get<ApiCollection<Grouping>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<Grouping>>> GetAsync(string token, GroupingFilter filter = null)
        {
            var uri = "/api/v1/groupings/".Append(filter);
            return await _client.GetAsync<ApiCollection<Grouping>>(token, uri);
        }

        public CrayonApiClientResult<Grouping> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Grouping>();
            }

            var uri = $"/api/v1/groupings/{id}";
            return _client.Get<Grouping>(token, uri);
        }

        public async Task<CrayonApiClientResult<Grouping>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<Grouping>();
            }

            var uri = $"/api/v1/groupings/{id}";
            return await _client.GetAsync<Grouping>(token, uri);
        }

        public CrayonApiClientResult<Grouping> Create(string token, Grouping grouping)
        {
            var uri = "/api/v1/groupings/";
            return _client.Post<Grouping>(token, uri, grouping);
        }

        public async Task<CrayonApiClientResult<Grouping>> CreateAsync(string token, Grouping grouping)
        {
            var uri = "/api/v1/groupings/";
            return await _client.PostAsync<Grouping>(token, uri, grouping);
        }
        
        public CrayonApiClientResult<Grouping> Update(string token, Grouping grouping)
        {
            Guard.NotNull(grouping, nameof(grouping));

            var uri = $"/api/v1/groupings/{grouping.Id}";
            return _client.Put<Grouping>(token, uri, grouping);
        }

        public async Task<CrayonApiClientResult<Grouping>> UpdateAsync(string token, Grouping grouping)
        {
            Guard.NotNull(grouping, nameof(grouping));

            var uri = $"/api/v1/groupings/{grouping.Id}";
            return await _client.PutAsync<Grouping>(token, uri, grouping);
        }

        public CrayonApiClientResult Delete(string token, int id)
        {
            var uri = $"/api/v1/groupings/{id}/";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, int id)
        {
            var uri = $"/api/v1/groupings/{id}/";
            return await _client.DeleteAsync(token, uri);
        }
    }
}