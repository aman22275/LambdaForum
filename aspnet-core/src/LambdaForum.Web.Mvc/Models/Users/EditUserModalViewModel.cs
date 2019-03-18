using System.Collections.Generic;
using System.Linq;
using LambdaForum.Roles.Dto;
using LambdaForum.Users.Dto;

namespace LambdaForum.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
