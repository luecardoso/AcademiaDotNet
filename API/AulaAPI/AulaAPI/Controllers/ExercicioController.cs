using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    public class ExercicioController : Controller
    {

        [HttpGet]
        [Route("nome")]
        public string RetornoNome()
        {
            return "Lucas Cardoso";
        }

        [HttpGet]
        [Route("idade")]
        public string RetornoIdade()
        {
            return "23";
        }

        [HttpPost]
        [Route("nome")]
        public string NomePost([FromBody] string nome)
        {
            return nome;
        }

        [HttpPost]
        [Route("maior/{idade}")]
        public string NomeIdadePost([FromBody] string nome, [FromRoute] int idade)
        {
            return nome + " tem " + idade + " e é maior de idade";
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
