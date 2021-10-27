using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Document : AuditableEntity
    {
        public Guid Id { get; set; }
        public string File { get; set; }
        public string Name { get; set; }
        //public User CreatedBy { get; set; }
        //public Guid CreatedById { get; set; }
        public Article Article { get; set; }
        public Guid ArticleId { get; set; }
        public bool Deleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
