using System.Collections.Generic;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Filtering
{
    public class CustomerTenantFilter : IHttpFilter
    {
        public CustomerTenantFilter()
        {
            Page = 1;
            PageSize = 50;
        }

        public int OrganizationId { get; set; }
        public int PublisherId { get; set; }
        public int ProgramId { get; set; }
        public int ConsumerId { get; set; }
        public string Domain { get; set; }
        public string DomainPrefix { get; set; }
        public CustomerTenantType CustomerTenantType { get; set; }
        public int InvoiceProfileId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}