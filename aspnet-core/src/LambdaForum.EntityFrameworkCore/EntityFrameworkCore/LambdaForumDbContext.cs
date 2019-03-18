using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LambdaForum.Authorization.Roles;
using LambdaForum.Authorization.Users;
using LambdaForum.MultiTenancy;

namespace LambdaForum.EntityFrameworkCore
{
    public class LambdaForumDbContext : AbpZeroDbContext<Tenant, Role, User, LambdaForumDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public LambdaForumDbContext(DbContextOptions<LambdaForumDbContext> options)
            : base(options)
        {
        }
    }
}
