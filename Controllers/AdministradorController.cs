using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        private readonly IAdministrador _administradorRepository;

        public AdministradorController(IAdministrador administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Administrador>> GetUsuario()
        {
            return await _administradorRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<Administrador> GetUsuario(int id)
        {
            var usuario = await _administradorRepository.Get(id);

            if (usuario == null)
            {
                return null;
            }

            return usuario;
        }

        [HttpPost]
        public async Task<Administrador> PostUsuario([FromBody] Administrador usuario)
        {
            var newUsuario = await _administradorRepository.Post(usuario);
            return newUsuario;
        }

        [HttpPut("{id}")]
        public async Task<Administrador> PutUsuario(int id, [FromBody] Administrador usuario)
        {
            var newUsuario = await _administradorRepository.Put(id, usuario);
            return newUsuario;
        }

        [HttpDelete("{id}")]
        public async Task<Administrador> DeleteUsuario(int id)
        {
            var usuario = await _administradorRepository.Delete(id);
            return usuario;
        }
    }
}
