using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAves.Models
{
    public class Natalidade
    {
        public int Natalidade_id { get; set; }
        public int Natalidade_idMae { get; set; }
        public int Natalidade_idPai { get; set; }

        public int Natalidade_qtdeOvos { get; set; }
        public int Natalidade_qtdeOvosNascidos { get; set; }
        public string Natalidade_obs { get; set; }
    }
}
