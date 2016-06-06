using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class BillingRecordBillingStatement
    {
        public int Id { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public Price TotalPrice { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public ObjectReference Organization { get; set; }

        public ObjectReference Tenant { get; set; }

        public DateTime Period { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Program { get; set; }

        public ObjectReference Agreement { get; set; }

        public ProvisionType ProvisionType { get; set; }
    }
}