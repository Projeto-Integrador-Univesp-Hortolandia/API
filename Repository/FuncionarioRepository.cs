using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class FuncionarioRepository : IFuncionario
    {
        public readonly DataContext _context;
        public FuncionarioRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Funcionario> Delete(int id)
        {
            var user = await _context.Funcionarios.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            _context.Funcionarios.Remove(user);
            return user;
        }

        public async Task<IEnumerable<Funcionario>> Get()
        {
            return await _context.Funcionarios.ToListAsync();
        }

        public async Task<Funcionario> Get(int id)
        {
            return await _context.Funcionarios.FindAsync(id);
        }

        public async Task<Funcionario> Post(Funcionario funcionario)
        {
            await _context.Funcionarios.AddAsync(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }

        public async Task<Funcionario> Put(int id, Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return funcionario;
        }
    }

}
