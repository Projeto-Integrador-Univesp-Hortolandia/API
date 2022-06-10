using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class AdminstradorRepository : IAdministrador
    {
        public readonly DataContext _context;

        public AdminstradorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Administrador> Delete(int id)
        {
            var user = await _context.Adminstradores.FindAsync(id);
            if (user != null)
            {
                _context.Adminstradores.Remove(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }

        public async Task<IEnumerable<Administrador>> Get()
        {
            return await _context.Adminstradores.ToListAsync();
        }

        public async Task<Administrador> Get(int id)
        {
            return await _context.Adminstradores.FindAsync(id);
        }

        public async Task<Administrador> Post(Administrador administrador)
        {
            await _context.Adminstradores.AddAsync(administrador);
            await _context.SaveChangesAsync();
            return administrador;
        }

        public async Task<Administrador> Put(int id, Administrador administrador)
        {
            _context.Entry(administrador).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return administrador;
        }
    }
}
