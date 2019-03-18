using System.Collections.Generic;
using LambdaForum.Roles.Dto;

namespace LambdaForum.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}