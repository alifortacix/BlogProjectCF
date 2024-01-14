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
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void MCreate(Author author)
        {
            _authorRepository.Create(author);
        }

        public void MDelete(int id)
        {
            _authorRepository.Delete(id);
        }

        public Author MGet(int id)
        {
            return _authorRepository.Get(id);
        }

        public List<Author> MGetAll()
        {
            return _authorRepository.GetAll();
        }

        public List<Author> MGetAllByCondition(Func<Author, bool> predicate)
        {
            return _authorRepository.GetAllByCondition(predicate);
        }

        public void MUpdate(Author author)
        {
            _authorRepository.Update(author);
        }
    }
}
