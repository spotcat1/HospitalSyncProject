

using Application.Dtos.Identity;
using FluentValidation;
using static Application.Queries.TokendentityQueries;

namespace Infrastructure.CrossCutting.Validations
{
    public class GetTokenQueryValidator:AbstractValidator<GetTokenQuery>
    {
        public GetTokenQueryValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(d => d.dto)
                .NotEmpty();
        }

    }


    public class GetTokenDtoValidator : AbstractValidator<GetTokenDto>
    {
        public GetTokenDtoValidator()
        {
            ClassLevelCascadeMode= CascadeMode.Stop;

            RuleFor(d => d.UserName)
                .NotEmpty()
                .WithMessage("نام کاربری");

            RuleFor(d => d.PassWord)
                .NotEmpty()
                .WithMessage("رمز عبور");
        }
    }
}
