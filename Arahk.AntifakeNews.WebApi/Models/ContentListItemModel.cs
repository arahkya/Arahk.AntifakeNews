namespace Arahk.AntifakeNews.WebApi.Models;

public class ContentListItemModel
{
    public string? TitleTh { get; internal set; }
    public string? TitleEn { get; internal set; }
    public string? Detail { get; internal set; }
    public string? CreatedBy { get; internal set; }
    public DateTime CreatedOn { get; internal set; }
    public Guid Id { get; internal set; }
}