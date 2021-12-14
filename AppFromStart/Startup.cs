using AppFromStart.Models;
using AppFromStart.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddControllersWithViews();
           services.AddMvc();
            services.AddScoped<IRepo<Student>, StudentRepo>();
            services.AddScoped<IListify, StatusList>();
            services.AddSingleton(typeof(DummyService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string msg = "Hello from ";
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                msg += "Development mode";
            }
            else
                msg += "Production mode is on. Be careful";
            
            app.UseRouting();
            app.UseDefaultFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Environment.CurrentDirectory, "MyFiles")),
                RequestPath = "/MyFiles"
            });
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("From teh middleware");
            //    await next();
            //});
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from run");
            //});

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World");
                //});
                //endpoints.MapGet("/first", async context =>
                //{
                //    await context.Response.WriteAsync(msg);
                //});
                endpoints.MapControllerRoute("default", pattern: "{controller=Student}/{action=Index}/{id?}");
            });



        }
    }
}
