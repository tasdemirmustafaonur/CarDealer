using CarDealer.Business.Interfaces;
using CarDealer.Business.Services;
using CarDealer.DataAccess.Interfaces;
using CarDealer.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Extensions;
using CarDealer.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.API
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
            services.AddMapperConfiguration();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, EFBrandRepository>();

            services.AddScoped<ICategoryBrandService, CategoryBrandService>();
            services.AddScoped<ICategoryBrandRepository, EFCategoryBrandRepository>();

            services.AddScoped<IBodyTypeService, BodyTypeService>();
            services.AddScoped<IBodyTypeRepository, EFBodyTypeRepository>();

            services.AddScoped<IFuelService, FuelService>();
            services.AddScoped<IFuelRepository, EFFuelRepository>();

            services.AddScoped<IGearService, GearService>();
            services.AddScoped<IGearRepository, EFGearRepository>();

            services.AddScoped<IWheelDriveService, WheelDriveService>();
            services.AddScoped<IWheelDriveRepository, EFWheelDriveRepository>();

            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IVehicleRepository, EFVehicleRepository>();

            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IModelRepository, EFModelRepository>();
            var connectionString = Configuration.GetConnectionString("db");
            services.AddDbContext<VehiclesDbContext>(option => option.UseSqlServer(connectionString));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarDealer.API", Version = "v1",
                    Contact = new OpenApiContact{Email = "mustafaonurtasdemirr@gmail.com",Name = "Mustafa Onur"}});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarDealer.API v1"));
            }

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
