using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFinalElectricidadSeret.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoFinalElectricidadSeret.Controllers
{
    public class HomeController : Controller
    {
        public IEnumerable<MenuItem> Menus { get; set; }
        private readonly ILogger<HomeController> _logger;
        private UsuaMenusController _UsuaMenusController { get; set; }
        public Usuario CurrentUser { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var currentUsr = HttpContext.Session.GetString("currentUser");

            if (currentUsr == null)
            {
               return RedirectToAction("Login", "Usuarios");
            }
            else {
                CurrentUser = JsonConvert.DeserializeObject<Usuario>(currentUsr);
                return View(CurrentUser);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NotAvailable()
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
