using System.Threading.Tasks;
using Abp.Application.Services;
using IODD.Sessions.Dto;

namespace IODD.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
