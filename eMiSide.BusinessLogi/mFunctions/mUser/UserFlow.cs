using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;
using eMiSide.BusinessLogic.Core.User;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.User
{
    public class UserFlow : IUserActions
    {
        private readonly UserActions _actions = new();
        public List<UserDto> GetAllUsersAction() => _actions.GetAll();
        public UserDto? GetUserByIdAction(int id) => _actions.GetById(id);
        public UserDto? CreateUserAction(UserData user) => _actions.Create(user);
        public bool DeleteUserAction(int id) => _actions.Delete(id);
        public UserDto? UpdateUserAction(int id, UserData user) => _actions.Update(id, user);
    }
}