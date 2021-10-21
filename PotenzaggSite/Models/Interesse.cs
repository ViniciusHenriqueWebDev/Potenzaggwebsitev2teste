using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotenzaggSite.Models
{
    public class Interesse
    {
        public int Id  { get; set; }

        public string Nome { get; set; }

        public IList<Interesse> Interesses { get; set; }



    }
}
