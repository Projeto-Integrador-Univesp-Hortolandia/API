using API.Models;

namespace API.Repository
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Feed>> GetAll();
        Task<Feed> GetById(int id);
        Task<Feed> Update(Feed feed, int funcionarioId);
        Task<Feed> Create(int funcionarioId, Feed feed);
        Task<Feed> Delete(int id, int funcionarioId);
    }
}
