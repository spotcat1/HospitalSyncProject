

using Domain.Commons;

namespace Domain.Entities
{
    public class PeopleEntity:BaseEntity
    {

        public PeopleEntity()
        {
            Patients = new List<PatientEntity>();
            Doctors = new List<DoctorEntity>();
            Nurses = new List<NurseEntity>();
        }
        public Guid GenderId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string FatherName{ get; set; }
        public required string UserName{ get; set; }
        public required string PassWord{ get; set; }
        public string? Biography{ get; set; }
        public required DateTime BirthDate { get; set; }
        public required string IdentityCode { get; set; }
        public string? Address { get; set; }

        public string? ImagePath { get; set; }
        public string? Nationality { get; set; }

        public bool IsDeleted { get; set; }



        //Navigation property

        public GenderEntity Gender { get; set; }    



        public ICollection<PatientEntity> Patients { get; set; }

        public ICollection<DoctorEntity> Doctors { get; set; }

        public ICollection<NurseEntity> Nurses { get;}

    }
}
