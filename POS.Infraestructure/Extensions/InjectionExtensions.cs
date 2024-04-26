using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infraestructure.Persistences.Interfaces;
using POS.Infraestructure.Persistences.Repositories;
using POS.Infraestrucure.Persistences.Contexts;

namespace POS.Infraestructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(SisventasContext).Assembly.FullName;

            services.AddDbContext<SisventasContext>(options => options.UseSqlServer(
                configuration.GetConnectionString(""), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient
            );

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
