using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Book.Web.Controllers
{
    public class RoleGroupAuthorizationHandler : AuthorizationHandler<RoleGroupRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleGroupRequirement requirement)
        {
            if (context.User.IsInRole(requirement.RoleGroup))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
