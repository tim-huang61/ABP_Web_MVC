using System.Linq;
using ABP_Web_MVC.EntityFramework;
using ABP_Web_MVC.MultiTenancy;

namespace ABP_Web_MVC.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABP_Web_MVCDbContext _context;

        public DefaultTenantCreator(ABP_Web_MVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
