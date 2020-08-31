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
using WebShop.authentication;

namespace WebShop
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
            services.AddMvc();//add 
            services.AddSession();//add
            services.AddDbContext<ProjectCore.Models.ProjectContext>(ServiceLifetime.Transient);
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();
            app.UseMiddleware<AuthenMiddle>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Register",
                    pattern: "{controller=User}/{action=Register}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Login",
                    pattern: "{controller=User}/{action=Login}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Logout",
                    pattern: "{controller=User}/{action=Logout}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Cart",
                    pattern: "{controller=Cart}/{action=Add}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Cart",
                    pattern: "{controller=Cart}/{action=Delete}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Cart",
                    pattern: "{controller=Cart}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area:exists}/{controller=Product}/{action=Product}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Product}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                  name: "Tables",
                  pattern: "{controller=Table}/{action=Table}/{area?}");

                endpoints.MapControllerRoute(
                 name: "Forms",
                 pattern: "{controller=Form}/{action=Index}/{area?}");

                endpoints.MapControllerRoute(
               name: "Calendar",
               pattern: "{controller=Calender}/{action=Index}/{area?}");


                endpoints.MapControllerRoute(
               name: "Charts",
               pattern: "{controller=Chart}/{action=Index}/{area?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Search",
                    pattern: "{controller=}/{action=Search}/{id?}");
            });

        }
    }
}
