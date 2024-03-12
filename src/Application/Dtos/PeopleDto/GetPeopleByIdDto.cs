using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.UserDto
{
    public class GetPeopleByIdDto
    {
        public required string GenderTitle { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string FatherName { get; set; }
        public required string UserName { get; set; }
        public required string PassWord { get; set; }
        public string? Biography { get; set; }
        public required string BirthDate { get; set; }
        public required string IdentityCode { get; set; }
        public string? Address { get; set; }

        public string? ImageFile { get; set; }
        public string? Nationality { get; set; }
    }
}
