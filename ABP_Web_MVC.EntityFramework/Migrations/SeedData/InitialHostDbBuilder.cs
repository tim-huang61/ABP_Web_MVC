using ABP_Web_MVC.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABP_Web_MVC.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABP_Web_MVCDbContext _context;

        public InitialHostDbBuilder(ABP_Web_MVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
