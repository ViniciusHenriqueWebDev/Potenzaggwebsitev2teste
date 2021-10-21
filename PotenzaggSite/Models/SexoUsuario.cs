using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PotenzaggSite.Models
{
    public class SexoUsuario
    {
        public int Id { get; set; }

        public string Orientacao { get; set; }

    }
}
