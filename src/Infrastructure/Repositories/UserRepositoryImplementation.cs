using Application.Contracts;
using Domain.Models;
using Infrastructure.Persistants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Application.Exceptions;
using Microsoft.AspNetCore.Http.Extensions;
using Application.Dtos.UserDto;

namespace Infrastructure.Repositories
{
    public class UserRepositoryImplementation : GenericRepositoryImplementaton<UserEntity>, IUserRepository
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICacheManagerService _cacheManagerService;
        private const string ImagePath = "images/users";
        private readonly static List<string> CachedKeyLists = new List<string>();

        public UserRepositoryImplementation(IWebHostEnvironment webHostEnvironment,
            IHttpContextAccessor contextAccessor, ApplicationDbContext context,
            ICacheManagerService cacheManagerService) : base(context)
        {

            _webHostEnvironment = webHostEnvironment;
            _contextAccessor = contextAccessor;
            _cacheManagerService = cacheManagerService;
        }





        public async Task<Guid> AddUserRepository(UserModel userModel)
        {
            var UploadRoot = Path.Combine(_webHostEnvironment.WebRootPath, ImagePath);

            if (!Directory.Exists(UploadRoot))
            {
                Directory.CreateDirectory(UploadRoot);
            }


            if (userModel.ImageFile != null)
            {
                var FileExtension = Path.GetExtension(userModel.ImageFile.FileName);
                var AllowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!AllowedExtensions.Any(x => x.Equals(FileExtension, StringComparison.OrdinalIgnoreCase)))
                {
                    userModel.ImageFile = null;
                }
            }


            var entity = new UserEntity
            {
                Id = Guid.NewGuid(),
                GenderId = userModel.GenderId,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                FatherName = userModel.FatherName,
                Address = userModel.Address,
                BirthDate = userModel.BirthDate,
                IdentityCode = userModel.IdentityCode,
                Biography = userModel.Biography,
                Nationality = userModel.Nationality,
                IsDeleted = userModel.IsDeleted,

            };


            if (userModel.ImageFile != null && userModel.ImageFile.Length > 0)
            {
                string FileExtension = Path.GetExtension(userModel.ImageFile.FileName);
                string NewFileName = $"user_{Guid.NewGuid().ToString().Replace("-", "")}{FileExtension}";
                var FilePath = Path.Combine(UploadRoot, NewFileName);
                using (var FileStream = new FileStream(FilePath, FileMode.Create))
                {
                    await userModel.ImageFile.CopyToAsync(FileStream).ConfigureAwait(false);
                }

                entity.ImagePath = $"{ImagePath}/{NewFileName}";
            }

            Add(entity);

            RemoveCachedKeys(CachedKeyLists);

