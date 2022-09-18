namespace Arahk.AntifakeNews.Domains
{
    public interface IContentRepository
    {
        Task AddAsync(ContentEntity contentEntity);
        Task CompleteAsync();
        Task<List<ContentEntity>> ListAsync();
    }
}