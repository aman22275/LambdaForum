using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LambdaForum.MultiTenancy.Dto;

namespace LambdaForum.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

