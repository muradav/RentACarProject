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

        [HttpPost("create")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] CarCreateDto carCreateDto)
        {
            bool existCategory = _context.Cars.Any(c => c.Name.ToLower() == carCreateDto.Name.ToLower());
            if (existCategory)
            {
                return StatusCode(409);
            }
            foreach (var item in carCreateDto.Photos)
            {
                if (!item.IsImage())
                {
                    return BadRequest();
                }
                if (item.ValidSize(2000))
                {
                    return BadRequest();
                }
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

            foreach (var item in carCreateDto.Photos)
            {
                CarImage newcarImage = new CarImage();
                newcarImage.ImageUrl = item.SaveImage(_env, "assets/img/car");
                newcarImage.CarId = newCar.Id;
                //if (item == carCreateDto.Photos[0])
                //{
                //    newCarImage.IsMain = true;
                //}


                await _context.AddAsync(newcarImage);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpPut("update/{id}")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, [FromForm] CarUpdateDto carUpdateDto)
        {
            Car c = _context.Cars
                .Include(c => c.Color)
                .Include(c => c.Brand)
                .Include(c => c.CarImages).FirstOrDefault(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            if (_context.Cars.Any(c => c.Name.ToLower() == carUpdateDto.Name.ToLower() && c.Id != id))
            {
                return BadRequest();
            }
            if (carUpdateDto.Photos != null)
            {
                foreach (var item in carUpdateDto.Photos)
                {
                    if (!item.IsImage())
                    {
                        return BadRequest();
                    }
                    if (item.ValidSize(2000))
                    {
                        return BadRequest();
                    }

                    CarImage newcarImage = new CarImage();
                    newcarImage.ImageUrl = item.SaveImage(_env, "assets/img/car");
                    newcarImage.CarId = c.Id;

                    await _context.AddAsync(newcarImage);
                    await _context.SaveChangesAsync();
                }
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
            CarReturnDto carReturnDto = _mapper.Map<CarReturnDto>(c);
            return StatusCode(200, carReturnDto);
        }

        [HttpDelete("deleteImage/{id}")]
        public async Task<IActionResult> RemoveCarImage(int id)
        {
            var image = await _context.CarImages.FindAsync(id);

            string path = Path.Combine(_env.WebRootPath, "assets/img/car", image.ImageUrl);
            path.DeleteImage();
            _context.CarImages.Remove(image);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Car c = await _context.Cars.Include(c=>c.CarImages).FirstOrDefaultAsync(c=>c.Id==id);
            List<CarImage> carImages= new List<CarImage>();

            foreach (var item in c.CarImages)
            {
                string path = Path.Combine(_env.WebRootPath, "assets/img/car", item.ImageUrl);
                path.DeleteImage();
                carImages.Add(item);
            }
            _context.CarImages.RemoveRange(carImages);
            _context.Cars.Remove(c);
            await _context.SaveChangesAsync();
            return Ok($"Car {c.Name} Deleted Successfully.");
        }
    }
}
