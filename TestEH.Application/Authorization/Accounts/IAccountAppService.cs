using System.Threading.Tasks;
using Abp.Application.Services;
using TestEH.Authorization.Accounts.Dto;

namespace TestEH.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
