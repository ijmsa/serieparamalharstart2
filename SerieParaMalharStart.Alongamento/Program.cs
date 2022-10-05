using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Alongamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alongamento
            //Variável - Atribuição - Entrada e Saída
            //Funções para String

            /*
             * Comentários de múltiplas linhas
             */
            Console.WriteLine("Digite o nome");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite a média");

            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade");

            int idade = int.Parse(Console.ReadLine());

            string mensagem = idade < 18? "menor": "maior"; //erro lógico; menor e maior estavam trocados 

            Console.WriteLine($"{nome} sua média foi {media}");

            Console.WriteLine($"{nome} você é {mensagem.ToUpper()}");

            Console.ReadKey();
        }
    }
}
