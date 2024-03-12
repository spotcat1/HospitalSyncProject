using Domain.Commons;


namespace Domain.Models
{
    public class MedicationModel : BaseModel
    {
        public MedicationModel()
        {
            PatientModels = new List<PatientModel>();   
        }
        public Guid UserId { get; set; }


        public required string Name { get; set; }
        public string? Dosage { get; set; }

        public string? Description { get; set; }


        public bool IsDeleted { get; set; }




        public ICollection<PatientModel> PatientModels { get; set; }


    }
}
