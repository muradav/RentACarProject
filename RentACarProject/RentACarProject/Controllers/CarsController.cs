using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Entities;
using RentACarProject.Extentions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public CarsController(AppDbContext context, IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            Car c = await _context.Cars
                .Where(c => c.isDeleted == false)
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color)
               .FirstOrDefaultAsync(c => c.Id == id);
            if (c == null) return NotFound();

            CarReturnDto carReturnDto = _mapper.Map<CarReturnDto>(c);

            return Ok(carReturnDto);

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = _context.Cars
                .Where(c => c.isDeleted == false)
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color);

            CarListDto carListDto = new CarListDto();

            //carListDto.Items = _mapper.Map(query.ToList(),typeof(CarReturnDto),typeof(List<CarListDto>));
            carListDto.Items = _mapper.Map<List<CarReturnDto>>(query.ToList());

            //carListDto.Items = query.Select(c => new CarReturnDto
            //{
            //    Name = c.Name,
            //    ModelYear = c.ModelYear,
            //    DailyPrice=c.DailyPrice,
            //    FuelType=c.FuelType,
            //    TransmissionType=c.TransmissionType,
            //    PassengerCount=c.PassengerCount,
            //}).ToList();
            carListDto.TotalCount = query.Count();


            return Ok(carListDto);
        }

        [HttpPost]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] CarCreateDto carCreateDto)
        {
            bool existCategory = _context.Cars.Any(c => c.Name.ToLower() == carCreateDto.Name.ToLower());
            if (existCategory)
            {
                return StatusCode(409);
            }
            if (!carCreateDto.Photo.IsImage())
            {
                return BadRequest();
            }
            if (carCreateDto.Photo.ValidSize(2000))
            {
                return BadRequest();
            }

            Car newCar = new Car();
            
            newCar.Name = carCreateDto.Name;
            newCar.ModelYear = carCreateDto.ModelYear;
            newCar.DailyPrice = carCreateDto.DailyPrice;
            newCar.FuelType = carCreateDto.FuelType;
            newCar.TransmissionType = carCreateDto.TransmissionType;
            newCar.PassengerCount = carCreateDto.PassengerCount;
            newCar.BrandId = carCreateDto.BrandId;
            newCar.ColorId = carCreateDto.ColorId;
            newCar.CreatedAt = DateTime.Now;

            await _context.AddAsync(newCar);
            await _context.SaveChangesAsync();

            CarImage newcarImage = new CarImage();
            newcarImage.ImageUrl = carCreateDto.Photo.SaveImage(_env, "assets/img/car");
            newcarImage.CarId = newCar.Id;


            await _context.AddAsync(newcarImage);
            
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] CarUpdateDto carUpdateDto)
        {
            Car c = _context.Cars.Include(c=>c.CarImages).FirstOrDefault(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            if (_context.Cars.Any(c => c.Name.ToLower() == carUpdateDto.Name.ToLower() && c.Id != id))
            {
                return BadRequest();
            }

            CarImage newcarImage = new CarImage();

            var carimage = await _context.CarImages.FirstOrDefaultAsync(i => i.CarId == id);

            if (carUpdateDto != null)
            {
                string path = Path.Combine(_env.WebRootPath, "assets/img/car", carimage.ImageUrl);
                path.DeleteImage();
                newcarImage.ImageUrl = carUpdateDto.Photo.SaveImage(_env, "assets/img/car");
                newcarImage.CarId = c.Id;

                await _context.AddAsync(newcarImage);
                await _context.SaveChangesAsync();
            }

            c.Name = carUpdateDto.Name;
            c.ModelYear = carUpdateDto.ModelYear;
            c.DailyPrice = carUpdateDto.DailyPrice;
            c.FuelType = carUpdateDto.FuelType;
            c.TransmissionType = carUpdateDto.TransmissionType;
            c.PassengerCount = carUpdateDto.PassengerCount;
            c.ColorId = carUpdateDto.ColorId;
            c.BrandId = carUpdateDto.BrandId;

            await _context.SaveChangesAsync();
            return StatusCode(200, carUpdateDto);
        }
    }
}
