using Microsoft.AspNetCore.Antiforgery;
using LambdaForum.Controllers;

namespace LambdaForum.Web.Host.Controllers
{
    public class AntiForgeryController : LambdaForumControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
