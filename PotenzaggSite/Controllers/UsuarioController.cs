using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PotenzaggSite.Data;
using PotenzaggSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace PotenzaggSite.Controllers
{
    public class UsuarioController : Controller
    {
        public ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {

                List<Usuario> Usuarios = _context.Usuarios.Include(c => c.Nome).ToList();
                return View(Usuarios);

        }

        public ActionResult New()
        {

            var OrientacaoSexual = new List<string>() { "Hetero", "Bissexual", "Homossexual", "Outros" };
               ViewBag.OrientacaoSexual = OrientacaoSexual;

            var EscolhaSexo = new List<string>() { "Masculino", "Feminino" };
            ViewBag.EscolhaSexo = EscolhaSexo;

            var CursoEscolhido = new List<string> { "Formação Live for Stream", " Mentoria of Legends", "Marketing Descomplicado", "FreeFire do Zero ao Competitivo" };
                ViewBag.CursoEscolhido = CursoEscolhido;


            return View();

        }

        
    }
}
