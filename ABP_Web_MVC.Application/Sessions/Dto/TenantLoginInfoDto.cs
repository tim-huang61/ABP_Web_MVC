using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABP_Web_MVC.MultiTenancy;

namespace ABP_Web_MVC.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}