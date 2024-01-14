using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Managers.Abstract
{
    public interface IArticleManager
    {
        void MCreate(Article article);
        void MUpdate(Article article);
        void MDelete(int id);
        Article MGet(int id);
        List<Article> MGetAll();
        List<Article> MGetAllByCondition(Func<Article, bool> predicate);
    }
}
