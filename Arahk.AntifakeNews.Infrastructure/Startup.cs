using Arahk.AntifakeNews.Domains;
using Microsoft.Extensions.DependencyInjection;

namespace Arahk.AntifakeNews.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<DefaultDbContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IContentRepository, ContentRepository>();

        using var scope = services.BuildServiceProvider().CreateScope();
        scope.ServiceProvider.GetRequiredService<DefaultDbContext>().Database.EnsureDeleted();
        scope.ServiceProvider.GetRequiredService<DefaultDbContext>().Database.EnsureCreated();

        return services;
    }
}