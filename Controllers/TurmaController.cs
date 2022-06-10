using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurma _turmaRepository;

        public TurmaController(ITurma turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Turma>> GetAll()
        {
            return await _turmaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Turma> Get(int id)
        {
            return await _turmaRepository.Get(id);
        }

        [HttpPost]
        public async Task<Turma> Post(Turma turma)
        {
            return await _turmaRepository.Post(turma);
        }

        [HttpPut("{id}")]
        public async Task<Turma> Put(int id, Turma turma)
        {
            return await _turmaRepository.Put(id, turma);
        }

        [HttpDelete("{id}")]
        public async Task<Turma> Delete(int id)
        {
            return await _turmaRepository.Delete(id);
        }

    }
}
