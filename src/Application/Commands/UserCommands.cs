
using Application.Dtos.UserDto;
using MediatR;

namespace Application.Commands
{
    public record CreateUser(AddUpdateUserDto dto):IRequest<Guid>;
    public record UpdateUser(AddUpdateUserDto dto, Guid Id) :IRequest<string>;
    public record DeleteUser(Guid Id):IRequest<string>;
    public record SoftDeleteUser(Guid Id):IRequest<string>;
}
