using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class TurmaRepository : ITurma
    {
        public readonly DataContext _context;

        public TurmaRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Turma> Delete(int id, int funcionarioId)
        {
            var user = await _context.Funcionarios.FindAsync(id);
            var turma = await _context.Turmas.FindAsync(id);
            if (user.Status == 1)            {
                
                _context.Turmas.Remove(turma);
                await _context.SaveChangesAsync();
            }
            return turma;
        }

        public async Task<IEnumerable<Turma>> Get()
        {
            return await _context.Turmas.ToListAsync();
        }

        public async Task<Turma> Get(int id)
        {
            return await _context.Turmas.FindAsync(id);
        }

        public async  Task<Turma> Post(Turma turma)
        {
            await _context.Turmas.AddAsync(turma);
            await _context.SaveChangesAsync();
            return turma;
        }

        public async  Task<Turma> Put(int id, Turma turma)
        {
            _context.Entry(turma).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return turma;
        }
    }
}
