

using Application.Dtos.UserDto;
using Domain.Models;

namespace Application.Contracts
{
    public interface IPeopleRepository
    {
        Task<Guid> AddPeople(PeopleModel userModel);

        Task<string> UpdatePeople(Guid Id, PeopleModel userModel);

        Task<PeopleModel> GetPeopleById(Guid Id, bool ShowIfIsDeleted = false);

        Task<List<PeopleModel>> GetAllPeople(string? FirstFIlterOn = null, string? FirstFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
            string? FirstOrderBy = null, bool FirstIsAscending = true,
            string? SecondOrderBy = null, bool SecondIsAscending = true, bool ShowDeletedOnes = false,
            int pageNumber = 1, int PageSize = 100);

        Task<List<PeopleModel>> GetAllPaginatedPeople(int PageNumber = 1, int PageSize = 100);
        Task<string> DeletePeopleById(Guid Id);
        Task<string> SoftDeletePeopleById(Guid Id);




        Task<bool> ExistGender(Guid GenderId);
        Task<bool> ExistUser(Guid Id);

        Task<bool> IsUniqueIdentityCode(string Id, Guid UserId);
        Task<bool> IsUniqueUserName(string UserName, Guid UserId);
    }
}
