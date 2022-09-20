using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Data;
using RentACarProject.Dtos.ColorDtos;
using RentACarProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ColorsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            Color c = await _context.Colors
                .Where(c => c.isDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (c == null) return NotFound();

            ColorReturnDto colorReturnDto = _mapper.Map<ColorReturnDto>(c);

            return Ok(colorReturnDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = _context.Colors.Where(c=>c.isDeleted==false);

            ColorListDto colorListDto = new ColorListDto();

            colorListDto.Items = _mapper.Map<List<ColorReturnDto>>(await query.ToListAsync());
            colorListDto.TotalCount = query.Count();

            return Ok(colorListDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ColorCreateDto colorCreateDto)
        {
            bool existCategory = _context.Colors.Any(c => c.Name.ToLower() == colorCreateDto.Name.ToLower());
            if (existCategory)
            {
                return StatusCode(409);
            }

            Color newColor = new Color();
            newColor.Name = colorCreateDto.Name;

            await _context.AddAsync(newColor);
            await _context.SaveChangesAsync();

            return Ok(newColor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ColorUpdateDto colorUpdateDto)
        {
            Color c = _context.Colors.Where(c => c.isDeleted==false).FirstOrDefault(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            if (_context.Colors.Any(c => c.Name.ToLower() == colorUpdateDto.Name.ToLower() && c.Id != id))
            {
                return BadRequest();
            }

            c.Name = colorUpdateDto.Name;

            await _context.SaveChangesAsync();
            return StatusCode(200, colorUpdateDto);
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Color c = _context.Colors.Where(c => c.isDeleted==false).FirstOrDefault(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }


            c.isDeleted = true;
            c.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok($"Color {c.Name} Deleted Successfully.");
        }

        [HttpPatch("backup/{id}")]
        public async Task<IActionResult> Return(int id)
        {
            Color c = _context.Colors.Where(c => c.isDeleted==true).FirstOrDefault(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }

            c.isDeleted = false;
            c.CreatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok($"Color {c.Name} is Created Again Successfully.");
        }

        [HttpGet("deletedcolors")]
        public async Task<IActionResult> GetAllDeleted()
        {
            var query = _context.Colors.Where(c => c.isDeleted == true);

            ColorListDto colorListDto = new ColorListDto();

            colorListDto.Items = _mapper.Map<List<ColorReturnDto>>(await query.ToListAsync());
            colorListDto.TotalCount = query.Count();

            return Ok(colorListDto);
        }
    }
}
