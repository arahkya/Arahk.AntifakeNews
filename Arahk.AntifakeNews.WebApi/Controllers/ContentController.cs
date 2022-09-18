using Arahk.AntifakeNews.Domains;
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
}
