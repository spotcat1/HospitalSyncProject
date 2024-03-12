

using Application.Dtos.UserDto;
using Domain.Models;

namespace Application.Services.Interface
{
    public interface IPeople
    {
        Task<Guid> AddPeople(AddUpdatePeopleDto dto);

        Task<string> UpdatePeople(AddUpdatePeopleDto dto, Guid Id);


        Task<GetPeopleByIdDto> GetPeopleById(Guid Id, bool ShowIfIsDeleted = false);

        Task<List<GetAllPeopleDto>> GetAllPeople(string? FirstFilterOn = null, string? FisFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
             string? FirstOrderBy = null, bool FirstIsAscending = true,
             string? SecondOrderBy = null, bool SecondIsAscending = true,
             bool ShowDeletedOnes = false,
             int PageNumber = 1, int PageSize = 100);

        Task<List<GetAllPeopleDto>> GetAllPaginatedPeople(int PageNumber = 1, int PageSize = 10);
    }
}
