using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LambdaForum.Configuration;

namespace LambdaForum.Web.Host.Startup
{
    [DependsOn(
       typeof(LambdaForumWebCoreModule))]
    public class LambdaForumWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LambdaForumWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LambdaForumWebHostModule).GetAssembly());
        }
    }
}
