namespace Arahk.AntifakeNews.Domains
{
    public interface IUnitOfWork
    {
        IContentRepository ContentRepository { get; set; }
    }
}