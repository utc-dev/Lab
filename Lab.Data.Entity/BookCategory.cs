using Bics.Data.Entity;

namespace Lab.Data.Entity
{
    public class BookCategory : BaseEntity, ISoftDelete, IAuditable
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTimeOffset LastModifiedAt { get; set; }
    }
}
