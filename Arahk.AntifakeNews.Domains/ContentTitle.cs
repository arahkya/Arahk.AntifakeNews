namespace Arahk.AntifakeNews.Domains
{
    public class ContentTitle
    {
        public string? Thai { get; private set; }
        public string? English { get; private set; }

        private ContentTitle()
        {
            
        }

        public static ContentTitle New(string? thai, string? english)
        {
            return new ContentTitle
            {
                Thai = thai,
                English = english
            };
        }
    }
}