using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class NextTermInstructions
    {

        public string PartNumber { get; set; }

        public BillingCycleType? BillingCycle { get; set; }

        public string TermDuration { get; set; }

        public int? Quantity { get; set; }

        public DateTime? CustomTermEndDate { get; set; }

    }
}
