using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LambdaForum.Authorization.Roles;
using LambdaForum.Authorization.Users;
using LambdaForum.MultiTenancy;
using LambdaForum.Common.Models;
using Task = LambdaForum.Common.Models.Task;

namespace LambdaForum.EntityFrameworkCore
{
    public class LambdaForumDbContext : AbpZeroDbContext<Tenant, Role, User, LambdaForumDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public LambdaForumDbContext(DbContextOptions<LambdaForumDbContext> options)
            : base(options)
        {
        }
    }
}
