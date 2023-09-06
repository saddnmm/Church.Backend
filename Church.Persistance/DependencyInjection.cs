using Church.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Church.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection 
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<ChurchDbContext>(option =>
            {
                option.UseNpgsql(connectionString);
            });
            services.AddScoped<IChurchDbContext>(provider =>
                provider.GetService<ChurchDbContext>());
            return services;
        }
    }
}
