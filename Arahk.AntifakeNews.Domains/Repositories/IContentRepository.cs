using Arahk.AntifakeNews.Domains.Entities;

namespace Arahk.AntifakeNews.Domains.Repositories;

public interface IContentRepository
{
    Task AddAsync(ContentEntity contentEntity);
    Task CompleteAsync();
    Task<List<ContentEntity>> ListAsync();
}
