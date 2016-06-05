using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class OrganizationAccess
    {
        public OrganizationAccess()
        {
            Agreements = new List<AgreementAccess>();
        }

        public int Id { get; set; }

        public bool AllAgreements { get; set; }

        public List<AgreementAccess> Agreements { get; set; }

        public Organization Organization { get; set; }

        public UserProfile User { get; set; }

        public OrganizationAccessRole Role { get; set; }

        public string CrayonCompanyName { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}