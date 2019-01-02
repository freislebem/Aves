using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAves.Models
{
    public class Entrada
    {
        public Entrada(int entrada_id, string entrada_tipo, int entrada_idAve)
        {
            Entrada_id = entrada_id;
            Entrada_tipo = entrada_tipo;
            Entrada_idAve = entrada_idAve;
        }

        public int Entrada_id { get; set; }
        public string Entrada_tipo { get; set; }
        public int Entrada_idAve { get; set; }
    }
}
