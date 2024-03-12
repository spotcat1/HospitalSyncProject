
using Application.Exceptions;
using Application.Services.Interface;
using Domain.Entities.User;
using MediatR;
using Microsoft.AspNetCore.Identity;
using static Application.Commands.UserIdentityCommand;



namespace Infrastructure.Handlers.UserIdentityCommandHandler
{
    public class CreateUserIdentityHandler : IRequestHandler<CreateUserIdentity, Guid>
    {
        private readonly IUser _user;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public CreateUserIdentityHandler(IUser user, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            _user = user;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Guid> Handle(CreateUserIdentity request, CancellationToken cancellationToken)
        {
            var Role = await _roleManager.Roles.AnyAsync(x => x.Id == request.RoleId);

            if (!Role)
            {
                throw new NotFoundException("شناسه نقش مورد نظر یافت نشد");
            }


            var existingUserWithPhoneNumber = await _userManager.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.Dto.UserIdentityDto.PhoneNumber);
            if (existingUserWithPhoneNumber != null)
            {
                throw new CustomException("شماره تلفن وارد شده قبلاً استفاده شده است. لطفاً شماره تلفن دیگری را وارد کنید.");
            }

            string hashedPassword = new PasswordHasher<ApplicationUser>().HashPassword(null, request.Dto.UserIdentityDto.Password);

            var IdentityUser = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Fullname = request.Dto.UserIdentityDto.FullName,
                UserName = request.Dto.UserIdentityDto.UserName,
                PhoneNumber = request.Dto.UserIdentityDto.PhoneNumber,
                PasswordHash = hashedPassword,
                Email = request.Dto.UserIdentityDto.Email,
                ConcurrencyStamp=Guid.NewGuid().ToString(),
                
            };

            var Result = await _userManager.CreateAsync(IdentityUser);

            if (!Result.Succeeded)
            {
                var errorMessage = string.Join(", ", Result.Errors.Select(error => error.Description));
                throw new CustomException($"ایجاد کاربر با خطا مواجه شد: {errorMessage}");
            }

            var RoleInfo = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == request.RoleId);


            var addToRoleResult = await _userManager.AddToRoleAsync(IdentityUser, RoleInfo.Name);

            if (!addToRoleResult.Succeeded)
            {
                throw new Exception("خطا در اختصاص نقش به کاربر");
            }


            await _user.AddUser(request.Dto.AddUpdateUserDto);


            return IdentityUser.Id;
        }
    }
}

