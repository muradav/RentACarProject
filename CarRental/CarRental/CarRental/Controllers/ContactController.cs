using CarRental.DAL;
using CarRental.Models;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            Bio bio = _context.Bios.FirstOrDefault();

            return View(await Task.FromResult(bio));
        }
    }
}
