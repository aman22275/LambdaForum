using Abp.AspNetCore.Mvc.ViewComponents;

namespace LambdaForum.Web.Views
{
    public abstract class LambdaForumViewComponent : AbpViewComponent
    {
        protected LambdaForumViewComponent()
        {
            LocalizationSourceName = LambdaForumConsts.LocalizationSourceName;
        }
    }
}
