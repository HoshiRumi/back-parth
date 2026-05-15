using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using eDomain.mEnums;
using Microsoft.IdentityModel.Tokens;

namespace eMiSide.BusinessLogic.Structure
{
    public class TokenService
    {
        private const string Issuer = "eMiSideApi";
        private const string Audience = "eMiSideClients";
        private const string SecretKey = "eMiSide_curs2026_super_secret_min_32_caractere!";

        public string GenerateToken(int userId, string userName, UserRole role)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, role.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}