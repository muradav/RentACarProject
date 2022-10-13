using CarRental.DAL;
using CarRental.Helpers;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRental.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    public class ElectricController : Controller
    {
        private readonly AppDbContext _context;

        public ElectricController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            ElectricVM electric = new ElectricVM();


            electric.Cars = await _context.Cars
                .Where(c => c.FuelType == "Elektrik")
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color).ToListAsync();
            electric.PagedLists = PagedList<Car>.CreateAsync(electric.Cars, page, pageSize);

            return View(electric);
        }
    }
}
