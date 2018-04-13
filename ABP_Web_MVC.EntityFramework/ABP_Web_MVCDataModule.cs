using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABP_Web_MVC.EntityFramework;

namespace ABP_Web_MVC
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABP_Web_MVCCoreModule))]
    public class ABP_Web_MVCDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABP_Web_MVCDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
