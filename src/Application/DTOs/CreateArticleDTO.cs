using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateArticleDTO
    {
        public string Title { get; set; }
        public string Story { get; set; }
        public string Category { get; set; }
    }
    public class ArticleCategoryDTO
    {
        public string Search { get; set; }
    }
}
