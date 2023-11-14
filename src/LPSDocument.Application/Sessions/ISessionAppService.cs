using System.Threading.Tasks;
using Abp.Application.Services;
using LPSDocument.Sessions.Dto;

namespace LPSDocument.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
