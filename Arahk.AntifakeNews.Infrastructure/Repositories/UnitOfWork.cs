using Arahk.AntifakeNews.Domains.Repositories;
using Arahk.AntifakeNews.Infrastructure.Data;
using Arahk.AntifakeNews.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;

namespace Arahk.AntifakeNews.Infrastructure;
public class UnitOfWork : IUnitOfWork
{
    public IContentRepository ContentRepository { get; set; } = null!;

    public UnitOfWork(DefaultDbContext dbContext, ILogger<ContentRepository> logger)
    {
        ContentRepository = new ContentRepository(dbContext, logger);
    }
}
