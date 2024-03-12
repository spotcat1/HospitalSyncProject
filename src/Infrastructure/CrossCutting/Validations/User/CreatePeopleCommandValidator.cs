
using Application.Commands;
using FluentValidation;
using MediatR;

namespace Infrastructure.CrossCutting.Validations.User
{
    public class CreatePeopleCommandValidator : AbstractValidator<CreatePeople>
    {
        public CreatePeopleCommandValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.dto)
                .NotEmpty()
                .SetValidator(new PeopleValidator())
                .WithName("مدل")
                .WithMessage("خطا در مدل فرستاده شده");
        }
    }
}
