using API.Models;

namespace API.Repository
{
    public interface IResponsavel
    {
        Task<IEnumerable<Responsavel>> Get();
        Task<Responsavel> Get(int id);
        Task<Responsavel> Post(Responsavel responsavel);
        Task<Responsavel> Put(int id, Responsavel responsavel);
        Task<Responsavel> Delete(int id);
        
    }
}
