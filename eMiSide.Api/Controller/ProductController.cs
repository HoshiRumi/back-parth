using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    public class ProductController : Controller
    {
        private IActionResult Index()
        {
            return View();
        }
    }
}
