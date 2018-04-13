using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP_Web_MVC.Roles.Dto;

namespace ABP_Web_MVC.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
