using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using consultorio.Models;

namespace consultorio.Controllers
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
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

         public IActionResult Agendamentos()
        {
            return View();
        }
        [HttpPost]    
         public IActionResult Agendamentos(Agenda novaAgenda)
        {
            InfoAgenda.Incluir(novaAgenda); 
            return View();
        }

         public IActionResult Info()
        {
            List<Agenda> listaAgenda = InfoAgenda.Listar();
            return View(listaAgenda);
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
