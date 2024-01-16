using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.DataAccessL.Repositories.Abstract
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
        List<Article> GetArticlesWithCategoryAndAuthor();
    }
}
