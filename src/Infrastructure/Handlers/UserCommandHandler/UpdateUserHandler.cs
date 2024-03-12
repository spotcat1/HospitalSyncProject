using Application.Commands;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class UpdateUserHandler : IRequestHandler<UpdateUser, string>
    {
        private readonly IUser _user;

        public UpdateUserHandler(IUser user)
        {
            _user = user;
        }

        public async Task<string> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            return await _user.UpdateUser( request.dto, request.Id);
        }
    }
}
