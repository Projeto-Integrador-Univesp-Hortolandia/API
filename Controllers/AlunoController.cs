using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAluno _alunoRepository;

        public AlunoController(IAluno alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Aluno>> GetAll()
        {
            return await _alunoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Aluno> Get(int id)
        {
            return await _alunoRepository.Get(id);
        }

        [HttpPost]
        public async Task<Aluno> Post(Aluno aluno)
        {
            return await _alunoRepository.Post(aluno);
        }

        [HttpPut("{id}")]
        public async Task<Aluno> Put(int id, Aluno aluno)
        {
            return await _alunoRepository.Put(id, aluno);
        }

        [HttpDelete("{id}")]
        public async Task<Aluno> Delete(int id)
        {
            return await _alunoRepository.Delete(id);
        }

    }
}
