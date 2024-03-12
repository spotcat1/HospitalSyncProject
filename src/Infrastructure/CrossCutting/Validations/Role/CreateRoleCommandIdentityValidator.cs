

using Application.Commands;
using Application.Dtos.RolesDto;
using FluentValidation;

namespace Infrastructure.CrossCutting.Validations.Role
{
    public class CreateRoleCommandIdentityValidator:AbstractValidator<CreateRole>
    {
        public CreateRoleCommandIdentityValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.dto)
                .SetValidator(new CreateRoleDtoValidator())
                .NotEmpty();
        }
        
    }


    public class CreateRoleDtoValidator : AbstractValidator<RoleDto>
    {
        public CreateRoleDtoValidator()
        {
            ClassLevelCascadeMode= CascadeMode.Stop;

            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(20)
                .Matches("^[آ-یa-zA-Z\\s]*$")
                .WithName("نام");
        }
    }
}
