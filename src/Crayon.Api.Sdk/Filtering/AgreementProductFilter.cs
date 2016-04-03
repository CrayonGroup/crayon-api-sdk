using Crayon.Api.Sdk.Domain.Agreements;
using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class AgreementProductFilter
    {
        public AgreementProductFilter()
        {
            Page = 1;
            PageSize = 50;
            Search = string.Empty;
            Include = new AgreementProductsSubFilter();
            Exclude = new AgreementProductsSubFilter();
        }

        public List<AgreementType> AgreementTypeIds { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public int PriceListId { get; set; }
        public int OrganizationId { get; set; }
        public List<int> AgreementIds { get; set; }
        public DateTimeOffset? SearchDate { get; set; }
        public AgreementProductsSubFilter Include { get; set; }
        public AgreementProductsSubFilter Exclude { get; set; }
    }
}