using Application.Common.Interfaces;
using Application.Infrastructure.Data;
using Ardalis.GuardClauses;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Guard.Against.Null(
                connectionString,
                message: "Connection string 'DefaultConnection' not found."
            );

            services.AddDbContext<ApplicationDbContext>(
                (sp, options) => 
                {
                    options.UseNpgsql(connectionString);
                }
            );

            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>()
            );

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}