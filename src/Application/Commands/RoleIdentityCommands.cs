

using Application.Dtos.RolesDto;
using MediatR;

namespace Application.Commands
{
    public record CreateRole(RoleDto dto):IRequest<Guid>;
    public record UpdateRole(Guid id, RoleDto dto):IRequest<string>;

    public record DeleteRole(Guid id):IRequest<string>;
}
