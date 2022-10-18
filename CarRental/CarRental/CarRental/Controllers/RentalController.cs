using CarRental.DAL;
using CarRental.Models;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarRental.Extentions;
using System.Collections.Generic;

namespace CarRental.Controllers
{
    public class RentalController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;

        public RentalController(AppDbContext context, UserManager<User> userManager, IConfiguration config)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
        }


        public async Task<IActionResult> Index(int id)
        {
            RentDetailVM rentDetail = new RentDetailVM();

            if (User.Identity.IsAuthenticated)
            {
                rentDetail.User = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            else
            {
                return RedirectToAction("login", "auth");
            }
            rentDetail.Car =await _context.Cars.Include(c => c.Brand).FirstOrDefaultAsync(c=>c.Id==id);

            return View(rentDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Rent(DateTime startDate, DateTime endDate, int carId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null) return View("Please login first");

            var car = await _context.Cars
                .Include(c => c.Brand)
                .Include(c => c.Color)
                .Include(c => c.CarImages)
                .FirstOrDefaultAsync(c => c.Id == carId);

            if (car == null) return NotFound();

            List<Rental> rental = await _context.Rentals.Where(r=>r.CarId==carId).ToListAsync();
            foreach (var item in rental)
            {
                if (item != null)
                {
                    var checkDate = startDate.InRange(item.RentDate, item.ReturnDate);
                    if (checkDate)
                    {
                        ModelState.AddModelError("Error", $"Car is reserved from {item.RentDate.ToString("MM/dd/yyyy")} till {item.ReturnDate.ToString("MM/dd/yyyy")}");
                        return View();
                    }
                }

            }
           

            Rental newRental = new Rental()
            {
                UserId = userId,
                CarId = carId,
                RentDate = startDate,
                ReturnDate = endDate,
                CreatedAt = DateTime.Now
            };

            await _context.AddAsync(newRental);
            await _context.SaveChangesAsync();

            return RedirectToAction("sendinvoice");
        }

        public IActionResult SuccessView()
        {
            return View();
        }

        public IActionResult SendInvoice(int? id)
        {
            return View();
        }
    }
}
