using API.Models;

namespace API.Repository
{
    public interface IAdministrador
    {
        Task<IEnumerable<Administrador>> Get();
        Task<Administrador> Get(int id);
        Task<Administrador> Post(Administrador administrador);
        Task<Administrador> Put(int id, Administrador administrador);
        Task<Administrador> Delete(int id);
        
    }
}
