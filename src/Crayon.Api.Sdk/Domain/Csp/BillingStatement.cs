using System;

namespace Crayon.Api.Sdk.Domain.Csp
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