using AutoMapper;
using BlogProjectCF.BusinessL.Helpers;
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
            string savePath = "/Uploads/Articles/";
            if (articleDto.Image != null)
            {
                string result = FileHelper.SaveFile(articleDto.Image, savePath);
                if (result != "FileSaveError")
                    article.ImageUrl = savePath + result;
            }
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

        public List<Article> MGetArticlesWithCategoryAndAuthor()
        {
            return _articleRepository.GetArticlesWithCategoryAndAuthor();
        }

        public void MUpdate(UpdateArticleDto articleDto)
        {
            Article updatedArticle = _articleRepository.Get(articleDto.Id.ToString());
            string oldFilePath = updatedArticle.ImageUrl;

            _mapper.Map(articleDto, updatedArticle);

            updatedArticle.UpdatedDate = DateTime.Now;

            if (articleDto.Image != null)
            {
                var savedImagePath = FileHelper.SaveFile(articleDto.Image, "/Uploads/Authors/");
                updatedArticle.ImageUrl = "/Uploads/Authors/" + savedImagePath;
                bool isDeleted = FileHelper.DeleteFile(oldFilePath);
            }

            _articleRepository.Update(updatedArticle);
        }
    }
}
