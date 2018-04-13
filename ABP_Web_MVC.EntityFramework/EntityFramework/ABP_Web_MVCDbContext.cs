using System.Data.Common;
using Abp.Zero.EntityFramework;
using ABP_Web_MVC.Authorization.Roles;
using ABP_Web_MVC.Authorization.Users;
using ABP_Web_MVC.MultiTenancy;

namespace ABP_Web_MVC.EntityFramework
{
    public class ABP_Web_MVCDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABP_Web_MVCDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABP_Web_MVCDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABP_Web_MVCDbContext since ABP automatically handles it.
         */
        public ABP_Web_MVCDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABP_Web_MVCDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABP_Web_MVCDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
