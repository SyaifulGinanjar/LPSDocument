using System.Threading.Tasks;
using Abp.Application.Services;
using LPSDocument.Authorization.Accounts.Dto;

namespace LPSDocument.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
