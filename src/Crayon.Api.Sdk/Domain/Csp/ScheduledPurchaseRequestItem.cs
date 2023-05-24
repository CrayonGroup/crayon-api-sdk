using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class ScheduledPurchaseRequestItem
    {
        public int OrderReferenceId { get; set; }

        public List<ScheduledPurchaseRequestLine> OrderItems { get; set; }
    }

    public class ScheduledPurchaseRequestLine
    {
        public int OrderNumber { get; set; }

        public string CatalogId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string BillingCycle { get; set; }

        public string TermDuration { get; set; }

        public string EmailReceiver { get; set; }

        public DateTime? ScheduledDate { get; set; }

    }
}
