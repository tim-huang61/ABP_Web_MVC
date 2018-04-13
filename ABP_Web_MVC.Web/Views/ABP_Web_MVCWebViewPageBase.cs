using Abp.Web.Mvc.Views;

namespace ABP_Web_MVC.Web.Views
{
    public abstract class ABP_Web_MVCWebViewPageBase : ABP_Web_MVCWebViewPageBase<dynamic>
    {

    }

    public abstract class ABP_Web_MVCWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABP_Web_MVCWebViewPageBase()
        {
            LocalizationSourceName = ABP_Web_MVCConsts.LocalizationSourceName;
        }
    }
}