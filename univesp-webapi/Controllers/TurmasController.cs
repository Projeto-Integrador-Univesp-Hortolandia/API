using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Data.DTO.Turmas;
using univesp_webapi.Handle;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasController : ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;

        public TurmasController(DataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Turmas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turma>>> GetTurmas()
        {
          if (_context.Turmas == null)
          {
              return NotFound();
          }
            var turmas = await _context.Turmas.ToListAsync();
            return turmas;
        }

        // GET: api/Turmas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetTurmaDTO>> GetTurma(int id)
        {
            var alunos = await _context.Alunos.Where(a => a.Turma == id).ToListAsync();            
            var turma = await _context.Turmas.FindAsync(id);            
            var Turma = _mapper.Map(turma,new GetTurmaDTO());
            var resultTurma = new GetTurmaDTO
            {
                Nome = Turma.Nome,
                turma = Turma.turma,
                Ano = Turma.Ano,
                Periodo = Turma.Periodo,
                Sala = Turma.Sala,
                ProfessorId = Turma.ProfessorId,
                STATUS = Turma.STATUS,
                Alunos = alunos,
            };            

            return resultTurma;
        }
        // PUT: api/Turmas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurma(int id, Turma turma)
        {
            if (id != turma.Id)
            {
                return BadRequest();
            }

            _context.Entry(turma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurmaExists(id))
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

        // POST: api/Turmas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Turma>> PostTurma(Turma turma)
        {
          if (_context.Turmas == null)
          {
              return Problem("Entity set 'DataBaseContext.Turmas'  is null.");
          }
            _context.Turmas.Add(turma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurma", new { id = turma.Id }, turma);
        }

        // DELETE: api/Turmas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurma(int id)
        {
            if (_context.Turmas == null)
            {
                return NotFound();
            }
            var turma = await _context.Turmas.FindAsync(id);
            if (turma == null)
            {
                return NotFound();
            }

            _context.Turmas.Remove(turma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurmaExists(int id)
        {
            return (_context.Turmas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
