using API.Models;

namespace API.Repository
{
    public interface ITurma
    {
        Task<IEnumerable<Turma>> Get();
        Task<Turma> Get(int id);
        Task<Turma> Post(Turma turma);
        Task<Turma> Put(int id, Turma turma);
        Task<Turma> Delete(int id);
        
    }
}
