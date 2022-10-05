using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlines.EstudoPiloto
{
    internal class Piloto
    {
        //Propriedade automática
        //Encapsulamento
        // set     get
        //Propriedade é privada
        //get e set é público
        //Encapsulamento

        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        //void - retorno vazio (procedimento - lógica de programação)
        /* 
         * lógica de programação
         *   void - procedimento (retorno vazio)
         *   return - função (retorna)
         */
        public String GerarNomeCompleto()
        {
            return $"{Nome}{Sobrenome}".ToUpper();
        }
        public String GerarNomeCompletoMinusculo()
        {
            return $"{Nome}{Sobrenome}".ToLower();
        }

    }
}
