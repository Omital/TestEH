using System.Threading.Tasks;
using Abp.Application.Services;
using TestEH.Configuration.Dto;

namespace TestEH.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}