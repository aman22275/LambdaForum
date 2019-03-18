using System.Threading.Tasks;
using Abp.Application.Services;
using LambdaForum.Authorization.Accounts.Dto;

namespace LambdaForum.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
