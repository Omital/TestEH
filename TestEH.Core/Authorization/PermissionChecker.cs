using Abp.Authorization;
using TestEH.Authorization.Roles;
using TestEH.Authorization.Users;

namespace TestEH.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
