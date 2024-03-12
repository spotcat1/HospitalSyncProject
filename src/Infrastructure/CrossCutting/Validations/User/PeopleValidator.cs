
using Application.Dtos.UserDto;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Globalization;

namespace Infrastructure.CrossCutting.Validations.User
{
    public class PeopleValidator:AbstractValidator<AddUpdatePeopleDto>
    {
        public PeopleValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;


            RuleFor(x => x.GenderId)
                .NotEmpty()
                .WithName("شناسه جنسیت");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s*]+$")
                .WithName("نام");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s*]+$")
                .WithName("نام خانوادگی");

            RuleFor(x => x.FatherName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z\\s*]+$")
                .WithName("نام پدر");

            RuleFor(x => x.UserName)
                .NotEmpty()
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z0-9]+$")
                .WithName("نام کاربری");

            RuleFor(x => x.PassWord)
                .NotEmpty()
                .MinimumLength(7)
                .Must(HasAtLeastOneCapital)
                .WithName("رمز عبور");


            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .Must(BeValidShamsidate)
                .WithName("تاریخ تولد");



            RuleFor(x => x.IdentityCode)
                .NotEmpty()
                .Length(10)
                .Matches("^[0-9]+$")
                .WithName("کد ملی");

            RuleFor(x => x.Biography)
                .MaximumLength(5000)
                .WithName("بیوگرافی");

            RuleFor(x => x.Nationality)
                .MaximumLength(100)
                .Matches("^[آ-یa-zA-Z]")
                .WithName("ملیت");

            RuleFor(x => x.Address)
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
