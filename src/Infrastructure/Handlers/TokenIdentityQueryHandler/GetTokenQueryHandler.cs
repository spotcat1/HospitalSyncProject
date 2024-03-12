using Application.Dtos.Identity;
using Infrastructure.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Queries.TokendentityQueries;

namespace Infrastructure.Handlers.UserIdentityQueryHandler
{
    internal class GetTokenQueryHandler : IRequestHandler<GetTokenQuery, JwtResultDto>
    {
        private readonly JwtTokenService _jwtTokenService;

        public GetTokenQueryHandler(JwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        public async Task<JwtResultDto> Handle(GetTokenQuery request, CancellationToken cancellationToken)
        {
            var JwtToken = await _jwtTokenService.GenerateTokenAsync(request.dto);
            return JwtToken;
        }
    }
}
