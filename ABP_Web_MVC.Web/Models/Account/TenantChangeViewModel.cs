using Abp.AutoMapper;
using ABP_Web_MVC.Sessions.Dto;

namespace ABP_Web_MVC.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}