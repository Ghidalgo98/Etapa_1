using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaBase.Models;
using Microsoft.Extensions.Logging;

namespace SistemaBase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
            
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            var usuarioSesion = HttpContext.Session.GetString("Usuario");
            string nombreApp = "Carnes La Casona"; // o lo lees desde appsettings.json

            ViewBag.Saludo = $"¡Bienvenido, a {nombreApp}!";
            ViewBag.Usuario = usuarioSesion;
            return View();
        }

        public IActionResult Privacy()
        {
            var usuarioSesion = HttpContext.Session.GetString("Usuario");
            // Leer nombre de la app desde appsettings.json
            string nombreApp = _config["AppSettings:NombreApp"] ?? "MiAplicación";
            ViewBag.Saludo = $"¡Bienvenido a {nombreApp}!";
            //ViewBag.usuario= usuarioSesion;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
