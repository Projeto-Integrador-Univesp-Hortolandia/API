using API.Models;

namespace API.Repository
{
    public interface IAluno
    {
        Task<IEnumerable<Aluno>> Get();
        Task<Aluno> Get(int id);
        Task<Aluno> Post(Aluno aluno);
        Task<Aluno> Put(int id, Aluno aluno);
        Task<Aluno> Delete(int id);

    }
}
