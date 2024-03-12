

using Application.Dtos.UserDto;
using Application.Queries;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserQueryHandler
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserById, GetUserByIdDto>
    {

        private readonly IUser _user;

        public GetUserByIdQueryHandler(IUser user)
        {
            _user = user;
        }

        public async Task<GetUserByIdDto> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            return await _user.GetUserById(request.Id,request.ShowIfIsDeleted);
        }
    }
}
