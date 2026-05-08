using eDomain.mEntities.mUser;
using eDomain.mModels.mUser;
using eMiSide.BusinessLogic.mInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserActions _userActions;
        public UserController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _userActions = bl.GetUserActions();
        }

        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            var users = _userActions.GetAllUsersAction();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userActions.GetUserByIdAction(id);
            if (user != null)
                return Ok(user);
            return NotFound(new { Message = $"User with ID {id} not found" });
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserData user)
        {
            var created = _userActions.CreateUserAction(user);
            if (created != null)
                return Created($"api/users/{created.Id}", created);
            return Conflict(new { Message = $"User with email {user.Email} already exists" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var wasDeleted = _userActions.DeleteUserAction(id);
            if (wasDeleted)
                return NoContent();
            return NotFound(new { Message = $"User with ID {id} not found" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserData user)
        {
            var updated = _userActions.UpdateUserAction(id, user);
            if (updated != null)
                return Ok(updated);
            return NotFound(new { Message = $"User with ID {id} not found" });
        }
    }
}