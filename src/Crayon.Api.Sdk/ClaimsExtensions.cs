using System.Security.Claims;

namespace Crayon.Api.Sdk
{
    public static class ClaimsExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(m => m.Type == ClaimTypes.NameIdentifier && !string.IsNullOrEmpty(m.Value) || m.Type == "sub" && !string.IsNullOrEmpty(m.Value))?.Value;
        }

        public static string GetToken(this ClaimsPrincipal user)
        {
            return user.FindFirst(m => m.Type == "token")?.Value;
        }

        public static bool IsTenantAdmin(this ClaimsPrincipal user)
        {
            return user.HasClaim(c => (c.Type == "role" || c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role") && c.Value == "TenantAdmin");
        }
    }
}