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
        void MDelete(string id);
        Article MGet(string id);
        List<Article> MGetAll();
        List<Article> MGetAllByCondition(Func<Article, bool> predicate);
    }
}
