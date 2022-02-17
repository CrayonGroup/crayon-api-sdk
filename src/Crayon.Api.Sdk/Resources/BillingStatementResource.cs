using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Resources
{
    public class BillingStatementResource
    {
        private readonly CrayonApiClient _client;

        public BillingStatementResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<BillingStatement>> Get(string token, BillingStatementFilter statementFilter = null)
        {
            var uri = "/api/v1/billingstatements/".Append(statementFilter);
            return _client.Get<ApiCollection<BillingStatement>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<BillingStatement>>> GetAsync(string token, BillingStatementFilter statementFilter = null)
        {
            var uri = "/api/v1/billingstatements/".Append(statementFilter);
            return await _client.GetAsync<ApiCollection<BillingStatement>>(token, uri);
        }

        public CrayonApiClientResult<ApiCollection<GroupedBillingStatement>> GetGrouped(string token, BillingStatementFilter statementFilter = null)
        {
            var uri = "/api/v1/billingstatements/grouped".Append(statementFilter);
            return _client.Get<ApiCollection<GroupedBillingStatement>>(token, uri);
        }

        public CrayonApiClientResult<BillingStatementFile> GetAsFile(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/file/{id}";
            return _client.Get<BillingStatementFile>(token, uri);
        }

        public async Task<CrayonApiClientResult<BillingStatementFile>> GetAsFileAsync(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/file/{id}";
            return await _client.GetAsync<BillingStatementFile>(token, uri);
        }

        public CrayonApiClientResult<ReconciliationFile> GetReconciliationAsFile(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/{id}/reconciliationfile";
            return _client.Get<ReconciliationFile>(token, uri);
        }

        public async Task<CrayonApiClientResult<ReconciliationFile>> GetReconciliationAsFileAsync(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/{id}/reconciliationfile";
            return await _client.GetAsync<ReconciliationFile>(token, uri);
        }

        public CrayonApiClientResult<BillingRecordsFile> GetBillingRecordsAsFile(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/{id}/billingrecordsfile";
            return _client.Get<BillingRecordsFile>(token, uri);
        }

        public async Task<CrayonApiClientResult<BillingRecordsFile>> GetBillingRecordsAsFileAsync(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/{id}/billingrecordsfile";
            return await _client.GetAsync<BillingRecordsFile>(token, uri);
        }
    }
}