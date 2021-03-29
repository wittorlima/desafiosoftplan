using CalculatesInterest.Domain.Interfaces.Repository;
using CalculatesInterest.Domain.Interfaces.Services;
using CalculatesInterest.Domain.Service;
using CalculatesInterest.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace CalculatesInterest.API
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
            //services.AddScoped<IInterestRateRepository, InterestRateRepository>();
            services.AddScoped<IInterestRateService, InterestRateService>();
            services.AddScoped<ICalculatesInterestService, CalculatesInterestService>();

            services.AddHttpClient<IInterestRateRepository, InterestRateRepository>(client =>
            {
                client.BaseAddress = new Uri(GetBaseUrlApiInterest());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Calculates Interest", Version = "v1" });
            });

            services.AddControllers();
        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }

        private string GetBaseUrlApiInterest() => $"{Configuration["ApiInterestSettings:ApiAddress"]}";
    }
}
