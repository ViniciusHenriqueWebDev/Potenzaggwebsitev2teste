using Microsoft.EntityFrameworkCore;
using PotenzaggSite.Data;
using PotenzaggSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext contexto)
        {
            _context = contexto; 
        }

        public IEnumerable<Usuario> Usuarios => _context.Usuarios.Include(c => c.Curso);

        public Usuario GetUsuarioById(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault();
        }
    }
}
