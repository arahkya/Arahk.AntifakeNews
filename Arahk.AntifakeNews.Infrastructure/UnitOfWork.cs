using Arahk.AntifakeNews.Domains;

namespace Arahk.AntifakeNews.Infrastructure;
public class UnitOfWork : IUnitOfWork
{
    public IContentRepository ContentRepository { get; set; } = null!;

    public UnitOfWork(IContentRepository contentRepo)
    {
        ContentRepository = contentRepo;
    }
}
