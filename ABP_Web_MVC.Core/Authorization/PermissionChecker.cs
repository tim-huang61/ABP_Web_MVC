using Abp.Authorization;
using ABP_Web_MVC.Authorization.Roles;
using ABP_Web_MVC.Authorization.Users;

namespace ABP_Web_MVC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
