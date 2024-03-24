using Microsoft.AspNetCore.Mvc;

namespace Light_Control.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
