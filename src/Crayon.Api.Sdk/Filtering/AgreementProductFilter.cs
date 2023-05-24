using Crayon.Api.Sdk.Domain;
using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class AgreementProductFilter : IHttpFilter
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
        public int CustomerTenantId { get; set; }
        public int AgreementId { get; set; }
        public bool? IsTrial { get; set; }
        public List<int> AgreementIds { get; set; }
        public DateTimeOffset? SearchDate { get; set; }
        public AgreementProductsSubFilter Include { get; set; }
        public AgreementProductsSubFilter Exclude { get; set; }

        public string SortKey { get; set; }

        public bool IncludeProductInformation { get; set; }

        public SortOrder SortOrder { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}