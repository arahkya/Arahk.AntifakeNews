namespace Arahk.AntifakeNews.Domains
{
    public class ContentDetail
    {
        public string Text { get; private set; } = null!;

        private ContentDetail(string text)
        {
            Text = text;
        }

        public static ContentDetail New(string text)
        {
            return new ContentDetail(text);
        }
    }
}