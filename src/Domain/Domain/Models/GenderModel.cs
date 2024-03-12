using Domain.Commons;
using Domain.Entities;

namespace Domain.Models
{
    public class GenderModel : BaseModel
    {
        public GenderModel()
        {
            Users = new List<UserModel>();
        }
        public required string Title { get; set; }




        public ICollection<UserModel> Users { get; set; }
    }
}

