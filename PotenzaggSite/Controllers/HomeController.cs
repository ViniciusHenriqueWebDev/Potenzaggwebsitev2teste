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

namespace PotenzaggSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //       ApplicationDbContext context = new ApplicationDbContext(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

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

        public IActionResult Faleconosco()
        {
            return View();
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
