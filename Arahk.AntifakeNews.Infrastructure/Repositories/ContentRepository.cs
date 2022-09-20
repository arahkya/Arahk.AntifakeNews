using Microsoft.EntityFrameworkCore;
using Arahk.AntifakeNews.Infrastructure.Data;
using Arahk.AntifakeNews.Infrastructure.Data.Entities;
using Arahk.AntifakeNews.Domains.Repositories;
using Arahk.AntifakeNews.Domains.Entities;
using Arahk.AntifakeNews.Domains.ValueObjects;
using Microsoft.Extensions.Logging;

namespace Arahk.AntifakeNews.Infrastructure.Repositories;
public class ContentRepository : IContentRepository
{
    private readonly DefaultDbContext defaultDbContext;
    private readonly ILogger<ContentRepository> logger;

    public ContentRepository(DefaultDbContext defaultDbContext, ILogger<ContentRepository> logger)
    {
        this.defaultDbContext = defaultDbContext;
        this.logger = logger;
    }

    public async Task<Guid> AddAsync(ContentEntity contentEntity)
    {
        ContentDbEntity contentDbEntity = new()
        {
            TitleTh = contentEntity.Title.Thai,
            TitleEn = contentEntity.Title.English,
            Detail = contentEntity.Detail.Text,
            Author = contentEntity.Author.Name,
            Organize = contentEntity.Author.Organize,
            CreatedOn = contentEntity.Info.CreatedOn,
            CreatedById = contentEntity.Info.CreatedById
        };

        await defaultDbContext.AddAsync(contentDbEntity);

        return contentDbEntity.Id;
    }

    public async Task CompleteAsync()
    {
        int effectedRows = await defaultDbContext.SaveChangesAsync();

        if(effectedRows <= 0)
        {
            logger.LogWarning("No effected rows on SaveChangeAsync.");
        }
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
