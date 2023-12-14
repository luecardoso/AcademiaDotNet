using AulaAPI.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [Authorize]
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJWTAuthenticationManager jwt;

        public TokenController(IJWTAuthenticationManager jwt)
        {
            this.jwt = jwt;
        }

        [HttpGet]
        [Route("endpoint1")]
        public string getEP1()
        {
            return "end point 1";
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("endpoint2")]
        public string getEP2()
        {
            return "end point 2";
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Autenticar([FromBody] Usuario usuario)
        {
            var token = jwt.Authenticate(usuario.login, usuario.senha);
            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
