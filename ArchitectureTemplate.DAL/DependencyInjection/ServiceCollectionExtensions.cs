using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ArchitectureTemplate.DAL.Data;

namespace ArchitectureTemplate.DAL.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Set ConnectionStrings:DefaultConnection before using the database.");
            }

            options.UseSqlServer(connectionString);
        });
        // Register repositories for the new project here.
        return services;
    }
}