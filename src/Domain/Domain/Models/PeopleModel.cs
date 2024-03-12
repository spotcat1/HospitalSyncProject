using Domain.Commons;
using Microsoft.AspNetCore.Http;

namespace Domain.Models
{
    public class PeopleModel : BaseModel
    {
        public PeopleModel()
        {
            Patients = new List<PatientModel>();
            Nurses = new List<NurseModel>();
            Doctors = new List<DoctorModel>();
        }
        public  Guid GenderId { get; set; } 
        public string GenderTitle { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string UserName { get; set; }
        public required string PassWord { get; set; }
        public  string? Biography { get; set; }
        public required string FatherName { get; set; }
        public required DateTime BirthDate { get; set; }
        public required string IdentityCode { get; set; }
        public string? Address { get; set; }

        public string? ImagePath { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? Nationality { get; set; }

        public bool IsDeleted { get; set; }

        public GenderModel Gender { get; set; }



        public ICollection<PatientModel> Patients { get; set; }
        public ICollection<NurseModel> Nurses { get; set; }
        public ICollection<DoctorModel> Doctors { get; set; }
    }
}
