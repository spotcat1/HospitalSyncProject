

using Application.Dtos.UserDto;
using Application.Dtos.UserIdentityDto;
using MediatR;

namespace Application.Commands
{
    public class UserIdentityCommand
    {
        public record CreateUserIdentity(CreateUserIdentityDto Dto, Guid RoleId):IRequest<Guid>;
    }
}
