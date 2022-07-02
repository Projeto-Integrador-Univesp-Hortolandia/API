using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using univesp_webapi.Data;
using univesp_webapi.Models;

namespace univesp_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public LoginController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<ActionResult> Post([FromBody] Login login)
        {
            var usuario = await _context.Responsavels.Where(p => p.Email == login.Usuario & p.Senha == login.Senha).FirstOrDefaultAsync();
            var prof = await _context.Professores.Where(p => p.Email == login.Usuario & p.Senha == login.Senha).FirstOrDefaultAsync();
            var func = await _context.Funcionarios.Where(p => p.Email == login.Usuario & p.Senha == login.Senha).FirstOrDefaultAsync();
            if (usuario == null)
            {
                if(prof == null)
                {
                    if(func == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        return Ok(func);
                    }
                }
                else
                {
                    return Ok(prof);
                }
            }            
            return Ok(usuario);

        }
            
    }
}
