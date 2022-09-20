using Arahk.AntifakeNews.Domains.Repositories;
using Arahk.AntifakeNews.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Arahk.AntifakeNews.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<DefaultDbContext>(options => {
            //options.UseInMemoryDatabase("Default");
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AntifakeNews;Trusted_Connection=True;", b => b.MigrationsAssembly("Arahk.AntifakeNews.WebApi"));
        });
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // using var scope = services.BuildServiceProvider().CreateScope();
        // scope.ServiceProvider.GetRequiredService<DefaultDbContext>().Database.EnsureDeleted();
        // scope.ServiceProvider.GetRequiredService<DefaultDbContext>().Database.EnsureCreated();

        return services;
    }
}