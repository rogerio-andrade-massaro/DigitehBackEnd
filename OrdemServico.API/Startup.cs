using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace OrdemServico.API
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

            // Add the Swagger pipeline
            services.AddSwaggerGen(a =>
            {
                a.SwaggerDoc("OrdemServico", new OpenApiInfo { Version = "1.0", Description = "OrdemServico", Title = "OrdemServico" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //a.IncludeXmlComments(xmlPath);

                var file = @"C:\OrdemServico.API.xml";
                a.IncludeXmlComments(file);
            
                //a.OperationFilter<HeaderOperationFilter>();
            });

        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Configure Swagger
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "OrdemServico/swagger/OrdemServico.API.xml/swagger.json";
            });

            //https://thecodebuzz.com/swagger-api-documentation-in-net-core-2-2/
            //https://thecodebuzz.com/resolved-failed-to-load-api-definition-undefined-swagger-v1-swagger-json/

            // Configure Swagger UI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/OrdemServico/swagger/v1/swagger.json", "OrdemServico");
                //c.RoutePrefix = "OrdemServico/swagger";
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
