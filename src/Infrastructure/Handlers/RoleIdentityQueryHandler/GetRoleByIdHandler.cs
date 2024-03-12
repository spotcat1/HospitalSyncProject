

using Application.Dtos.RolesDto;
using Application.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using static Application.Queries.RoleIdentityQueries;

namespace Infrastructure.Handlers.RoleIdentityQueryHandler
{
    public class GetRoleByIdHandler : IRequestHandler<GetRoleById, RoleDto>
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public GetRoleByIdHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<RoleDto> Handle(GetRoleById request, CancellationToken cancellationToken)
        {
            var Role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == request.id);

            if (Role == null)
            {
                throw new NotFoundException("شناسه نقش مورد نظر برای نمایش یافت نشد");
            }

            var RoleToReturn = new RoleDto
            {
                Name = Role.Name
            };

            return RoleToReturn;
        }
    }
}
