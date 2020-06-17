using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoFinal.Models
{
    public class Usuario
    {
        //1. CRIAR Classe Usuario com todas as propriedades do objeto
        public int codigo { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string data { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}

