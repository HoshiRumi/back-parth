using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;

namespace eMiSide.BusinessLogic.mInterfaces
{
    public interface IUserActions
    {
        List<UserDto> GetAllUsersAction();
        UserDto? GetUserByIdAction(int id);
        UserDto? CreateUserAction(UserData user);
        bool DeleteUserAction(int id);
        UserDto? UpdateUserAction(int id, UserData user);
    }
}