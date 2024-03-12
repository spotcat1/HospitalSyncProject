

using Application.Contracts;
using Application.Dtos.UserDto;
using Application.Helper;
using Application.Queries;
using Application.Services.Interface;
using Domain.Entities;
using Domain.Models;

namespace Application.Services.Implementation
{
    public class UserImplementation : IUser
    {

        private readonly IUnitOfWork _unitOfWork;

        public UserImplementation(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> AddUser(AddUpdateUserDto dto)
        {
            if (dto.IdentityCode != null)
            {
                dto.IdentityCode = RemoveSpaces(dto.IdentityCode);
            }

            var UserInstanceModel = new UserModel
            {
                GenderId = dto.GenderId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                FatherName = dto.FatherName,
                BirthDate = dto.BirthDate.ConvertToMiladi(),
                IdentityCode = dto.IdentityCode,
                Address = dto.Address,
                Biography = dto.Biography,
                Nationality = dto.Nationality,
                ImageFile = dto.ImageFile,
                IsDeleted = dto.IsDeleted


            };


            //business logic

            //return await _userRepository.AddUserRepository(UserInstanceModel);

            return await _unitOfWork.UserRepository.AddUserRepository(UserInstanceModel);

        }

        public async Task<List<GetAllUsersDto>> GetAllPaginatedUser(int PageNumber = 1, int PageSize = 10)
        {
            var UsersToReturnRepository = await _unitOfWork.UserRepository.GetAllPaginatedUsers(PageNumber, PageSize);




            var ListOfUsers = new List<GetAllUsersDto>();

            foreach (var user in UsersToReturnRepository)
            {
                var Users = new GetAllUsersDto
                {
                    GenderTitle = user.GenderTitle,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    FatherName = user.FatherName,
                    IdentityCode = user.IdentityCode,
                    BirthDate = user.BirthDate.ConvertToPersiandate(),
                    Address = user.Address,
                    Biography = user.Biography,
                    ImageFile = user.ImagePath,
                    Nationality = user.Nationality,


                };

                ListOfUsers.Add(Users);
            }

            return ListOfUsers;
        }

        public async Task<List<GetAllUsersDto>> GetAllUsers(string? FirstFilterOn = null, string? FirstFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
            string? FirstOrderBy = null, bool FirstIsAscending = true,
            string? SecondOrderBy = null, bool SecondIsAscending = true,
            bool ShowDeletedOnes = false, int PageNumber = 1, int PageSize = 100)
        {
            if (!string.IsNullOrWhiteSpace(FirstFilterOn))
            {

                FirstFilterOn = RemoveSpaces(FirstFilterOn);

                if (!string.IsNullOrWhiteSpace(FirstFilterQuery))
                {
                    FirstFilterQuery = RemoveSpaces(FirstFilterQuery);
                }
            }



            if (!string.IsNullOrWhiteSpace(SecondFilterOn))
            {
                SecondFilterOn = RemoveSpaces(SecondFilterOn);

                if (!string.IsNullOrWhiteSpace(SecondFilterQuery))
                {
                    SecondFilterQuery = RemoveSpaces(SecondFilterQuery);
                }
            }


            if (!string.IsNullOrWhiteSpace(FirstOrderBy))
            {
                FirstOrderBy = RemoveSpaces(FirstOrderBy);

                if (!string.IsNullOrWhiteSpace(SecondOrderBy))
                {
                    SecondOrderBy = RemoveSpaces(SecondOrderBy);
                }
            }



            var UsersToReturnRepository = await _unitOfWork.UserRepository.GetAllUsers(FirstFilterOn, FirstFilterQuery, SecondFilterOn, SecondFilterQuery,
                FirstOrderBy, FirstIsAscending, SecondOrderBy, SecondIsAscending, ShowDeletedOnes, PageNumber, PageSize);


            var ListOfUsers = new List<GetAllUsersDto>();

            foreach (var user in UsersToReturnRepository)
            {
                var Users = new GetAllUsersDto
                {
                    GenderTitle = user.GenderTitle,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    FatherName = user.FatherName,
                    IdentityCode = user.IdentityCode,
                    BirthDate = user.BirthDate.ConvertToPersiandate(),
                    Address = user.Address,
                    Biography = user.Biography,
                    ImageFile = user.ImagePath,
                    Nationality = user.Nationality,


                };

                ListOfUsers.Add(Users);
            }

            return ListOfUsers;

        }

        public async Task<GetUserByIdDto> GetUserById(Guid Id, bool ShowIfIsDeleted = false)
        {
            var UserToReturn = await _unitOfWork.UserRepository.GetUserById(Id, ShowIfIsDeleted);


            var UserToReturnDto = new GetUserByIdDto
            {
                GenderTitle = UserToReturn.GenderTitle,
                FirstName = UserToReturn.FirstName,
                LastName = UserToReturn.LastName,
                FatherName = UserToReturn.FatherName,
                BirthDate = UserToReturn.BirthDate.ConvertToPersiandate(),
                IdentityCode = UserToReturn.IdentityCode,
                Address = UserToReturn.Address,
                Biography = UserToReturn.Biography,
                Nationality = UserToReturn.Nationality,
                ImageFile = UserToReturn.ImagePath
            };



            return UserToReturnDto;
        }

        public async Task<string> UpdateUser(AddUpdateUserDto dto, Guid Id)
        {
            if (dto.IdentityCode != null)
            {
                dto.IdentityCode = RemoveSpaces(dto.IdentityCode);
            }


            var UserInstanceModel = new UserModel
            {
                GenderId = dto.GenderId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                FatherName = dto.FatherName,
                BirthDate = dto.BirthDate.ConvertToMiladi(),
                IdentityCode = dto.IdentityCode,
                Address = dto.Address,
                Biography = dto.Biography,
                Nationality = dto.Nationality,
                ImageFile = dto.ImageFile,
                IsDeleted = dto.IsDeleted,
            };


            return await _unitOfWork.UserRepository.UpdateUserRepository(Id, UserInstanceModel);

        }
        private string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
