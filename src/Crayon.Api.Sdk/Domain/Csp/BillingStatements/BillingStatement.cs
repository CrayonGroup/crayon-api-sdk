using Crayon.Api.Sdk.Domain.CloudProvisioning;
using Crayon.Api.Sdk.Domain.Common;
using System;
using Crayon.Api.Sdk.Domain.Products;

namespace Crayon.Api.Sdk.Domain.Csp.BillingStatements
{
    public class BillingStatement
    {
        public int Id { get; set; }

        public Price TotalSalesPrice { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public ObjectReference Organization { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public ProvisionType ProvisionType { get; set; }
    }
}