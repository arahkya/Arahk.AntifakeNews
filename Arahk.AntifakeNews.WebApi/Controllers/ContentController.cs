using Arahk.AntifakeNews.Domains.Entities;
using Arahk.AntifakeNews.Domains.ValueObjects;
using Arahk.AntifakeNews.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arahk.AntifakeNews.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContentController : ControllerBase
{
    private readonly ILogger<ContentController> _logger;

    public ContentController(ILogger<ContentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "list")]
    public async IAsyncEnumerable<ContentListItemModel> List()
    {
        foreach (var entity in await ContentEntity.ListAsync())
        {
            yield return new()
            {
                Id = entity.Identity.Id,
                TitleTh = entity.Title.Thai,
                TitleEn = entity.Title.English,
                Detail = entity.Detail.Text,
                CreatedBy = entity.Info.CreatedBy,
                CreatedOn = entity.Info.CreatedOn
            };
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ContentCreateModel model)
    {
        string createdBy = "Arahk Yambupah";
        DateTime createdOn = DateTime.Now;
        Guid createdById = Guid.NewGuid();

        ContentEntity content = ContentEntity.New(
            ContentTitle.New(model.TitleTh, model.TitleEn), 
            ContentDetail.New(model.Detail), 
            ContentAuthor.New(model.Author, model.Organize),
            InfoEntity.New(createdBy, createdOn, createdById));

        await content.SaveAsync();

        return Ok(content.Identity.Id);
    }
}
