using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atividade3.Models;

namespace atividade3.Controllers
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

        public IActionResult PreAgendamento()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PreAgendamento(Agenda novaAgenda)
        {
            InfoAgenda.Incluir(novaAgenda);
            return RedirectToAction("PreAgendamento");
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
