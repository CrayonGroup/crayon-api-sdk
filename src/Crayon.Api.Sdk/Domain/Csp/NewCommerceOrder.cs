using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class NewCommerceOrder
    {
        public int CustomerTenantId { get; set; }

        public string PartNumber { get; set; }

        public BillingCycleType BillingCycle { get; set; }

        public string TermDuration { get; set; }

        public int Quantity { get; set; }

        public DateTime? CustomTermEndDate { get; set; }

        /// <summary>
        /// Choose a date if you want to schedule the order, or leave null if you want to place regular order
        /// </summary>
        public DateTime? ScheduledDate { get; set; }
    }
}
