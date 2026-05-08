using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.User
{
    public class UserFlow : IUserActions
    {
        public List<UserDto> GetAllUsersAction() => new();
        public UserDto? GetUserByIdAction(int id) => null;
        public UserDto? CreateUserAction(UserData user) => null;
        public bool DeleteUserAction(int id) => false;
        public UserDto? UpdateUserAction(int id, UserData user) => null;
    }
}