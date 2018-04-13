using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABP_Web_MVC.EntityFramework.Repositories
{
    public abstract class ABP_Web_MVCRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABP_Web_MVCDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABP_Web_MVCRepositoryBase(IDbContextProvider<ABP_Web_MVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABP_Web_MVCRepositoryBase<TEntity> : ABP_Web_MVCRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABP_Web_MVCRepositoryBase(IDbContextProvider<ABP_Web_MVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
