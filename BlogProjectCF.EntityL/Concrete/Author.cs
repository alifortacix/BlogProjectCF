using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.EntityL.Concrete
{
    public class Author : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Birthday { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Article> Articles{ get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
