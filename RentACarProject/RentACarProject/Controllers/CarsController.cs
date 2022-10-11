using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Dtos.CarImageDtos;
using RentACarProject.Entities;
using RentACarProject.Services;
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
            carListDto.Items = _mapper.Map<List<CarReturnDto>>(await query.ToListAsync());

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

        [HttpGet("deletedCars")]
        public async Task<IActionResult> GetAllDeleted()
        {
            var query = _context.Cars
                .Where(c => c.isDeleted == true)
                .Include(c => c.Brand)
                .Include(c => c.CarImages)
                .Include(c => c.Color);

            CarListDto carListDto = new CarListDto();

            //carListDto.Items = _mapper.Map(query.ToList(),typeof(CarReturnDto),typeof(List<CarListDto>));
            carListDto.Items = _mapper.Map<List<CarReturnDto>>(await query.ToListAsync());

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
            bool existCar = _context.Cars.Any(c => c.Name.ToLower() == carCreateDto.Name.ToLower());
            if (existCar)
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
                if (item == carCreateDto.Photos[0])
                {
                    newcarImage.IsMain = true;
                }


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
                .Where(c => c.isDeleted==false)
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
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveCarImage(int id)
        {
            var image = await _context.CarImages.Where(i=>i.isDeleted==false).FirstOrDefaultAsync(i => i.Id==id);

            if (image == null) return NotFound();

            //string path = Path.Combine(_env.WebRootPath, "assets/img/car", image.ImageUrl);
            //path.DeleteImage();
            //_context.CarImages.Remove(image);
            image.isDeleted = true;
            image.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPatch("backUpImage/{id}")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ReturnCarImage(int id)
        {
            var image = await _context.CarImages.Where(i => i.isDeleted == true).FirstOrDefaultAsync(i => i.Id == id);

            if (image == null) return NotFound();

            image.isDeleted = true;
            image.CreatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("deletedImages")]
        public async Task<IActionResult> GetAllDeletedCars()
        {
            var query = _context.CarImages.Where(b => b.isDeleted == true);

            CarImageListDto carImageListDto = new CarImageListDto();

            carImageListDto.Items = _mapper.Map<List<CarImageReturnDto>>(await query.ToListAsync());
            carImageListDto.TotalCount = query.Count();

            return Ok(carImageListDto);
        }

        [HttpDelete("delete/{id}")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            Car c = await _context.Cars.Where(c => c.isDeleted==false).Include(c=>c.CarImages).FirstOrDefaultAsync(c=>c.Id==id);

            if (c == null) return NotFound();

            List<CarImage> carImages= new List<CarImage>();

            foreach (var item in c.CarImages)
            {
                item.isDeleted = true;
            }
            //_context.CarImages.RemoveRange(carImages);
            //_context.Cars.Remove(c);
            c.isDeleted = true;
            await _context.SaveChangesAsync();
            return Ok($"Car {c.Name} Deleted Successfully.");
        }

        [HttpPatch("backup/{id}")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Return(int id)
        {
            Car c = await _context.Cars.Where(c => c.isDeleted==true).Include(c => c.CarImages).FirstOrDefaultAsync(c => c.Id == id);

            if (c == null) return NotFound();

            List<CarImage> carImages = new List<CarImage>();

            foreach (var item in c.CarImages)
            {
                item.isDeleted = false;
            }
            //_context.CarImages.RemoveRange(carImages);
            //_context.Cars.Remove(c);
            c.isDeleted = false;
            await _context.SaveChangesAsync();
            return Ok($"Car {c.Name} is Created Again Successfully.");
        }

        [HttpPut("updateIsMain")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeIsMain(int carId,int id)
        {
            Car c = await _context.Cars.Include(c => c.CarImages).FirstOrDefaultAsync(c=>c.Id==carId);

            if (c == null) return NotFound();

            var oldMain= c.CarImages.FirstOrDefault(i => i.IsMain);
            var newMain = c.CarImages.FirstOrDefault(i => i.Id == id);
            if (oldMain == newMain)
            {
                return BadRequest("This image already is main");
            }
            oldMain.IsMain = false;
            newMain.IsMain = true;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
