using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return RedirectToAction("login","auth");
        }
    }
}
