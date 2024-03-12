

namespace Application.Dtos.Identity
{
    public class JwtResultDto
    {
        public Guid UserId { get; set; }

        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
