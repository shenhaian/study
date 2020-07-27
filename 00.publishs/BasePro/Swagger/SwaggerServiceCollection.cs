using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BasePro.Swagger
{
    /// <summary>
    /// swagger 服务
    /// </summary>
    public static class SwaggerServiceCollection
    {
        public static IServiceCollection SwaggerServcieAdd(this IServiceCollection services)
        {
            services.AddSwaggerGen(m => {
                m.SwaggerDoc("SWG1", new OpenApiInfo { Title = "swaggerTest", Version = "SWG1" }); 
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                foreach (var item in Directory.GetFiles(basePath, "*.xml"))
                {
                    if (!Path.GetFileName(item).Contains("BasePro"))
                    { 
                        m.IncludeXmlComments(item); 
                    }
                }
            }); 
            return services;
        }

        public static IApplicationBuilder UseSwaggerX(this IApplicationBuilder app)
        {  
            app.UseSwagger(); 
            app.UseSwaggerUI(c =>
            {
                var sss = c;
                c.SwaggerEndpoint($"/swagger/SWG1/swagger.json", "EsProduct");
            });
            return app;
        }
    }
}
