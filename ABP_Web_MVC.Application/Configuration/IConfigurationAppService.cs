using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Web_MVC.Configuration.Dto;

namespace ABP_Web_MVC.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}