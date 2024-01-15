using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.DataAccessL.Repositories.Abstract
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Author GetAuthorByUsernameAndPassword(string username, string password);
    }
}
