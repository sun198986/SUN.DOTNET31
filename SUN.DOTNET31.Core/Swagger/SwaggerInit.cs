using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;

namespace SUN.DOTNET31.Core.Swagger
{
    public static class SwaggerInit
    {
        public static void InitSwaggerConfig(this IServiceCollection service)
        {
            service.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Station API", Version = "v1" });
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "SUN.DOTNET31.WebApi.xml");
                c.IncludeXmlComments(xmlPath);
            });
        }

        //applicationBuilder添加
        public static void UserSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Station API V1");
            });
        }
    }
}
