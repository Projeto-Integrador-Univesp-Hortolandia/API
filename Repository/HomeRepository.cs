using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class HomeRepository : IHomeRepository
    {
        public readonly DataContext _context;

        public HomeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Feed> Create(int funcionarioid, Feed feed)
        {
            var funcionario = await _context.Funcionarios.FindAsync(funcionarioid);
            if(funcionario.Status == 1)
            {
                await _context.Feed.AddAsync(feed);
                await _context.SaveChangesAsync();
                return feed;
            }
            return feed;
            
        }

        public async Task<Feed> Delete(int id, int funcionarioId)
        {
            var funcionario = await _context.Funcionarios.FindAsync(funcionarioId);
            var feed = await _context.Feed.FindAsync(funcionarioId);
            if(funcionario.Status == 1)
            {
                _context.Feed.Remove(feed);
                await _context.SaveChangesAsync();
                return feed;
            }
            return feed;
        }

        public async Task<IEnumerable<Feed>> GetAll()
        {
            return await _context.Feed.ToListAsync();
        }

        public async Task<Feed> GetById(int id)
        {
            return await _context.Feed.FindAsync(id);
        }

        public async Task<Feed> Update(Feed feed, int funcionarioId)
        {
            var funcionario = await _context.Funcionarios.FindAsync(funcionarioId);
            if(funcionario.Status == 1)
            {
                _context.Entry(feed).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return feed;
            }
            return feed;
        }
    }
}
