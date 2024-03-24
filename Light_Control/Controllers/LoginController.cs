using Microsoft.AspNetCore.Mvc;

namespace Light_Control.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
