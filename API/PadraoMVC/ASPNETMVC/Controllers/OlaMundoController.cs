using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASPNETMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        public IActionResult Index()
        {
            //as rotas MVC indicam que este Index é chamado automaticamente quando acessar a URL/OlaMundo
            //index fica na pasta shared
            return View();
        }

        public string Welcome(int id,string nome)
        {
            //as rotas MVC que este index é chamado automaticamente quando acessar a URL/OlaMundo/Welcome
            return HtmlEncoder.Default.Encode("Oi "+nome+" ID = "+id);
            //https://localhost:7234/OlaMundo/Welcome?nome=Lucas
            //https://localhost:7234/OlaMundo/Welcome/5?nome=Lucas
            //return "Estou no método welcome do controlador olamundo";
        }

        public IActionResult MostrarMensagem(string nome, int qtd) 
        {
            ViewData["Nome"] = nome;
            ViewData["Quantidade"] = qtd;
            return View(); 
        }
    }
}
