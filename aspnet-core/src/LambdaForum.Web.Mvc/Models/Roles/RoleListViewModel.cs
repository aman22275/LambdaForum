using System.Collections.Generic;
using LambdaForum.Roles.Dto;

namespace LambdaForum.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
