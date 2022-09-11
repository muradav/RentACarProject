using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.CarDtos;
using RentACarProject.Entity;
using System.Collections.Generic;
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

        public CarsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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


    }
}
