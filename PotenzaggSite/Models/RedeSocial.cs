using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Models
{
    public class RedeSocial
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<RedeSocial> RedesSociais { get; set; }
    }
}
