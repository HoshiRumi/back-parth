using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    public class AuthController : Controller
    {
        private IActionResult Index()
        {
            return View();
        }
    }
}
