using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP_Web_MVC.Configuration.Dto;

namespace ABP_Web_MVC.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABP_Web_MVCAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
