using BLL.iClasses;
using BLL.Classes;
using DAL.DalClasses;
using DAL.DaliClasses;
using DAL.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyProject1
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
            services.AddCors(xx => xx.AddPolicy("allowAll", x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddDbContext<finalProject1Context>(p => p.UseSqlServer("Data Source=LAPTOP-SC0QPGU7;Initial Catalog=finalProject1;Integrated Security=True"));
            services.AddScoped(typeof(IBllPerson), typeof(BllPerson));
            //כאשר מנהל התלויות רואה שהוא צריך ליצור אוביקט מסוג ממשק, 
            //נגדיר לו מופע מאיזה מחלקה ליצור
            services.AddScoped(typeof(IDalPerson), typeof(DalPerson));



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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("allowAll");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
