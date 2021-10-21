using PotenzaggSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Repositories
{
    interface IUsuarioRepository
    {
        IEnumerable<Usuario> Usuarios { get; }
        Usuario GetUsuarioById(int usuarioId);

    }
}
