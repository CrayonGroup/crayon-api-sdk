using Crayon.Api.Sdk.Domain.Common;

namespace Crayon.Api.Sdk.Domain.Users
{
    public class UserProfile
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ObjectReference Tenant { get; set; }
    }
}