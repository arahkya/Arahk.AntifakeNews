namespace Arahk.AntifakeNews.Domains.ValueObjects;

public class InfoEntity
{
    public string CreatedBy { get; private set; } = null!;
    public DateTime CreatedOn { get; private set; }
    public Guid CreatedById { get; private set; }

    private InfoEntity(string createdBy, DateTime createdOn, Guid createdById)
    {
        CreatedBy = createdBy;
        CreatedOn = createdOn;
        CreatedById = createdById;
    }

    public static InfoEntity New(string createdBy, DateTime createdOn, Guid createdById)
    {
        return new InfoEntity(createdBy, createdOn, createdById);
    }
}