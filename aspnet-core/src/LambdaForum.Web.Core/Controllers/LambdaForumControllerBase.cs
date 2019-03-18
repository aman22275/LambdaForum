using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LambdaForum.Controllers
{
    public abstract class LambdaForumControllerBase: AbpController
    {
        protected LambdaForumControllerBase()
        {
            LocalizationSourceName = LambdaForumConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
