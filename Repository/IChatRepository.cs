using API.Models;

namespace API.Repository
{
    public interface IChatRepository
    {
        Task<IEnumerable<Chat>> GetAll();
        Task<Chat> GetById(int id);
        Task<Chat> Create(Chat chat);
        Task<Chat> Update(Chat chat);
        Task<Chat> Delete(int id);
    }
}
