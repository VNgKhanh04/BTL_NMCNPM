using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BTL_NMCNPM.Data
{
    public class CheckBL
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CheckBL(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool IsUserLoggedIn()
        {
            var user = _httpContextAccessor.HttpContext.User;
            return user.Identity.IsAuthenticated;
        }

        public string GetUserId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
