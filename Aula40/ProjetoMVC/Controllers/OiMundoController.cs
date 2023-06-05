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

        public IActionResult Welcome(string nome, int numTimes = 1)
        {
            ViewData["Message"] = "Oi Julia";
            ViewData["NumTimes"] = 10;
            return View();
            //return HtmlEncoder.Default.Encode($"Oi {nome},ID: {ID}");
            // https://localhost:7006/OiMundo/Welcome?nome=Julia&vezes=4
            //return "Estou nométodo Welcome do OiMundoController";
        }

        public string Oi()
        {
            return "Oi";
        }
    }
}
