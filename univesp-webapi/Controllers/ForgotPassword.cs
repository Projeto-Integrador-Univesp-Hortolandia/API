using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPassword : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ForgotPassword(DataBaseContext context)
        {
            _context = context;
        }


        [HttpGet("{cpf}")]
        
        public async Task<ActionResult<Responsavel>> Get(long cpf)
        {
            var responsavel = await _context.Responsavels.Where(p => p.cpf == cpf).FirstOrDefaultAsync();

            if (responsavel == null)
            {
                return NotFound();
            }

            return responsavel;
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Responsavel>> Put(int id,[FromBody]Responsavel responsavel)
        {
            var usuario = await _context.Responsavels.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.Senha = responsavel.Senha;
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return usuario;
        }

    }
}
