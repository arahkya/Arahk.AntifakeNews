namespace Arahk.AntifakeNews.Domains
{
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
}