using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LambdaForum.Roles.Dto;
using LambdaForum.Users.Dto;

namespace LambdaForum.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
