using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcAds.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
