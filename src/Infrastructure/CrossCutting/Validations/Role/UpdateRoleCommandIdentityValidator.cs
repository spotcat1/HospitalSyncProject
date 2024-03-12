using Application.Commands;
using Application.Dtos.RolesDto;
using FluentValidation;


namespace Infrastructure.CrossCutting.Validations.Role
{
    public class UpdateRoleCommandIdentityValidator:AbstractValidator<UpdateRole>
    {
        public UpdateRoleCommandIdentityValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.dto)
                .SetValidator(new UpdateRoleDtoValidator())
                .NotEmpty();
        }
    }


    public class UpdateRoleDtoValidator : AbstractValidator<RoleDto>
    {
        public UpdateRoleDtoValidator()
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
