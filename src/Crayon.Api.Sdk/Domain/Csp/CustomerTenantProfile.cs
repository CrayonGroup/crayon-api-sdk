namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CustomerTenantProfile
    {
        public CustomerTenantProfile()
        {
            CultureCode = "en-US";
            LanguageCode = "en";
        }

        public string CultureCode { get; set; }

        public string LanguageCode { get; set; }

        public CustomerTenantContact Contact { get; set; }

        public CustomerTenantAddress Address { get; set; }
    }
}