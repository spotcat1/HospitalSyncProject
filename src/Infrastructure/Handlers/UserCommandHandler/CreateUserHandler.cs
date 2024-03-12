using Application.Commands;
using Application.Services.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers.UserCommandHandler
{
    internal class CreateUserHandler : IRequestHandler<CreateUser, Guid>
    {
        private readonly IUser _user;

        public CreateUserHandler(IUser user)
        {
            _user = user;
        }

        public async Task<Guid> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            return await _user.AddUser(request.dto);
        }
    }
}
