using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.BrandDtos;
using RentACarProject.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BrandsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            Brand b = await _context.Brands
                .Where(b => b.isDeleted == false)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (b == null) return NotFound();

            BrandReturnDto brandReturnDto = _mapper.Map<BrandReturnDto>(b);

            return Ok(brandReturnDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = _context.Brands.Where(b => b.isDeleted == false);

            BrandListDto brandListDto = new BrandListDto();

            brandListDto.Items = _mapper.Map<List<BrandReturnDto>>(query.ToList());
            brandListDto.TotalCount = query.Count();

            return Ok(brandListDto);
        }
    }
}
