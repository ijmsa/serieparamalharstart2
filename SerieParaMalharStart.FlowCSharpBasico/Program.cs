using SerieParaMalharStart.FlowCSharpBasico.DotNet;
using SerieParaMalharStart.VoeAirlinesEstudo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.FlowCSharpBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio inicio = new Inicio();
            Console.WriteLine("Tour.NET!");
            Console.WriteLine("Deseja viajar para aonde?");
            Console.WriteLine("1-História " +
                "2-.NET Framework " +
                "3-.NET Core " +
                "4-Trainning 01 " +
                "5-VoeAirlines");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(inicio.MostrarHistoria());break;
                case 5:
                    Console.WriteLine("Olá, você chegou no módulo POO");
                    Console.WriteLine("Voe Airlines voando com você!");
                    Aeronave aeronave = new Aeronave();
                    aeronave._fabricante = "Embraer";
                    aeronave._modelo = "Bandeirante";
                    aeronave._codigo = "EMB-100";
                    Console.WriteLine("Fabricante" + aeronave._fabricante);break;


            }
            Console.ReadKey();

            
        } 
    }
}
