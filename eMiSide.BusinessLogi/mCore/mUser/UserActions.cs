using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;
using eMiSide.DataAccess.Context;

namespace eMiSide.BusinessLogic.Core.User
{
    public class UserActions
    {
        public List<UserDto> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.Users.Select(u => new UserDto
                {
                    Id = u.Id,
                    Email = u.Email,
                    Username = u.Username
                }).ToList();
            }
        }

        public UserDto? GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                var u = db.Users.FirstOrDefault(u => u.Id == id);
                if (u == null) return null;
                return new UserDto
                {
                    Id = u.Id,
                    Email = u.Email,
                    Username = u.Username
                };
            }
        }

        public UserDto? Create(UserData user)
        {
            using (var db = new AppDbContext())
            {
                if (db.Users.Any(u => u.Email == user.Email)) return null;
                db.Users.Add(user);
                db.SaveChanges();
                return new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    Username = user.Username
                };
            }
        }

        public bool Delete(int id)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == id);
                if (user == null) return false;
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
        }

        public UserDto? Update(int id, UserData user)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.Users.FirstOrDefault(u => u.Id == id);
                if (existing == null) return null;
                existing.Email = user.Email;
                existing.Username = user.Username;
                db.SaveChanges();
                return new UserDto
                {
                    Id = existing.Id,
                    Email = existing.Email,
                    Username = existing.Username
                };
            }
        }
    }
}