using System.Threading.Tasks;
using LPSDocument.Configuration.Dto;

namespace LPSDocument.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
