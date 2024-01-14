using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Managers.Concrete
{
    public class ArticleManager : IArticleManager
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleManager(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void MCreate(Article article)
        {
            _articleRepository.Create(article);
        }

        public void MDelete(int id)
        {
            _articleRepository.Delete(id);
        }

        public Article MGet(int id)
        {
            return _articleRepository.Get(id);
        }

        public List<Article> MGetAll()
        {
            return _articleRepository.GetAll();
        }

        public List<Article> MGetAllByCondition(Func<Article, bool> predicate)
        {
            return _articleRepository.GetAllByCondition(predicate);
        }

        public void MUpdate(Article article)
        {
            _articleRepository.Update(article);
        }
    }
}
