using BlogProjectCF.Dtos.ArticleDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectCF.BusinessL.Validations.ArticleValidators
{
    public class CreateArticleDtoValidator : AbstractValidator<CreateArticleDto>
    {
        public CreateArticleDtoValidator()
        {
            RuleFor(article => article.Title).NotNull().MinimumLength(3);
            RuleFor(article => article.Description).NotNull();
            RuleFor(article => article.Content).NotNull();
            RuleFor(article => article.AuthorId).NotNull();
            RuleFor(article => article.CategoryId).NotNull();
        }
    }
}
