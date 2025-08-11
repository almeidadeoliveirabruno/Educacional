using System.Diagnostics;
using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); //fica dentro de views/home
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            ViewData["Nome"] = "Bruno";
            return View();
        }
        public IActionResult Sobre()
        {
            ViewData["NomeFaculdade"] = "UniEsquina";
            return View();
        }
        public IActionResult Aluno()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
