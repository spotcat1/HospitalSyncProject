

using Application.Dtos.UserDto;
using Domain.Models;

namespace Application.Services.Interface
{
    public interface IUser
    {
        Task<Guid> AddUser(AddUpdateUserDto dto);

        Task<string> UpdateUser(AddUpdateUserDto dto, Guid Id);


        Task<GetUserByIdDto> GetUserById(Guid Id, bool ShowIfIsDeleted = false);

        Task<List<GetAllUsersDto>> GetAllUsers(string? FirstFilterOn = null, string? FisFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
             string? FirstOrderBy = null, bool FirstIsAscending = true,
             string? SecondOrderBy = null, bool SecondIsAscending = true,
             bool ShowDeletedOnes = false,
             int PageNumber = 1, int PageSize = 100);

        Task<List<GetAllUsersDto>> GetAllPaginatedUser(int PageNumber = 1, int PageSize = 10);
    }
}
