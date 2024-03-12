

using Application.Dtos.UserDto;
using Application.Dtos.UserIdentityDto;
using FluentValidation;
using Infrastructure.CrossCutting.Validations.User;
using System.Globalization;
using System.Text.RegularExpressions;
using static Application.Commands.UserIdentityCommand;

namespace Infrastructure.CrossCutting.Validations.UserIdentity
{
    public class CreateUseridentityCommandValidator : AbstractValidator<CreateUserIdentity>
    {
        public CreateUseridentityCommandValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.Dto)
                .NotEmpty()
                .SetValidator(new CreateUseridentityDtoValidator())
                .SetValidator(new UserValidator());
        }
    }



    public class CreateUseridentityDtoValidator : AbstractValidator<CreateUserIdentityDto>
    {
        public CreateUseridentityDtoValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.UserIdentityDto.FullName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s_]*$")
                .WithName("نام کامل");


            RuleFor(x => x.UserIdentityDto.UserName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s]*$")
                .WithName("نام کاربری");


            RuleFor(x => x.UserIdentityDto.Password)
                .NotEmpty()
                .MinimumLength(6)
                .Must(password => !password.Contains(" "))
                .Must(password => !Regex.IsMatch(password, @"[\u0600-\u06FF]")) // Ensure password doesn't contain Farsi characters
                .Must(ContainAtLeastOneLowerAndOneUpper)
                .WithName("رمز عبور");


            RuleFor(x => x.UserIdentityDto.Email)
                .NotEmpty()
                .MaximumLength(30)
                .EmailAddress()                
                .WithName("رایا نامه");

            RuleFor(x => x.UserIdentityDto.PhoneNumber)
                .NotEmpty()
                .Length(13)
                .Matches(@"^\+98\d{10}$")
                .WithName("شماره تلفن");


        }



        private bool ContainAtLeastOneLowerAndOneUpper(string password)
        {
            if (password != null)
            {
                return password.Any(char.IsUpper) && password.Any(char.IsLower);
            }

            return true;
        }
    }




















    public class UserValidator : AbstractValidator<CreateUserIdentityDto>
    {
        public UserValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;


            RuleFor(x => x.AddUpdateUserDto.GenderId)
                .NotEmpty()
                .WithName("شناسه جنسیت");

            RuleFor(x => x.AddUpdateUserDto.FirstName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s]*$")
                .WithName("نام");

            RuleFor(x => x.AddUpdateUserDto.LastName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s]*$")
                .WithName("نام خانوادگی");

            RuleFor(x => x.AddUpdateUserDto.FatherName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s]*$")
                .WithName("نام پدر");


            RuleFor(x => x.AddUpdateUserDto.BirthDate)
                .NotEmpty()
                .Must(BeValidShamsidate)
                .WithName("تاریخ تولد");



            RuleFor(x => x.AddUpdateUserDto.IdentityCode)
                .NotEmpty()
                .Length(10)
                .Matches("^[0-9]+$")
                .WithName("کد ملی");

            RuleFor(x => x.AddUpdateUserDto.Biography)
                .MaximumLength(5000)
                .WithName("بیوگرافی");

            RuleFor(x => x.AddUpdateUserDto.Nationality)
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z]")
                .WithName("ملیت");

            RuleFor(x => x.AddUpdateUserDto.Address)
                .MaximumLength(300)
                .WithName("نشانی");




        }


        private bool HasAtLeastOneCapital(string password)
        {
            return password.Any(char.IsUpper);
        }


        private bool BeValidShamsidate(string date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            return DateTime.TryParseExact(date, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var ParsedDate)
                && ParsedDate.Year >= persianCalendar.MinSupportedDateTime.Year
                && ParsedDate.Year <= persianCalendar.MaxSupportedDateTime.Year
                && ParsedDate.Month >= 1
                && ParsedDate.Month <= 12
                && ParsedDate.Day >= 1
                && ParsedDate.Day <= persianCalendar.GetDaysInMonth(ParsedDate.Year, ParsedDate.Month);
        }
    }




}
