using BlogProjectCF.Dtos.AuthorDtos;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Managers.Abstract
{
    public interface IAuthorManager
    {
        void MCreate(CreateAuthorDto author);
        void MUpdate(UpdateAuthorDto author);
        void MDelete(string id);
        Author MGet(string id);
        List<Author> MGetAll();
        List<Author> MGetAllByCondition(Func<Author, bool> predicate);
        Author MGetAuthorByUsernameAndPassword(string username, string password);

    }
}
