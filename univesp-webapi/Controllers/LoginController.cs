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

        public async Task<ActionResult<ResponsavelsController>> Post([FromBody] Responsavel responsavel)
        {
            var usuario = await _context.Responsavels.Where(r => r.Email == responsavel.Email && r.Senha == responsavel.Senha).FirstOrDefaultAsync();
            var prof = await _context.Professores.Where(r => r.Email == responsavel.Email && r.Senha == responsavel.Senha).FirstOrDefaultAsync();
            var func = await _context.Funcionarios.Where(r => r.Email == responsavel.Email && r.Senha == responsavel.Senha).FirstOrDefaultAsync();
            if(usuario == null)
            {
                if (prof == null)
                {
                    if (func == null)
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
            else
            {
                return Ok(usuario);
            }
        }
    }
}
