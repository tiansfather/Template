using System.Threading.Tasks;
using Abp.Application.Services;
using Master.Sessions.Dto;

namespace Master.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
