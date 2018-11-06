using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CustomerTenantAgreement
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool SameAsPrimaryContact { get; set; }

        public string DateAgreed { get; set; }

        public bool Accepted { get; set; }

        public int AgreementType { get; set; }
    }
}
