using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Resources
{
    public class AgreementReportResource
    {
        private readonly CrayonApiClient _client;

        public AgreementReportResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<AgreementReport>> Get(string token, int productContainerId)
        {
            var uri = $"/api/v1/agreementreports/{productContainerId}/";
            return _client.Get<ApiCollection<AgreementReport>>(token, uri);
        }

        public async Task<CrayonApiClientResult<ApiCollection<AgreementReport>>> GetAsync(string token, int productContainerId)
        {
            var uri = $"/api/v1/agreementreports/{productContainerId}/";
            return await _client.GetAsync<ApiCollection<AgreementReport>>(token, uri);
        }

        public CrayonApiClientResult<AgreementReport> Update(string token, AgreementReport agreementReport)
        {
            var uri = $"api/v1/agreementreports/{agreementReport.Agreement.Id}/";
            return _client.Put<AgreementReport>(token, uri, agreementReport);
        }

        public async Task<CrayonApiClientResult<AgreementReport>> UpdateAsync(string token, AgreementReport agreementReport)
        {
            var uri = $"api/v1/agreementreports/{agreementReport.Agreement.Id}/";
            return await _client.PutAsync<AgreementReport>(token, uri, agreementReport);
        }
    }
}
