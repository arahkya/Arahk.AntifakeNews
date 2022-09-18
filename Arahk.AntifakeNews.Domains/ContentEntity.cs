namespace Arahk.AntifakeNews.Domains;
public class ContentEntity
{
    internal static IUnitOfWork UnitOfWork {get; set; } = null!;

    public ContentTitle Title { get; private set; }
    public ContentDetail Detail { get; private set; }
    public ContentAuthor Author { get; private set; }
    public InfoEntity Info { get; private set; }
    public IdentityEntity Identity { get; set; }

    private ContentEntity(IdentityEntity identity, ContentTitle title, ContentDetail detail, ContentAuthor author, InfoEntity info)
    {
        Identity = identity;
        Title = title;
        Detail = detail;
        Author = author;
        Info = info;
    }

    public static ContentEntity New(IdentityEntity identity, ContentTitle title, ContentDetail detail, ContentAuthor author, InfoEntity info)
    {
        return new ContentEntity(identity, title, detail, author, info);
    }

    public static Task<List<ContentEntity>> ListAsync()
    {
        return UnitOfWork.ContentRepository.ListAsync();
    }

    public async Task SaveAsync()
    {
        await UnitOfWork.ContentRepository.AddAsync(this);
        await UnitOfWork.ContentRepository.CompleteAsync();
    }
}
