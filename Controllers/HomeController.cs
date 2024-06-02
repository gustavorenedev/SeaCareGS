using Microsoft.AspNetCore.Mvc;
using SeaCare.Models;
using System.Diagnostics;

namespace SeaCare.Controllers
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
            if (TempData.ContainsKey("Sucesso"))
            {
                ViewBag.Sucesso = TempData["Sucesso"];
            }
            else if (TempData.ContainsKey("Erro"))
            {
                ViewBag.Erro = TempData["Erro"];
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
