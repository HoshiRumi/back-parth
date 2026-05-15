using eDomain.mEntities.mUser;
using eDomain.mEnums;
using eDomain.mModels.mUser;
using eMiSide.DataAccess.Context;
using eMiSide.BusinessLogic.Structure;

namespace eMiSide.BusinessLogic.Core.Auth
{
    public class AuthActions
    {
        private readonly TokenService _tokenService = new();

        public string Login(UserAuthAction data)
        {
            using var db = new AppDbContext();
            var user = db.Users.FirstOrDefault(u =>
                u.Email == data.Email && u.PasswordHash == data.Password);
            if (user == null) return string.Empty;
            return _tokenService.GenerateToken(user.Id, user.Username, user.Role);
        }

        public string Register(UserAuthAction data)
        {
            using var db = new AppDbContext();
            if (db.Users.Any(u => u.Email == data.Email)) return string.Empty;

            var newUser = new UserData
            {
                Username = data.Username,
                Email = data.Email,
                PasswordHash = data.Password,
                Role = UserRole.Customer
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            return _tokenService.GenerateToken(newUser.Id, newUser.Username, newUser.Role);
        }
    }
}