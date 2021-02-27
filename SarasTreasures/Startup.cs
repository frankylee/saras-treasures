using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using SarasTreasures.Models;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Antiforgery;

namespace SarasTreasures
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
            services.AddControllersWithViews();
            // Inject repositories into controller
            services.AddTransient<IStoryRepository, StoryRepository>();  // <Repo interface, Repo class>

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                services.AddDbContext<SarasTreasuresContext>(options => options.UseSqlServer(Configuration["ConnectionString:AzureSQL"]));
            else
                services.AddDbContext<SarasTreasuresContext>(options => options.UseSqlite(Configuration["ConnectionString:SQLite"]));

            // Add Identity service with default password options
            services.AddIdentity<AppUser, IdentityRole>(options => {
                // Require unique email address for user
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<SarasTreasuresContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SarasTreasuresContext context)
        {
            app.Use(async (ctx, next) =>
            {
                // Prevent clickjacking by setting X-Frame-Options at the code level;
                // use this header to ensure content cannot be iframed
                // X-Frame-Options Header Not Set 
                ctx.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                // X-Content-Type-Options Header Missing
                ctx.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                await next();
            });

            // Sets cookies to secure and limits the reach of XSS attack vectors
            app.UseCookiePolicy(new CookiePolicyOptions
            {
                HttpOnly = HttpOnlyPolicy.Always,
                Secure = CookieSecurePolicy.Always,
                MinimumSameSitePolicy = SameSiteMode.Strict
            });

            // Define new cookie options and prevent loosely scoped cookie;
            // Only works on live site, not localhost
            CookieOptions cookie = new CookieOptions
            {
                Domain = "http://sarastreasures.azurewebsites.net",
                //Path = "/"
            };

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // Call async method to Seed Roles & Users from the DbContext
            SarasTreasuresContext.CreateAdminUser(app.ApplicationServices).Wait();
            // Create a role manager and pass it to SeedData
            RoleManager<IdentityRole> roleManager = app.ApplicationServices.GetRequiredService<RoleManager<IdentityRole>>();
            // Create a user manager and pass it to SeedData
            UserManager<AppUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<AppUser>>();
            // Use SeedData if database is empty.
            SeedData.Seed(context, userManager, roleManager);

        }
    }
}
