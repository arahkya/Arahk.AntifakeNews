namespace Arahk.AntifakeNews.Domains.ValueObjects;

public class ContentAuthor
{
    public string Name { get; private set; }
    public string Organize { get; private set; }

    private ContentAuthor(string name, string organize)
    {
        Name = name;
        Organize = organize;
    }

    public static ContentAuthor New(string name, string organize)
    {
        return new ContentAuthor(name, organize);
    }
}
