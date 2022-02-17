using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class FacebookOrder
    {
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ConsumerContactName { get; set; }
        public string ConsumerFullLegalName { get; set; }
        public string ConsumerContactEmail { get; set; }
        public int OrganizationId { get; set; }
        public int InvoiceProfileId { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public string ConsumerSignupEmail { get; set; }

        public IEnumerable<FacebookOrderLine> Lines;
    }
}
