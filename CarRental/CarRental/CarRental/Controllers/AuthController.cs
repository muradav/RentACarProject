using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
