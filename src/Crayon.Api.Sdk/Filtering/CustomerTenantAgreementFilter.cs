using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Filtering
{
    public class CustomerTenantAgreementFilter : IHttpFilter
    {
        public CustomerTenantAgreementFilter()
        {
        }

        public AgreementTypeConsent? AgreementTypeConsent { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}