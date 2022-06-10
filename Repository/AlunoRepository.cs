using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class AlunoRepository : IAluno
    {
        public readonly DataContext _context;

        public AlunoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Aluno> Delete(int id)
        {
            var user = await _context.Alunos.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            _context.Alunos.Remove(user);
            return user;
        }

        public async Task<IEnumerable<Aluno>> Get()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<Aluno> Get(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<Aluno> Post(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
            return aluno;
        }

        public async Task<Aluno> Put(int id, Aluno aluno)
        {
            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return aluno;
        }
    }
}
