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
    public class CarController : Controller
    {

        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            CarVM car = new CarVM();

            car.Cars = await _context.Cars
                .Where(c => c.isDeleted == false)
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color).ToListAsync();
            car.PagedLists = PagedList<Car>.CreateAsync(car.Cars, page, pageSize);

            return View(car);
        }
    }
}
