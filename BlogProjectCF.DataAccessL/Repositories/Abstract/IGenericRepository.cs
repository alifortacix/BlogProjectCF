using BlogProjectCF.EntityL.Abstract;

namespace BlogProjectCF.DataAccessL.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class, IBaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(string id);
        T Get(string id);
        List<T> GetAll();
        List<T> GetAllByCondition(Func<T, bool> predicate);
    }
}
