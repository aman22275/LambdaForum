using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LambdaForum.Configuration;
using LambdaForum.Web;

namespace LambdaForum.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LambdaForumDbContextFactory : IDesignTimeDbContextFactory<LambdaForumDbContext>
    {
        public LambdaForumDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LambdaForumDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LambdaForumDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LambdaForumConsts.ConnectionStringName));

            return new LambdaForumDbContext(builder.Options);
        }
    }
}
