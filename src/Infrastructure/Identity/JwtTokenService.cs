

using Application.Dtos.Identity;
using Application.Exceptions;
using Domain.Entities.User;
using Infrastructure.Persistants;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Identity
{
    public class JwtTokenService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtOption _jwtOption;
        private readonly ApplicationDbContext _context;
        public JwtTokenService(UserManager<ApplicationUser> userManager, IOptions<JwtOption> jwtOption,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _jwtOption = jwtOption.Value;
            _context = context;
        }

        public async Task<JwtResultDto> GenerateTokenAsync(GetTokenDto dto)
        {
            var User = await _userManager.FindByNameAsync(dto.UserName);

            if (User is null)
            {
                throw new CustomException("نام کاربری یا رمز عبور معتبر نمیباشد");
            }

            if (await _userManager.CheckPasswordAsync(User, dto.PassWord))
            {
                var UserClaims = await _userManager.GetClaimsAsync(User);
                var Roles = await _userManager.GetRolesAsync(User);

                var RoleCLaims = new List<Claim>();

                foreach (var role in Roles)
                {
                    RoleCLaims.Add(new Claim(ClaimTypes.Role, role));
                }
                var JwtCLaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub,User.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.GivenName,User.Fullname),

                    //Just a Custom Claim for demonstration
                    new Claim("Custom","CustomValue")
                };

                var Claims = UserClaims.Union(RoleCLaims).Union(JwtCLaims);

                var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.Key));
                var SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
                var Expiration = DateTime.UtcNow.AddMinutes(_jwtOption.Expiration);
                var JwtSecurityToken = new JwtSecurityToken(

                    issuer: _jwtOption.Issuer,
                    audience: _jwtOption.Audience,
                    expires: Expiration,
                    signingCredentials: SigningCredentials,
                    claims: Claims

                    );

                return new JwtResultDto
                {
                    ExpirationDate = Expiration,
                    UserId = User.Id,
                    Token = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken)
                };
            }

            throw new CustomException("نام کاربری یا رمز عبور معتبر نمیباشد");

        }
    }
}
