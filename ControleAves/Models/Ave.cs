using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAves.Models
{
    public class Ave
    {
        public int Ave_id { get; set; }
        public int Ave_idPai { get; set; }
        public int Ave_idMae { get; set; }
        public int Ave_idPulseira { get; set; }

        public string Ave_nome { get; set; }
        public string Ave_raca { get; set; }
        public DateTime Ave_dtaNascimento { get; set; }
        public DateTime Ave_dtaCadastro { get; set; }
        public string Ave_obs { get; set; }
        public string Ave_vascinada { get; set; }

        //fazer esquema para informar a idade da ave e avisos referente a idade
    }
}
