

using Domain.Commons;
using Domain.Models;

namespace Domain.Entities
{
    public class MedicationEntity : BaseEntity
    {
        public MedicationEntity()
        {
            Patients = new List<PatientEntity>();   
        }
        public Guid UserId { get; set; }


        public required string Name { get; set; }
        public required string Dosage { get; set; }

        public string? Description { get; set; }


        public bool IsDeleted { get; set; }




        public ICollection<PatientEntity> Patients { get; set; }
    }
}
