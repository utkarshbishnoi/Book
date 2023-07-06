using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Web.Controllers
{
    public class RoleGroupRequirement : IAuthorizationRequirement
    {
        public string RoleGroup { get; }

        public RoleGroupRequirement(string roleGroup)
        {
            RoleGroup = roleGroup;
        }
    }
}
