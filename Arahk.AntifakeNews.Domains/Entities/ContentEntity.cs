using Arahk.AntifakeNews.Domains.Repositories;
using Arahk.AntifakeNews.Domains.ValueObjects;

namespace Arahk.AntifakeNews.Domains.Entities;
public class ContentEntity
{
    internal static IUnitOfWork UnitOfWork { get; set; } = null!;

    public ContentTitle Title { get; private set; } = null!;
    public ContentDetail Detail { get; private set; } = null!;
    public ContentAuthor Author { get; private set; } = null!;
    public InfoEntity Info { get; private set; } = null!;
    public IdentityEntity Identity { get; set; } = null!;

    private ContentEntity() { }

    private ContentEntity(IdentityEntity identity, ContentTitle title, ContentDetail detail, ContentAuthor author, InfoEntity info)
    {
        Identity = identity;
        Title = title;
        Detail = detail;
        Author = author;
        Info = info;
    }

    internal static ContentEntity New(IdentityEntity identity, ContentTitle title, ContentDetail detail, ContentAuthor author, InfoEntity info)
    {
        return new ContentEntity(identity, title, detail, author, info);
    }

    public static ContentEntity New(ContentTitle title, ContentDetail detail, ContentAuthor author, InfoEntity info)
    {
        ContentEntity newContent = new();
        newContent.Title = title;
        newContent.Detail = detail;
        newContent.Author = author;
        newContent.Info = info;
        
        return newContent;
    }

    public static Task<List<ContentEntity>> ListAsync()
    {
        return UnitOfWork.ContentRepository.ListAsync();
    }

    public async Task SaveAsync()
    {
        Guid id = await UnitOfWork.ContentRepository.AddAsync(this);

        Identity = IdentityEntity.New(id);

        await UnitOfWork.ContentRepository.CompleteAsync();
    }
}
