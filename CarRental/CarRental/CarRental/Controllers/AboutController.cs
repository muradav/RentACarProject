using CarRental.DAL;
using CarRental.Models;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutVM about = new AboutVM();

            about.Teams = await _context.Teams.ToListAsync();
            about.Abouts =await _context.About.ToListAsync();

            return View(about);
        }
    }
}
