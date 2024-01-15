using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.Dtos.ArticleDtos
{
    public class UpdateArticleDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public string AuthorId { get; set; }
        public string CategoryId { get; set; }
    }
}
