using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HomeWork_03.Infrastucture;
using HomeWork_03.Interfaces;
using HomeWork_03.Services;

namespace HomeWork_03
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
      services.AddMvc(options =>
      {
        options.Filters.Add<App_Filter>();
      });

      services.AddSingleton<IEmployeeService, EmployeeService>();
      services.AddSingleton<IProductService, ProductService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if(env.IsDevelopment())
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

      //Если маршрут "/CustomHandler" - вызываем CustomHandler(IApplicationBuilder app)
      app.Map("/CustomHandler", CustomHandler);
      //Используем Middleware с логикой метода UseMidlewareSample(app)
      UseMidlewareSample(app);
      //Используем Middleware с логикой класса TokenMidleware
      app.UseMiddleware<TokenMidleware>();

      app.UseRouting();
      //app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
      });
    }

    private void UseMidlewareSample(IApplicationBuilder app)
    {
      //Что то делаем ...
      app.Use(async (context, next) =>
      {
        bool isError = false;
        if(isError)
        {
          await context.Response.WriteAsync("Unexpected error...");
        }
        else
        {
          await next.Invoke();
        }
      });
    }

    private void CustomHandler(IApplicationBuilder app)
    {
      app.Run(async context =>
      {
        await context.Response.WriteAsync("Call CustomHandler...");
      });
    }
  }
}
