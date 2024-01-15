using AutoMapper;
using BlogProjectCF.Dtos.ArticleDtos;
using BlogProjectCF.Dtos.AuthorDtos;
using BlogProjectCF.EntityL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
