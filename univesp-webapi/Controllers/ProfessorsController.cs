using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Data.DTO.Professores;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;

        public ProfessorsController(DataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Professors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessores()
        {
          if (_context.Professores == null)
          {
              return NotFound();
          }
            return await _context.Professores.ToListAsync();
        }

        // GET: api/Professors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetprofessoresDTO>> GetProfessor(int id)
        {
            var turma = await _context.Turmas.Where(a => a.ProfessorId == id).ToListAsync();
            var professor = await _context.Professores.FindAsync(id);
            var Professor = _mapper.Map(professor, new GetprofessoresDTO());
            var resultProfessor = new GetprofessoresDTO
            {
                Nome = Professor.Nome,
                cpf = Professor.cpf,
                DataNasc = Professor.DataNasc,
                Registro = Professor.Registro,
                Email = Professor.Email,
                Foto = Professor.Foto,
                STATUS = Professor.STATUS,
                IsAdmin = 1,
                Turmas = turma,
            };

            return resultProfessor;
        }

        // PUT: api/Professors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessor(int id, Professor professor)
        {
            if (id != professor.Id)
            {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(id))
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

        // POST: api/Professors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Professor>> PostProfessor(Professor professor)
        {
            var turma = await _context.Turmas.FindAsync(professor.Id);
            if (_context.Professores == null)
          {
              return Problem("Entity set 'DataBaseContext.Professores'  is null.");
          }
            var prof = new Professor();
            prof.Nome = professor.Nome;
            prof.Email = professor.Email;
            prof.cpf = professor.cpf;
            prof.Senha = professor.Senha;
            prof.Foto = professor.Foto;
            prof.STATUS = professor.STATUS;
            prof.IsAdmin = 1;
            

            _context.Professores.Add(prof);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessor", new { id = professor.Id }, professor);
        }

        // DELETE: api/Professors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int id)
        {
            if (_context.Professores == null)
            {
                return NotFound();
            }
            var professor = await _context.Professores.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            _context.Professores.Remove(professor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessorExists(int id)
        {
            return (_context.Professores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
