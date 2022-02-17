namespace Crayon.Api.Sdk.Domain
{
    public class Organization
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public string CrayonCompanyName { get; set; }

        public string AccountNumber { get; set; }
    }
}