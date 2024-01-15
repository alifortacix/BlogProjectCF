using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class AuthorRepository : GenericRepository<Author> , IAuthorRepository
    {
        private readonly AppSqlContext _context;
        public AuthorRepository(AppSqlContext context) : base(context)
        {
            _context = context;
        }

        public Author GetAuthorByUsernameAndPassword(string username, string password)
        {
            return _context.Authors.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
