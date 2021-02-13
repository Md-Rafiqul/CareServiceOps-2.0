using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataHandler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using MonteServices.MonteAPI.Models;

namespace MonteAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
           using var scope = host.Services.CreateScope();
           var services = scope.ServiceProvider;
           var userManager = services.GetRequiredService<UserManager<User>>();
           var roleManager = services.GetRequiredService<RoleManager<Role>>();
           try
           {
               await Seed.SeedUsers(userManager, roleManager);
           }
           catch(Exception e)
           {
              Console.WriteLine(e.InnerException);
           }
           await host.RunAsync();
           
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
