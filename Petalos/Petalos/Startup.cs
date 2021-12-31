using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Petalos.Models;

namespace Petalos
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<floresContext>(optionsBuilder=> { optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=flores", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.18-mysql")); });
        }    
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseFileServer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
