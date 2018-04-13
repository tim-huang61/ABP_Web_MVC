using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using ABP_Web_MVC.Authorization.Roles;

namespace ABP_Web_MVC.Roles.Dto
{
    [AutoMapFrom(typeof(Role)), AutoMapTo(typeof(Role))]
    public class RoleDto : EntityDto<int>
    {
        [Required]
        [StringLength(AbpRoleBase.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpRoleBase.MaxDisplayNameLength)]
        public string DisplayName { get; set; }

        [StringLength(Role.MaxDescriptionLength)]
        public string Description { get; set; }

        public bool IsStatic { get; set; }

        public List<string> Permissions { get; set; }
    }
}
