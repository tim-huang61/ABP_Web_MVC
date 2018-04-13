using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP_Web_MVC.Roles.Dto;
using ABP_Web_MVC.Users.Dto;

namespace ABP_Web_MVC.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}