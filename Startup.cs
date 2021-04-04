using MbmStore.Models;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lesson01
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
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/Page/{page:int}",
                    defaults: new
                    {
                        Controller = "Catalogue",
                        action = "Index"
                    }
                );

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/{category}",
                    defaults: new
                    {
                        Controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    }
                );

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "",
                    defaults: new
                    {
                        Controller = "Catalogue",
                        action = "Index"
                    }
                );

                endpoints.MapControllerRoute(
                    name : "pagination",
                    pattern: "Catalogue/{category}/Page/{page}",
                    defaults: new {
                        Controller = "Catalogue",
                        action = "Index"
                    }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}