using Domain.Commons;


namespace Domain.Models
{
    public class TestModel : BaseModel
    {
        public TestModel()
        {
            AppointmentModels = new List<AppointmentModel>();
        }
        public required string Name { get; set; }
        public required string Description { get; set; }


        public ICollection<AppointmentModel> AppointmentModels { get; set; }
    }
}
