using System.Threading.Tasks;
using Abp.Application.Services;
using LambdaForum.Sessions.Dto;

namespace LambdaForum.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
