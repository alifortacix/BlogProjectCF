using BlogProjectCF.Dtos.AuthorDtos;
using FluentValidation;

namespace BlogProjectCF.BusinessL.Validations.AuthorValidators
{
    public class AuthorValidator : AbstractValidator<CreateAuthorDto>
    {
        public AuthorValidator()
        {
            RuleFor(author => author.Username).NotNull().MinimumLength(3).MaximumLength(16);
            RuleFor(author => author.Password).NotNull().MinimumLength(3).MaximumLength(16);
            RuleFor(author => author.ConfirmPassword).NotNull().MinimumLength(3).MaximumLength(16).Equal(author => author.Password);
            RuleFor(author => author.Email).EmailAddress().NotNull();
            RuleFor(author => author.Title).NotNull();
            RuleFor(author => author.Birthday).NotNull();
        }
    }
}
