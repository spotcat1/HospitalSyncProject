

using Application.Commands;
using FluentValidation;

namespace Infrastructure.CrossCutting.Validations.User
{
    public class UpdatePeopleCommandValidator:AbstractValidator<UpdatePeople>
    {
        public UpdatePeopleCommandValidator()
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
