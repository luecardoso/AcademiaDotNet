using ASPNETMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVC.Controllers
{
    public class CadastrosCotroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(Pessoa pessoa)
        {
            AulaentityContext context = new AulaentityContext();
            context.Pessoas.Add(pessoa);
            context.SaveChanges();
            return View(pessoa);
        }

        public IActionResult Consultar()
        {
            AulaentityContext context = new AulaentityContext();
            List<Pessoa> pessoas = (from Pessoa p in context.Pessoas select p).ToList();

            return View();
        }
    }
}
