using Domain.Common;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModels
{
    public class FileUpload : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
        public DateTime InseredOn { get; set; }
        public Article Article { get; set; }
        public Guid ArticleId { get; set; }

    }
}
