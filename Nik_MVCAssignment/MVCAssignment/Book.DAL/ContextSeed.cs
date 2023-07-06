using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL
{

    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<Book.BL.ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles

            await roleManager.CreateAsync(new IdentityRole(Book.BL.Role.Admin.ToString()));

            await roleManager.CreateAsync(new IdentityRole(Book.BL.Role.Basic.ToString()));
        }
        public static async Task SeedAdminAsync(UserManager<BL.ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new BL.ApplicationUser
            {
                UserName = "myadmin@bookevents.com",
                Email = "myadmin@bookevents.com",
                FullName = "MVC Admin",

                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Ab@1234");
                    await userManager.AddToRoleAsync(defaultUser, BL.Role.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Book.BL.Role.Admin.ToString());
                }

            }
        }
    }
}
