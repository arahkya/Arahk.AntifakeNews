using Microsoft.EntityFrameworkCore;
using Arahk.AntifakeNews.Infrastructure.Data;
using Arahk.AntifakeNews.Infrastructure.Data.Entities;
using Arahk.AntifakeNews.Domains.Repositories;
using Arahk.AntifakeNews.Domains.Entities;
using Arahk.AntifakeNews.Domains.ValueObjects;

namespace Arahk.AntifakeNews.Infrastructure.Repositories;
public class ContentRepository : IContentRepository
{
    private readonly DefaultDbContext defaultDbContext;

    public ContentRepository(DefaultDbContext defaultDbContext)
    {
        this.defaultDbContext = defaultDbContext;
    }

    public async Task AddAsync(ContentEntity contentEntity)
    {
        await defaultDbContext.AddAsync(new ContentDbEntity
        {
            TitleTh = contentEntity.Title.Thai,
            TitleEn = contentEntity.Title.English,
            Detail = contentEntity.Detail.Text,
            Author = contentEntity.Author.Name,
            Organize = contentEntity.Author.Organize,
            CreatedOn = contentEntity.Info.CreatedOn,
            CreatedById = contentEntity.Info.CreatedById
        });
    }

    public async Task CompleteAsync()
    {
        await defaultDbContext.SaveChangesAsync();
    }

    public async Task<List<ContentEntity>> ListAsync()
    {
        return await defaultDbContext.Contents.Include(p => p.CreatedBy).Select(p => ContentEntity.New(
            IdentityEntity.New(p.Id)
            , ContentTitle.New(p.TitleTh, p.TitleEn)
            , ContentDetail.New(p.Detail)
            , ContentAuthor.New(p.Author, p.Organize)
            , InfoEntity.New(p.CreatedBy!.FullName, p.CreatedOn, p.CreatedBy.Id)
        )).ToListAsync();
    }
}
