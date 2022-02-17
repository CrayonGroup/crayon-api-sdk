using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Filtering
{
    public class CrayonAccountFilter : IHttpFilter
    {
        public CrayonAccountFilter()
        {
            Page = 1;
            PageSize = 50;
        }

        public int OrganizationId { get; set; }
        public int PublisherId { get; set; }
        public int ConsumerId { get; set; }
        public CustomerTenantType CustomerTenantType { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}
