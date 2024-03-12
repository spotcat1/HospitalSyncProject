

using Application.Dtos.RolesDto;
using MediatR;

namespace Application.Queries
{
    public class RoleIdentityQueries
    {
        public record GetRoleById(Guid id) : IRequest<RoleDto>;

        public record GetRoles(int PageNumber = 1, int PageSize = 10) : IRequest<List<RoleDto>>;
    }
}
