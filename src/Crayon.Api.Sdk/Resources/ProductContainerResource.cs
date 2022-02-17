using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class ProductContainerResource
    {
        private readonly CrayonApiClient _client;

        public ProductContainerResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<ProductContainer>> Get(string token, ProductContainerFilter filter = null)
        {
            var uri = "/api/v1/productcontainers/".Append(filter);
            return _client.Get<ApiCollection<ProductContainer>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<ProductContainer>>> GetAsync(string token, ProductContainerFilter filter = null)
        {
            var uri = "/api/v1/productcontainers/".Append(filter);
            return await _client.GetAsync<ApiCollection<ProductContainer>>(token, uri);
        }

        public CrayonApiClientResult<ProductContainer> GetById(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<ProductContainer>();
            }

            var uri = $"/api/v1/productcontainers/{id}";
            return _client.Get<ProductContainer>(token, uri);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> GetByIdAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<ProductContainer>();
            }

            var uri = $"/api/v1/productcontainers/{id}";
            return await _client.GetAsync<ProductContainer>(token, uri);
        }

        public CrayonApiClientResult<ProductContainer> GetByIdWithRowIssues(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<ProductContainer>();
            }

            var uri = $"/api/v1/productcontainers/rowissues/{id}";
            return _client.Get<ProductContainer>(token, uri);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> GetByIdWithRowIssuesAsync(string token, int id)
        {
            if (id <= 0)
            {
                return CrayonApiClientResult.NotFound<ProductContainer>();
            }

            var uri = $"/api/v1/productcontainers/rowissues/{id}";
            return await _client.GetAsync<ProductContainer>(token, uri);
        }

        public CrayonApiClientResult<ProductContainer> Update(string token, ProductContainer productContainer)
        {
            var uri = $"/api/v1/productcontainers/{productContainer.Id}";
            return _client.Put<ProductContainer>(token, uri, productContainer);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> UpdateAsync(string token, ProductContainer productContainer, bool? requireEulaAnalysis = false)
        {
            var uri = $"/api/v1/productcontainers/{productContainer.Id}?requireEulaAnalysis={requireEulaAnalysis}";
            return await _client.PutAsync<ProductContainer>(token, uri, productContainer);
        }

        public CrayonApiClientResult<ProductContainer> GetOrCreateShoppingCart(string token,int organizationId)
        {
            var uri = $"/api/v1/productcontainers/getorcreateshoppingcart?organizationId={organizationId}";
            return _client.Get<ProductContainer>(token, uri);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> GetOrCreateShoppingCartAsync(string token, int organizationId)
        {
            var uri = $"/api/v1/productcontainers/getorcreateshoppingcart?organizationId={organizationId}";
            return await _client.GetAsync<ProductContainer>(token, uri);
        }

        public CrayonApiClientResult Delete(string token, int id)
        {
            var uri = $"/api/v1/productcontainers/{id}";
            return _client.Delete(token, uri);
        }

        public async Task<CrayonApiClientResult> DeleteAsync(string token, int id)
        {
            var uri = $"/api/v1/productcontainers/{id}";
            return await _client.DeleteAsync(token, uri);
        }

        public CrayonApiClientResult<ProductContainer> CreateReport(string token, int organizationId, int programId, int year, int month, bool copyLast = false)
        {
            var uri = $"/api/v1/productcontainers/reportbymonth/?organizationId={organizationId}&programId={programId}&year={year}&month={month}&copyLast={copyLast}";
            return _client.Post<ProductContainer>(token, uri, null);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> CreateReportAsync(string token, int organizationId, int programId, int year, int month, bool copyLast = false)
        {
            var uri = $"/api/v1/productcontainers/reportbymonth/?organizationId={organizationId}&programId={programId}&year={year}&month={month}&copyLast={copyLast}";
            return await _client.PostAsync<ProductContainer>(token, uri, null);
        }

        public CrayonApiClientResult<ProductContainer> PatchRow(string token, int productContainerId, int productRowId, ProductRowPatch patch)
        {
            var uri = $"/api/v1/productcontainers/{productContainerId}/row/{productRowId}";
            return _client.Patch<ProductContainer>(token, uri, patch);
        }

        public async Task<CrayonApiClientResult<ProductContainer>> PatchRowAsync(string token, int productContainerId, int productRowId, ProductRowPatch patch)
        {
            var uri = $"/api/v1/productcontainers/{productContainerId}/row/{productRowId}";
            return await _client.PatchAsync<ProductContainer>(token, uri, patch);
        }
    }
}