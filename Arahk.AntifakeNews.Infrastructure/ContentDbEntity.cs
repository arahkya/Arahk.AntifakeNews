namespace Arahk.AntifakeNews.Infrastructure
{
    public class ContentDbEntity
    {
        public string? TitleTh { get; internal set; }
        public string? TitleEn { get; internal set; }
        public string Detail { get; internal set; } = null!;
        public string Author { get; internal set; } = null!;
        public string Organize { get; internal set; } = null!;
        public DateTime CreatedOn { get; internal set; }
        public Guid CreatedById { get; internal set; }
        public UserDbEntity? CreatedBy { get; set; }
        public Guid Id { get; internal set; }
    }
}