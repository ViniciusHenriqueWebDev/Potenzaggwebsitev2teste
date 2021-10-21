using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Models
{
    public class CadastroUsuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
