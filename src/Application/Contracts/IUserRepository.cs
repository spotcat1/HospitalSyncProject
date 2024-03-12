

using Application.Dtos.UserDto;
using Domain.Models;

namespace Application.Contracts
{
    public interface IUserRepository
    {
        Task<Guid> AddUserRepository(UserModel userModel);

        Task<string> UpdateUserRepository(Guid Id, UserModel userModel);

        Task<UserModel> GetUserById(Guid Id, bool ShowIfIsDeleted = false);

        Task<List<UserModel>> GetAllUsers(string? FirstFIlterOn = null, string? FirstFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
            string? FirstOrderBy = null, bool FirstIsAscending = true,
            string? SecondOrderBy = null, bool SecondIsAscending = true, bool ShowDeletedOnes = false,
            int pageNumber = 1, int PageSize = 100);

        Task<List<UserModel>> GetAllPaginatedUsers(int PageNumber = 1, int PageSize = 100);
        Task<string> DeleteUserByIdRepository(Guid Id);
        Task<string> SoftDeleteUserByIdRepository(Guid Id);




        Task<bool> ExistGender(Guid GenderId);
        Task<bool> ExistUser(Guid Id);

        Task<bool> IsUniqueIdentityCode(string Id, Guid UserId);
  
    }
}
