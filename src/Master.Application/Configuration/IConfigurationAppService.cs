using System.Threading.Tasks;
using Master.Configuration.Dto;

namespace Master.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
