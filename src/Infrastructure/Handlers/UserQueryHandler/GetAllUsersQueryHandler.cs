
using Application.Dtos.UserDto;
using Application.Queries;
using Application.Services.Interface;
using MediatR;

namespace Infrastructure.Handlers.UserQueryHandler
{
    internal class GetAllUsersQueryHandler : IRequestHandler<GetAllUsers, List<GetAllUsersDto>>
    {

        private readonly IUser _user;

        public GetAllUsersQueryHandler(IUser user)
        {
            _user = user;
        }

        public async Task<List<GetAllUsersDto>> Handle(GetAllUsers request, CancellationToken cancellationToken)
        {
            return await _user.GetAllUsers(

                request.FirstFilterOn, request.FisFilterQuery,
                request.SecondFilterOn, request.SecondFilterQuery,
                request.FirstOrderBy, request.FirstIsAscending,
                request.SecondOrderBy, request.SecondIsAscending, request.ShowDeletedOnes,
                request.PageNumber, request.PageSize

                );
        }
    }
}
