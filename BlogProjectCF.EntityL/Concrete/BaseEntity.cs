using BlogProjectCF.EntityL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.EntityL.Concrete
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set ; }
    }
}
