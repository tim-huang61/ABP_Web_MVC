using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Web_MVC.Sessions.Dto;

namespace ABP_Web_MVC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
