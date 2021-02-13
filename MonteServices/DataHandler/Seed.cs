using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;
using MonteServices.MonteAPI.Models;

namespace DataHandler
{
    public class Seed
    {
        public static async Task SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
           if (await userManager.Users.AnyAsync()) return;
           await initRole(roleManager);
           var userData = await System.IO.File.ReadAllTextAsync("DataHandler/UserSeedData.json");
           var seedUsers = JsonSerializer.Deserialize<List<User>>(userData);
           if(seedUsers == null) return;
           foreach(var user in seedUsers)
           {
                await userManager.CreateAsync(user, "MemberPa$$word007");
                await userManager.AddToRoleAsync(user, "Member");
           }
           var admin = new User
           {
               UserName = "Developer"
           };
           await userManager.CreateAsync(admin, "AdminPa$$word007");
           await userManager.AddToRolesAsync(admin, new[] {"Admin", "Moderator"});
        }

        public static async Task initRole(RoleManager<Role> roleManager)
        {
            List<Role> roles = new List<Role>
            {
                new Role{Name = "Admin"},
                new Role{Name = "Moderator"},
                new Role{Name = "Member"}
            };
            foreach(var role in roles)
            {
                await roleManager.CreateAsync(role);
            }
            
        }
    }
}