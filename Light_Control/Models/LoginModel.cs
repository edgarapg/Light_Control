using Microsoft.AspNetCore.Mvc;

namespace Light_Control.Models
{
    public class LoginModel : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
