using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.BrandDtos;
using RentACarProject.Entities;
using RentACarProject.Extentions;
using System;
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
        private readonly IWebHostEnvironment _env;

        public BrandsController(AppDbContext context, IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
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

        [HttpPost]
        public IActionResult Create([FromForm] BrandCreateDto brandCreateDto)
        {
            bool existCategory = _context.Brands.Any(c => c.Name.ToLower() == brandCreateDto.Name.ToLower());
            if (existCategory)
            {
                return StatusCode(409);
            }
            if (!brandCreateDto.Photo.IsImage())
            {
                return BadRequest();
            }
            if (brandCreateDto.Photo.ValidSize(2000))
            {
                return BadRequest();
            }

            Brand newBrand = new Brand();
            newBrand.Name = brandCreateDto.Name;
            newBrand.CreatedAt = DateTime.Now;
            newBrand.ImageUrl = brandCreateDto.Photo.SaveImage(_env, "assets/img/brand");

            _context.Add(newBrand);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
