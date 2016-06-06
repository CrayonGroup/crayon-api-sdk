namespace Crayon.Api.Sdk.Domain
{
    public class UserChangePassword
    {
        public string UserId { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}