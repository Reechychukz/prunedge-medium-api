using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ArticleDTO : AuditableEntityDTO
    {
        public string Title { get; set; }
        public string Story { get; set; }
        public EArticleStatus Status { get; set; } = EArticleStatus.DRAFT;

    }
}
