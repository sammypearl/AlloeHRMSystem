using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AlloeHRMSystem.Persistence.IServices;
using AlloeHRMSystem.ApplicationServices.AppServices;
using AlloeHRMSystem.Persistence;
using AlloeHRMSystem.Domain.IdentityEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;
using AlloeHRMSystem.UI.Security;

namespace AlloeHRMSystem.UI
{
    public class Startup
    {
        

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var server = Configuration["DBServer"] ?? "codenclouddb";
            var port = Configuration["DBPort"] ?? "1443";
            var user = Configuration["DBUser"] ?? "sa";
            var password = Configuration["DBPassword"] ?? "Sammyk_2601";
            var database = Configuration["Database"] ?? "AlloeDB";

            services.AddDbContext<AlloeContext>(options =>
               options.UseSqlServer($"Server = { server}, {port}; Initial Catalog={database}; User Id={user}; Password={password}"
                  // Configuration.GetConnectionString("AlloeDBConnection")
                  ));

            services.AddIdentity<AppUser, AppRole>(options => {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 2;
            }).AddEntityFrameworkStores<AlloeContext>();
            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Admin/AccessDenied");
            });

            services.AddAuthorization(options =>
            {
              //  options.AddPolicy("DeleteRolePolicy",
               //     policy => policy.RequireClaim("Delete Role"));

                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireRole("Admin"));

                //options.AddPolicy("EditRolePolicy",
                //   policy => policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));

                options.AddPolicy("EditRolePolicy",
                  policy => policy.RequireAssertion(context =>
                  context.User.IsInRole("Admin") ||
                  context.User.HasClaim(claim => claim.Type == "Edit Role" && claim.Value == "true")
                  || context.User.IsInRole("Super Admin")
                  
                  ));

                options.InvokeHandlersAfterFailure = false;

                options.AddPolicy("AdminRolePolicy",
               policy => policy.RequireRole("Admin"));

            });

            services.AddSingleton(Configuration);
         //   services.AddTransient<AlloeContext>();
            services.AddTransient<IEmployeeRepository, EmployeeService>();
           
            // Authorization handlers.
            services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();

            services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
           // services.AddScoped<IAuthorizationHandler,
                                //  EmployeeIsOwnerAuthorizationHandler>();
            // services.AddTransient<AlloeHRMSystemInitializers>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();
            services.AddRazorPages();

            //services.AddMvc().AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.ContractResolver
            //    = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
           // AlloeContext context,
           // UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
           // AlloeHRMSystemInitializers.Initialize(context, userManager, roleManager);
            app.UseAuthorization();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Admin}/{action=listusers}/{id?}");
            //    endpoints.MapRazorPages();
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                
            });

          //  AlloeHRMSystemInitializers.Initialize(context, userManager, roleManager);
        }
    }
}
