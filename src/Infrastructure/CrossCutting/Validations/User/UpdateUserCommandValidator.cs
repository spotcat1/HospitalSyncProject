

using Application.Commands;
using FluentValidation;

namespace Infrastructure.CrossCutting.Validations.User
{
    public class UpdateUserCommandValidator:AbstractValidator<UpdateUser>
    {
        public UpdateUserCommandValidator()
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
