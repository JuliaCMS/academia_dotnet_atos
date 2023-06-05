using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ProjetoMVC.Controllers
{
    public class OiMundoController : Controller
    {
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "Apresenta esta mensagem";
        }

        public string Welcome(string nome, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Oi {nome},ID: {ID}");
            // https://localhost:7006/OiMundo/Welcome?nome=Julia&vezes=4
            //return "Estou nométodo Welcome do OiMundoController";
        }

        public string Oi()
        {
            return "Oi";
        }
    }
}
