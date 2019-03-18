using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace LambdaForum.Web.Views
{
    public abstract class LambdaForumRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LambdaForumRazorPage()
        {
            LocalizationSourceName = LambdaForumConsts.LocalizationSourceName;
        }
    }
}
