using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult Get()
        {
            return Ok("Healthy");
        }
    }
}