using Microsoft.AspNetCore.Mvc;

namespace WebPageLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
