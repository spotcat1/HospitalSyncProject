using Domain.Commons;


namespace Domain.Models
{
    public class AppointmentModel : BaseModel
    {
        public AppointmentModel()
        {
            Tests = new List<TestModel>();
        }
        public Guid PatientId { get; set; }
        public Guid NurseId { get; set; }
        public Guid DoctorId { get; set; }


        public DateTime AppointmentDate { get; set; }
        public string? Description { get; set; }

        public bool IsDeleted { get; set; }


        public required PatientModel Patient { get; set; }
        public required DoctorModel Doctor { get; set; }
        public required NurseModel Nurse { get; set; }




        public ICollection<TestModel> Tests { get; set; }
    }
}
