using Abp.Authorization;
using LambdaForum.Authorization.Roles;
using LambdaForum.Authorization.Users;

namespace LambdaForum.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
