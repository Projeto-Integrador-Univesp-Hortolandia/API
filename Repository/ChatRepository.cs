using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ChatRepository : IChatRepository
    {
        public DataContext _Context;

        public ChatRepository(DataContext context)
        {
            _Context = context;
        }

        public async Task<Chat> Create(Chat chat)
        {
            await _Context.Chat.AddAsync(chat);
            await _Context.SaveChangesAsync();
            return chat;
        }

        public async Task<Chat> Delete(int id)
        {
            var chat = await _Context.Chat.FindAsync(id);
            _Context.Chat.Remove(chat);
            return chat;
        }

        public async Task<IEnumerable<Chat>> GetAll()
        {
            return await _Context.Chat.ToListAsync();
        }

        public async  Task<Chat> GetById(int id)
        {
            return await _Context.Chat.FindAsync(id);
        }

        public async Task<Chat> Update(Chat chat)
        {
            _Context.Entry(chat).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
            return chat;
        }
    }
}
