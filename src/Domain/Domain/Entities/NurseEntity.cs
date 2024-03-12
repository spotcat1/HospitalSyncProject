

using Domain.Commons;
using Domain.Entities;

namespace Domain.Entities
{
    public class NurseEntity : BaseEntity
    {
        public NurseEntity()
        {
            Appointments = new List<AppointmentEntity>();    
        }
        public Guid UserId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public bool IsDeleted { get; set; }


        public UserEntity User { get; set; }



        public ICollection<AppointmentEntity> Appointments { get; set; }

    }
}
