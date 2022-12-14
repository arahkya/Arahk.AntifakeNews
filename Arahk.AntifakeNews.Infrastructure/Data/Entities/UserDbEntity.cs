namespace Arahk.AntifakeNews.Infrastructure.Data.Entities;

public class UserDbEntity
{
    public Guid Id { get; set; }
    public string FullName => $"{Firstname} {Lastname}";
    public string Firstname { get; internal set; } = null!;
    public string Lastname { get; internal set; } = null!;
}