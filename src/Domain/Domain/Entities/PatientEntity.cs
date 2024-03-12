
using Domain.Commons;
using Domain.Entities;


namespace Domain.Entities
{
    public class PatientEntity : BaseEntity
    {
        public PatientEntity()
        {
            Medications = new List<MedicationEntity>();

            Appointments = new List<AppointmentEntity>();
        }

        public Guid UserId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public bool IsDeleted { get; set; }     



        public UserEntity User { get; set; }



        public ICollection<MedicationEntity> Medications { get; set; }
        public ICollection<AppointmentEntity> Appointments { get; set; }

    }
}
