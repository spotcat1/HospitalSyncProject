
using Application.Commands;
using FluentValidation;
using Infrastructure.CrossCutting.Validations.User;
using MediatR;

namespace Infrastructure.CrossCutting.Validations.UserValidators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUser>
    {
        public CreateUserCommandValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.dto)
                .NotEmpty()
                .SetValidator(new UserValidator())
                .WithName("مدل")
                .WithMessage("خطا در مدل فرستاده شده");
        }
    }
}
