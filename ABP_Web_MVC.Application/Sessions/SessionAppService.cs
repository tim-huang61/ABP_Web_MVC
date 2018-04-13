using System.Threading.Tasks;
using Abp.Auditing;
using Abp.AutoMapper;
using ABP_Web_MVC.Sessions.Dto;

namespace ABP_Web_MVC.Sessions
{
    public class SessionAppService : ABP_Web_MVCAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput();

            if (AbpSession.UserId.HasValue)
            {
                output.User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>();
            }

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            return output;
        }
    }
}