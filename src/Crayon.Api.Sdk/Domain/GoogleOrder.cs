using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class GoogleOrder
    {
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ConsumerContactName { get; set; }
        public string ConsumerFullLegalName { get; set; }
        public string ConsumerContactEmail { get; set; }
        public int OrganizationId { get; set; }
        public int InvoiceProfileId { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public string DomainName { get; set; }
        public string ConsumerCountry { get; set; }
        public string ConsumerStreetAddress { get; set; }
        public string ConsumerCity { get; set; }
        public string ConsumerState { get; set; }
        public string ConsumerZipCode { get; set; }
        public string ConsumerPhoneNumber { get; set; }
        public string PrimaryAdminName { get; set; }
        public string PrimaryAdminUserName { get; set; }

        public IEnumerable<GoogleOrderLine> Lines;
    }
}
