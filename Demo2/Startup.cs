using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo2.Bussiness.Impl;
using Demo2.Bussiness.Interface;
using Demo2.Data.Impl;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo2
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
//            services.Configure<CookiePolicyOptions>(options =>
//            {
//                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
//                options.CheckConsentNeeded = context => true;
//                options.MinimumSameSitePolicy = SameSiteMode.None;
//            });
//
//
//            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc();
            services.AddDbContext<DataContext>(options => options.UseMySQL(AppConfig.MysqlConnection));
            
//            var accessImpleAndInterfaces = AssemblyHelper.GetImpleAndInterfaces("Demo2.Data", "Repository");
//            foreach (var v in accessImpleAndInterfaces)
//                services.AddScoped(v.Value[0], v.Key);
//            var logicImpleAndInterfaces = AssemblyHelper.GetImpleAndInterfaces("Demo2.Bussiness", "Service");
//            foreach (var v in logicImpleAndInterfaces)
//                services.AddScoped(v.Value[0], v.Key);
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IRecipeTypeRepository, RecipeTypeRepository>();
            services.AddScoped<IMainUserRepository, MainUserRepository>();
            services.AddScoped<IDinnerTableRepository, DinnerTableRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderRecipeRepository, OrderRecipeRepository>();
            services.AddScoped<IFileRepository, FileRepository>();
            
            services.AddScoped<IRecipeService, RecipeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"); //{controller=Recipe}/{action=Index}/{id?}"); 
            });
        }
    }
}