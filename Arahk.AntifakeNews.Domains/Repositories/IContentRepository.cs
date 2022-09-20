using Arahk.AntifakeNews.Domains.Entities;

namespace Arahk.AntifakeNews.Domains.Repositories;

public interface IContentRepository
{
    Task<Guid> AddAsync(ContentEntity contentEntity);
    Task CompleteAsync();
    Task<List<ContentEntity>> ListAsync();
}
