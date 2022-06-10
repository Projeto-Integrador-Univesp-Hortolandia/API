using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionario _funcionarioRepository;

        public FuncionarioController(IFuncionario funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Funcionario>> GetAll()
        {
            return await _funcionarioRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Funcionario> Get(int id)
        {
            return await _funcionarioRepository.Get(id);
        }

        [HttpPost]
        public async Task<Funcionario> Post([FromBody] Funcionario funcionario)
        {
            var newUser = await _funcionarioRepository.Post(funcionario);
            return newUser;
        }

        [HttpPut("{id}")]
        public async Task<Funcionario> Put(int id, [FromBody] Funcionario funcionario)
        {
            var updatedUser = await _funcionarioRepository.Put(id, funcionario);
            return updatedUser;
        }

        [HttpDelete("{id}")]
        public async Task<Funcionario> Delete(int id)
        {
            var deletedUser = await _funcionarioRepository.Delete(id);
            return deletedUser;
        }

    }
}
