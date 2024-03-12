

using Microsoft.AspNetCore.Http;

namespace Application.Dtos.UserDto
{
    public class AddUpdateUserDto
    {
        public Guid GenderId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string FatherName { get; set; }
        public string? Biography { get; set; }
        public required string BirthDate { get; set; }
        public required string IdentityCode { get; set; }
        public string? Address { get; set; }
        public string? Nationality { get; set; }

        public IFormFile? ImageFile { get; set; }



        public bool IsDeleted { get; set; } = false;
    }
}
