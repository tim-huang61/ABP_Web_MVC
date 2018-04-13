using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using ABP_Web_MVC.Authorization.Users;
using ABP_Web_MVC.MultiTenancy;
using ABP_Web_MVC.Users;
using Microsoft.AspNet.Identity;

namespace ABP_Web_MVC
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABP_Web_MVCAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ABP_Web_MVCAppServiceBase()
        {
            LocalizationSourceName = ABP_Web_MVCConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}