using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using eDomain.mEnums;
using Microsoft.IdentityModel.Tokens;

namespace eMiSide.BusinessLogic.Structure
{
    public class TokenService
    {
        public string GenerateToken(int userId, string userName, UserRole role)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, role.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: JwtSettings.Issuer,
                audience: JwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(JwtSettings.ExpireMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}