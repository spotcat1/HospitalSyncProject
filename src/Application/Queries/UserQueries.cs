using Application.Dtos.Identity;
using Application.Dtos.UserDto;
using MediatR;



namespace Application.Queries
{
    public record GetUserById(Guid Id, bool ShowIfIsDeleted = false):IRequest<GetUserByIdDto>;

    public record GetAllUsers(string? FirstFilterOn = null, string? FisFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
            string? FirstOrderBy = null, bool FirstIsAscending = true,
            string? SecondOrderBy = null, bool SecondIsAscending = true,
            bool ShowDeletedOnes = false, int PageNumber = 1, int PageSize = 100) :IRequest<List<GetAllUsersDto>>;

    public record GetAllPaginatedUsers(int PageNumber = 1, int PageSize = 10) : IRequest<List<GetAllUsersDto>>;

    
}
