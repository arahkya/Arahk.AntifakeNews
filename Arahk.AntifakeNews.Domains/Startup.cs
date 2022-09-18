using Arahk.AntifakeNews.Domains.Entities;
using Arahk.AntifakeNews.Domains.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Arahk.AntifakeNews.Domains;

public static class Startup
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        ContentEntity.UnitOfWork = services.BuildServiceProvider().GetRequiredService<IUnitOfWork>();

        return services;
    }
}