using Crayon.Api.Sdk.Domain;
using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class AgreementFilter : IHttpFilter
    {
        public AgreementFilter()
        {
            Page = 1;
            PageSize = 50;
            Search = string.Empty;
            SearchDate = DateTimeOffset.UtcNow;
        }

        public List<int> OrganizationIds { get; set; }
        public List<int> PricelistIds { get; set; }
        public AgreementStatus Status { get; set; }
        public List<AgreementType> AgreementTypes { get; set; }
        public List<int> PublisherIds { get; set; }
        public List<int> ProgramIds { get; set; }
        public DateTimeOffset SearchDate { get; set; }
        public List<int> AgreementIds { get; set; }
        public string SalesPriceCurrency { get; set; }
        public bool TermRequired { get; set; }
        public int PublisherId { get; set; }
        public DateTimeOffset? EndDateFrom { get; set; }
        public DateTimeOffset? EndDateTo { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}