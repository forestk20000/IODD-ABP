using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IODD.MultiTenancy.Dto;

namespace IODD.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
