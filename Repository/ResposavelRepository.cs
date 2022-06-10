using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ResposavelRepository : IResponsavel
    {
        public readonly DataContext _context;

        public ResposavelRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Responsavel> Delete(int id)
        {
            var user = await _context.Responsaveis.FindAsync(id);
            if(user == null)
            {
                return null;
            }
            _context.Responsaveis.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<IEnumerable<Responsavel>> Get()
        {
            return await _context.Responsaveis.ToListAsync();
        }

        public async Task<Responsavel> Get(int id)
        {
            return await _context.Responsaveis.FindAsync(id);
        }

        public async Task<Responsavel> Post(Responsavel responsavel)
        {
            await _context.Responsaveis.AddAsync(responsavel);
            await _context.SaveChangesAsync();
            return responsavel;
        }

        public async Task<Responsavel> Put(int id, Responsavel responsavel)
        {
            _context.Entry(responsavel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return responsavel;
        }
    }
}
