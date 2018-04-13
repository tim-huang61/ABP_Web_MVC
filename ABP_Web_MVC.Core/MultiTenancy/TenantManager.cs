using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ABP_Web_MVC.Authorization.Users;
using ABP_Web_MVC.Editions;

namespace ABP_Web_MVC.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}