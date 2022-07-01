using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public AlunoesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Alunoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunos()
        {
          if (_context.Alunos == null)
          {
              return NotFound();
          }
            return await _context.Alunos.ToListAsync();
        }

        // GET: api/Alunoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
          if (_context.Alunos == null)
          {
              return NotFound();
          }
            var aluno = await _context.Alunos.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return aluno;
        }

        // PUT: api/Alunoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAluno(int id, Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return BadRequest();
            }

            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoExists(id))
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

        // POST: api/Alunoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(int turmaid, Aluno aluno)
        {
            var turmaAluno = await _context.Turmas.FindAsync(turmaid);
            if (_context.Alunos == null)
          {
              return Problem("Entity set 'DataBaseContext.Alunos'  is null.");
          }
            var newAluno = new Aluno
            {
                Nome = aluno.Nome,
                cpf = aluno.cpf,
                DataNascimento = aluno.DataNascimento,
                Observacoes = aluno.Observacoes,
                Foto = aluno.Foto,
                ResponsavelId = aluno.ResponsavelId,
                STATUS = 0,
                Turma = aluno.Turma,
                
            };
            _context.Alunos.Add(newAluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAluno", new { id = aluno.Id }, aluno);
        }

        // DELETE: api/Alunoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            if (_context.Alunos == null)
            {
                return NotFound();
            }
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunoExists(int id)
        {
            return (_context.Alunos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
