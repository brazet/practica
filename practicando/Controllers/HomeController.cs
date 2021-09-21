using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practicando.Models;

namespace ejemplomvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contacto() {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto) {
            // Guardarlo en una BD
            // Enviar un correo
            // No hacer nada
            Console.WriteLine(contacto.NombreCompleto);
            Console.WriteLine(contacto.Mensaje);
            return RedirectToAction("ContactoConfirmacion");
            //return View("ContactoConfirmacion");
        }

        public IActionResult ContactoConfirmacion(string param1) {
            return View();
        }

        public IActionResult Index(string mensaje, int n)
        {
            // ViewData["param1"] = n;
            // ViewData["mensaje"] = mensaje;
            // return View();
            //return RedirectToAction("Contacto");
            return RedirectToAction("Principal");
        }

        public IActionResult Principal() {
            return View();
        }

        public IActionResult Privacy()
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