using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AlloeHRMSystem.Domain.IdentityEntities;
using AlloeHRMSystem.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AlloeHRMSystem.UI
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build();
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
               // var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {

                    var context = services.GetService<AlloeContext>();
                    var userManager = services.GetService<UserManager<AppUser>>();
                    var userRole = services.GetService<RoleManager<AppRole>>();

                    // var concreteContext = (AlloeContext);
                    //  context.Database.Migrate();

                    AlloeHRMSystemInitializers.Initialize(context,
                        userManager, userRole);
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database.");
                }
            }

            host.Run();
        }

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
             new WebHostBuilder()
              .UseKestrel()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .ConfigureAppConfiguration((hostingContext, config) =>
              {
                  var env = hostingContext.HostingEnvironment;
                  config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                         .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true)
                         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                  config.AddEnvironmentVariables();
              })
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseStartup<Startup>();

    }
}
