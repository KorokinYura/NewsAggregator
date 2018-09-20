using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsAggregator.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsAggregator.Models;
using NewsAggregator.Services.Interfaces;

namespace NewsAggregator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")
                    .Replace("|DBFolder|", Environment.CurrentDirectory + "\\Data")));

            //services.AddDefaultIdentity<AppUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();



            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
            });

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings 
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            //    options.LoginPath = "/Account/Login"; // If the LoginPath is not set here,  
            //                                          // ASP.NET Core will default to /Account/Login 
            //    options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here,  
            //                                            // ASP.NET Core will default to /Account/Logout 
            //    options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is  
            //                                                        // not set here, ASP.NET Core  
            //                                                        // will default to  
            //                                                        // /Account/AccessDenied 
            //    options.SlidingExpiration = true;
            //});

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var db = services.BuildServiceProvider().GetService<ApplicationDbContext>();
            var ae = services.BuildServiceProvider().GetService<IHostingEnvironment>();
            services.AddSingleton<INewsAggregator, Services.NewsAggregator>(s => new Services.NewsAggregator(db, ae));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            CreateUserRoles(services).Wait();
        }

        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            var adminRoleCheck = await RoleManager.RoleExistsAsync("Admin");
            var moderatorRoleCheck = await RoleManager.RoleExistsAsync("Moderator");

            if (!adminRoleCheck)
            {
                await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!moderatorRoleCheck)
            {
                await RoleManager.CreateAsync(new IdentityRole("Moderator"));
            }

            AppUser admin = await UserManager.FindByNameAsync("Admin");
            await UserManager.AddToRoleAsync(admin, "Admin");

            AppUser moder = await UserManager.FindByNameAsync("Moderator");
            await UserManager.AddToRoleAsync(moder, "Moderator");
        }
    }
}
