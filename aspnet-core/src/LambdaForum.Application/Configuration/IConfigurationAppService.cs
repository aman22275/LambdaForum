using System.Threading.Tasks;
using LambdaForum.Configuration.Dto;

namespace LambdaForum.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
