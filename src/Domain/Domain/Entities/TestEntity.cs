using Domain.Commons;


namespace Domain.Entities
{
    public class TestEntity : BaseEntity
    {
        public TestEntity()
        {
            Appointments = new List<AppointmentEntity>();
        }
        public required string Name { get; set; }
        public string? Description { get; set; }



        public ICollection<AppointmentEntity> Appointments { get; set; }    

    }
}
