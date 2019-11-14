using Abp.Authorization;
using Master.Authorization.Roles;
using Master.Authorization.Users;

namespace Master.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
