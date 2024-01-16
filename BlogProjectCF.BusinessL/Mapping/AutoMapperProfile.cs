using AutoMapper;
using BlogProjectCF.Dtos.ArticleDtos;
using BlogProjectCF.Dtos.AuthorDtos;
using BlogProjectCF.Dtos.CategoryDtos;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();
            CreateMap<Article, CreateArticleDto>().ReverseMap();
            CreateMap<Article, UpdateArticleDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
