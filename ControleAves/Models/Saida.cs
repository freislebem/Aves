using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAves.Models
{
    public class Saida
    {
        public int Saida_id { get; set; }
        public string Saida_tipo { get; set; }
        public string Saida_subtipo { get; set; }
        public DateTime Saida_dta { get; set; }
        public DateTime Saida_dtaCadastro { get; set; }
    }
}
