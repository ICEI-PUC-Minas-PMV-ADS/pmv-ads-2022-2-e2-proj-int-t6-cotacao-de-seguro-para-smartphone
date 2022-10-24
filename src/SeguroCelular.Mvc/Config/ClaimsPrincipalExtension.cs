using System.Security.Claims;

namespace SeguroCelular.Mvc.Config
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetUserEmail(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Email)?.Value;
        }
    }
}
