using eMiSide.BusinessLogic.mInterfaces;
using eDomain.mModels.mUser;
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
        public IActionResult Get() => Ok("Session is active");

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserAuthAction data)
        {
            var token = _auth.LoginActionFlow(data);
            return Ok(token);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserAuthAction data)
        {
            var token = _auth.RegisterActionFlow(data);
            return Ok(token);
        }
    }
}