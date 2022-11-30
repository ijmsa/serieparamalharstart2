using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlinesEstudo
{
    public class Aeronave
    {
        //variável padrão: camelCase
        public string _fabricante;
        public string _modelo;
        public string _codigo;

        //propriedade automática: PascalCase
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }


    }
}
