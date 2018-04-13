using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ABP_Web_MVC.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ABP_Web_MVC.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ABP_Web_MVC.EntityFramework.ABP_Web_MVCDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABP_Web_MVC";
        }

        protected override void Seed(ABP_Web_MVC.EntityFramework.ABP_Web_MVCDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
