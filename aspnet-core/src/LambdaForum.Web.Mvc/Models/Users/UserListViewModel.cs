using System.Collections.Generic;
using LambdaForum.Roles.Dto;
using LambdaForum.Users.Dto;

namespace LambdaForum.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
