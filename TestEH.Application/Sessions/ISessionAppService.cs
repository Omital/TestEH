using System.Threading.Tasks;
using Abp.Application.Services;
using TestEH.Sessions.Dto;

namespace TestEH.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
