using BlogProjectCF.EntityL.Abstract;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.DataAccessL.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class, IBaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        T Get(int id);
        List<T> GetAll();
        List<T> GetAllByCondition(Func<T, bool> predicate);
    }
}
