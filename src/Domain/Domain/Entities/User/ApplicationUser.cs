

using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.User
{
<<<<<<< HEAD
    public class ApplicationUser:IdentityUser<Guid>
    {
        public string FullName { get; set; }
=======
    public class ApplicationUser : IdentityUser<Guid>
    {
        public required string Fullname { get; set; }
>>>>>>> 36b60cbf4346dd2b4774f3093b946930a106efd1
    }
}
