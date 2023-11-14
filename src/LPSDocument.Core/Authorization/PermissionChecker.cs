using Abp.Authorization;
using LPSDocument.Authorization.Roles;
using LPSDocument.Authorization.Users;

namespace LPSDocument.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
