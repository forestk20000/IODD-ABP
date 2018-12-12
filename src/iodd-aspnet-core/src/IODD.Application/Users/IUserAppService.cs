using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IODD.Roles.Dto;
using IODD.Users.Dto;

namespace IODD.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
