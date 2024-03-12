using Application.Dtos.RolesDto;
using Application.Exceptions;
using Application.Services.Interface;
using MediatR;
using Microsoft.AspNetCore.Identity;
using static Application.Queries.RoleIdentityQueries;

namespace Infrastructure.Handlers.RoleIdentityQueryHandler
{
    internal class GetRolesQueryHandler : IRequestHandler<GetRoles, List<RoleDto>>
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public GetRolesQueryHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<RoleDto>> Handle(GetRoles request, CancellationToken cancellationToken)
        {

            var roles = _roleManager.Roles.AsQueryable();

            var SkipPages = (request.PageNumber - 1) * request.PageSize;


            var RolesList = await roles.Skip(SkipPages).Take(request.PageSize).ToListAsync();

            if (RolesList.Count == 0)
            {
                throw new CustomException("نقشی برای نمایش وجود ندارد");
            }


            var roleDtos = new List<RoleDto>();
            foreach (var role in RolesList)
            {
                roleDtos.Add(new RoleDto { Name = role.Name });
            }

            return roleDtos;
        }
    }
}
