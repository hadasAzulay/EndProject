using BLL.Classes;
using BLL.iClasses;
using DAL.DalClasses;
using DAL.DaliClasses;
using DAL.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
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
            services.AddControllers();
            services.AddCors(xx => xx.AddPolicy("allowAll", x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddDbContext<finalProject1Context>(p => p.UseSqlServer("Data Source=LAPTOP-SC0QPGU7;Initial Catalog=finalProject1;Integrated Security=True"));
            services.AddScoped(typeof(IBllPerson), typeof(BllPerson));
            //כאשר מנהל התלויות רואה שהוא צריך ליצור אוביקט מסוג ממשק, 
            //נגדיר לו מופע מאיזה מחלקה ליצור
            services.AddScoped(typeof(IDalPerson), typeof(DalPerson));
            //........
            services.AddScoped(typeof(IbllApartment), typeof(bllApartment));
            services.AddScoped(typeof(IDalApartment), typeof(DalApartment));
            //........
            services.AddScoped(typeof(IBllCalculation), typeof(BllCalculation));
            services.AddScoped(typeof(IDalCalculation), typeof(DalCalculation));
            //........
            services.AddScoped(typeof(IBllContractor), typeof(BllContractor));
            services.AddScoped(typeof(IDalContractor), typeof(DalContractor));
            //........
            services.AddScoped(typeof(IBllCostumer), typeof(BllCostumer));
            services.AddScoped(typeof(IDalCostumer), typeof(DalCostumer));
            //........
            services.AddScoped(typeof(IBllCostumersMessage), typeof(BllCostumerMessage));
            services.AddScoped(typeof(IDalCostumersMessage), typeof(DalCostumersMessage));
            //........
            services.AddScoped(typeof(IBllDailyDairy), typeof(BllDailyDairy));
            services.AddScoped(typeof(IDalDailyDairy), typeof(DalDailyDairy));
            //........
            services.AddScoped(typeof(IBllDoubt), typeof(BllDoubt));
            services.AddScoped(typeof(IDalDoubt), typeof(DalDoubt));
            //........
            services.AddScoped(typeof(IBllDoubtsForTool), typeof(BllDoubtsForTool));
            services.AddScoped(typeof(IDalDoubtsForTool), typeof(DalDoubtsForTool));
            //........
            services.AddScoped(typeof(IBllEquipment), typeof(BllEquipment));
            services.AddScoped(typeof(IDalEquipment), typeof(DalEquipment));
            //........
            services.AddScoped(typeof(IBllEquipmentForDay), typeof(BllEquipmentForDay));
            services.AddScoped(typeof(IDalEquipmentForDay), typeof(DalEquipmentForDay));
            //........
            services.AddScoped(typeof(IBllEquipmentForTool), typeof(BllEquipmentForTool));
            services.AddScoped(typeof(IDalEquipmentForTool), typeof(DalEquipmentForTool));
            //........
            services.AddScoped(typeof(IBllExecutionStage), typeof(BllExecutionStage));
            services.AddScoped(typeof(IDalExecutionStage), typeof(DalExecutionStage));
            //........
            services.AddScoped(typeof(IBllLevelType), typeof(BllLevelType));
            services.AddScoped(typeof(IDalLevelType), typeof(DalLevelType));
            //........
            services.AddScoped(typeof(IBllMaterial), typeof(BllMaterial));
            services.AddScoped(typeof(IDalMaterial), typeof(DalMaterial));
            //........
            services.AddScoped(typeof(IBllMaterialForTool), typeof(BllMaterialsForTool));
            services.AddScoped(typeof(IDalMaterialForTool), typeof(DalMaterialsForTool));
            //........
            services.AddScoped(typeof(IBllMaterialsForDay), typeof(BllMaterialsForDay));
            services.AddScoped(typeof(IDalMaterialsForDay), typeof(DalMaterialsForDay));
            //........
            services.AddScoped(typeof(IBllProgressSchedule), typeof(BllProgressSchedule));
            services.AddScoped(typeof(IDalProgressSchedule), typeof(DalProgressSchedule));
            //........
            services.AddScoped(typeof(IBllProjectcs), typeof(BllProject));
            services.AddScoped(typeof(IDalProjects), typeof(DalProject));
            //........
            services.AddScoped(typeof(IBllTool), typeof(BllTool));
            services.AddScoped(typeof(IDalTool), typeof(DalTool));
            //........
            services.AddScoped(typeof(IBllToolForDay), typeof(BllToolsForDay));
            services.AddScoped(typeof(IDalToolForDay), typeof(DalToolsForDay));
            //........
            services.AddScoped(typeof(IBllWorker), typeof(BllWorker));
            services.AddScoped(typeof(IDalWorker), typeof(DalWorker));
            //........
            
            //דואג שהנתונים לא יתחלפ לאותיות קטנות.
            services.AddControllers()
           .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("allowAll");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
