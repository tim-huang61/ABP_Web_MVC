using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP_Web_MVC.MultiTenancy.Dto;

namespace ABP_Web_MVC.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
