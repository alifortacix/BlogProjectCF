using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.EntityL.Abstract
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
