using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PotenzaggSite.Data;
using PotenzaggSite.Models;
using System.Collections.Generic;
using System.Linq;
using MailChimp;
using MailChimp.Lists;
using MailChimp.Helper;
using System.Net.Http;
using System;

namespace PotenzaggSite.Controllers
{
    public class CursoController : Controller
    {
        ApplicationDbContext _context;
        private readonly Usuario usuario;
        private readonly object HttpStatus;

        public CursoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index
        {
            get
            {

                List<Usuario> Usuarios = _context.Usuarios.Include(c => c.Nome).ToList();
                return View(Usuarios);

            }
        }

        public ActionResult LiveForStream()
        {
            var CursoEscolhido = new List<string> { "Formação Live for Stream", " Mentoria of Legends", "Marketing Descomplicado", "FreeFire do Zero ao Competitivo" };
            ViewBag.CursoEscolhido = CursoEscolhido;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LiveForStream(Usuario usuario)
        {
             if (ModelState.IsValid)
                {

                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();

                }

            TempData["Message"] = "Sua Inscrição foi concluida com sucesso, aguarde um consultor entrar em contato!";

            return RedirectToAction("LiveForStream", "Curso"); 

        }



        public ActionResult MentoriaOfLegends()
        {
            var OrientacaoSexual = new List<string>() { "Hetero", "Bissexual", "Homossexual", "Outros" };
            ViewBag.OrientacaoSexual = OrientacaoSexual;

            var EscolhaSexo = new List<string>() { "Masculino", "Feminino" };
            ViewBag.EscolhaSexo = EscolhaSexo;

            var CursoEscolhido = new List<string> { "Formação Live for Stream", " Mentoria of Legends", "Marketing Descomplicado", "FreeFire do Zero ao Competitivo" };
            ViewBag.CursoEscolhido = CursoEscolhido;

        

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MentoriaOfLegends(Usuario usuario)
        {
            var OrientacaoSexual = new List<string>() { "Hetero", "Bissexual", "Homossexual", "Outros" };
            ViewBag.OrientacaoSexual = OrientacaoSexual;

            var EscolhaSexo = new List<string>() { "Masculino", "Feminino" };
            ViewBag.EscolhaSexo = EscolhaSexo;

            var CursoEscolhido = new List<string> { "Formação Live for Stream", " Mentoria of Legends", "Marketing Descomplicado", "FreeFire do Zero ao Competitivo" };
            ViewBag.CursoEscolhido = CursoEscolhido;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("MentoriaOfLegends", "Curso");
        }

        public ActionResult FreeFire()
        {
            var OndeConheceu = new List<string> { "Google", "Facebook", "Instagram", "Streamers", "Outros" };
            ViewBag.OndeConheceu = OndeConheceu;


            return View();
        }

        [HttpPost]
        public ActionResult FreeFire(Usuario usuario)
        {
            var OndeConheceu = new List<string> { "Google", "Facebook", "Instagram", "Streamers", "Outros" };
            ViewBag.OndeConheceu = OndeConheceu;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("FreeFire", "Curso");

        }

        public ActionResult MarketingDigital()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MarketingDigital(Usuario usuario)
        {
            var OndeConheceu = new List<string> { "Google", "Facebook", "Instagram", "Streamers", "Outros" };
            ViewBag.OndeConheceu = OndeConheceu;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("Marketing Digital", "Curso");
        }

    }
}