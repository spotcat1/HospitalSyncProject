

namespace Application.Dtos.Identity
{
    public class GetTokenDto
    {
        public required string UserName { get; set; }
        public required string PassWord { get; set; }
    }
}
