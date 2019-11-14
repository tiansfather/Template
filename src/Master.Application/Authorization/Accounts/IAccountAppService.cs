using System.Threading.Tasks;
using Abp.Application.Services;
using Master.Authorization.Accounts.Dto;

namespace Master.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
