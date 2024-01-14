using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Managers.Abstract
{
    public interface ICategoryManager
    {
        void MCreate(Category category);
        void MUpdate(Category category);
        void MDelete(int id);
        Category MGet(int id);
        List<Category> MGetAll();
        List<Category> MGetAllByCondition(Func<Category, bool> predicate);
    }
}
