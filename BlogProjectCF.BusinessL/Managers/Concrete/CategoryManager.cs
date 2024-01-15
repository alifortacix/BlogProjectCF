using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Managers.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void MCreate(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void MDelete(string id)
        {
            _categoryRepository.Delete(id);
        }

        public Category MGet(string id)
        {
            return _categoryRepository.Get(id);
        }

        public List<Category> MGetAll()
        {
            return _categoryRepository.GetAll();
        }

        public List<Category> MGetAllByCondition(Func<Category, bool> predicate)
        {
            return _categoryRepository.GetAllByCondition(predicate);
        }

        public void MUpdate(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
