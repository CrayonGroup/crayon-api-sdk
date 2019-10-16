using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CustomerTenantAgreement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DateAgreed { get; set; }
        public AgreementTypeConsent AgreementType { get; set; }
    }
}