using Abp.Authorization;
using IODD.Authorization.Roles;
using IODD.Authorization.Users;

namespace IODD.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
