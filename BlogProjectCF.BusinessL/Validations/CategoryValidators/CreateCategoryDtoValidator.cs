using BlogProjectCF.Dtos.CategoryDtos;
using FluentValidation;

namespace BlogProjectCF.BusinessL.Validations.CategoryValidators
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(c => c.Name).NotNull().MinimumLength(3);
            RuleFor(c => c.Description).NotNull();
        }
    }
}
