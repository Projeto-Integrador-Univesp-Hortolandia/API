using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Data.DTO.Responsavel;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsavelsController : ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;

        public ResponsavelsController(DataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Responsavels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Responsavel>>> GetResponsavels()
        {
          if (_context.Responsavels == null)
          {
              return NotFound();
          }
            return await _context.Responsavels.ToListAsync();
        }

        // GET: api/Responsavels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetResponsavelDTO>> GetResponsavel(int id)
        {
            var alunos = await _context.Alunos.Where(a => a.ResponsavelId == id).ToListAsync();
            var responsavel = await _context.Responsavels.FindAsync(id);
            var Responsavel = _mapper.Map(responsavel, new GetResponsavelDTO());
            var resultResponsavel = new GetResponsavelDTO
            {
                Nome = Responsavel.Nome,
                cpf = Responsavel.cpf,
                DataNascimento = Responsavel.DataNascimento,
                Observacao = responsavel.Observacao,
                Foto = Responsavel.Foto,
                Alunos = alunos
            };

            return resultResponsavel;
        }

        // PUT: api/Responsavels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponsavel(int id, Responsavel responsavel)
        {
            if (id != responsavel.Id)
            {
                return BadRequest();
            }

            _context.Entry(responsavel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponsavelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Responsavels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Responsavel>> PostResponsavel(Responsavel responsavel)
        {
          if (_context.Responsavels == null)
          {
              return Problem("Entity set 'DataBaseContext.Responsavels'  is null.");
          }
            _context.Responsavels.Add(responsavel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponsavel", new { id = responsavel.Id }, responsavel);
        }

        // DELETE: api/Responsavels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponsavel(int id)
        {
            if (_context.Responsavels == null)
            {
                return NotFound();
            }
            var responsavel = await _context.Responsavels.FindAsync(id);
            if (responsavel == null)
            {
                return NotFound();
            }

            _context.Responsavels.Remove(responsavel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResponsavelExists(int id)
        {
            return (_context.Responsavels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
