using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LPSDocument.Configuration.Dto;

namespace LPSDocument.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LPSDocumentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
