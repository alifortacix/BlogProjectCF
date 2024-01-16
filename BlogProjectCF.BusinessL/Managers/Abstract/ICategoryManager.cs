using BlogProjectCF.Dtos.CategoryDtos;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Managers.Abstract
{
    public interface ICategoryManager
    {
        void MCreate(CreateCategoryDto category);
        void MUpdate(UpdateCategoryDto category);
        void MDelete(string id);
        Category MGet(string id);
        List<Category> MGetAll();
        List<Category> MGetAllByCondition(Func<Category, bool> predicate);
    }
}
