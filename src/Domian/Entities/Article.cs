using Domain.Common;
using Domain.Enums;
using Domain.ViewModels;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Article : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Story { get; set; }
        public string documentUrl { get; set; }
        public EArticleStatus Status { get; set; } = EArticleStatus.DRAFT;
        public IEnumerable<FileUpload> FileUploads { get; set; }
        //public Guid CreatedById { get; set; }
        //public string Privacy { get; set; }

        //Navigation Properties
        //public Category Category { get; set; }
        //public Tag Tag { get; set; }
    }
}
