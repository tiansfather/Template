using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Master.Configuration.Dto;

namespace Master.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MasterAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
