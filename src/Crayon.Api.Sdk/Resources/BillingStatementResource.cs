using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Filtering;
using System;

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

        public CrayonApiClientResult<BillingStatementFile> GetAsFile(string token, int id)
        {
            var uri = $"/api/v1/billingstatements/file/{id}";
            return _client.Get<BillingStatementFile>(token, uri);
        }

        [Obsolete("This endpoint is deprecated")]
        public CrayonApiClientResult<BillingRecordCollection> GetBillingRecords(string token, int billingStatementId, BillingRecordFilter filter = null)
        {
            var uri = $"/api/v1/billingstatements/{billingStatementId}/records/".Append(filter);
            return _client.Get<BillingRecordCollection>(token, uri);
        }
    }
}