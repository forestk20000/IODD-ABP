using System.Threading.Tasks;
using IODD.Configuration.Dto;

namespace IODD.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
