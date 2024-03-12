
using Application.Commands;
using Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Handlers.RoleIdentityCommandHandler
{
    internal class CreateRoleHandler : IRequestHandler<CreateRole, Guid>
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public CreateRoleHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<Guid> Handle(CreateRole request, CancellationToken cancellationToken)
        {

            if (_roleManager.Roles.Any(r => r.Name.ToUpper() == request.dto.Name.ToUpper()))
            {
                throw new CustomException("نقش وارد شده  تکراری است");
            }




            var role = new IdentityRole<Guid>
            {
                Id = Guid.NewGuid(),
                Name = request.dto.Name,
                NormalizedName = request.dto.Name.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };


            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return role.Id;
            }
            else
            {
                // Handle error or throw exception
                throw new CustomException("ایجاد نقش با خطا رو به رو شد");
            }
        }
    }
}
