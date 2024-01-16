using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly AppSqlContext _context;
        public ArticleRepository(AppSqlContext context) : base(context)
        {
            _context = context;
        }

        public List<Article> GetArticlesWithCategoryAndAuthor()
        {
            return _context.Articles.Include(a => a.Author).Include(c => c.Category).ToList();
        }
    }
}
