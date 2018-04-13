using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABP_Web_MVC.EntityFramework;

namespace ABP_Web_MVC.Migrator
{
    [DependsOn(typeof(ABP_Web_MVCDataModule))]
    public class ABP_Web_MVCMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABP_Web_MVCDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}