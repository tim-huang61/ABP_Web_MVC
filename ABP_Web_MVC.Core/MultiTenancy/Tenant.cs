using Abp.MultiTenancy;
using ABP_Web_MVC.Authorization.Users;

namespace ABP_Web_MVC.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}