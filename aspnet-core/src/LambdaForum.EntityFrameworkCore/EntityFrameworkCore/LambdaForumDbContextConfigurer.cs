using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LambdaForum.EntityFrameworkCore
{
    public static class LambdaForumDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LambdaForumDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LambdaForumDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
