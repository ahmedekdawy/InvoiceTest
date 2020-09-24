using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceTest.Models;
using InvoiceTest.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace InvoiceTest
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
         
            services.AddRazorPages();
            services.AddScoped<Service.IInvoiceRepository, InvoiceRespository>();
            services.AddScoped<Service.IItemRepository, ItemRespository>();
            services.AddScoped<Service.IStoreRepository, StoreRespository>();
            services.AddScoped<Service.IUnitRepository, UnitRespository>();
            string connectionString = Configuration.GetConnectionString("Default");
            services.AddCors(option => option.AddPolicy("",
                         builder =>
                         {
                             builder.WithOrigins("http://example.com",
                                                 "http://www.contoso.com");
                         } ));
            services.AddDbContext<InvoiceContext>(opt =>
          opt.UseSqlServer(connectionString));
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
                app.UseExceptionHandler("/Error");

            }


            app.UseStaticFiles();
           
            app.UseRouting();

            //    app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(name: "Default", pattern: "{controller=invocie}/{action=create}");
                endpoints.MapControllers();
          
            });
        }
    }
}
