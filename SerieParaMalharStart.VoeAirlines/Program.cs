using SerieParaMalharStart.VoeAirlines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlines
{
    internal class Program 
    { 
      static void Main(string[] args)
        {
            Aeronave aero = new Aeronave();
            /*
             * Aeronave : CLasse
             * aero: É o objeto da classe
             * = : É o que atribui
             * new : operador de instanciação
             * instância: É o objeto (A concretização de uma classe)
             * Aeronave(): Chamada ao construtor
             * var = (tipo de variável) tipo de inferência
             * 
             */

            //INTERFACE COM USUARIO

            Console.WriteLine("Digite o Fabricante");
            var entradaFabricante = Console.ReadLine();
            Console.WriteLine("Digite a Matricula");
            var entradaMatricula = Console.ReadLine();
            Console.WriteLine("Digite Modelo");
            var entradaModelo = Console.ReadLine();
            Console.WriteLine("Digite Codigo");
            var entradaCodigo = Console.ReadLine();
            Console.WriteLine("Digite Quantidade de Passageiros");
            var entradaQtdePassageiros = int.Parse(Console.ReadLine());

            //ATRIBUIÇOES

            aero.Fabricante = entradaFabricante;
            aero.Matricula = entradaMatricula;
            aero.Modelo = entradaModelo;
            aero.Codigo = entradaCodigo;
            aero.Capacidade = entradaQtdePassageiros;

            //NOTICIA

            Console.WriteLine($"Jatinho Executivo do Messi é um {aero.Modelo}-" +
                $"{aero.Codigo} Cuja a capacidade é {aero.Capacidade}" +
                $"Fabricado pela {aero.Fabricante} " +
                $"de matricula {aero.Matricula}.");
            Console.ReadKey();

        }

    }
       
     
    
}
