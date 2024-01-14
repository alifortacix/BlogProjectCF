using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Managers.Abstract
{
    public interface IAuthorManager
    {
        void MCreate(Author author);
        void MUpdate(Author author);
        void MDelete(int id);
        Author MGet(int id);
        List<Author> MGetAll();
        List<Author> MGetAllByCondition(Func<Author, bool> predicate);
    }
}
