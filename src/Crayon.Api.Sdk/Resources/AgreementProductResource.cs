using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public CrayonApiClientDataResult<AgreementProductCollection> GetCspSeatProducts(string token, AgreementProductFilter filter, bool includeAddOns)
        {
            filter.Include = filter.Include ?? new AgreementProductsSubFilter();
            filter.Include.PublisherNames = filter.Include.PublisherNames ?? new List<string>();
            filter.Include.ProgramNames = filter.Include.ProgramNames ?? new List<string>();
            filter.Include.ProductTypeNames = filter.Include.ProductTypeNames ?? new List<string>();

            Action<List<string>, string> includeValue = (list, s) => {
                string obj = list.FirstOrDefault(p => p.Equals(s, StringComparison.CurrentCultureIgnoreCase));
                if (obj == null)
                {
                    list.Add(s);
                }
            };

            includeValue(filter.Include.ProgramNames, "CSP");
            includeValue(filter.Include.ProductTypeNames, "Subscription");
            if (includeAddOns)
            {
                includeValue(filter.Include.ProductTypeNames, "Subscription Add-On");
            }

            return Get(token, filter);
        }
    }
}