using BlogProjectCF.Dtos.ArticleDtos;
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
        void MCreate(CreateArticleDto article);
        void MUpdate(UpdateArticleDto article);
        void MDelete(string id);
        Article MGet(string id);
        List<Article> MGetAll();
        List<Article> MGetAllByCondition(Func<Article, bool> predicate);
    }
}
