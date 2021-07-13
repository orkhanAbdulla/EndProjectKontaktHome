using KontaktHome.DAL;
using KontaktHome.Helpers;
using KontaktHome.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome
{
    public class Startup
    {
        public IConfiguration _config { get; }
        public Startup(IConfiguration config)
        {
            _config = config;
        }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession(option=>
            {
                option.IdleTimeout = TimeSpan.FromSeconds(20);
            });
            services.AddControllersWithViews();
            services.AddIdentity<AppUser, IdentityRole>(identityOption =>
            {
                identityOption.Password.RequiredLength = 8;
                identityOption.Password.RequireDigit = true;
                identityOption.Password.RequireLowercase = true;
                identityOption.Password.RequireUppercase = true;
                identityOption.Password.RequireNonAlphanumeric = true;

                identityOption.User.RequireUniqueEmail = true;

                identityOption.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                identityOption.Lockout.MaxFailedAccessAttempts = 3;
                identityOption.Lockout.AllowedForNewUsers = true;

            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>().AddErrorDescriber<AzIdentityErrorDescriber>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config["ConnectionStrings:Default"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>

            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
            );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
