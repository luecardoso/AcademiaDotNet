using AulaAPI.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaAPI.Controllers
{
    [Route("api/entity")]
    [ApiController]
    public class EntityController : Controller
    {
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getPessoas(
            [FromServices] Contexto contexto
            )
        {
            var pessoas = await contexto.Pessoas
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ? NoContent() : Ok(pessoas);
        }


        [HttpGet]
        [Route("pessoa/{id}")]
        public async Task<IActionResult> getPessoa(
            [FromServices] Contexto contexto,
            [FromRoute] int id
            )
        {
            var pessoas = await contexto.Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.id == id);

            return pessoas == null ? NoContent() : Ok(pessoas);
        }


        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> postPessoa(
            [FromServices] Contexto contexto,
            [FromBody] Pessoa pessoa
            )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();

                return Created("api/pessoas/"+pessoa.id,pessoa);
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
