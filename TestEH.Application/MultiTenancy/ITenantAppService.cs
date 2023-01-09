using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestEH.MultiTenancy.Dto;

namespace TestEH.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
