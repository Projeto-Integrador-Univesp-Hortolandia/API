using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsavelController : ControllerBase
    {
        private readonly IResponsavel _responsavelRepository;

        public ResponsavelController(IResponsavel responsavelRepository)
        {
            _responsavelRepository = responsavelRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Responsavel>> GetAll()
        {
            return await _responsavelRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Responsavel> Get(int id)
        {
            return await _responsavelRepository.Get(id);
        }

        [HttpPost]
        public async Task<Responsavel> Post(Responsavel responsavel)
        {
            return await _responsavelRepository.Post(responsavel);
        }

        [HttpPut("{id}")]
        public async Task<Responsavel> Put(int id, Responsavel responsavel)
        {
            return await _responsavelRepository.Put(id, responsavel);
        }

        [HttpDelete("{id}")]
        public async Task<Responsavel> Delete(int id)
        {
            return await _responsavelRepository.Delete(id);
        }
    }
}
