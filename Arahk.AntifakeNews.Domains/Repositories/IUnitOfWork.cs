namespace Arahk.AntifakeNews.Domains.Repositories;

public interface IUnitOfWork
{
    IContentRepository ContentRepository { get; set; }
}
