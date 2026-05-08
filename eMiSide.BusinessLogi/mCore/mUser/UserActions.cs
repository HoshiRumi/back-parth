using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;

namespace eMiSide.BusinessLogic.Core.User
{
    public class UserActions
    {
        private static List<UserDto> _users = new();
        private static int _nextId = 1;

        public List<UserDto> GetAll() => _users;

        public UserDto? GetById(int id) =>
            _users.FirstOrDefault(u => u.Id == id);

        public UserDto? Create(UserData user)
        {
            if (_users.Any(u => u.Email == user.Email)) return null;
            var dto = new UserDto
            {
                Id = _nextId++,
                Email = user.Email,
                Username = user.Username
            };
            _users.Add(dto);
            return dto;
        }

        public bool Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;
            _users.Remove(user);
            return true;
        }

        public UserDto? Update(int id, UserData user)
        {
            var existing = _users.FirstOrDefault(u => u.Id == id);
            if (existing == null) return null;
            existing.Email = user.Email;
            existing.Username = user.Username;
            return existing;
        }
    }
}