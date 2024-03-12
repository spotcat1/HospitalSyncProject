

namespace Application.Dtos.UserDto
{
    public class GetAllUsersDto
    {
        public Guid Guid { get; set; }

        public required string GenderTitle { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string FatherName { get; set; }
        public string? Biography { get; set; }
        public required string BirthDate { get; set; }
        public required string IdentityCode { get; set; }
        public string? Address { get; set; }

        public string? ImageFile { get; set; }
        public string? Nationality { get; set; }
    }
}
