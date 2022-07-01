using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


        [HttpGet("{cpf")]

        public async Task<ActionResult<Responsavel>> Get(string cpf)
        {
            var responsavel = await _context.Responsavels.FindAsync(cpf);

            if (responsavel == null)
            {
                return NotFound();
            }

            return responsavel;
        }

        [HttpPost]

        public async Task<ActionResult<Responsavel>> Post(Responsavel responsavel)
        {
            _context.Responsavels.Add(responsavel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = responsavel.cpf }, responsavel);
        }

    }
}
