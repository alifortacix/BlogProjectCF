using AutoMapper;
using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.Dtos.CategoryDtos;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Managers.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public void MCreate(CreateCategoryDto category)
        {
            var mappedData = _mapper.Map<Category>(category);
            mappedData.CreatedDate = DateTime.Now;
            mappedData.UpdatedDate = DateTime.Now;
            _categoryRepository.Create(mappedData);
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

        public void MUpdate(UpdateCategoryDto category)
        {
            var mappedData = _mapper.Map<Category>(category);
            mappedData.UpdatedDate = DateTime.Now;
            _categoryRepository.Update(mappedData);
        }
    }
}
