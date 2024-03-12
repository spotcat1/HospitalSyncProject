using Domain.Commons;


namespace Domain.Models
{
    public class DoctorModel : BaseModel
    {
        public DoctorModel()
        {
            AppointmentModels = new List<AppointmentModel>();
        }
        public Guid UserId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public bool IsDeleted { get; set; }



        public UserModel User { get; set; }


        public ICollection<AppointmentModel> AppointmentModels { get; set; }
    }
}
