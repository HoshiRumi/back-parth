using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;

namespace eMiSide.BusinessLogic.Core.Auth
{
    public class AuthActions
    {
        private static List<UserData> _users = new();
        private static int _nextId = 1;

        public string Login(UserAuthAction data)
        {
            var user = _users.FirstOrDefault(u =>
                u.Email == data.Email && u.PasswordHash == data.Password);
            if (user == null) return string.Empty;
            return $"stub-token-{user.Id}";
        }

        public string Register(UserAuthAction data)
        {
            if (_users.Any(u => u.Email == data.Email))
                return string.Empty;

            _users.Add(new UserData
            {
                Id = _nextId++,
                Username = data.Username,
                Email = data.Email,
                PasswordHash = data.Password
            });
            return $"stub-token-{_nextId}";
        }
    }
}