namespace Arahk.AntifakeNews.Domains
{
    public class InfoEntity
    {
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public Guid CreatedById { get; set; }

        private InfoEntity(string createdBy, DateTime createdOn, Guid createdById)
        {
            CreatedBy = createdBy;
            CreatedOn = createdOn;
        }

        public static InfoEntity New(string createdBy, DateTime createdOn, Guid createdById)
        {
            return new InfoEntity(createdBy, createdOn, createdById);
        }
    }
}