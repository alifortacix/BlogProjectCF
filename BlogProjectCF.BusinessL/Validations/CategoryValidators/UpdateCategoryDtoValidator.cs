using BlogProjectCF.Dtos.CategoryDtos;
using FluentValidation;

namespace BlogProjectCF.BusinessL.Validations.CategoryValidators
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
            RuleFor(c => c.Id).NotNull();
            RuleFor(c => c.Name).NotNull().MinimumLength(3);
            RuleFor(c => c.Description).NotNull();
        }
    }
}
