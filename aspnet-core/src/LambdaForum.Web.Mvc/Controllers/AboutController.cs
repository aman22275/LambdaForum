using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LambdaForum.Controllers;

namespace LambdaForum.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LambdaForumControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
