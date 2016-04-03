using Crayon.Api.Sdk.Exceptions;
using System.Net;
using System.Security.Claims;

namespace Crayon.Api.Sdk.Extensions
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

        private static int GetTenantId(this ClaimsPrincipal user)
        {
            int tenantId;
            string strTenantId = user.FindFirst(m => m.Type == "tenantId")?.Value;
            if (!int.TryParse(strTenantId, out tenantId))
            {
                return 0;
            }

            return tenantId;
        }

        public static bool IsTenantAdmin(this ClaimsPrincipal user)
        {
            return user.HasClaim(c => (c.Type == "role" || c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role") && c.Value == "TenantAdmin");
        }

        public static int GetVerifiedTenantId(this ClaimsPrincipal user)
        {
            int tenantId = user.GetTenantId();
            if (tenantId <= 0)
            {
                throw new ApiHttpException(HttpStatusCode.Unauthorized, "Invalid tenant id");
            }

            return tenantId;
        }

        public static int AssertTenantId(this ClaimsPrincipal user, int tenantId)
        {
            int userTenantId = user.GetTenantId();
            if (userTenantId <= 0)
            {
                throw new ApiHttpException(HttpStatusCode.Unauthorized, "Invalid tenant id");
            }

            if (userTenantId != tenantId)
            {
                throw new ApiHttpException(HttpStatusCode.Unauthorized, "Access denied, invalid tenant id");
            }

            return userTenantId;
        }
    }
}