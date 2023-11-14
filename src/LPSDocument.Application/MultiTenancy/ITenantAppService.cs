using Abp.Application.Services;
using LPSDocument.MultiTenancy.Dto;

namespace LPSDocument.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

