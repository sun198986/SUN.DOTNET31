using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.EFCore;
using System.Repasitory;
using SUN.DOTNET31.Core.Swagger;
using System.Repasitory.Impl;
using System.Reflection;
using Common.Repasitory.Pattern;
using Common.Repasitory.Pattern.Impl;

namespace SUN.DOTNET31.WebAPI
{
    /// <summary>
    /// Æô¶¯·½·¨
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //mysql
            services.AddDbContext<MSDBContext>(options =>
            {
                options.UseMySql("Database=System.Test;Data Source=192.168.241.128;Port=3306;User Id=root;Password=123456;Charset=utf8;TreatTinyAsBoolean=false;");
            });

            services.AddScoped<IUserRepasitory, UserRepasitory>();

            services.AddControllers();

            //swagger
            services.InitSwaggerConfig();
        }

        
        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //swagger
            app.UserSwaggerConfig();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
