using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Models
{
    public class Usuario

    {

        public int Id { get; set; }

        [Display(Name = "Qual seu nome?")]
        public string Nome { get; set; }

        [Display(Name = "Qual seu Nick?")]
        public string Nick { get; set; }

        [EmailAddress]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$")]
        [Required(ErrorMessage = "Digite seu e-mail corretamente.")]
        [Display(Name = "Qual seu e-mail?")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Qual seu Telefone?")]
        public string Celular { get; set; }


        public string Sexo { get; set; }


        public string OrientacaoSexual { get; set; }


        public DateTime DataNascimento { get; set; }


        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Curso { get; set; }


        public string OndeConheceu { get; set; }

        public string Campanha { get; set; }

        public string Entrada { get; set; }

        public string UrlTAG { get; set; }

        [Display(Name = "Receber notificações no Email")]
        public bool OptInEmail { get; set; }

        [Display(Name = "Receber notificações no Whats App")]
        public bool OptInZap { get; set; }

  

    }

}
