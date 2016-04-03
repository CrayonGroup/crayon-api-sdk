namespace Crayon.Api.Sdk.Domain.Users
{
    public class ChangePassword
    {
        public string UserId { get; set; }

        public string NewPassword { get; set; }
    }
}