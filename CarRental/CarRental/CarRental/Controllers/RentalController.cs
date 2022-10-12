using CarRental.DAL;
using CarRental.Helpers;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    public class RentalController : Controller
    {
        private readonly AppDbContext _context;

        public RentalController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            RentalVM rental = new RentalVM();

            rental.Cars = await _context.Cars
                .Where(c => c.isDeleted == false)
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color).ToListAsync();
            rental.PagedLists = PagedList<Car>.CreateAsync(rental.Cars, page, pageSize);

            return View(rental);
        }
    }
}
