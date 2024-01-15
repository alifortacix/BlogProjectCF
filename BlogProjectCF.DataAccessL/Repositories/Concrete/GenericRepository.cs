using BlogProjectCF.DataAccessL.Contexts;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BlogProjectCF.DataAccessL.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity
    {
        private readonly AppSqlContext _context;
        public GenericRepository(AppSqlContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var data = _context.Set<T>().SingleOrDefault(x=> x.Id == Guid.Parse(id));
            _context.Set<T>().Remove(data);
            _context.SaveChanges();
        }

        public T Get(string id)
        {
            return _context.Set<T>().SingleOrDefault(x => x.Id == Guid.Parse(id));
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public List<T> GetAllByCondition(Func<T, bool> predicate)
        {
            return _context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
