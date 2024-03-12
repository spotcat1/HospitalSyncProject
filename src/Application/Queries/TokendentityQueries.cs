using Application.Dtos.Identity;
using MediatR;


namespace Application.Queries
{
    public class TokendentityQueries
    {
        public record GetTokenQuery(GetTokenDto dto) : IRequest<JwtResultDto>;
    }
}
