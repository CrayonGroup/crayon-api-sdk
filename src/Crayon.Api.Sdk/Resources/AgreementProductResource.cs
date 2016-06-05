using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Resources
{
    public class AgreementProductResource
    {
        private readonly CrayonApiClient _client;

        public AgreementProductResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<AgreementProductCollection> Get(string token, AgreementProductFilter filter = null)
        {
            var uri = "/api/v1/agreementproducts/";
            return _client.Post<AgreementProductCollection>(token, uri, filter);
        }
    }
}