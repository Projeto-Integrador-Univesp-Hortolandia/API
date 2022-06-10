using API.Models;

namespace API.Repository
{
    public interface IFuncionario
    {
        Task<IEnumerable<Funcionario>> Get();
        Task<Funcionario> Get(int id);
        Task<Funcionario> Post(Funcionario funcionario);
        Task<Funcionario> Put(int id, Funcionario funcionario);
        Task<Funcionario> Delete(int id);

    }
}
