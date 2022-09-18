namespace Arahk.AntifakeNews.Domains.ValueObjects;

public class IdentityEntity
{
    public Guid Id { get; private set; }

    private IdentityEntity(Guid id)
    {
        Id = id;
    }

    public static IdentityEntity New(Guid id)
    {
        return new IdentityEntity(id);
    }
}
