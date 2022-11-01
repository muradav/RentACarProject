using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
