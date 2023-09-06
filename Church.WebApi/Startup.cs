using Church.Application;
using Church.Application.Common.Mapping;
using Church.Application.Interfaces;
using Church.Persistance;
using Church.WebApi.Middleware;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Church.WebApi
{
    public class Startup
    {

        public IConfiguration Configuration { get;}

        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        /// <summary>
        /// Добавление всех сервисов
        /// </summary>
        /// <param name="service">IServiceCollection</param>
        public void ConfigurationService(IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new AssamblyMappingProfile(Assembly.GetExecutingAssembly()));
                cfg.AddProfile(new AssamblyMappingProfile(typeof(IChurchDbContext).Assembly));
            });

            service.AddApplication();
            service.AddControllers();
            service.AddPersistance(Configuration);

            //  Нужно ограничить
            //  CSRF+ - Cross Site Request Forgery.
            //  CORS - ресурсы другого домена. 
            //  Same-Origin Policy.
            service.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                });
            });
        }

        /// <summary>
        /// Конвейер
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCustomExceptionHandler();     
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseCors("AllowAll");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
