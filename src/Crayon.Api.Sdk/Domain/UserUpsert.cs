namespace Crayon.Api.Sdk.Domain
{
    public class UserUpsert
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool LockoutEnabled { get; set; }

        public bool TenantAdmin { get; set; }
    }
}
