using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.RentalDtos;
using RentACarProject.Entities;
using RentACarProject.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentACarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;



        public RentalsController(AppDbContext context, IMapper mapper, UserManager<User> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            Rental r = await _context.Rentals
                .Where(r => r.isDeleted == false)
                .Include(r => r.User)
                .Include(r => r.Car)
                .ThenInclude(c=>c.Brand)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (r == null) return NotFound();

            RentalReturnDto rentalReturnDto = _mapper.Map<RentalReturnDto>(r);

            return Ok(rentalReturnDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = _context.Rentals
                .Where(r => r.isDeleted == false)
                .Include(r => r.User)
                .Include(r => r.Car)
                .ThenInclude(c => c.Brand);

            RentalListDto rentalListDto = new RentalListDto();

            rentalListDto.Items = _mapper.Map<List<RentalReturnDto>>(await query.ToListAsync());
            rentalListDto.TotalCount =await query.CountAsync();

            return Ok(rentalListDto);
        }

        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> Create(int id, [FromForm] RentalCreateDto rentalCreateDto)
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null) return Ok("Please login first");

            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);

            if (car == null) return NotFound();

            var rental = await _context.Rentals.FirstOrDefaultAsync(r => r.CarId == id);

            if (rental!=null)
            {
                var checkDate = rentalCreateDto.RentDate.InRange(rental.RentDate, rental.ReturnDate);
                if (checkDate)
                {
                    return Ok($"Car is reserved from {rental.RentDate.ToString("MM/dd/yyyy")} till {rental.ReturnDate.ToString("MM/dd/yyyy")}");
                }
            }

            Rental newRental = new Rental()
            {
                UserId = userId,
                CarId = id,
                RentDate = rentalCreateDto.RentDate,
                ReturnDate = rentalCreateDto.ReturnDate
            };

            await _context.AddAsync(newRental);
            await _context.SaveChangesAsync();

            return Ok(newRental);
        }
    }
}
