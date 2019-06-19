using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}