            return entity.Id;


        }


        public async Task<string> UpdateUserRepository(Guid Id, UserModel userModel)
        {
            var UploadRootPath = Path.Combine(_webHostEnvironment.WebRootPath, ImagePath);

            if (!Directory.Exists(UploadRootPath))
            {
                Directory.CreateDirectory(UploadRootPath);
            }

            var UserToUpdate = Table().FirstOrDefault(x => x.Id == Id && !x.IsDeleted);


            if (UserToUpdate == null)
            {
                throw new NotFoundException("شناسه کاربر یافت نشد");
            }


            if (userModel.ImageFile != null && userModel.ImageFile.Length > 0)
            {
                var FileExtension = Path.GetExtension(userModel.ImageFile.FileName);
                var AllowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!AllowedExtensions.Any(x => x.Equals(FileExtension, StringComparison.OrdinalIgnoreCase)))
                {
                    userModel.ImageFile = null;
                }
            }



            if (userModel.ImageFile != null && userModel.ImageFile.Length > 0)
            {
                var FileExtension = Path.GetExtension(userModel.ImageFile.FileName);
                string NewFileName = $"user_{Guid.NewGuid().ToString().Replace("-", "")}{FileExtension}";
                var FilePath = Path.Combine(UploadRootPath, NewFileName);
                using (var FileStream = new FileStream(FilePath, FileMode.Create))
                {
                   await userModel.ImageFile.CopyToAsync(FileStream).ConfigureAwait(false);
                }

                UserToUpdate.ImagePath = $"{ImagePath}/{NewFileName}";

                if (!string.IsNullOrEmpty(UserToUpdate.ImagePath))
                {
                    DeleteImage(UserToUpdate.ImagePath);
                }
            }
            else
            {
                UserToUpdate.ImagePath = UserToUpdate.ImagePath;
            }

            UserToUpdate.GenderId = userModel.GenderId;
            UserToUpdate.FirstName = userModel.FirstName;
            UserToUpdate.LastName = userModel.LastName;
            UserToUpdate.FatherName = userModel.FatherName;
            UserToUpdate.Biography = userModel.Biography;
            UserToUpdate.BirthDate = userModel.BirthDate;
            UserToUpdate.IdentityCode = userModel.IdentityCode;
            UserToUpdate.Address = userModel.Address;
            UserToUpdate.Nationality = userModel.Nationality;
            UserToUpdate.IsDeleted = userModel.IsDeleted;


            Update(UserToUpdate);
            RemoveCachedKeys(CachedKeyLists);
            return  "ویرایش با موفقیت انجام شد";
        }

        private void DeleteImage(string imagePath)
        {
            var FilePath = _webHostEnvironment.WebRootPath + imagePath;

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }



        public async Task<bool> ExistGender(Guid GenderId)
        {
            var Exist = await _context.Genders.AnyAsync(x => x.Id == GenderId);

            if (!Exist)
            {
                throw new NotFoundException("شناسه جنسیت نا معتبر است ");
            }

            return true;
        }



        public async Task<bool> IsUniqueIdentityCode(string Id, Guid UserId)
        {
            var Reserved = await Table().AnyAsync(x => x.IdentityCode == Id && !x.IsDeleted && x.Id != UserId);

            if (Reserved)
            {
                throw new CustomException("کد ملی متعلق به شخص دیگری است");
            }

            return true;
        }






        public async Task<bool> ExistUser(Guid UserId)
        {
            var Exist = await Table().AnyAsync(x => x.Id == UserId);

            if (!Exist)
            {
                throw new NotFoundException("شناسه کاربری یافت نشد");
            }


            return true;
        }




        public async Task<List<UserModel>> GetAllUsers(string? FirstFilterOn = null, string? FirstFilterQuery = null,
            string? SecondFilterOn = null, string? SecondFilterQuery = null,
            string? FirstOrderBy = null, bool FirstIsAscending = true,
            string? SecondOrderBy = null, bool SecondIsAscending = true,
            bool ShowDeletedOnes = false, int pageNumber = 1, int PageSize = 100)
        {
            var Users = TableTracking().Include(x => x.Gender).AsQueryable();

            //FILTER

            if (!string.IsNullOrWhiteSpace(FirstFilterOn) && !string.IsNullOrWhiteSpace(FirstFilterQuery))
            {
                if (FirstFilterQuery.Equals("نامخانوادگی"))
                {
                    Users = Users.Where(x => x.LastName.Contains(FirstFilterQuery));
                }
            }

            if (!string.IsNullOrWhiteSpace(SecondFilterOn) && !string.IsNullOrWhiteSpace(SecondFilterQuery))
            {
                if (SecondFilterQuery.Equals("نام"))
                {
                    Users = Users.Where(x => x.FirstName.Contains(SecondFilterQuery));
                }
            }




            //SORT

            if (!string.IsNullOrWhiteSpace(FirstOrderBy))
            {
                if (FirstOrderBy.Equals("نامخانوادگی"))
                {
                    Users = FirstIsAscending ? Users.OrderBy(x => x.LastName) : Users.OrderByDescending(x => x.LastName);

                    if (!string.IsNullOrWhiteSpace(SecondOrderBy))
                    {
                        if (SecondOrderBy.Equals("نام") && FirstIsAscending)
                        {
                            Users = SecondIsAscending ? Users.OrderBy(x => x.LastName).ThenBy(x => x.FirstName)
                                : Users.OrderBy(x => x.LastName).ThenByDescending(x => x.FirstName);
                        }

                        if (SecondOrderBy.Equals("نام") && !FirstIsAscending)
                        {
                            Users = SecondIsAscending ? Users.OrderByDescending(x => x.LastName).ThenBy(x => x.FirstName)
                                : Users.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName);
                        }

                    }


                }
            }



            //ShowDeletedOnes

            if (!ShowDeletedOnes)
            {
                Users = Users.Where(x => !x.IsDeleted);
            }

            //Paging

            var SkipPages = (pageNumber - 1) * PageSize;

            var UsersList = await Users.Skip(SkipPages).Take(PageSize).ToListAsync();


            var UsersMappedList = new List<UserModel>();

            foreach (var entity in UsersList)
            {
                var MapResult = new UserModel
                {
                    GenderTitle = entity.Gender.Title,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    FatherName = entity.FatherName,
                    BirthDate = entity.BirthDate,
                    IdentityCode = entity.IdentityCode,
                    Address = entity.Address,
                    Biography = entity.Biography,
                    Nationality = entity.Nationality,
                    ImagePath = entity.ImagePath != null ? BuildAbsoluteUrl(entity.ImagePath) : null,
                };

                UsersMappedList.Add(MapResult);
            }

            return UsersMappedList;



        }




        public async Task<List<UserModel>> GetAllPaginatedUsers(int PageNumber = 1, int PageSize = 10)
        {
            var CachedKey = $"PaginatedUsers_{PageNumber}_{PageSize}";

            CachedKeyLists.Add(CachedKey);

            var CachedUsers = await _cacheManagerService.GetAsync<List<UserModel>>(CachedKey, async() =>
            {
                var Users = Table().Include(x => x.Gender).AsQueryable();

                var SkipPages = (PageNumber - 1) * PageSize;

                var UsersList = await Users.Skip(SkipPages).Take(PageSize).ToListAsync();

                var usersMappedList = new List<UserModel>();

                foreach (var entity in UsersList)
                {
                    var UserModel = new UserModel
                    {
                        GenderTitle = entity.Gender.Title,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        FatherName = entity.FatherName,
                        BirthDate = entity.BirthDate,
                        IdentityCode = entity.IdentityCode,
                        Address = entity.Address,
                        Biography = entity.Biography,
                        Nationality = entity.Nationality,
                        ImagePath = entity.ImagePath != null ? BuildAbsoluteUrl(entity.ImagePath) : null,
                    };

                    usersMappedList.Add(UserModel);
                }

                return usersMappedList;
                

            }, 5);

            return CachedUsers;
        }

        public async Task<UserModel> GetUserById(Guid Id, bool ShowIfIsDeleted = false)
        {
            var UserEntityQuery = Table().AsQueryable();

            if (!ShowIfIsDeleted)
            {
                UserEntityQuery = UserEntityQuery.Where(x => !x.IsDeleted);
            }


            var UserEntity = await UserEntityQuery.Include(x => x.Gender)
                .FirstOrDefaultAsync(x => x.Id == Id);


            if (UserEntity is null)
            {
                throw new NotFoundException("شناسه کاربر مورد نظر یافت نشد");
            }

            var UserToReturnDomainModel = new UserModel
            {
                GenderTitle = UserEntity.Gender.Title,
                FirstName = UserEntity.FirstName,
                LastName = UserEntity.LastName,
                FatherName = UserEntity.FatherName,
                BirthDate = UserEntity.BirthDate,
                IdentityCode = UserEntity.IdentityCode,
                Address = UserEntity.Address,
                Biography = UserEntity.Biography,
                ImagePath = UserEntity.ImagePath,
                Nationality = UserEntity.Nationality,


            };


            if (UserEntity.ImagePath != null)
            {
                UserToReturnDomainModel.ImagePath = BuildAbsoluteUrl(UserToReturnDomainModel.ImagePath);
            }

            return UserToReturnDomainModel;

        }

        private string? BuildAbsoluteUrl(string? relativeImagePath)
        {
            var AbsoluteURL = new Uri(_contextAccessor.HttpContext.Request.GetDisplayUrl());
            var BaseURL = $"{AbsoluteURL.GetLeftPart(UriPartial.Authority)}";
            return $"{BaseURL}/{relativeImagePath}";
        }

        public async Task<string> SoftDeleteUserByIdRepository(Guid Id)
        {
            var UserToDelete = await TableTracking().FirstOrDefaultAsync(x => x.Id == Id);

            if (UserToDelete == null)
            {
                throw new NotFoundException("شناسه کاربر یافت نشد");
            }


            if (UserToDelete.IsDeleted)
            {
                throw new CustomException("کاربر مورد نظر قبلا حذف منطقی شده است");
            }

            UserToDelete.IsDeleted = true;

            RemoveCachedKeys(CachedKeyLists);

            return "حذف منطقی با موفقیت انجام شد";
        }


        public async Task<string> DeleteUserByIdRepository(Guid Id)
        {
            var UserToDelete = await GetByIdAsync(Id);

            Remove(UserToDelete);

            _cacheManagerService.Remove("User-List");

            RemoveCachedKeys(CachedKeyLists);

            return "حذف کاربر با موفقیت انجام شد";
        }


        private void RemoveCachedKeys(List<string> cachedKeysToRemove)
        {
            if (cachedKeysToRemove != null && cachedKeysToRemove.Any())
            {
                foreach (var cacheKeyToRemove in cachedKeysToRemove)
                {
                    _cacheManagerService.Remove(cacheKeyToRemove);
                }

                cachedKeysToRemove.Clear();
            }

            
        }


    }
}
