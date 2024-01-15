using AutoMapper;
using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.Dtos.ArticleDtos;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Managers.Concrete
{
    public class ArticleManager : IArticleManager
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public ArticleManager(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public void MCreate(CreateArticleDto articleDto)
        {
            Article article = _mapper.Map<Article>(articleDto);
            _articleRepository.Create(article);
        }

        public void MDelete(string id)
        {
            _articleRepository.Delete(id);
        }

        public Article MGet(string id)
        {
            return _articleRepository.Get(id);
        }

        public List<Article> MGetAll()
        {
            return _articleRepository.GetAll();
        }

        public List<Article> MGetAllByCondition(Func<Article, bool> predicate)
        {
            return _articleRepository.GetAllByCondition(predicate);
        }

        public void MUpdate(UpdateArticleDto articleDto)
        {
            Article article = _mapper.Map<Article>(articleDto);
            _articleRepository.Update(article);
        }
    }
}
