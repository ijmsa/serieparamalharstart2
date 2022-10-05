using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um número inteiro e mostre o valor digitado 
             e o tipo juntamente com o valor*/
            
            Console.WriteLine("número inteiro:");
            Console.ReadLine();

            int numero = 50;
            string digitado = "cinquenta";

            Console.WriteLine($"Inteiro: {numero} e digitado: {digitado}");
            Console.ReadKey(); 
        }
    }
}
