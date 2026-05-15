using eMiSide.BusinessLogic.mInterfaces;
using eDomain.mModels.mUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/session")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        internal IAuthActions _auth;

        public AuthController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _auth = bl.GetAuthActions();
        }

        [HttpGet("status")]
        [AllowAnonymous]
        public IActionResult Get() => Ok("Session is active");

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserAuthAction data)
        {
            var token = _auth.LoginActionFlow(data);
            if (string.IsNullOrEmpty(token))
                return Unauthorized(new { Message = "Invalid email or password" });
            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody] UserAuthAction data)
        {
            var token = _auth.RegisterActionFlow(data);
            if (string.IsNullOrEmpty(token))
                return Conflict(new { Message = "Email is already in use" });
            return Ok(new { Token = token });
        }
    }
}