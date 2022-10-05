using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo31._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Média aritmética entre três números fornecidos pelo usuário
            {
                double n1, n2, n3, media;
                Console.WriteLine("numero 1:");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("numero 2: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("numero 3: ");
                n3 = Convert.ToDouble(Console.ReadLine());

                media = (n1 + n2 + n3) / 3;

                Console.WriteLine("Média é: " + media);

                Console.ReadKey();

            }
        }
    }
}

