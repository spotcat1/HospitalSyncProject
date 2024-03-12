using Application.Dtos.UserDto;
using Application.Queries;
using Application.Services.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Handlers.UserQueryHandler
{
    internal class GetAllPaginatedUsersQueryHandler : IRequestHandler<GetAllPaginatedUsers, List<GetAllUsersDto>>
    {
        private readonly IUser user;

        public GetAllPaginatedUsersQueryHandler(IUser user)
        {
            this.user = user;
        }

        public async Task<List<GetAllUsersDto>> Handle(GetAllPaginatedUsers request, CancellationToken cancellationToken)
        {
            return await user.GetAllPaginatedUser(request.PageNumber, request.PageSize);
        }
    }
}
