using MailChimp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PotenzaggSite.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MailChimp.Helper;
using System;
using PotenzaggSite.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PotenzaggSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly object _context;
        ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        public ActionResult Contato()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contato(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return View();
            }

            ModelState.Clear();
            return View("Contato");

            TempData["Message"] = "Sua Inscrição foi concluida com sucesso, aguarde um consultor entrar em contato!";

            return RedirectToAction("Contato", "Home");

        }




        public IActionResult Potenzalovers()
        {
            return View();
        }

        public IActionResult Formacoes()
        {
            return View();
        }


        public IActionResult PotenzaGGForTeams()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Embaixadores()
        {
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public override bool Equals(object obj)
        {
            return obj is HomeController controller &&
                   EqualityComparer<ILogger<HomeController>>.Default.Equals(_logger, controller._logger);
        }

        public IActionResult MyForm()
        {
            return View();
        }
      
    }
}
