using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet(template: "ping")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}