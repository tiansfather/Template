using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Master.MultiTenancy.Dto;

namespace Master.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

