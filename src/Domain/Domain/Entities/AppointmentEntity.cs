

using Domain.Commons;

namespace Domain.Entities
{
    public class AppointmentEntity : BaseEntity
    {
        public AppointmentEntity()
        {
            Tests = new List<TestEntity>();
        }
        public Guid PatientId { get; set; }
        public Guid NurseId { get; set; }
        public Guid DoctorId { get; set; }


        public DateTime AppointmentDate { get; set;}
        public string? Description { get; set; }

        public bool IsDeleted { get; set; }


        public required PatientEntity Patient { get; set; }
        public required DoctorEntity Doctor { get; set; }
        public required NurseEntity Nurse { get; set; }


        public ICollection<TestEntity> Tests { get; set; }

    }
}
